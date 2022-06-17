﻿using System;
using System.IO;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Queue;
using System.Threading.Tasks;
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;

namespace ContosoFunctionApp
{
    public static class StorageMethods
    {
        public const string receiptBlobName = "receipts";
        public const string imageDirectoryName = "images";
        public static CloudBlobClient blobClient { get; set; }
        public static CloudBlobContainer blobContainer { get; set; }

        static async Task<string> GetImage(string fileName, IConfiguration config)
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(config["ConnectionStrings:ReceiptStorage"]);            
            
            // Create the blob client.
            blobClient = storageAccount.CreateCloudBlobClient();

            // Retrieve a reference to a container.
            blobContainer = blobClient.GetContainerReference(imageDirectoryName);

            // Create the container if it doesn't already exist.
            await blobContainer.CreateIfNotExistsAsync();

            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference(fileName);
            string filePath = Path.Combine(Path.GetTempPath(), fileName);

            if (!File.Exists(filePath))
            {
                await blockBlob.DownloadToFileAsync(filePath, FileMode.OpenOrCreate);
            }

            return filePath;

        }


        /// <summary>
        /// Upload the generated receipt Pdf to Blob storage.
        /// </summary>
        /// <param name="file">Byte array containig the Pdf file contents to be uploaded.</param>
        /// <param name="fileName">The desired filename of the uploaded file.</param>
        /// <returns></returns>
        public static async Task<string> UploadPdfToBlob(byte[] file, string fileName, IConfiguration config,  ILogger log)
        {
            log.LogInformation("Hit Upload");
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(config["ConnectionStrings:ReceiptStorage"]);
            // Create the blob client.
            blobClient = storageAccount.CreateCloudBlobClient();
    
            // Retrieve a reference to a container.
            blobContainer = blobClient.GetContainerReference(receiptBlobName);

            // Create the container if it doesn't already exist - private.
            var blobRequestOptions = new BlobRequestOptions();
            
            await blobContainer.CreateIfNotExistsAsync(BlobContainerPublicAccessType.Off, null, null);
            string fileUri = string.Empty;

            CloudBlockBlob blockBlob = blobContainer.GetBlockBlobReference(fileName);

            using (var stream = new MemoryStream(file))
            {
                // Upload the in-memory Pdf file to blob storage.
                await blockBlob.UploadFromStreamAsync(stream);
            }

            // Get a SAS URL to use to read the doc from.
            SharedAccessBlobPolicy readPolicy = new SharedAccessBlobPolicy()
            {
                SharedAccessExpiryTime = DateTime.UtcNow.AddYears(7),
                Permissions = SharedAccessBlobPermissions.Read
            };

            fileUri = blockBlob.Uri.ToString() + blockBlob.GetSharedAccessSignature(readPolicy);
            log.LogInformation($"Using fileUri {fileUri}");
            return fileUri;
        }

        /// <summary>
        /// Grabs the next pending queue message containing the next order
        /// whose receipt we need to generate.
        /// </summary>
        /// <returns></returns>
        public static async Task<int> GetOrderIdFromQueue(IConfiguration config)
        {
            int orderId = 0;

            // Create the queue client.
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(config["ConnectionStrings:ReceiptStorage"]);
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a queue.
            CloudQueue queue = queueClient.GetQueueReference("receiptgenerator");

            // Create the queue if it doesn't already exist.
            if (await queue.CreateIfNotExistsAsync())
            {
                Console.WriteLine("Queue '{0}' Created", queue.Name);
            }
            else
            {
                Console.WriteLine("Queue '{0}' Exists", queue.Name);
            }

            // Get the next message.
            CloudQueueMessage retrievedMessage = await queue.GetMessageAsync();

            if (retrievedMessage != null)
            {
                Trace.TraceInformation("Retrieved Queue Message: " + retrievedMessage.AsString);
                // Process the message in less than 30 seconds, and then delete the message.
                await queue.DeleteMessageAsync(retrievedMessage);
                int.TryParse(retrievedMessage.AsString, out orderId);
            }

            return orderId;
        }
    }
}

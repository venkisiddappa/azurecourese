#pragma checksum "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22e2be1306f17de4e2c939d3e3fd5c87261ca30a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\_ViewImports.cshtml"
using Contoso.Apps.SportsLeague.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e2be1306f17de4e2c939d3e3fd5c87261ca30a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26569d82efc307699895556049274a32bd1308f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Contoso.Apps.SportsLeague.Web.Models.HomeModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/vendor/knockout-3.3.0.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            DefineSection("HeaderOverlay", async() => {
                WriteLiteral(@"
    <div class=""button-wrapper"">
        <div class=""container"">
            <div class=""row"">
                <a href=""#"" class=""btn-content"">Contoso Sports League</a>
            </div>
            <div class=""row clearfix"">
                <p><br /></p>
                <p><br /></p>
                <p><a");
                BeginWriteAttribute("href", " href=\"", 427, "\"", 463, 1);
#nullable restore
#line 16 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 434, Url.Action("Index", "Store"), 434, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn red-btn\">Visit our Store</a></p>\n            </div>\n        </div>\n    </div>\n");
            }
            );
            WriteLiteral(@"
<section class=""store"">
    <div class=""container"">
        <div class=""row"">
            <div class=""wrapper clearfix"">
                <aside class=""content contact-wrap"">
                    <div class=""store-details-wrap clearfix"">
                        <div class=""shop-related clearfix"">
                            <h2>Today's Offers</h2>
                            <p>We found these great products just for you!</p>
                            <p><br /></p>

                            <div id=""offers"" data-bind=""foreach: offers"">
                                <div class=""figure"">
                                    <div class=""item"">
                                        <div class=""item-img"">
                                            <img data-bind=""attr: {'src':  '/Images/Products/' + imagePath, 'alt': 'Add ' + productName + ' to cart'}"" class=""center-block"">
                                            <div class=""item-cart"">
                                                <a data-bind=""attr:");
            WriteLiteral(@" {'href':  '/Cart/AddToCart?productId=' + productID}"">Add to cart</a>
                                            </div>
                                        </div>
                                        <div class=""item-content"">
                                            <div class=""item-header clearfix"">
                                                <span class=""headline-lato"" data-bind=""text: productName""></span>
                                                <span");
            BeginWriteAttribute("class", " class=\"", 2061, "\"", 2069, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-bind=""money: unitPrice""></span>
                                            </div>
                                            <p>
                                                <a data-bind=""attr: {'href':  '/Store/Details/' + productID}"" class=""btn trans-btn"">Product Details</a>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </aside>
            </div>
        </div>
    </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22e2be1306f17de4e2c939d3e3fd5c87261ca30a7444", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n    <script type=\"text/javascript\">\n        var offersUri = \'");
#nullable restore
#line 67 "C:\MCW\MCW-Modern-cloud-apps-main\Hands-on lab\lab-files\src\Contoso Sports League\Contoso.Apps.SportsLeague.Web\Views\Home\Index.cshtml"
                     Write(ViewBag.offersAPIUrl);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
        var viewModel = {
            offers: ko.observableArray()
        };

        $(document).ready(function () {
            // Call the Offers service and populate the offers list:
            var jqxhr = $.get(offersUri, function (data) {
                // Success: Bind the data to our viewmodel.
                viewModel.offers(data);
            })
            .fail(function (req, status, err) {
                if (req.readyState == 0 || req.status == 0) {
                    // Most likely a CORS issue where this domain has not been added
                    // by the destination server.
                    alert('An error has occurred while retrieving the latest offered products. It appears as though CORS has not been configured.');
                }
                else if (err != null && err != '') {
                    alert('An error has occurred while retrieving the latest offered products: ' + err)
                }
            });

            // TODO: Throw alert on error

            ");
                WriteLiteral(@"ko.applyBindings(viewModel);
        });

        ko.bindingHandlers.money = {
            update: function (element, valueAccessor, allBindingsAccessor) {
                var value = valueAccessor(), allBindings = allBindingsAccessor();
                var valueUnwrapped = ko.utils.unwrapObservable(value);

                var m = """";
                var out = """";
                if (valueUnwrapped) {
                    m = parseFloat(valueUnwrapped);
                    if (m) {
                        out = '$' + m.toMoney(2);
                    }
                }
                $(element).text(out);
            }
        };

    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Contoso.Apps.SportsLeague.Web.Models.HomeModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b83cf773cf558777026e6a17c3dbab71149987c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreApp;

#line default
#line hidden
#line 2 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\_ViewImports.cshtml"
using NetCoreApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b83cf773cf558777026e6a17c3dbab71149987c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e90199b334a593f2ee7d0ce2dc9f86cb1e7aded8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListProducts>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Banner1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Imagen responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(66, 175, true);
            WriteLiteral("\r\n<div class=\"section\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-2\"></div>\r\n            <div class=\"col-md-8\">\r\n                ");
            EndContext();
            BeginContext(241, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "14678dfbced7444ebb8ae490f45db89f", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(320, 1618, true);
            WriteLiteral(@"
            </div>
            <div class=""col-md-2""></div>
        </div>
    </div>
</div>
<hr class=""hr"" />
<div class=""section"">
    <div class=""container"">
        <div class=""row grid-divider"">
            <div class=""col-md-4 col-xs-12"">
                <div class=""col-padding"">
                    <h4 class=""text-center"">Contact</h4>
                    <ul>
                        <li>Mobile: 3514608874</li>
                        <li>Address: Bv. Los Alemanes 3800 , Barrio Los Boulevares</li>
                        <li>E-mail: emailcontacto@gmail.com</li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-4 col-xs-12"">
                <div class=""col-padding"">
                    <h4 class=""text-center"">Blog</h4>
                    <ul>
                        <li>Asp.Net Core with Docker</li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-4 col-xs-12"">
               ");
            WriteLiteral(@" <div class=""col-padding"">
                    <h4 class=""text-center"">About Us</h4>
                    <ul>
                        <li>
                            Descrip
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<hr class=""hr"" />
<br />
<div class=""section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""section"">
                    <h2 class=""text-center"">Recents Products</h2>
                    <div>
");
            EndContext();
#line 61 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                          
                            for (int i = 0; i < Model.products.Count; i++)
                            {
                                bool renderNewRow = i % 4 == 0 ? true : false;
                                if (renderNewRow)
                                {
                                    

#line default
#line hidden
            BeginContext(2276, 31, false);
#line 67 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                               Write(Html.Raw("<div class=\"row\">"));

#line default
#line hidden
            EndContext();
#line 67 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                                                                    ;
                                    foreach (var items in Model.products.Skip(i).Take(4))
                                    {

#line default
#line hidden
            BeginContext(2440, 64, true);
            WriteLiteral("                                        <div class=\"col-md-3\">\r\n");
            EndContext();
            BeginContext(2840, 198, true);
            WriteLiteral("                                            <img src=\"http://pingendo.github.io/pingendo-bootstrap/assets/placeholder.png\"\r\n                                                 class=\"img-responsive\">\r\n");
            EndContext();
            BeginContext(3090, 48, true);
            WriteLiteral("                                            <h3>");
            EndContext();
            BeginContext(3139, 10, false);
#line 80 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                                           Write(items.name);

#line default
#line hidden
            EndContext();
            BeginContext(3149, 55, true);
            WriteLiteral("</h3>\r\n                                            <h4>");
            EndContext();
            BeginContext(3205, 11, false);
#line 81 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                                           Write(items.price);

#line default
#line hidden
            EndContext();
            BeginContext(3216, 56, true);
            WriteLiteral("</h4>\r\n                                            <p>\r\n");
            EndContext();
            BeginContext(3344, 151, true);
            WriteLiteral("                                            </p>\r\n                                            <p></p>\r\n                                        </div>\r\n");
            EndContext();
#line 87 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                                    }
                                }

                                if (renderNewRow)
                                {
                                    

#line default
#line hidden
            BeginContext(3694, 18, false);
#line 92 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                               Write(Html.Raw("</div>"));

#line default
#line hidden
            EndContext();
#line 92 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                                                       ;

#line default
#line hidden
            BeginContext(3715, 44, true);
            WriteLiteral("                                    <br />\r\n");
            EndContext();
#line 94 "C:\Docker\NetCoreWithDocker\NetCoreApp\Views\Home\Index.cshtml"
                                }
                            }
                        

#line default
#line hidden
            BeginContext(3852, 108, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListProducts> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9d1f1d040487474cf9a1ba17aab1ba9b8b669e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_UserProductDetails), @"mvc.1.0.view", @"/Views/Products/UserProductDetails.cshtml")]
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
#line 1 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\_ViewImports.cshtml"
using AuthApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\_ViewImports.cshtml"
using AuthApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\_ViewImports.cshtml"
using Omu.AwesomeMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\_ViewImports.cshtml"
using Omu.Awem.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9d1f1d040487474cf9a1ba17aab1ba9b8b669e2", @"/Views/Products/UserProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d5512970a8db89a7fad5d279dc1b67feae9953", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_UserProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AuthApplication.Models.Comment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Product Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle border p-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:64px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("User Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    List<Comment>Comments  = ViewBag.Comments;
    var Product = ViewBag.Product;
    var PhotoPath = "~/images/" + (Product.Image ?? "noimage.jpg");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <style>
        .DetailsBtn {
            background-color: #B0B435;
            color: white;
            transition-property: all;
            transition-duration: .3s;
        }

            .DetailsBtn:hover {
                background-color: #010101;
                border: 1px solid #B0B435;
                cursor:pointer;
                color:white;
            }
    </style>
    <div class=""container"" style=""margin-top: 50px;"">
        <div class=""row"">
            <div class=""col-xl-5 col-lg-5 col-md-6"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9d1f1d040487474cf9a1ba17aab1ba9b8b669e26901", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                                    WriteLiteral(PhotoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-xl-7 col-lg-7 col-md-6\">\r\n                <h3>");
#nullable restore
#line 30 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
               Write(Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h6 style=\"display: inline-block;\"><del>$ ");
#nullable restore
#line 31 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                                                     Write(Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del></h6>\r\n                <h5 style=\"display: inline-block; font-weight: bolder; color: #B0B435;\">$");
#nullable restore
#line 32 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                                                                                     Write(Product.Price*90/100);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <p style=""font-size: 1vw;""><span> More than 20 available / <a href=""#"" style=""text-decoration: none; color: #B0B435;"">8 sold </a></span><p>
                    <h5>Short Description:</h5>
                <p style=""font-size: 1.1vw; line-height: 2.5vw;"">
                    ");
#nullable restore
#line 36 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
               Write(Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                <div style=\"margin-top: 70px;\">\r\n                    <a class=\"btn DetailsBtn text-white\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1693, "\"", 1719, 3);
            WriteAttributeValue("", 1703, "Add(", 1703, 4, true);
#nullable restore
#line 39 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
WriteAttributeValue("", 1707, Product.ID, 1707, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1718, ")", 1718, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">Add to cart</a>
                    <div style=""float: right;"">
                        <a class=""btn DetailsBtn"" href=""#""><i class=""fab fa-facebook"" aria-hidden=""true""></i></a>
                        <a class=""btn DetailsBtn"" href=""#""><i class=""fab fa-google-plus"" aria-hidden=""true""></i></a>
                        <a class=""btn DetailsBtn"" href=""#""><i class=""fab fa-twitter"" aria-hidden=""true""></i></a>
                        <a class=""btn DetailsBtn"" href=""#""><i class=""fab fa-pinterest-p"" aria-hidden=""true""></i></a>
                        <a class=""btn DetailsBtn"" href=""#""><i class=""fab fa-whatsapp"" aria-hidden=""true""></i></a>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row  my-5 "">

            <div class=""col-md-12 card card-outline-secondary my-4"">
                <div class=""card-header"">
                    <h2>Product Reviews</h2>
                </div>
                <div class=""card-body"">
");
#nullable restore
#line 57 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                     foreach (var item in Comments)
                    {
                        var Photo = "";
                        if (item.User!=null)
                        {
                            Photo = @item.User.ImagePath;
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"media mb-3\">\r\n                                <div class=\"mr-2 \">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d9d1f1d040487474cf9a1ba17aab1ba9b8b669e213176", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/");
#nullable restore
#line 66 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                                                                                                WriteLiteral(Photo);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 66 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"media-body\">\r\n                                    <p>");
#nullable restore
#line 69 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                                  Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                                    <small class=\"text-muted\">Posted by <b style=\"color:#B0B435\">");
#nullable restore
#line 70 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                                                                                            Write(item.User.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 70 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                                                                                                                 Write(item.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>  on ");
#nullable restore
#line 70 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"
                                                                                                                                             Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 73 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\Products\UserProductDetails.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9d1f1d040487474cf9a1ba17aab1ba9b8b669e217810", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AuthApplication.Models.Comment> Html { get; private set; }
    }
}
#pragma warning restore 1591

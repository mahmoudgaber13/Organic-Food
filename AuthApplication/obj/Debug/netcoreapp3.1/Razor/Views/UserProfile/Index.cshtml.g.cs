#pragma checksum "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f15bba229c946c48b75e3027fed13a32acf900af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_Index), @"mvc.1.0.view", @"/Views/UserProfile/Index.cshtml")]
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
#nullable restore
#line 1 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
using AuthApplication.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f15bba229c946c48b75e3027fed13a32acf900af", @"/Views/UserProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d5512970a8db89a7fad5d279dc1b67feae9953", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/UserProfile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/NoUser.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("imgProfile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 150px; height: 150px; border-radius: 50%; border: 3px solid #B0B435;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var orders = ViewData["Orders"] as List<Order>;


#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f15bba229c946c48b75e3027fed13a32acf900af6355", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">

                    <div class=""card-body"">
                        <div class=""card-title mb-4"">
                            <div class=""d-flex justify-content-start"">
                                <div class=""image-container"">
");
#nullable restore
#line 19 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                     if (Model.ImagePath == "")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f15bba229c946c48b75e3027fed13a32acf900af8191", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f15bba229c946c48b75e3027fed13a32acf900af9830", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/images/");
#nullable restore
#line 25 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                               WriteLiteral(Model.ImagePath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 25 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n                                <div class=\"userData ml-3\">\r\n                                    <h2 class=\"d-block\" style=\"display: inline; font-size: 1.5rem; font-weight: bold; margin: 100px 0 0 40px\">");
#nullable restore
#line 30 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                                                                                                         Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 30 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                                                                                                                          Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                                </div>
                                <div class=""ml-auto"">
                                    <div><a href=""UserProfile/Edit"" class=""btn submitOrder"" style=""width:192px"">Edit Profile</a></div>
                                    <div style=""margin-top:40px;""><a href=""UserProfile/ChangePassword"" class=""btn submitOrder"" style=""width:192px"">Change Password</a></div>
                                </div>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col-12"">
                                <ul class=""nav nav-tabs mb-4"" id=""myTab"" role=""tablist"">
                                    <li class=""nav-item"">
                                        <a class=""nav-link active"" id=""basicInfo-tab"" data-toggle=""tab"" href=""#basicInfo"" role=""tab"" aria-controls=""basicInfo"" aria-selected=""true"">Basic Info</a>
                                    </li>
                     ");
            WriteLiteral(@"               <li class=""nav-item"">
                                        <a class=""nav-link"" id=""connectedServices-tab"" data-toggle=""tab"" href=""#connectedServices"" role=""tab"" aria-controls=""connectedServices"" aria-selected=""false"">Oreders</a>
                                    </li>
                                </ul>
                                <div class=""tab-content ml-1"" id=""myTabContent"">
                                    <div class=""tab-pane fade show active"" id=""basicInfo"" role=""tabpanel"" aria-labelledby=""basicInfo-tab"">


                                        <div class=""row"">
                                            <div class=""col-sm-3 col-md-2 col-5"">
                                                <label style=""font-weight:bold;"">Full Name</label>
                                            </div>
                                            <div class=""col-md-8 col-6"">
                                                ");
#nullable restore
#line 58 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                           Write(Model.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 58 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                            Write(Model.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                            <div class=""col-sm-3 col-md-2 col-5"">
                                                <label style=""font-weight:bold;"">Email</label>
                                            </div>
                                            <div class=""col-md-8 col-6"">
                                                ");
#nullable restore
#line 67 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                           Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                            <div class=""col-sm-3 col-md-2 col-5"">
                                                <label style=""font-weight:bold;"">City</label>
                                            </div>
                                            <div class=""col-md-8 col-6"">
                                                ");
#nullable restore
#line 76 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                           Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                            <div class=""col-sm-3 col-md-2 col-5"">
                                                <label style=""font-weight:bold;"">Country</label>
                                            </div>
                                            <div class=""col-md-8 col-6"">
                                                ");
#nullable restore
#line 85 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                           Write(Model.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                            <div class=""col-sm-3 col-md-2 col-5"">
                                                <label style=""font-weight:bold;"">Phone Nom.</label>
                                            </div>
                                            <div class=""col-md-8 col-6"">
                                                ");
#nullable restore
#line 94 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                           Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </div>
                                        </div>
                                        <hr />
                                        <div class=""row"">
                                        </div>
                                    </div>
                                    <div class=""tab-pane fade"" id=""connectedServices"" role=""tabpanel"" aria-labelledby=""ConnectedServices-tab"">
                                        <h2>Orders</h2>
                                        <div class=""table-hover table-responsive"">
                                            <table class=""table"" style=""margin-top: 50px;"">
                                                <thead style=""background-color: #B0B435; color: white; font-weight: bolder;"">
                                                    <tr>
                                                        
                                                        <th>Order ID.</th>
                          ");
            WriteLiteral(@"                              <th>Quantity</th>
                                                        <th>Date</th>
                                                        <th>Status</th>
                                                        <th>Details</th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
#nullable restore
#line 116 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                     foreach (var order in orders)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td style=\"padding-top: 50px;\">\r\n                                                            ");
#nullable restore
#line 120 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                       Write(order.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style=\"padding-top: 50px;\">\r\n                                                            ");
#nullable restore
#line 123 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                       Write(order.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style=\"padding-top: 50px;\">\r\n                                                            ");
#nullable restore
#line 126 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                       Write(order.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style=\"padding-top: 50px;\">\r\n                                                            ");
#nullable restore
#line 129 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                       Write(order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                        <td style=\"padding-top: 50px;\">\r\n                                                            <a");
            BeginWriteAttribute("href", " href=\"", 8657, "\"", 8708, 2);
            WriteAttributeValue("", 8664, "UserProfile/GetOrderDetailsById?id=", 8664, 35, true);
#nullable restore
#line 132 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
WriteAttributeValue("", 8699, order.ID, 8699, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Details</a>\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 135 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\Index.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\GetOrderByLoggedInUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58ccac5765ba0838062450f9c687491a4b93c1ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserProfile_GetOrderByLoggedInUser), @"mvc.1.0.view", @"/Views/UserProfile/GetOrderByLoggedInUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58ccac5765ba0838062450f9c687491a4b93c1ab", @"/Views/UserProfile/GetOrderByLoggedInUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63d5512970a8db89a7fad5d279dc1b67feae9953", @"/Views/_ViewImports.cshtml")]
    public class Views_UserProfile_GetOrderByLoggedInUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Order>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\GetOrderByLoggedInUser.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>GetOrderByLoggedInUser</h1>\r\n<table class=\"table table-hover table-responsive\">\r\n    <thead>\r\n        <tr>\r\n            <th>Order ID.</th>\r\n            <th>User ID.</th>\r\n            <th>Order Date.</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\GetOrderByLoggedInUser.cshtml"
         foreach (var order in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\GetOrderByLoggedInUser.cshtml"
               Write(order.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\GetOrderByLoggedInUser.cshtml"
               Write(order.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\GetOrderByLoggedInUser.cshtml"
               Write(order.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 24 "F:\final project\fuck amira\Organic_Food\AuthApplication\Views\UserProfile\GetOrderByLoggedInUser.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591

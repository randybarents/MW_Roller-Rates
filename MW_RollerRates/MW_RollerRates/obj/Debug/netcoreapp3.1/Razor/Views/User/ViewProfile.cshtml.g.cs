#pragma checksum "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\User\ViewProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86bcd3106cab5a197672b85b055984e9995c7533"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ViewProfile), @"mvc.1.0.view", @"/Views/User/ViewProfile.cshtml")]
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
#line 1 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\_ViewImports.cshtml"
using MW_RollerRates;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\_ViewImports.cshtml"
using MW_RollerRates.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86bcd3106cab5a197672b85b055984e9995c7533", @"/Views/User/ViewProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6e00006d4972225514182381be1803f7485f9a", @"/Views/_ViewImports.cshtml")]
    public class Views_User_ViewProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MW_RollerRates.Models.UserProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\User\ViewProfile.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "Profile page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content bg_white_block\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <h1>Username : ");
#nullable restore
#line 12 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\User\ViewProfile.cshtml"
                      Write(Model.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h2>Email : ");
#nullable restore
#line 13 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\User\ViewProfile.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n            <h3>Description : ");
#nullable restore
#line 14 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\User\ViewProfile.cshtml"
                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
            <h4>User Checkins</h4>
        </div>
    </div>
</div>

<div class=""row"">
    <table class=""table table-striped"">
        <thead class=""thead-ligh"">
            <tr>
                <th>
                    Rollercoaster Name
                </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 30 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\User\ViewProfile.cshtml"
             foreach (var item in Model.RollerCoasters)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\User\ViewProfile.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 37 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\User\ViewProfile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MW_RollerRates.Models.UserProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

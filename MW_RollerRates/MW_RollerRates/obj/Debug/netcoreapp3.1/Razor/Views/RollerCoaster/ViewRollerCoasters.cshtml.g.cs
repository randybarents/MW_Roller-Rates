#pragma checksum "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65e9ed7dfbd6e685e8d4d9490c42f6195f9a4516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RollerCoaster_ViewRollerCoasters), @"mvc.1.0.view", @"/Views/RollerCoaster/ViewRollerCoasters.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65e9ed7dfbd6e685e8d4d9490c42f6195f9a4516", @"/Views/RollerCoaster/ViewRollerCoasters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be6e00006d4972225514182381be1803f7485f9a", @"/Views/_ViewImports.cshtml")]
    public class Views_RollerCoaster_ViewRollerCoasters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MW_RollerRates.Models.ViewRollerCoasterModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    ViewData["Title"] = "ViewRollerCoasters";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content bg_white_block"">
    <div class=""row"">
        <div class=""col-md-6"">
            <h1>RollerCoasters</h1>
        </div>
    </div>

    <div class=""row"">
        <table class=""table table-striped"">
            <thead class=""thead-ligh"">
                <tr>
                    <th>
                        ");
#nullable restore
#line 20 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 23 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                   Write(Html.DisplayNameFor(model => model.Speed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 26 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                   Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 29 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                   Write(Html.DisplayNameFor(model => model.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 34 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 38 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Speed));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 44 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Length));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Height));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "D:\Git\MW_Roller-Rates\MW_RollerRates\MW_RollerRates\Views\RollerCoaster\ViewRollerCoasters.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MW_RollerRates.Models.ViewRollerCoasterModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

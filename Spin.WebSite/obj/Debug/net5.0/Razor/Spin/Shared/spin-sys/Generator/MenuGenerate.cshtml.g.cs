#pragma checksum "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6db1ccad549eeb6e773dd348d03278e52e09aac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Shared_spin_sys_Generator_MenuGenerate), @"mvc.1.0.view", @"/Spin/Shared/spin-sys/Generator/MenuGenerate.cshtml")]
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
#line 3 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.WebSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Helper.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Modules.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper.Extend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\_ViewImports.cshtml"
using Spin.Base.Helper.Company;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
using Spin.Modules.Entity.Backend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6db1ccad549eeb6e773dd348d03278e52e09aac", @"/Spin/Shared/spin-sys/Generator/MenuGenerate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Shared_spin_sys_Generator_MenuGenerate : Spin.Base.Extend.Page.SpinWebViewPage<Dictionary<string, BackendContent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
  
    string SelectItem = ViewBag.SelectItem;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-menu"">
    <div class=""row no-gutters align-items-center items-menu"">
        <div class=""col-3 content-menu-logo"">
            <div id=""menuMobile"" class=""row menu-logo"">

                <div class=""col-10 title-mobile-page"">
                    ");
#nullable restore
#line 14 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
                Write((String.IsNullOrEmpty(SpinViewPage.Module.Alias)) ? SpinViewPage.Module.Name : SpinViewPage.Module.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <div class=""d-xl-none d-lg-none d-md-none d-sm-block d-block col-2"">
                    <div class=""menu-mobile"">
                        <i class=""fas fa-angle-right fa-2x"" aria-hidden=""true""></i>
                    </div>
                </div>

            </div>
        </div>
        <div id=""contentMenu"" class=""col-9 content-items-menu"">
            <ul class=""content-menu-back"">

");
#nullable restore
#line 27 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
                 foreach (var ItemMenu in Model.OrderBy(a => a.Value.Order))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 1081, "\"", 1165, 1);
#nullable restore
#line 29 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
WriteAttributeValue("", 1089, (ItemMenu.Value.GetNameController() == SelectItem)?"color-select-menu":"", 1089, 76, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1195, "\"", 1287, 5);
            WriteAttributeValue("", 1202, "/Admin/", 1202, 7, true);
#nullable restore
#line 30 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
WriteAttributeValue("", 1209, SpinViewPage.ModuleName, 1209, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1235, "/", 1235, 1, true);
#nullable restore
#line 30 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
WriteAttributeValue("", 1236, ItemMenu.Value.GetNameController(), 1236, 37, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1273, "/IndexGenerate", 1273, 14, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 31 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
                             if (!String.IsNullOrEmpty(ItemMenu.Value.Logo))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i");
            BeginWriteAttribute("class", " class=\"", 1434, "\"", 1464, 1);
#nullable restore
#line 33 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
WriteAttributeValue("", 1442, ItemMenu.Value.Logo, 1442, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n");
#nullable restore
#line 34 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
#nullable restore
#line 35 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
                       Write(ItemMenu.Value.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");
#nullable restore
#line 38 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Shared\spin-sys\Generator\MenuGenerate.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dictionary<string, BackendContent>> Html { get; private set; }
    }
}
#pragma warning restore 1591

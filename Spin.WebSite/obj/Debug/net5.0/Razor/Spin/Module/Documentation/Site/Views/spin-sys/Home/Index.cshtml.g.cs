#pragma checksum "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4058db98054695e280241403c9f3f8c4ae99cf3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Spin_Module_Documentation_Site_Views_spin_sys_Home_Index), @"mvc.1.0.view", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/Index.cshtml")]
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
#line 2 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
using Spin.Base.Documentation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
using Spin.Modules.Entity.Base;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
using Spin.Base.Documentation.Language;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4058db98054695e280241403c9f3f8c4ae99cf3e", @"/Spin/Module/Documentation/Site/Views/spin-sys/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e902045ac0bdbf79334c35ab32155f142969e063", @"/Spin/_ViewImports.cshtml")]
    public class Spin_Module_Documentation_Site_Views_spin_sys_Home_Index : Spin.Base.Extend.Page.SpinWebViewPage<MemberDocument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
  
    this.SpinViewPage.AddStyle("/lib/bootstrap-treeview/dist/bootstrap-treeview.min.css", false);
    this.SpinViewPage.AddJavaScript("/lib/bootstrap-treeview/dist/bootstrap-treeview.min.js", false);

    this.SpinViewPage.AddStyle("https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.18.1/styles/vs2015.min.css", false);
    this.SpinViewPage.AddJavaScript("https://cdnjs.cloudflare.com/ajax/libs/highlight.js/9.18.1/highlight.min.js", false);

    this.SpinViewPage.AddStyle("/Spin/Module/Documentation/Resource/spin-sys/css/documentation.css", false);
    this.SpinViewPage.AddStyle("/Spin/Module/Documentation/Resource/spin-sys/css/documentation-media.css", false);
    this.SpinViewPage.AddStyle("/Spin/Module/Documentation/Resource/spin-sys/css/fonts/font-documentation/style.css");
    this.SpinViewPage.AddJavaScript("/Spin/Module/Documentation/Resource/spin-sys/js/documentation.js", false);

    //try override
    this.SpinViewPage.AddTryStyle("/Spin/Module/Documentation/Resource/css/documentation.css", false);
    this.SpinViewPage.AddTryStyle("/Spin/Module/Documentation/Resource/css/documentation-media.css", false);
    this.SpinViewPage.AddTryJavaScript("/Spin/Module/Documentation/Resource/js/documentation.js", false);

    //https://github.com/jonmiles/bootstrap-treeview

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row no-gutters\">\r\n    <div class=\"col-3\">\r\n        <div class=\"content-tree\">\r\n            <div id=\"tree\"></div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-9 content-render-page\">\r\n        <div");
            BeginWriteAttribute("class", " class=\"", 1670, "\"", 1678, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 34 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
             if (Model == null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"class-detail\">\r\n                    ");
#nullable restore
#line 37 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
               Write(await Html.SpinRenderActionAsync("Introduction"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input id=\"className\" type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1968, "\"", 1991, 1);
#nullable restore
#line 42 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
WriteAttributeValue("", 1976, Model.FullName, 1976, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <div>\r\n                    ");
#nullable restore
#line 44 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
               Write(await Html.SpinRenderActionAsync("Index", "Breadcrumbs", "Util"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral("                <div id=\"page\" class=\"page-documentation\">\r\n");
#nullable restore
#line 48 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                     switch (Model.TypeMember)
                    {
                        default:
                        case TypeMember.Class:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n                                ");
#nullable restore
#line 53 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync("ClassDetail", new { id = Model.FullName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 55 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;

                        case TypeMember.External:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n");
#nullable restore
#line 59 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                                   var ExternalData = (ExternalDocument)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
#nullable restore
#line 60 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync(ExternalData.Action, ExternalData.Controller, ExternalData.Module));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 62 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;


                        case TypeMember.Package:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n                                ");
#nullable restore
#line 67 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync("PackageDetail", new { id = Model.FullName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 69 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;


                        case TypeMember.Method:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n                                ");
#nullable restore
#line 74 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync("MethodDetail", new { id = Model.FullName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 76 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;


                        case TypeMember.Property:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n                                ");
#nullable restore
#line 81 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync("PropertyDetail", new { id = Model.FullName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 83 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;

                        case TypeMember.Constructor:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n                                ");
#nullable restore
#line 87 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync("ConstructorDetail", new { id = Model.FullName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 89 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;


                        case TypeMember.Field:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n                                ");
#nullable restore
#line 94 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync("FieldDetail", new { id = Model.FullName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 96 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;

                        case TypeMember.Enum:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n                                ");
#nullable restore
#line 100 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync("EnumDetail", new { id = Model.FullName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 102 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;

                        case TypeMember.Interface:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"class-detail\">\r\n                                ");
#nullable restore
#line 106 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                           Write(await Html.SpinRenderActionAsync("InterfaceDetail", new { id = Model.FullName }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 108 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
                            break;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 111 "C:\Users\57300\Documents\Repositorios\Spin-gRPC-Tutoria\Spin.WebSite\Spin\Module\Documentation\Site\Views\spin-sys\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberDocument> Html { get; private set; }
    }
}
#pragma warning restore 1591

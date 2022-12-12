#pragma checksum "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "618eeffc1887d98248fe0980370dc9ce85673ea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_Index), @"mvc.1.0.view", @"/Views/Experience/Index.cshtml")]
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
#line 1 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618eeffc1887d98248fe0980370dc9ce85673ea7", @"/Views/Experience/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Experience_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Deneyimler</h4>


            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Başlık</th>
                            <th>Tarih</th>
                            <th>Sil</th>
                            <th>Güncelle</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 26 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 29 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
                               Write(item.ExperiencID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1084, "\"", 1137, 2);
            WriteAttributeValue("", 1091, "/Experience/DeleteExperience/", 1091, 29, true);
#nullable restore
#line 32 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1120, item.ExperiencID, 1120, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Sil</a></td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1222, "\"", 1275, 2);
            WriteAttributeValue("", 1229, "/Experience/UpdateExperience/", 1229, 29, true);
#nullable restore
#line 33 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
WriteAttributeValue("", 1258, item.ExperiencID, 1258, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Güncelle</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 35 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Experience\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <br />\r\n            <a href=\"/Experience/AddExperience\" class=\"btn btn-info\">Yeni Deneyim Ekle</a>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

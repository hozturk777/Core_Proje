#pragma checksum "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "335b1336303302aa8fc4e85b388b9fdd5bfd17de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PortFolio_UpdatePortfolio), @"mvc.1.0.view", @"/Views/PortFolio/UpdatePortfolio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"335b1336303302aa8fc4e85b388b9fdd5bfd17de", @"/Views/PortFolio/UpdatePortfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_PortFolio_UpdatePortfolio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.PortFolio>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
  
    ViewData["Title"] = "UpdatePortfolio";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
 using (Html.BeginForm("UpdatePortfolio", "PortFolio", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card-header border-0\" style=\"margin-top:7px\">\r\n        <h3 class=\"mb-0\">Proje Düzenleme Tablosu </h3>\r\n    </div>\r\n");
#nullable restore
#line 12 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.HiddenFor(x => x.PortFolioID));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 14 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.Label("Deneyim Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Name, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Görsel 1</label>\r\n");
#nullable restore
#line 19 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Görsel 2</label>\r\n");
#nullable restore
#line 23 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ImageUrl2, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ImageUrl2));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Proje Url</label>\r\n");
#nullable restore
#line 27 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.ProjectUrl, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.ProjectUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Fiyat</label>\r\n");
#nullable restore
#line 31 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Price, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Tamamlanma Oranı</label>\r\n");
#nullable restore
#line 35 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Value, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <label>Platform</label>\r\n");
#nullable restore
#line 39 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.TextBoxFor(x=>x.Platform, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
Write(Html.ValidationMessageFor(x => x.Platform));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
            WriteLiteral("    <button class=\"btn btn-primary\">Güncelle</button>\r\n");
#nullable restore
#line 44 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\PortFolio\UpdatePortfolio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.PortFolio> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
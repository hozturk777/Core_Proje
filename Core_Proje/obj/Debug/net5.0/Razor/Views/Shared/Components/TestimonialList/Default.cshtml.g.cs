#pragma checksum "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "053082d9286581ee9aea60bb66b78c77a212700f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_TestimonialList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
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
#line 1 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"053082d9286581ee9aea60bb66b78c77a212700f", @"/Views/Shared/Components/TestimonialList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_TestimonialList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Testimonial>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"section px-3 px-lg-4 pt-5\" id=\"testimonials\">\r\n\t<div class=\"container-narrow\">\r\n\t\t<div class=\"text-center mb-5\">\r\n\t\t\t<h2 class=\"marker marker-center\">Referanslarım</h2>\r\n\t\t</div>\r\n\t\t<div class=\"row\">\r\n");
#nullable restore
#line 9 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-6 mb-5\" data-aos=\"fade-right\" data-aos-delay=\"100\">\r\n\t\t\t\t\t<div class=\"d-flex ms-md-3\"><span><i class=\"fas fa-2x fa-quote-left\"></i></span><span class=\"m-2\">");
#nullable restore
#line 12 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                                                                                 Write(item.Comment);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n\t\t\t\t\t<div class=\"d-flex justify-content-end align-items-end\">\r\n\t\t\t\t\t\t<div class=\"text-end me-2\">\r\n\t\t\t\t\t\t\t<div class=\"fw-bolder\">");
#nullable restore
#line 15 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                              Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t\t<div class=\"text-small\">");
#nullable restore
#line 16 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 16 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
                                                             Write(item.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\t\t\t\t\t\t</div><img class=\"me-md-3 rounded\"");
            BeginWriteAttribute("src", " src=\"", 769, "\"", 789, 1);
#nullable restore
#line 17 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
WriteAttributeValue("", 775, item.ImageUrl, 775, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"96\" height=\"96\" alt=\"client 1\" />\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 20 "F:\hüseyin\core1\Core_Proje\Core_Proje\Core_Proje\Views\Shared\Components\TestimonialList\Default.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Testimonial>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
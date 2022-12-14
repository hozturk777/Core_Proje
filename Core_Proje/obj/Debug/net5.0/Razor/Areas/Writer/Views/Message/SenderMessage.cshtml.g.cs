#pragma checksum "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8c7c43f8b72b9c8c71625efc915321f4ebddf10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Writer_Views_Message_SenderMessage), @"mvc.1.0.view", @"/Areas/Writer/Views/Message/SenderMessage.cshtml")]
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
#line 1 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8c7c43f8b72b9c8c71625efc915321f4ebddf10", @"/Areas/Writer/Views/Message/SenderMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23ac09be4bcfaa7f9829a01d1a134874eaae1f3b", @"/Areas/Writer/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Writer_Views_Message_SenderMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WriterMessage>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
  
    ViewData["Title"] = "SenderMessage";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Giden Kutusu</h4>
            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Konu</th>
                            <th>Alıcı</th>
                            <th>Tarih</th>
                            <th>Detaylar</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 24 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <th>");
#nullable restore
#line 27 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                               Write(item.WriterMessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                                <td>");
#nullable restore
#line 28 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                               Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                               Write(item.ReceiverName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                                Write(((DateTime)item.Date).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1197, "\"", 1262, 2);
            WriteAttributeValue("", 1204, "/Writer/Message/SenderMessageDetails/", 1204, 37, true);
#nullable restore
#line 31 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
WriteAttributeValue("", 1241, item.WriterMessageID, 1241, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Mesajı Gör</a></td>\r\n                            </tr>\r\n");
#nullable restore
#line 33 "F:\hüseyin\Core_Proje\Core_Proje\Areas\Writer\Views\Message\SenderMessage.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WriterMessage>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

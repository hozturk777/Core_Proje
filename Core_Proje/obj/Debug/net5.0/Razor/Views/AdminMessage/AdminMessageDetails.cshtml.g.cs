#pragma checksum "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8991d89c4526d5ef11d592c7336f8d65fa178620"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminMessage_AdminMessageDetails), @"mvc.1.0.view", @"/Views/AdminMessage/AdminMessageDetails.cshtml")]
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
#line 1 "F:\hüseyin\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\hüseyin\Core_Proje\Core_Proje\Views\_ViewImports.cshtml"
using Core_Proje.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8991d89c4526d5ef11d592c7336f8d65fa178620", @"/Views/AdminMessage/AdminMessageDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3916d9c95bde3173996b91a771a7fba1f38cc4f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_AdminMessage_AdminMessageDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.WriterMessage>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReceiverMessageList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
  
    ViewData["Title"] = "AdminMessageDetails";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8991d89c4526d5ef11d592c7336f8d65fa1786204750", async() => {
                WriteLiteral(@"
    <div class=""col-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"" style=""font-size:25px"">
                    Mesaj Kutusu

                </h4>
                ");
#nullable restore
#line 15 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.HiddenFor(x => x.WriterMessageID, new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 17 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.Label("Konu"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 18 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.TextBoxFor(x => x.Subject, new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 20 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.Label("Gönderen Adı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 21 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.TextBoxFor(x => x.SenderName, new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 23 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.Label("Alıcı Adı"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 24 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.TextAreaFor(x => x.ReceiverName, new { @class ="form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 26 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.Label("Tarih"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 27 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.TextBoxFor(x => x.Date, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <br />\r\n                ");
#nullable restore
#line 29 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.Label("Mesaj"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 30 "F:\hüseyin\Core_Proje\Core_Proje\Views\AdminMessage\AdminMessageDetails.cshtml"
           Write(Html.TextAreaFor(x => x.MessageContent, 6,3, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n               \r\n\r\n                <br />\r\n                <div style=\"text-align:right\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8991d89c4526d5ef11d592c7336f8d65fa1786208608", async() => {
                    WriteLiteral("Geri");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.WriterMessage> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Autobus\UrediAutobus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "521289a01dc2e44e68f646483ba390bc3564fe4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autobus_UrediAutobus), @"mvc.1.0.view", @"/Views/Autobus/UrediAutobus.cshtml")]
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
#line 1 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\_ViewImports.cshtml"
using WebAutoprevozncniko;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\_ViewImports.cshtml"
using WebAutoprevozncniko.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Autobus\UrediAutobus.cshtml"
using Autoprevoznicko_preduzece_HTS.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"521289a01dc2e44e68f646483ba390bc3564fe4e", @"/Views/Autobus/UrediAutobus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_Autobus_UrediAutobus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Autobus/SpasiUredjivanje"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Autobus\UrediAutobus.cshtml"
  
    ViewData["Title"] = "UrediAutobus";
    Autobus a = (Autobus)ViewData["Autobus"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumb"">
    <div class=""container"">
        <div class=""d-flex justify-content-between align-content-center"">
            <h2>Uredi</h2>
            <ol>
                <li><a href=""/Autobus"">Vrati nazad</a></li>
                <li>Uredi</li>
            </ol>
        </div>
    </div>
</section>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "521289a01dc2e44e68f646483ba390bc3564fe4e4641", async() => {
                WriteLiteral("\r\n    <input name=\"ID\" style=\"display:none\"");
                BeginWriteAttribute("value", " value=\"", 558, "\"", 571, 1);
#nullable restore
#line 19 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Autobus\UrediAutobus.cshtml"
WriteAttributeValue("", 566, a.ID, 566, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"form-group\">\r\n        <label>Redni broj autobusa</label>\r\n        <input class=\"form-control\" name=\"RedniBrojAutobusa\"");
                BeginWriteAttribute("value", " value=\"", 711, "\"", 739, 1);
#nullable restore
#line 22 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Autobus\UrediAutobus.cshtml"
WriteAttributeValue("", 719, a.RedniBrojAutobusa, 719, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Broj sjedista</label>\r\n        <input class=\"form-control\" name=\"BrojSjedista\"");
                BeginWriteAttribute("value", " value=\"", 880, "\"", 902, 1);
#nullable restore
#line 26 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Autobus\UrediAutobus.cshtml"
WriteAttributeValue("", 888, a.BrojSjedila, 888, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Godiste autobusa</label>\r\n        <input class=\"form-control\" name=\"GodisteAutobusa\"");
                BeginWriteAttribute("value", " value=\"", 1049, "\"", 1075, 1);
#nullable restore
#line 30 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Autobus\UrediAutobus.cshtml"
WriteAttributeValue("", 1057, a.GodisteAutobusa, 1057, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Info</label>\r\n        <input class=\"form-control\" name=\"Info\"");
                BeginWriteAttribute("value", " value=\"", 1199, "\"", 1221, 1);
#nullable restore
#line 34 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Autobus\UrediAutobus.cshtml"
WriteAttributeValue("", 1207, a.informacije, 1207, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n    <input type=\"submit\" value=\"Snimi\" />\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<a href=\"/Autobus\">Vrati nazad</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

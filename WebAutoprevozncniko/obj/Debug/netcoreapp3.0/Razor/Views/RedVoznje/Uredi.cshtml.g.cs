#pragma checksum "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "facc1da5d7f37a097fc2cc15d679b95a9a27a960"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RedVoznje_Uredi), @"mvc.1.0.view", @"/Views/RedVoznje/Uredi.cshtml")]
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
#line 1 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\_ViewImports.cshtml"
using WebAutoprevozncniko;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\_ViewImports.cshtml"
using WebAutoprevozncniko.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
using Autoprevoznicko_preduzece_HTS.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
using WebAutoprevozncniko.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"facc1da5d7f37a097fc2cc15d679b95a9a27a960", @"/Views/RedVoznje/Uredi.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_RedVoznje_Uredi : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/RedVoznje/SpasiUredi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
  
    ViewData["Title"] = "DodajRedVoznje";
    List<ComboBox> linija = (List<ComboBox>)ViewData["linija"];
    RedVoznje rv = (RedVoznje)ViewData["redvoznje"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""breadcrumbs"">
    <div class=""container"">

        <div class=""d-flex justify-content-between align-items-center"">
            <h2>Uredi red voznje </h2>
            <ol>
                <li><a href=""/Karta"">Vrati nazad</a></li>
                <li>Uredi red voznje</li>
            </ol>
        </div>
    </div>
</section>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "facc1da5d7f37a097fc2cc15d679b95a9a27a9604985", async() => {
                WriteLiteral("\r\n    <div class=\"form-group\">\r\n        <input class=\"form-control\" name=\"ID\" style=\"display:none\"");
                BeginWriteAttribute("value", " value=\"", 743, "\"", 757, 1);
#nullable restore
#line 23 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
WriteAttributeValue("", 751, rv.ID, 751, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <select name=\"linijaID\" class=\"form-control\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "facc1da5d7f37a097fc2cc15d679b95a9a27a9605821", async() => {
                    WriteLiteral("Odaberite liniju");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
             foreach (ComboBox l in linija)
            {
                if (l.ID == rv.gradskaLinijaID)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "facc1da5d7f37a097fc2cc15d679b95a9a27a9607215", async() => {
#nullable restore
#line 30 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
                                              Write(l.naziv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
                                WriteLiteral(l.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "facc1da5d7f37a097fc2cc15d679b95a9a27a9609714", async() => {
#nullable restore
#line 33 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
                                 Write(l.naziv);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 33 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
                   WriteLiteral(l.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label>Vrijeme polaska</label>\r\n        <input class=\"form-control\" type=\"datetime\" name=\"vrijemePolaska\"");
                BeginWriteAttribute("value", " value=\"", 1330, "\"", 1356, 1);
#nullable restore
#line 39 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\RedVoznje\Uredi.cshtml"
WriteAttributeValue("", 1338, rv.VrijemePolaska, 1338, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    </div>\r\n\r\n    <br />\r\n    <input type=\"submit\" value=\"Snimi\" />\r\n\r\n");
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
            WriteLiteral("\r\n<a href=\"/GradskeLinije\">Vrati nazad</a>\r\n\r\n\r\n");
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

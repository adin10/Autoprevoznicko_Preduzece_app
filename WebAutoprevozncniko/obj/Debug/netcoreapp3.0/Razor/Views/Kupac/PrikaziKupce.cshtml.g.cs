#pragma checksum "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2bf9fc70cdfd193d040d44181f5b96328f5e0644"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kupac_PrikaziKupce), @"mvc.1.0.view", @"/Views/Kupac/PrikaziKupce.cshtml")]
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
#line 1 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
using Autoprevoznicko_preduzece_HTS.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
using WebAutoprevozncniko.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2bf9fc70cdfd193d040d44181f5b96328f5e0644", @"/Views/Kupac/PrikaziKupce.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_Kupac_PrikaziKupce : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
  
    ViewData["Title"] = "PrikaziKupce";
    List<KupacPrikaziWM> kupci = (List<KupacPrikaziWM>)ViewData["kupci"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"" integrity=""sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI"" crossorigin=""anonymous""></script>
<div>
    <section class=""breadcrumbs"">
        <div class=""container"">

            <div class=""d-flex justify-content-between align-items-center"" style=""padding-top:40px"">
                <h2>Lista kupaca </h2>
");
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2bf9fc70cdfd193d040d44181f5b96328f5e06445681", async() => {
                WriteLiteral(@"
        <table>
            <tr>
                <td>Ime</td>
                <td>Prezime</td>
                <td>Telefon</td>
                <td>Email</td>
                <td>Grad</td>
                <td>Obrisi kupca</td>
                <td>Uredi podatke</td>
                <td>Obavijesti kupca</td>
            </tr>

");
#nullable restore
#line 37 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
             foreach (KupacPrikaziWM k in kupci)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 40 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
                   Write(k.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
                   Write(k.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
                   Write(k.telefon);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
                   Write(k.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
                   Write(k.Grad);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>\r\n                        <a class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 2158, "\"", 2197, 2);
                WriteAttributeValue("", 2165, "/Kupac/ObrisiKupca?KupacID=", 2165, 27, true);
#nullable restore
#line 46 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
WriteAttributeValue("", 2192, k.ID, 2192, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Obrisi</a>\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-warning\"");
                BeginWriteAttribute("href", " href=\"", 2314, "\"", 2352, 2);
                WriteAttributeValue("", 2321, "/Kupac/UrediKupca?KupacID=", 2321, 26, true);
#nullable restore
#line 49 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
WriteAttributeValue("", 2347, k.ID, 2347, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Uredi</a>\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-warning\"");
                BeginWriteAttribute("href", " href=\"", 2468, "\"", 2498, 2);
                WriteAttributeValue("", 2475, "/SMS/Send?KupacID=", 2475, 18, true);
#nullable restore
#line 52 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
WriteAttributeValue("", 2493, k.ID, 2493, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Posalji poruku</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 55 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Kupac\PrikaziKupce.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n\r\n    ");
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
            WriteLiteral("\r\n    <br />\r\n    <a class=\"btn btn-secondary\" href=\"/Kupac\">Vrati nazad</a>\r\n</div>\r\n\r\n\r\n");
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

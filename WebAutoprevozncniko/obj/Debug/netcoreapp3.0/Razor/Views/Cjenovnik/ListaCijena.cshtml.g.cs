#pragma checksum "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29a77a8bf7bb823a269aec7937488ce62f7367c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cjenovnik_ListaCijena), @"mvc.1.0.view", @"/Views/Cjenovnik/ListaCijena.cshtml")]
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
#line 1 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
using Autoprevoznicko_preduzece_HTS.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
using WebAutoprevozncniko.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
using WebAutoprevozncniko.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29a77a8bf7bb823a269aec7937488ce62f7367c6", @"/Views/Cjenovnik/ListaCijena.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_Cjenovnik_ListaCijena : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 6 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "ListaCijena";
    List<CjenovnikPrikaziVM> cijene = (List<CjenovnikPrikaziVM>)ViewData["Cjenovnik"];
    Login login = Context.GetLogiraniKorisnik();
    MyContext _context = Context.RequestServices.GetService<MyContext>();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
<script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
<script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"" integrity=""sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"" crossorigin=""anonymous""></script>
<script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"" integrity=""sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI"" crossorigin=""anonymous""></script>


");
#nullable restore
#line 19 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
 if (login == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"breadcrumbs\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"d-flex justify-content-between align-items-center\" style=\"padding-top:20px\">\r\n                <h2>Lista cijena </h2>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a77a8bf7bb823a269aec7937488ce62f7367c66872", async() => {
                WriteLiteral("\r\n        <table>\r\n            <tr>\r\n                <td>Zona</td>\r\n                <td>Vrsta karte</td>\r\n                <td>Tip karte</td>\r\n                <td>Cijena</td>\r\n");
                WriteLiteral("            </tr>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
             foreach (CjenovnikPrikaziVM c in cijene)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 47 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.zona);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 48 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.VrstaKarte);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 49 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.tipKarte);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 50 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.Cijena);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span>KM</span></td>\r\n");
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 58 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
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
            WriteLiteral("\r\n    <br />\r\n    <a class=\"btn btn-secondary\" href=\"/Home\">Vrati nazad</a>\r\n");
#nullable restore
#line 63 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
}
else if (_context.vozac.Where(x => x.loginID == login.ID).FirstOrDefault() != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"breadcrumbs\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"d-flex justify-content-between align-items-center\" style=\"padding-top:40px\">\r\n                <h2>Lista cijena </h2>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a77a8bf7bb823a269aec7937488ce62f7367c611111", async() => {
                WriteLiteral("\r\n        <table>\r\n            <tr>\r\n                <td>Zona</td>\r\n                <td>Vrsta karte</td>\r\n                <td>Tip karte</td>\r\n                <td>Cijena</td>\r\n");
                WriteLiteral("            </tr>\r\n\r\n");
#nullable restore
#line 89 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
             foreach (CjenovnikPrikaziVM c in cijene)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 92 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.zona);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 93 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.VrstaKarte);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 94 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.tipKarte);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 95 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.Cijena);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span>KM</span></td>\r\n\r\n");
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 104 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
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
            WriteLiteral("\r\n    <br />\r\n    <a class=\"btn btn-secondary\" href=\"/Home\">Vrati nazad</a>\r\n");
#nullable restore
#line 109 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"breadcrumbs\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"d-flex justify-content-between align-items-center\" style=\"padding-top:40px\">\r\n                <h2>Lista cijena </h2>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29a77a8bf7bb823a269aec7937488ce62f7367c615278", async() => {
                WriteLiteral(@"
        <table>
            <tr>
                <td>Zona</td>
                <td>Vrsta karte</td>
                <td>Tip karte</td>
                <td>Cijena</td>
                <td>Obrisi</td>
                <td>Uredi</td>
            </tr>

");
#nullable restore
#line 135 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
             foreach (CjenovnikPrikaziVM c in cijene)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 138 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.zona);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 139 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.VrstaKarte);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 140 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.tipKarte);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 141 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
                   Write(c.Cijena);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span>KM</span></td>\r\n\r\n                    <td>\r\n                        <a class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 5423, "\"", 5456, 2);
                WriteAttributeValue("", 5430, "/Cjenovnik/Obrisi?ID=", 5430, 21, true);
#nullable restore
#line 144 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
WriteAttributeValue("", 5451, c.ID, 5451, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Obrisi</a>\r\n                    </td>\r\n                    <td>\r\n                        <a class=\"btn btn-warning\"");
                BeginWriteAttribute("href", " href=\"", 5573, "\"", 5605, 2);
                WriteAttributeValue("", 5580, "/Cjenovnik/Uredi?ID=", 5580, 20, true);
#nullable restore
#line 147 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
WriteAttributeValue("", 5600, c.ID, 5600, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Uredi</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 150 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n    ");
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
            WriteLiteral("\r\n    <br />\r\n    <a class=\"btn btn-secondary\" href=\"/Cjenovnik\">Vrati nazad</a>\r\n");
#nullable restore
#line 155 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Cjenovnik\ListaCijena.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
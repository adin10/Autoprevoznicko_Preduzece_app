#pragma checksum "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9a336756a9e9ab8afc00aa2f58d3d4f641caf3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Uprava_PrikazUprave), @"mvc.1.0.view", @"/Views/Uprava/PrikazUprave.cshtml")]
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
#line 1 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
using Autoprevoznicko_preduzece_HTS.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
using WebAutoprevozncniko.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9a336756a9e9ab8afc00aa2f58d3d4f641caf3b", @"/Views/Uprava/PrikazUprave.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_Uprava_PrikazUprave : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 3 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
  
    ViewData["Title"] = "PrikazUprave";
    List<UpravaPrikaziVM> uprava = (List<UpravaPrikaziVM>)ViewData["uprava"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <section class=\"breadcrumbs\">\r\n        <div class=\"container\">\r\n\r\n            <div class=\"d-flex justify-content-between align-items-center\" style=\"padding-top:40px\">\r\n                <h2>Lista uprave </h2>\r\n");
            WriteLiteral("            </div>\r\n        </div>\r\n    </section>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e9a336756a9e9ab8afc00aa2f58d3d4f641caf3b4801", async() => {
                WriteLiteral(@"
        <table>
            <tr>
                <th>Ime</th>
                <th>Prezime</th>
                <th>Datum Rodjenja</th>
                <th>Korisnicko Ime</th>
                <th>Obrisi</th>
                <th>Uredi</th>
            </tr>

");
#nullable restore
#line 33 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
             foreach (UpravaPrikaziVM u in uprava)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
           Write(u.Ime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
           Write(u.Prezime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
           Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", u.DatumRodjenja)));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n            <td>");
#nullable restore
#line 40 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
           Write(u.login);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            <td>\r\n                <a class=\"btn btn-danger\"");
                BeginWriteAttribute("href", " href=\"", 1261, "\"", 1303, 2);
                WriteAttributeValue("", 1268, "/Uprava/ObrisiUprava?UpravaID=", 1268, 30, true);
#nullable restore
#line 42 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
WriteAttributeValue("", 1298, u.ID, 1298, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Obrisi</a>\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-warning\"");
                BeginWriteAttribute("href", " href=\"", 1396, "\"", 1437, 2);
                WriteAttributeValue("", 1403, "/Uprava/UrediUprava?UpravaID=", 1403, 29, true);
#nullable restore
#line 45 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
WriteAttributeValue("", 1432, u.ID, 1432, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Uredi</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\user\Source\Repos\Autoprevoznicko_Preduzece_app\WebAutoprevozncniko\Views\Uprava\PrikazUprave.cshtml"
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
            WriteLiteral("\r\n    <br />\r\n    <a class=\"btn btn-secondary\" href=\"/Uprava\">Vrati nazad</a>\r\n</div>\r\n");
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

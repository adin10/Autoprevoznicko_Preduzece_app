#pragma checksum "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35fc4fedf54eb5f4b9d563220e1a0371fdfe71ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 49 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
using Autoprevoznicko_preduzece_HTS.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
using WebAutoprevozncniko.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
using Microsoft.Extensions.DependencyInjection;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35fc4fedf54eb5f4b9d563220e1a0371fdfe71ec", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 54 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
  
     Login login = Context.GetLogiraniKorisnik();
    MyContext _context = Context.RequestServices.GetService<MyContext>();



#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35fc4fedf54eb5f4b9d563220e1a0371fdfe71ec5648", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta content=\"width=device-width, initial-scale=1.0\" name=\"viewport\">\r\n\r\n    <title>Autoprevozničko preduzeće HTS</title>\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 2998, "\"", 3008, 0);
                EndWriteAttribute();
                WriteLiteral(" name=\"descriptison\">\r\n    <meta");
                BeginWriteAttribute("content", " content=\"", 3041, "\"", 3051, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""keywords"">

    <!-- Favicons -->
    <link href=""/Content/assets/img/favicon.png"" rel=""icon"">
    <link href=""/Content/assets/img/apple-touch-icon.png"" rel=""apple-touch-icon"">

    <!-- Google Fonts -->
    <link href=""https://fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i|Raleway:300,300i,400,400i,500,500i,600,600i,700,700i|Poppins:300,300i,400,400i,500,500i,600,600i,700,700i"" rel=""stylesheet"">

    <!-- Vendor CSS Files -->
    <link href=""/Content/assets/vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""/Content/assets/vendor/icofont/icofont.min.css"" rel=""stylesheet"">
    <link href=""/Content/assets/vendor/boxicons/css/boxicons.min.css"" rel=""stylesheet"">
    <link href=""/Content/assets/vendor/owl.carousel/assets/owl.carousel.min.css"" rel=""stylesheet"">
    <link href=""/Content/assets/vendor/venobox/venobox.css"" rel=""stylesheet"">

    <!-- Template Main CSS File -->
    <link href=""/Content/assets/css/style.css"" rel=""stylesheet"">");
                WriteLiteral(@"

    <!-- =======================================================
    * Template Name: Baker - v2.1.0
    * Template URL: https://bootstrapmade.com/baker-free-onepage-bootstrap-theme/
    * Author: BootstrapMade.com
    * License: https://bootstrapmade.com/license/
    ======================================================== -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35fc4fedf54eb5f4b9d563220e1a0371fdfe71ec8588", async() => {
                WriteLiteral(@"

    <!-- ======= Header ======= -->
    <header id=""header"" class=""fixed-top "">
        <div class=""container d-flex align-items-center"">

            <h2 class=""logo mr-auto""><a href=""/Home"">Autoprevoznicko preduzece HTS</a></h2>
            <!-- Uncomment below if you prefer to use an image logo -->
            <!-- <a href=""index.html"" class=""logo mr-auto""><img src=""assets/img/logo.png"" alt="""" class=""img-fluid""></a>-->

");
#nullable restore
#line 106 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
             if (login == null)//
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <nav class=""nav-menu d-none d-lg-block"">
                    <ul>
                        <li>
                            <a href=""/Home"">Pocetna</a>
                        </li>
                        <li>
                            <a href=""/Cjenovnik/ListaCijena"">Cjenovnik</a>
                        </li>
                        <li>
                            <a href=""/GradskeLinije/ListaLinija"">Gradske Linije</a>
                        </li>
                        <li>
                            <a href=""/Obavijesti/PregledObavijesti"">Obavijesti</a>
                        </li>
                        <li>
                            <a href=""/RedVoznje/RasporedVoznje"">Red voznje</a>
                        </li>
                        <li>
                            <a href=""/Grad"">Grad</a>
                        </li>
                        <li>
                            <a class=""btn btn-warning"" href=""/Autentifikacija/Index"">Prijavi se</a>
       ");
                WriteLiteral("                 </li>\r\n                    </ul>\r\n                </nav>\r\n");
#nullable restore
#line 133 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
            }
            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 136 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
                 if (_context.vozac.Where(x => x.loginID == login.ID).FirstOrDefault() != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <nav class=\"nav-menu d-none d-lg-block\">\r\n                        <ul>\r\n");
                WriteLiteral("                            <li>\r\n                                <a href=\"/Home\">Pocetna</a>\r\n                            </li>\r\n");
                WriteLiteral(@"                            <li>
                                <a href=""/Karta/ListaKarata"">Karta</a>
                            </li>
                            <li>
                                <a href=""/Cjenovnik/ListaCijena"">Cjenovnik</a>
                            </li>
");
                WriteLiteral("                            <li>\r\n                                <a href=\"/GradskeLinije/ListaLinija\">Gradske Linije</a>\r\n                            </li>\r\n");
                WriteLiteral("                            <li>\r\n                            <a href=\"/Vozac/PrikazVozaca\">Vozac</a>\r\n                            </li>\r\n");
                WriteLiteral("                            <li>\r\n                                <a href=\"/Obavijesti/PregledObavijesti\">Obavijesti</a>\r\n                            </li>\r\n");
                WriteLiteral(@"                            <li>
                                <a href=""/RedVoznje/RasporedVoznje"">Red voznje</a>
                            </li>
                            <li>
                                <a href=""/Autobus/PrikaziAutobusa"">Autobus</a>
                            </li>
                             <li>
                                <a class=""btn btn-warning"" href=""/Autentifikacija/Logout"">Odjavi se</a>
                            </li>
");
                WriteLiteral("\r\n");
                WriteLiteral("\r\n                        </ul>\r\n                        <ul>\r\n                            <li>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 9172, "\"", 9179, 0);
                EndWriteAttribute();
                WriteLiteral(">Posalji poruku</a>\r\n                            </li>\r\n                        </ul>\r\n\r\n                    </nav><!-- .nav-menu -->\r\n");
#nullable restore
#line 208 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 210 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
                 if (_context.uprava.Where(x => x.loginID == login.ID).FirstOrDefault() != null)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <nav class=\"nav-menu d-none d-lg-block\">\r\n\r\n\r\n\r\n                        <ul>\r\n");
                WriteLiteral(@"                            <li>
                                <a href=""/Home"">Pocetna</a>
                            </li>
                            <li>
                                <a href=""/Kupac"">Kupac</a>
                            </li>
                            <li>
                                <a href=""/karta"">Karta</a>
                            </li>
                            <li>
                                <a href=""/Cjenovnik"">Cjenovnik</a>
                            </li>
                             <li>
                                <a href=""/Grad"">Grad</a>
                            </li>
                            <li>
                                <a href=""/GradskeLinije"">Gradske Linije</a>
                            </li>
                            <li>
                                <a href=""/Opstina"">Opstina</a>
                            </li>
                           <li>
                                <a class=""btn btn-warning"" ");
                WriteLiteral("href=\"/Autentifikacija/Logout\">Odjavi se</a>\r\n                            </li>\r\n");
                WriteLiteral("                           \r\n");
                WriteLiteral(@"
                        </ul>
                        <ul>
                            <li>
                                <a href=""/Vozac"">Vozac</a>
                            </li>
                            <li>
                                <a href=""/Uprava"">Uprava</a>
                            </li>
                            <li>
                                <a href=""/Obavijesti"">Obavijesti</a>
                            </li>
                            <li>
                                <a href=""/AutobusVozac"">Autobus-Vozac</a>
                            </li>
                            <li>
                                <a href=""/RedVoznje"">Red voznje</a>
                            </li>
                            <li>
                                <a href=""/Autobus"">Autobus</a>
                            </li>

                        </ul>

                    </nav><!-- .nav-menu -->
");
#nullable restore
#line 285 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 285 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </div>\r\n    </header><!-- End Header -->\r\n\r\n    <main id=\"main\">\r\n        <div class=\"container\">\r\n            <main role=\"main\" class=\"pb-3\">\r\n                ");
#nullable restore
#line 293 "C:\Users\Adin\Desktop\webappPravaVerzija\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Shared\_Layout.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </main>



        </div>


    </main><!-- End #main -->
    <!-- ======= Footer ======= -->
    <footer id=""footer"">

        <div class=""footer-top"">
            <div class=""container"">
                <div class=""row"">

                    <div class=""col-lg-3 col-md-6 footer-contact"">
                        <h3>HTS</h3>
                        <p>
                            Maršala Tita,Mostar 88000 <br>
                            Mostar<br>
                            Bosna i Hercegovina <br><br>
                            <strong>Phone:</strong> +1 5589 55488 55<br>
                            <strong>Email:</strong> web.autoprevoznicko@gmail.com<br>
                        </p>
                    </div>

                    <div class=""col-lg-2 col-md-6 footer-links"">
                        <h4>Useful Links</h4>
                        <ul>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Home</a></li>
                   ");
                WriteLiteral(@"         <li><i class=""bx bx-chevron-right""></i> <a href=""#"">About us</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Services</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Terms of service</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Privacy policy</a></li>
                        </ul>
                    </div>

                    <div class=""col-lg-3 col-md-6 footer-links"">
                        <h4>Our Services</h4>
                        <ul>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Web Design</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Web Development</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Product Management</a></li>
                            <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Marketing</a></li>
             ");
                WriteLiteral(@"               <li><i class=""bx bx-chevron-right""></i> <a href=""#"">Graphic Design</a></li>
                        </ul>
                    </div>

                    <div class=""col-lg-4 col-md-6 footer-newsletter"">
                        <h4>Join Our Newsletter</h4>
                        <p>Tamen quem nulla quae legam multos aute sint culpa legam noster magna</p>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35fc4fedf54eb5f4b9d563220e1a0371fdfe71ec20065", async() => {
                    WriteLiteral("\r\n                            <input type=\"email\" name=\"email\"><input type=\"submit\" value=\"Subscribe\">\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>

                </div>
            </div>
        </div>

        <div class=""container d-md-flex py-4"">

            <div class=""mr-md-auto text-center text-md-left"">
                <div class=""copyright"">
                    &copy; Copyright <strong><span>Baker</span></strong>. All Rights Reserved
                </div>
                <div class=""credits"">
                    <!-- All the links in the footer should remain intact. -->
                    <!-- You can delete the links only if you purchased the pro version. -->
                    <!-- Licensing information: https://bootstrapmade.com/license/ -->
                    <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/baker-free-onepage-bootstrap-theme/ -->
                    Designed by <a href=""https://bootstrapmade.com/"">BootstrapMade</a>
                </div>
            </div>
            <div class=""social-links text-center text-md-right pt-3 pt-");
                WriteLiteral(@"md-0"">
                <a href=""#"" class=""twitter""><i class=""bx bxl-twitter""></i></a>
                <a href=""#"" class=""facebook""><i class=""bx bxl-facebook""></i></a>
                <a href=""#"" class=""instagram""><i class=""bx bxl-instagram""></i></a>
                <a href=""#"" class=""google-plus""><i class=""bx bxl-skype""></i></a>
                <a href=""#"" class=""linkedin""><i class=""bx bxl-linkedin""></i></a>
            </div>
        </div>
    </footer><!-- End Footer -->

    <a href=""#"" class=""back-to-top""><i class=""bx bx-up-arrow-alt""></i></a>

    <!-- Vendor JS Files -->
    <script src=""/Content/assets/vendor/jquery/jquery.min.js""></script>
    <script src=""/Content/assets/vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""/Content/assets/vendor/jquery.easing/jquery.easing.min.js""></script>
    <script src=""/Content/assets/vendor/php-email-form/validate.js""></script>
    <script src=""/Content/assets/vendor/waypoints/jquery.waypoints.min.js""></script>
    <script ");
                WriteLiteral(@"src=""/Content/assets/vendor/counterup/counterup.min.js""></script>
    <script src=""/Content/assets/vendor/owl.carousel/owl.carousel.min.js""></script>
    <script src=""/Content/assets/vendor/isotope-layout/isotope.pkgd.min.js""></script>
    <script src=""/Content/assets/vendor/venobox/venobox.min.js""></script>

    <!-- Template Main JS File -->
    <script src=""/Content/assets/js/main.js""></script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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

#pragma checksum "C:\Users\franc\source\repos\Orbisgame\Orbisgame\Views\Home\Descuento.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a9cdae026e9c4d56d579b0ddd52635df66224da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Descuento), @"mvc.1.0.view", @"/Views/Home/Descuento.cshtml")]
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
#line 1 "C:\Users\franc\source\repos\Orbisgame\Orbisgame\Views\_ViewImports.cshtml"
using Orbisgame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\franc\source\repos\Orbisgame\Orbisgame\Views\_ViewImports.cshtml"
using Orbisgame.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a9cdae026e9c4d56d579b0ddd52635df66224da", @"/Views/Home/Descuento.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182fe8d8d1edf2a4cad9f63ff969824f182a9b1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Descuento : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Menu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\franc\source\repos\Orbisgame\Orbisgame\Views\Home\Descuento.cshtml"
  
    ViewData["Title"] = "Catalogo";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Titulo de la pestaña-->\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9cdae026e9c4d56d579b0ddd52635df66224da4995", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>Orbis Game</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a9cdae026e9c4d56d579b0ddd52635df66224da5322", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@" <!--ACA invoco al diseño (css) que esta en la clase site.css-->
    <script src=""https://kit.fontawesome.com/b99e675b6e.js""></script>
    <style>
    body {
        color: #000000;
        background-color: #CFD8DC
    }

    .card1 {
        text-transform: uppercase;
        text-align: center;
        color: #ffffff;
        background-color: #000000
    }

    .card2 {
        margin-bottom: 20px;
        padding-bottom: 40px
    }

    .bg-black {
        background-color: #000000
    }

    #summer {
        font-weight: normal;
        font-size: 50px;
        padding-top: 50px;
        margin-bottom: 0;
        transform: scale(1, 1.3);
        color: #FF5252;
        opacity: 0.8
    }

    #sale {
        font-weight: normal;
        font-size: 70px;
        transform: scale(1.2, 1.2);
        letter-spacing: 8px;
        padding-left: 4px;
        color: #FF5252;
        opacity: 0.8
    }

    #saveupto {
        color: #00BFA5;
        letter-spacing");
                WriteLiteral(@": 10px;
        transform: scale(1, 1);
        font-size: 20px;
        margin-top: 40px;
        padding-left: 6px
    }

    #thirty {
        font-size: 70px;
        transform: scale(1.2, 1.5)
    }

    #percent {
        font-weight: normal;
        font-size: 34px;
        margin-bottom: 0;
        padding-left: 10px;
        transform: scale(1.8, 1.6)
    }

    #off {
        font-size: 35px;
        transform: scale(1.2, 1);
        padding-left: 0px
    }

    media (max-width: 768px) {
        #percent

    {
        padding-left: 5px
    }

    #off {
        padding-left: 0px;
        transform: scale(1.1, 1);
        font-size: 30px
    }

    }

    #instore {
        border-top: 1px solid grey;
        border-bottom: 1px solid grey;
        padding-bottom: 4px;
        padding-top: 4px;
        color: grey;
        margin-bottom: 80px;
        padding-left: 20px;
        padding-right: 20px
    }

    .bg-white {
        background-color: ");
                WriteLiteral(@"#ffffff
    }

    .subhead1 {
        text-transform: uppercase;
        font-size: 18px;
        padding-top: 70px
    }

    .subhead2 {
        color: #00BFA5;
        font-weight: normal;
        font-size: 25px;
        padding-top: 30px;
        padding-bottom: 30px
    }

    input.input-box,
    textarea.input-box {
        background-color: #CFD8DC;
        color: #212121;
        font-size: 15px;
        padding: 15px auto 15px auto !important;
        height: 55px !important;
        text-align: center
    }

    input.input-box:focus,
    textarea.input-box:focus {
        color: #212121;
        background-color: #ECEFF1;
        box-shadow: 0 0 1px 1px ##CFD8DC
    }

    .rm-border:focus {
        border-color: inherit;
        -webkit-box-shadow: none;
        box-shadow: none
    }

    form .form-control::-webkit-input-placeholder {
        color: #9E9E9E
    }

    ::-moz-placeholder {
        color: #9E9E9E !important
    }

    input.btn-re");
                WriteLiteral(@"d {
        background-color: #D50000;
        padding-left: 0px;
        padding-right: 0px;
        color: #ffffff;
        font-weight: bold;
        height: 55px;
        opacity: 0.8
    }

    input.btn-red:hover {
        opacity: 1
    }

    .thanks {
        color: #000000 !important;
        text-align: center;
        text-transform: uppercase;
        padding-bottom: 10px
    }

    .thanks:hover {
        color: #000000 !important;
        text-decoration: underline;
        padding-bottom: 10px
    }

    .conditions {
        font-size: 12px;
        color: #546E7A;
        text-align: center
    }
    </style>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9cdae026e9c4d56d579b0ddd52635df66224da11055", async() => {
                WriteLiteral(@"
    <!--ESTA ES LA VISTA PARA EL CATALOGO DE JUEGOS PARA DESCARGAR-->

    <div class=""wrapper"">
        <div class=""sidebar"">
            <h2>Opciones</h2>
            <ul>
                <!--CREO LOS ICONOS DEL MENU DE OPCIONES -->
                <li><a href=""../Home/MainUser""> <i class=""fas fa-home""></i>Home</a></li> <!--fas se relaciona con el fas de la clase site.cc linea 108. alli le aplico eldiseño a todo lo que tenga fas-->
                <li><a href=""../Home/Descargas""> <i class=""fas fa-gamepad""></i>Descargas</a></li> <!-- Lista de juegos descargados-->
                <li><a href=""../Home/Catalogo""> <i class=""fas fa-gamepad""></i>Catalogo de juegos</a></li> <!--Catalogo de juegos para descargar-->
                <li><a href=""../Home/Descuento""> <i class=""fas fa-times""></i>Cupon de Descuento</a></li>
                <li><a href=""../Home/Inicio""> <i class=""fas fa-times""></i>Cerrar Sesion</a></li> <!--Cerrar sesion-->
            </ul>
        </div>
    </div>

    <div class=""con");
                WriteLiteral(@"tainer"">
        <div class=""container"">
            <div class=""container"">
                <div class=""container"">
                    <div class=""container"">
                        <div class=""container"">
                                
                            <div class=""container-fluid mt-5"">
                                <div class=""row justify-content-center"">
                                    <div class=""col-lg-9 px-0"">
                                        <div class=""container-fluid rounded-0 border-0 mt-4"">
                                            <div class=""row"">
                                                <div class=""col-md-5 bg-black"">
                                                    <div class=""card rounded-0 border-0 card1"">
                                                        <div class=""row justify-content-center"">
                                                            <div class=""col-md-12 col-12"">
                                              ");
                WriteLiteral(@"                  <h2 id=""summer"">Summer</h2>
                                                            </div>
                                                            <div class=""col-md-12 col-12"">
                                                                <h2 id=""sale"">Sale</h2>
                                                            </div>
                                                        </div>
                                                        <div class=""row justify-content-center"">
                                                            <div class=""col-md-12 col-12"">
                                                                <h2 id=""saveupto"">Descuento de</h2>
                                                            </div>
                                                        </div>
                                                        <div class=""row justify-content-center"">
                                                            <div class=""col");
                WriteLiteral(@"-11"">
                                                                <div class=""row justify-content-left"">
                                                                    <div class=""col-md-6 col-6 text-right"">
                                                                        <h2 id=""thirty""");
                BeginWriteAttribute("class", " class=\"", 7365, "\"", 7373, 0);
                EndWriteAttribute();
                WriteLiteral(@">30</h2>
                                                                    </div>
                                                                    <div class=""col-1 px-0""></div>
                                                                    <div class=""col-4 text-left"">
                                                                        <div class=""row d-flex"">
                                                                            <p id=""percent"">%</p>
                                                                        </div>
                                                                        <div class=""row d-flex"">
                                                                            <p id=""off"">OFF</p>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                       ");
                WriteLiteral(@"                     </div>
                                                        </div>
                                                        <div class=""row justify-content-center"">
                                                            <p id=""instore"">En juegos Digitales</p>
                                                        </div>
                                                    </div>
                                                </div>
                                                <div class=""col-md-6 bg-white"">
                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a9cdae026e9c4d56d579b0ddd52635df66224da16712", async() => {
                    WriteLiteral(@"
                                                        <div class=""card rounded-0 border-0 card2"">
                                                            <div class=""row justify-content-center"">
                                                                <div class=""col-11"">
                                                                    <h4 class=""subhead1 text-center"">Ingrese su Email para Desbloquear</h4>
                                                                </div>
                                                            </div>
                                                            <div class=""row justify-content-center"">
                                                                <div class=""col-11"">
                                                                    <h3 class=""subhead2 text-center"">A Donde enviamos su 30% off?</h3>
                                                                </div>
                                                        ");
                    WriteLiteral(@"    </div>
                                                            <div class=""row justify-content-center"">
                                                                <div class=""col-md-10 col-11"">
                                                                    <div class=""form-group row"">
                                                                        <div class=""col-md-12""> <input id=""email"" type=""email"" placeholder=""Ingrese su Email "" class=""form-control input-box rm-border""> </div>
                                                                    </div>
                                                                    <div class=""form-group row"">
                                                                        <div class=""col-md-12""> <input type=""submit"" value=""CONSEGUIR MIS $30 OFF"" class=""btn btn-red rm-border btn-block""> </div>
                                                                    </div>
                                                             ");
                    WriteLiteral(@"       <div class=""form-group row justify-content-center mb-0"">
                                                                        <div class=""col-md-12 px-3 mt-4"">
                                                                            <a href=""#"">
                                                                                <p class=""thanks"">No Gracias</p>
                                                                            </a>
                                                                        </div>
                                                                    </div>
                                                                    <div class=""form-group row justify-content-center mb-0"">
                                                                        <div class=""col-md-10 px-3"">
                                                                            <p class=""conditions"">Solo para personas que se registren por primera vez. * $ 10 de descuento en pedidos ");
                    WriteLiteral(@"de $ 25 +, e ingresar su correo electrónico también lo hace elegible para recibir futuros correos electrónicos promocionales.</p>
                                                                        </div>
                                                                    </div>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    ");
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
                WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>               
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>



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
            WriteLiteral("\r\n\r\n\r\n</html>");
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
#pragma checksum "C:\Users\franc\source\repos\Orbisgame\Orbisgame\Views\Home\AltaJuego.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc51b2c28c13a4435f7b0c836ac29362310838b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AltaJuego), @"mvc.1.0.view", @"/Views/Home/AltaJuego.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc51b2c28c13a4435f7b0c836ac29362310838b2", @"/Views/Home/AltaJuego.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182fe8d8d1edf2a4cad9f63ff969824f182a9b1b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_AltaJuego : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Menu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AltaJuego", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\franc\source\repos\Orbisgame\Orbisgame\Views\Home\AltaJuego.cshtml"
  
    ViewData["Title"] = "Catalogo";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <!--Titulo de la pesta??a-->\r\n");
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc51b2c28c13a4435f7b0c836ac29362310838b25656", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>Orbis Game</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cc51b2c28c13a4435f7b0c836ac29362310838b25983", async() => {
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
                WriteLiteral(@" <!--ACA invoco al dise??o (css) que esta en la clase site.css-->
    <script src=""https://kit.fontawesome.com/b99e675b6e.js""></script>
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js""></script>
    <script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
    <style>

    .get-in-touch {
        max-width: 800px;
        margin: 50px auto;
        position: relative;
    }

    .get-in-touch .title {
        text-align: center;
        text-transform: uppercase;
        letter-spacing: 3px;
        font-size: 3.2em;
        line-height: 48px;
        padding-bottom: 48px;
        color: #5543ca;
        background: #5543ca;
        background: -moz-linear-gradient(left,#f4524d 0%,#5543ca 100%) !important;
        background: -webkit-linear-gradient(left,#f4524d 0%,#5543ca 100%) !important;
        background: line");
                WriteLiteral(@"ar-gradient(to right,#f4524d 0%,#5543ca 100%) !important;
        -webkit-background-clip: text !important;
        -webkit-text-fill-color: transparent !important;
    }

    .contact-form .form-field {
        position: relative;
        margin: 32px 0;
    }

    .contact-form .input-text {
        display: block;
        width: 100%;
        height: 36px;
        border-width: 0 0 2px 0;
        border-color: #5543ca;
        font-size: 18px;
        line-height: 26px;
        font-weight: 400;
    }

    .contact-form .input-text:focus {
        outline: none;
    }

    .contact-form .input-text:focus + .label,
    .contact-form .input-text.not-empty + .label {
        -webkit-transform: translateY(-24px);
        transform: translateY(-24px);
    }

    .contact-form .label {
        position: absolute;
        left: 20px;
        bottom: 11px;
        font-size: 18px;
        line-height: 26px;
        font-weight: 400;
        color: #5543ca;
        cursor: tex");
                WriteLiteral(@"t;
        transition: -webkit-transform .2s ease-in-out;
        transition: transform .2s ease-in-out;
        transition: transform .2s ease-in-out, -webkit-transform .2s ease-in-out;
    }

    .contact-form .submit-btn {
        display: inline-block;
        background-color: #000;
        background-image: linear-gradient(125deg,#a72879,#064497);
        color: #fff;
        text-transform: uppercase;
        letter-spacing: 2px;
        font-size: 16px;
        padding: 8px 16px;
        border: none;
        width: 200px;
        cursor: pointer;
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc51b2c28c13a4435f7b0c836ac29362310838b210607", async() => {
                WriteLiteral(@"
    <!--ESTA ES LA VISTA PARA EL CATALOGO DE JUEGOS PARA DESCARGAR-->

    <div class=""wrapper"">
        <div class=""sidebar"">
            <h2><i class=""fas fa-user-secret"">Opciones</i></h2>
            <ul>
                <!--CREO LOS ICONOS DEL MENU DE OPCIONES -->
                <li><a href=""../Home/MainAdmin""> <i class=""fas fa-home""></i>Home</a></li> <!--fas se relaciona con el fas de la clase site.cc linea 108. alli le aplico eldise??o a todo lo que tenga fas-->
                <li><a href=""../Home/AltaJuego""><i class=""fab fa-playstation""></i>Alta de Juegos</a></li> <!-- Lista de juegos descargados-->
                <li><a href=""../Home/UsuariosActivos""><i class=""fas fa-users""></i>Usuarios Activos</a></li> <!--Catalogo de juegos para descargar-->
                <li><a href=""../Home/Inicio""> <i class=""fas fa-times""></i>Cerrar Sesion</a></li> <!--Cerrar sesion-->
            </ul>
        </div>
    </div>

    <div class=""container"">
        <div class=""container"">
            <div c");
                WriteLiteral(@"lass=""container"">
                <div class=""container"">
                    <div class=""container"">
                        <div class=""container"">
                            <div class=""container"">
                                <div class=""container"">
                                    <div class=""full-page"">
                                        <section class=""get-in-touch"">
                                            <h1 class=""title"">Alta de Juego</h1>
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc51b2c28c13a4435f7b0c836ac29362310838b212490", async() => {
                    WriteLiteral(@"
                                                <div class=""form-field col-lg-6"">
                                                    <input id=""name"" name=""Nom_Juego"" class=""input-text js-input"" type=""text"" required>
                                                    <label class=""label"" for=""Nombre"">Nombre</label>
                                                </div>
                                                <div class=""form-field col-lg-6 "">
                                                    <input id=""email"" name=""Categorias"" class=""input-text js-input"" type=""text"" required>
                                                    <label class=""label"" for=""Categoria"">Categoria</label>
                                                </div>
                                                <div class=""form-field col-lg-6 "">
                                                    <input id=""company"" name=""Precio"" class=""input-text js-input"" type=""text"" required>
                                    ");
                    WriteLiteral(@"                <label class=""label"" for=""Precio"">Precio</label>
                                                </div>
                                                <div class=""form-field col-lg-6 "">
                                                    <input id=""phone"" name=""Compatibilidad"" class=""input-text js-input"" type=""text"" required>
                                                    <label class=""label"" for=""Compatibilidad"">Compatibilidad</label>
                                                </div>
                                                <div class=""form-field col-lg-12"">
                                                    <input class=""submit-btn"" type=""submit"" value=""Ingresar"">
                                                </div>
                                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </section>
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
            WriteLiteral("\r\n\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

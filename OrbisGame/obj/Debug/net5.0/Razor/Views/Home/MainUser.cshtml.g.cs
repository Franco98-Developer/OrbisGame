#pragma checksum "C:\Users\franc\source\repos\Orbisgame\Orbisgame\Views\Home\MainUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d7bf66013a9e7bd90433f36719a58599a93010c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MainUser), @"mvc.1.0.view", @"/Views/Home/MainUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d7bf66013a9e7bd90433f36719a58599a93010c", @"/Views/Home/MainUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182fe8d8d1edf2a4cad9f63ff969824f182a9b1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MainUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Menu.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d7bf66013a9e7bd90433f36719a58599a93010c4100", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <title>Orbis Game</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5d7bf66013a9e7bd90433f36719a58599a93010c4427", async() => {
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
                WriteLiteral(" <!--ACA invoco al diseño (css) que esta en la clase site.css-->\r\n    <script src=\"https://kit.fontawesome.com/b99e675b6e.js\"></script>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d7bf66013a9e7bd90433f36719a58599a93010c6452", async() => {
                WriteLiteral(@"
    <!--ESTA ES LA VISTA PARA LOS JUEGOS DESCARGADOS-->

    <div class=""wrapper"">
        <div>
            <div class=""sidebar"">
                <h2>Opciones</h2>
                <ul>
                    <!--CREO LOS ICONOS DEL MENU DE OPCIONES -->
                    <li><a href=""../Home/MainUser""> <i class=""fas fa-home""></i>Home</a></li> <!--fas se relaciona con el fas de la clase site.cc linea 108. alli le aplico eldiseño a todo lo que tenga fas-->
                    <li><a href=""../Home/Descargas""><i class=""fas fa-cloud-download-alt""></i>Descargas</a></li> <!-- Lista de juegos descargados-->
                    <li><a href=""../Home/Catalogo""><i class=""fas fa-bomb""></i>Catalogo de juegos</a></li> <!--Catalogo de juegos para descargar-->
                    <li><a href=""../Home/Descuento""> <i class=""fas fa-tags""></i>Cupon de Descuento</a></li>
                    <li><a href=""../Home/Inicio""> <i class=""fas fa-times""></i>Cerrar Sesion</a></li> <!--Cerrar sesion-->
                </ul>
   ");
                WriteLiteral(@"         </div>
        </div>
    </div>
   
    <div class=""container"">
        <div class=""container"">
            <div class=""container"">
                <div class=""container"">
                    <div class=""container"">
                        <div class=""container"">
                            <div class=""container"">
                                <div class=""container"">
                                    <div class=""container"">
                                        <div class=""container"">
                                            <h1>Bienvenidos a OrbisGame</h1>
                                            <div class=""carousel slide"" id=""main-carousel"" data-ride=""carousel"">
                                                <ol class=""carousel-indicators"">
                                                    <li data-target=""#main-carousel"" data-slide-to=""0"" class=""active""></li>
                                                    <li data-target=""#main-carousel"" data-slide-to=""1""></");
                WriteLiteral(@"li>
                                                    <li data-target=""#main-carousel"" data-slide-to=""2""></li>
                                                    <li data-target=""#main-carousel"" data-slide-to=""3""></li>
                                                </ol><!-- /.carousel-indicators -->

                                                <div class=""carousel-inner"">
                                                    <div class=""carousel-item active"">
                                                        <img class=""d-block img-fluid"" src=""https://sm.ign.com/ign_es/screenshot/default/playstation-pc-steam_qe1u.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 3000, "\"", 3006, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    </div>
                                                    <div class=""carousel-item"">
                                                        <img class=""d-block img-fluid"" src=""https://www.xtrafondos.com/descargar.php?id=2037&resolucion=1920x1200""");
                BeginWriteAttribute("alt", " alt=\"", 3313, "\"", 3319, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                    </div>
                                                    <div class=""carousel-item"">
                                                        <img class=""d-block img-fluid"" src=""https://i.3djuegos.com/juegos/13689/playstation_now/fotos/ficha/playstation_now-4993238.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 3648, "\"", 3654, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    </div>\r\n                                                    <div class=\"carousel-item\">\r\n                                                        <img src=\"https://wallpaperaccess.com/full/17452.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3908, "\"", 3914, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""d-block img-fluid"">
                                                    </div>
                                                </div><!-- /.carousel-inner -->

                                                <a href=""#main-carousel"" class=""carousel-control-prev"" data-slide=""prev"">
                                                    <span class=""carousel-control-prev-icon""></span>
                                                    <span class=""sr-only"" aria-hidden=""true"">Prev</span>
                                                </a>
                                                <a href=""#main-carousel"" class=""carousel-control-next"" data-slide=""next"">
                                                    <span class=""carousel-control-next-icon""></span>
                                                    <span class=""sr-only"" aria-hidden=""true"">Next</span>
                                                </a>
                                            </div><!-- /.carousel -->
           ");
                WriteLiteral(@"                             </div><!-- /.container -->
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

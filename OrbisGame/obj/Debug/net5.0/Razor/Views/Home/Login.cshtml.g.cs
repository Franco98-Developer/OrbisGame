#pragma checksum "C:\Users\franc\source\repos\Orbisgame\Orbisgame\Views\Home\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ca780a866149fcb7addce0ba6e1e42258c0c3fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Login), @"mvc.1.0.view", @"/Views/Home/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ca780a866149fcb7addce0ba6e1e42258c0c3fb", @"/Views/Home/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"182fe8d8d1edf2a4cad9f63ff969824f182a9b1b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Img/play4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Cinque Terre"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("304"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loginform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("signupform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>Ingrese los Datos</h2>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ca780a866149fcb7addce0ba6e1e42258c0c3fb6600", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



        <div class=""container"">
            <div id=""loginbox"" style=""margin-top:50px;"" class=""mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2"">
                <div class=""panel panel-info"">
                    <div class=""panel-heading"">
                        <div class=""panel-title"">Registrese</div>
                        <div style=""float:right; font-size: 80%; position: relative; top:-10px""><a href=""#"">Olvidaste tu Contrase??a?</a></div>
                    </div>

                    <div style=""padding-top:30px"" class=""panel-body"">

                        <div style=""display:none"" id=""login-alert"" class=""alert alert-danger col-sm-12""></div>

                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca780a866149fcb7addce0ba6e1e42258c0c3fb8701", async() => {
                WriteLiteral(@"

                            <div style=""margin-bottom: 25px"" class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-user""></i></span>
                                <input id=""login-username"" type=""text"" class=""form-control"" name=""username""");
                BeginWriteAttribute("value", " value=\"", 1368, "\"", 1376, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Email"">
                            </div>

                            <div style=""margin-bottom: 25px"" class=""input-group"">
                                <span class=""input-group-addon""><i class=""glyphicon glyphicon-lock""></i></span>
                                <input id=""login-password"" type=""password"" class=""form-control"" name=""password"" placeholder=""Contrase??a"">
                            </div>



                            <div class=""input-group"">
                                <div class=""checkbox"">
                                    <label>
                                        <input id=""login-remember"" type=""checkbox"" name=""remember"" value=""1""> Recordarme
                                    </label>
                                </div>
                            </div>


                            <div style=""margin-top:10px"" class=""form-group"">
                                <!-- Button -->

                                <div class=""col-sm-12");
                WriteLiteral(@" controls"">
                                    <input type=""submit"" value=""Enviar"" />
                                    <a id=""btn-login"" href=""#"" class=""btn btn-success"">Ingresar  </a>
                                    <a id=""btn-fblogin"" href=""https://es-facebook.com/""la. class=""btn btn-primary"">Ingresar vi aFacebook</a>

                                </div>
                            </div>


                            <div class=""form-group"">
                                <div class=""col-md-12 control"">
                                    <div style=""border-top: 1px solid#888; padding-top:15px; font-size:85%"">
                                       No Tengo Cuenta!
                                        <a href=""#"" onClick=""$('#loginbox').hide(); $('#signupbox').show()"">
                                            Registrate
                                        </a>
                                    </div>
                                </div>
                          ");
                WriteLiteral("  </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
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
            <div id=""signupbox"" style=""display:none; margin-top:50px"" class=""mainbox col-md-6 col-md-offset-3 col-sm-8 col-sm-offset-2"">
                <div class=""panel panel-info"">
                    <div class=""panel-heading"">
                        <div class=""panel-title"">Ingrese</div>
                        <div style=""float:right; font-size: 85%; position: relative; top:-10px""><a id=""signinlink"" href=""#"" onclick=""$('#signupbox').hide(); $('#loginbox').show()"">Sign In</a></div>
                    </div>
                    <div class=""panel-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ca780a866149fcb7addce0ba6e1e42258c0c3fb13570", async() => {
                WriteLiteral(@"

                            <div id=""signupalert"" style=""display:none"" class=""alert alert-danger"">
                                <p>Error:</p>
                                <span></span>
                            </div>



                            <div class=""form-group"">
                                <label for=""email"" class=""col-md-3 control-label"">Email</label>
                                <div class=""col-md-9"">
                                    <input type=""text"" class=""form-control"" name=""email"" placeholder=""Direccion de Email "">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label for=""firstname"" class=""col-md-3 control-label"">Nombre</label>
                                <div class=""col-md-9"">
                                    <input type=""text"" class=""form-control"" name=""firstname"" placeholder=""NOMBRE"">
                                </div>
      ");
                WriteLiteral(@"                      </div>
                            <div class=""form-group"">
                                <label for=""lastname"" class=""col-md-3 control-label"">Apellido</label>
                                <div class=""col-md-9"">
                                    <input type=""text"" class=""form-control"" name=""lastname"" placeholder=""APELLIDO"">
                                </div>
                            </div>
                            <div class=""form-group"">
                                <label for=""password"" class=""col-md-3 control-label"">Contrase??a</label>
                                <div class=""col-md-9"">
                                    <input type=""password"" class=""form-control"" name=""passwd"" placeholder=""CONTRASE??A"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label for=""icode"" class=""col-md-3 control-label"">Codigo de Invitacion</label>
        ");
                WriteLiteral("                        <div class=\"col-md-9\">\r\n                                    <input type=\"text\" class=\"form-control\" name=\"icode\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 6384, "\"", 6398, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <!-- Button -->
                                <div class=""col-md-offset-3 col-md-9"">
                                    <button id=""btn-signup"" type=""button"" class=""btn btn-info""><i class=""icon-hand-right""></i> &nbsp Ingrese</button>
                                    <span style=""margin-left:8px;"">or</span>
                                </div>
                            </div>

                            <div style=""border-top: 1px solid #999; padding-top:20px"" class=""form-group"">

                                <div class=""col-md-offset-3 col-md-9"">
                                    <button id=""btn-fbsignup"" type=""button"" class=""btn btn-primary""><i class=""icon-facebook""></i> ?? Ingrese con Facebook</button>
                                </div>

                            </div>



                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n");
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

#pragma checksum "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "978234bc8965346c15947fe025f835c16bdc1252"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profil_Index), @"mvc.1.0.view", @"/Views/Profil/Index.cshtml")]
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
#line 1 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\_ViewImports.cshtml"
using SocialMedia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"978234bc8965346c15947fe025f835c16bdc1252", @"/Views/Profil/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3c1c4110c97850527e62d53d9f9c1592b4add2", @"/Views/_ViewImports.cshtml")]
    public class Views_Profil_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SocialMedia.ViewModels.Profil.ProfilViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Profil", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n\r\n    <div class=\"container\">\r\n        <nav class=\"navbar navbar-light bg-light\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "978234bc8965346c15947fe025f835c16bdc12525835", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "978234bc8965346c15947fe025f835c16bdc12526109", async() => {
                    WriteLiteral("Галерия");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <a class=\"btn btn-sm btn-outline-secondary\" >Съобщение</a>\r\n                <a class=\"btn btn-sm btn-outline-secondary\">Чат</a>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </nav>
        <div class=""row"">
            <div class=""col"">
                <img src=""https://pbs.twimg.com/media/EnNVaoOUUAA8V5V.jpg"" alt=""..."" width=""500"">

            </div>

            <div class=""col"">
                
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "978234bc8965346c15947fe025f835c16bdc12529215", async() => {
                WriteLiteral("Редактирай Профила");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                                                                                                        WriteLiteral(Model.ApplicationUserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                <table class=\"table table-striped\" style=\"width: 80%\">\r\n\r\n                    <thead>\r\n                        <tr>\r\n\r\n                            <th scope=\"col\"><H2>");
#nullable restore
#line 28 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                                           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</H2></th>\r\n");
            WriteLiteral("                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n                        <tr>\r\n                            <th scope=\"row\">Пол</th>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Харесва</th>\r\n                            <td>");
#nullable restore
#line 42 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Години</th>\r\n                            <td>");
#nullable restore
#line 47 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">От</th>\r\n                            <td>");
#nullable restore
#line 52 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.From);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Височина</th>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Кг</th>\r\n                            <td>");
#nullable restore
#line 62 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <th scope=\"row\">Цвят на очите</th>\r\n                            <td>");
#nullable restore
#line 68 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.EyesColor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Цвят на косата</th>\r\n                            <td>");
#nullable restore
#line 73 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.EyesColor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Статус</th>\r\n                            <td>");
#nullable restore
#line 78 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Търси</th>\r\n                            <td>");
#nullable restore
#line 83 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.LookingFor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                        </tr>
                    </tbody>

                </table>
            </div>
        </div>
        <div class=""row"">
            <div class=""col"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <th scope=""row"">Цигари</th>
                            <td>");
#nullable restore
#line 101 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.Cigarettes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Алкохол</th>\r\n                            <td>");
#nullable restore
#line 106 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.Alcohol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Дата на раждане</th>\r\n                            <td>");
#nullable restore
#line 111 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                           Write(Model.DateBirthday);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                        </tr>
                    </tbody>
                </table>
            </div>
            <div class=""col-5"">

                <div class=""card"">
                    <div class=""card-header"" >
                        Описание
                    </div>
                    <div class=""card-body"">
                        <p class=""card-text"" >");
#nullable restore
#line 124 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\Index.cshtml"
                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SocialMedia.ViewModels.Profil.ProfilViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

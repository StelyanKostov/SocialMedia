#pragma checksum "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2cbe41ee08c9de3fa7f0ec3f06974e4e076d2cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profil_OpenProfil), @"mvc.1.0.view", @"/Views/Profil/OpenProfil.cshtml")]
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
#nullable restore
#line 1 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
using SocialMedia.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2cbe41ee08c9de3fa7f0ec3f06974e4e076d2cc", @"/Views/Profil/OpenProfil.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3c1c4110c97850527e62d53d9f9c1592b4add2", @"/Views/_ViewImports.cshtml")]
    public class Views_Profil_OpenProfil : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SocialMedia.ViewModels.Profil.ProfilViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Gallery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Messages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendMessages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
  
    var image = Model.Images.Where(x => x.ProfilImage).Select(x => new
    {
        Id = x.Id,
        Extension = x.Extension
    }).FirstOrDefault();


#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n\r\n    <div class=\"container\">\r\n        <nav class=\"navbar navbar-light bg-light\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2cbe41ee08c9de3fa7f0ec3f06974e4e076d2cc8117", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2cbe41ee08c9de3fa7f0ec3f06974e4e076d2cc8391", async() => {
                    WriteLiteral("Галерия");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                                                                 WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 20 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                 if (SignInManager.UserManager.GetUserId(this.User) != Model.ApplicationUserId)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2cbe41ee08c9de3fa7f0ec3f06974e4e076d2cc11390", async() => {
                    WriteLiteral("Съобщение");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                                                                                                                      WriteLiteral(Model.id);

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
                WriteLiteral("\r\n                    <a class=\"btn btn-sm btn-outline-secondary\">Чат</a>\r\n");
#nullable restore
#line 24 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </nav>\r\n        <div class=\"row\">\r\n            <div class=\"col\">\r\n");
#nullable restore
#line 29 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                 if (Model.Images.Count == 0 || image == null)
                {

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c2cbe41ee08c9de3fa7f0ec3f06974e4e076d2cc15830", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1252, "~/images/ProfilImage/", 1252, 21, true);
#nullable restore
#line 35 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
AddHtmlAttributeValue("", 1273, Model.UserName, 1273, 15, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1288, "/", 1288, 1, true);
#nullable restore
#line 35 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
AddHtmlAttributeValue("", 1289, image.Id, 1289, 9, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 1298, ".", 1298, 1, true);
#nullable restore
#line 35 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
AddHtmlAttributeValue("", 1299, image.Extension, 1299, 16, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 36 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n\r\n            <div class=\"col\">\r\n\r\n\r\n                <table class=\"table table-striped\" style=\"width: 80%\">\r\n\r\n                    <thead>\r\n                        <tr>\r\n\r\n                            <th scope=\"col\"><H2>");
#nullable restore
#line 49 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                                           Write(Model.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</H2></th>\r\n\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n                        <tr>\r\n                            <th scope=\"row\">Пол</th>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Харесва</th>\r\n                            <td>");
#nullable restore
#line 61 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.Likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Години</th>\r\n                            <td>");
#nullable restore
#line 66 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">От</th>\r\n                            <td>");
#nullable restore
#line 71 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.From);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Височина</th>\r\n                            <td>");
#nullable restore
#line 76 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Кг</th>\r\n                            <td>");
#nullable restore
#line 81 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n\r\n                        <tr>\r\n                            <th scope=\"row\">Цвят на очите</th>\r\n                            <td>");
#nullable restore
#line 87 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.EyesColor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Цвят на косата</th>\r\n                            <td>");
#nullable restore
#line 92 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.EyesColor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Статус</th>\r\n                            <td>");
#nullable restore
#line 97 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Търси</th>\r\n                            <td>");
#nullable restore
#line 102 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
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
#line 120 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.Cigarettes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Алкохол</th>\r\n                            <td>");
#nullable restore
#line 125 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                           Write(Model.Alcohol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                        </tr>\r\n                        <tr>\r\n                            <th scope=\"row\">Дата на раждане</th>\r\n                            <td>");
#nullable restore
#line 130 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
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
                    <div class=""card-header"">
                        Описание
                    </div>
                    <div class=""card-body"">
                        <p class=""card-text"">");
#nullable restore
#line 143 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Profil\OpenProfil.cshtml"
                                        Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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

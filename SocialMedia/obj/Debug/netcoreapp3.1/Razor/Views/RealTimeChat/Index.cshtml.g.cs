#pragma checksum "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aea3a06f4d333c702660692033608d31e6b302bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RealTimeChat_Index), @"mvc.1.0.view", @"/Views/RealTimeChat/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aea3a06f4d333c702660692033608d31e6b302bd", @"/Views/RealTimeChat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3c1c4110c97850527e62d53d9f9c1592b4add2", @"/Views/_ViewImports.cshtml")]
    public class Views_RealTimeChat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia.ViewModels.Chat.RealTimeChatViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
   this.ViewBag.Title = "Chat"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 5 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
Write(this.ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
 foreach (var item in Model)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container border\">\r\n\r\n        <h3");
            BeginWriteAttribute("class", " class=\"", 225, "\"", 257, 1);
#nullable restore
#line 15 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
WriteAttributeValue("", 233, item.WithProfilUserName, 233, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
                                        Write(item.WithProfilUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n        <input type=\"hidden\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 332, "\"", 358, 1);
#nullable restore
#line 17 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
WriteAttributeValue("", 340, item.WithProfilId, 340, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""profilId"" />
        <div id=""message-holder"" class=""mt-3 d-flex justify-content-start"">
            <h4>Message</h4>
            <input class=""w-75 ml-4 pl-3 messageInput"" type=""text"" placeholder=""Message..."" />
            <button class=""ml-4 btn btn-dark btn-lg sendButton"">Send</button>
        </div>
        <hr style=""height: 5px;"" class=""bg-dark"" />
        <div class=""messagesList"" style=""font-size: 28px;""");
            BeginWriteAttribute("id", " id=\"", 790, "\"", 819, 1);
#nullable restore
#line 24 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
WriteAttributeValue("", 795, item.WithProfilUserName, 795, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 25 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
             foreach (var item2 in item.Messages)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>");
#nullable restore
#line 28 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
                Write(item2.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 29 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 32 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\RealTimeChat\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        var connection =
            new signalR.HubConnectionBuilder()
                .withUrl(""/chatter"")
                .build();

        connection.on(""NewMessage"",
            function (message) {
                var chatInfo = `<div>[${message.user}] ${escapeHtml(message.text)}</div>`;

                

                $(`#${message.user}`).append(chatInfo);
            });

        $("".sendButton"").click(function (event) {


            var message = event.currentTarget.parentElement.parentElement.getElementsByClassName('messageInput')[0].value;
            var recipientProfilId = event.currentTarget.parentElement.parentElement.getElementsByClassName('profilId')[0].value;

            console.log(recipientProfilId)
            //todoo
            var chatInfo = `<div>[me] ${escapeHtml(message)}</div>`;
            let element = event.currentTarget.parentElement.parentElement.getElementsByClassName('messagesList')[0];

            let divElement = document.cr");
                WriteLiteral(@"eateElement(""div"");
            divElement.innerHTML = `[me] ${escapeHtml(message)}`
            element.appendChild(divElement);


            var data = message + '<>=!' + recipientProfilId;
            connection.invoke(""SendToOneProfil"", data);
            $("".messageInput"").val("""");
        });

        connection.start().catch(function (err) {
            return console.error(err.toString());
        });

        function escapeHtml(unsafe) {
            return unsafe
                .replace(/&/g, ""&amp;"")
                .replace(/</g, ""&lt;"")
                .replace(/>/g, ""&gt;"")
                .replace(/""/g, ""&quot;"")
                .replace(/'/g, ""&#039;"");
        }</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia.ViewModels.Chat.RealTimeChatViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

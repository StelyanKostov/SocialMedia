#pragma checksum "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71c5bcf1d97c2df2f66ba25a8dd4349c0a5c082c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_RealTimeChatPartial), @"mvc.1.0.view", @"/Views/Shared/RealTimeChatPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c5bcf1d97c2df2f66ba25a8dd4349c0a5c082c", @"/Views/Shared/RealTimeChatPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3c1c4110c97850527e62d53d9f9c1592b4add2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_RealTimeChatPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia.ViewModels.Chat.RealTimeChatViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<style>
    .under {
        position: absolute;
        bottom: 200px;
        right: 200px;
    }

    .containerr {
        position: fixed;
        bottom: 0;
        right: 0;
        /*pointer-events: none;*/
    }

    .chat {
        border: 1px solid #999;
        display: inline-block;
        vertical-align: bottom;
        position: relative;
        margin: 0 5px;
        pointer-events: auto;
        background: #fff;
        height: 350px;
        width: 400px;
        border: 1px solid #ACD8F0;
        overflow-x: auto;
        white-space: nowrap;
        position: relative;
        bottom: 0;
    }

    .title {
        padding: 0.5em;
        background-color: royalblue;
        color: white;
    }

    .text {
        padding: 10px;
        overflow: auto;
        bottom: 0;
        max-height: 280px;
        position: relative;
        width: 100%;
    }

    .chatbox {
        bottom: 0;
        position: fixed;
    }

    .messagesLis");
            WriteLiteral("t {\r\n    }\r\n</style>\r\n\r\n\r\n");
#nullable restore
#line 62 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
 if (Model != null)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"containerr\">\r\n\r\n");
#nullable restore
#line 68 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
         foreach (var item in Model.Where(x => !x.IsDeleted))
        {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <label class=\"popUpChat btn btn-primary\">\r\n                <span class=\"badge\">");
#nullable restore
#line 73 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                               Write(item.Messages.Where(x => x.Sender == item.WithProfilUserName).Count(x => !x.Seen));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                ");
#nullable restore
#line 74 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
           Write(item.WithProfilUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n            <div class=\"chat\" style=\"display:none\">\r\n                <input type=\"hidden\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 1674, "\"", 1690, 1);
#nullable restore
#line 77 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
WriteAttributeValue("", 1682, item.Id, 1682, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"RouteChatId\" />\r\n\r\n                <div class=\"title \">");
#nullable restore
#line 79 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                               Write(item.WithProfilUserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"far fa-trash-alt removeIcon\" style=\"margin-left:2em\"></i></div>\r\n                <div class=\"text messagesList\"");
            BeginWriteAttribute("id", " id=\"", 1900, "\"", 1929, 1);
#nullable restore
#line 80 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
WriteAttributeValue("", 1905, item.WithProfilUserName, 1905, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 82 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                     foreach (var item2 in item.Messages)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                         if (item.WithProfilUserName == item2.Sender)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <blockquote class=\"blockquote text-right\">\r\n                                <p class=\"mb-0\" style=\"font-size: 100%;\">");
#nullable restore
#line 88 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                                                                    Write(item2.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <footer class=\"blockquote-footer\" style=\"font-size: 50%;\"> ");
#nullable restore
#line 89 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                                                                                      Write(item2.CreateOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</footer>\r\n                            </blockquote>\r\n");
#nullable restore
#line 91 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <blockquote class=\"blockquote text-left\">\r\n                                <p class=\"mb-0\" style=\"font-size: 100%;\">");
#nullable restore
#line 95 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                                                                                                  Write(item2.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <footer class=\"blockquote-footer\" style=\"font-size: 50%;\"> ");
#nullable restore
#line 96 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                                                                                      Write(item2.CreateOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</footer>\r\n                            </blockquote>\r\n");
#nullable restore
#line 98 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
                                  

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <div class=\"chatbox\">\r\n                    <nav>\r\n                        <div class=\"input-group-append\">\r\n                            <input type=\"hidden\" name=\"name\"");
            BeginWriteAttribute("value", " value=\"", 3290, "\"", 3316, 1);
#nullable restore
#line 110 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
WriteAttributeValue("", 3298, item.WithProfilId, 3298, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""profilId"" />
                            <input type=""text"" class=""messageInput form-control"" />

                            <button class=""sendButton btn btn-primary"">Send</button>
                        </div>

                    </nav>

                </div>
            </div>
");
#nullable restore
#line 120 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 124 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Views\Shared\RealTimeChatPartial.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>

    let element = document.querySelectorAll('.removeIcon').forEach(x => x.addEventListener('click', function (e) {


        e.currentTarget.parentElement.parentElement.previousSibling.previousSibling.remove();


        var routeId = e.currentTarget.parentElement.parentElement.getElementsByClassName('RouteChatId')[0].value;

        fetch('FeatureMessages/DeltedRouteChat', {
            method: 'POST',
            headers: {
                'Accept': 'application/json; charset=utf-8',
                'Content-Type': 'application/json;charset=UTF-8'
            },
            body: JSON.stringify(routeId)


        })
            .then(x => x.json())
            .then(x => console.log(x))

        console.log(routeId)

        e.currentTarget.parentElement.parentElement.remove()

    }))
    /* window.scroll(0, 10000)*/

    /* eee.scroll(0, 1999)*/


</script>


<script>
    let elements = document.querySelectorAll('.popUpChat').forEach(x => x.addEventListener");
            WriteLiteral(@"('click', function (e) {



        let divChat = e.currentTarget.nextSibling.nextSibling;
        divChat.style.display = """";

        var id = divChat.getElementsByClassName('profilId')[0].value;
        console.log(id)
        fetch(`/RealTimeChat/SeenMessages?id2=${id}`,
            {
                method: 'GET',
                headers: {
                    'Accept': 'application/json; charset=utf-8',
                    'Content-Type': 'application/json;charset=UTF-8'
                },
                /*body: JSON.stringify(id)*/
            })
            .then(x => x.json())
            .then(x => {


            })

        e.currentTarget.getElementsByClassName('badge')[0].innerHTML = 0;


        var mlForScroll = divChat.getElementsByClassName('messagesList')[0];

        mlForScroll.scrollTop = mlForScroll.scrollHeight;

        let labelPopUp = e.currentTarget;
        labelPopUp.style.display = ""none"";

        divChat.getElementsByClassName('title')[0].add");
            WriteLiteral("EventListener(\'click\', function (e) {\r\n\r\n\r\n            e.currentTarget.parentElement.style.display = \'none\';\r\n\r\n            labelPopUp.style.display = \'\';\r\n        })\r\n\r\n    }));\r\n\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71c5bcf1d97c2df2f66ba25a8dd4349c0a5c082c14256", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    var connection = new signalR.HubConnectionBuilder()
        .withUrl(""/chatter"")
        .build();


    connection.on(""NewMessage"",
        function (message) {
            //var chatInfo = `<p>[${message.user}] ${escapeHtml(message.text)}</p>`;
            //$(`#${message.user}`).append(chatInfo);

            let blockquoteElement = document.createElement(""blockquote"");
            blockquoteElement.classList.add(""blockquote"");
            blockquoteElement.classList.add(""text-right"");
            blockquoteElement.innerHTML = `<p class=""mb-0"" style=""font-size: 100%;"">${escapeHtml(message.text)}</p>
                                <footer class=""blockquote-footer"" style=""font-size: 50%;"">${new Date().toLocaleString()}</footer>`;
            $(`#${message.user}`).append(blockquoteElement);



            let element = document.getElementById(message.user);
            console.log();
            let dataBadge = element.parentElement.previousSibling.previousSibling.getElem");
            WriteLiteral(@"entsByClassName(""badge"")[0];

            console.log(dataBadge);
            let valueBadge = parseInt(dataBadge.innerHTML) + 1;
            console.log(valueBadge);

            dataBadge.innerHTML = valueBadge;

            console.log(dataBadge);

            element.scrollTop = element.scrollHeight;



        });


    document.querySelectorAll('.sendButton').forEach(x => x.addEventListener('click', function (event) {

        var message = event.currentTarget.parentElement.getElementsByClassName('messageInput')[0].value;

        if (message === '') {
            return;
        }

        var recipientProfilId = event.currentTarget.parentElement.getElementsByClassName('profilId')[0].value;

        //todoo
        let elementMessagesList = event.currentTarget.parentElement.parentElement.parentElement.parentElement.getElementsByClassName('messagesList')[0];


        //let pElement = document.createElement(""p"");
        //pElement.innerHTML = `[me] ${escapeHtml(message)}");
            WriteLiteral(@"`
        //elementMessagesList.appendChild(pElement);

        let blockquoteElement = document.createElement(""blockquote"");
        blockquoteElement.classList.add(""blockquote"");
        blockquoteElement.classList.add(""text-left"");
        blockquoteElement.innerHTML = `<p class=""mb-0"" style=""font-size: 100%;"">${escapeHtml(message)}</p>
                                <footer class=""blockquote-footer"" style=""font-size: 50%;"">${new Date().toLocaleString()}</footer>`;
        elementMessagesList.appendChild(blockquoteElement);



        var data = message + '<>=!' + recipientProfilId;
        connection.invoke(""SendToOneProfil"", data);
        $("".messageInput"").val("""");

        elementMessagesList.scrollTop = elementMessagesList.scrollHeight;


");
            WriteLiteral(@"
    }));

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
    }
</script>


");
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

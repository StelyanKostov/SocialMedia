#pragma checksum "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\Admin\MsgContactForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae04a3ac41e79bde258ada3547c40f46838d0e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administration_Views_Admin_MsgContactForm), @"mvc.1.0.view", @"/Areas/Administration/Views/Admin/MsgContactForm.cshtml")]
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
#line 1 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\_ViewImports.cshtml"
using SocialMedia;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\_ViewImports.cshtml"
using SocialMedia.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae04a3ac41e79bde258ada3547c40f46838d0e62", @"/Areas/Administration/Views/Admin/MsgContactForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb3c1c4110c97850527e62d53d9f9c1592b4add2", @"/Areas/Administration/Views/_ViewImports.cshtml")]
    public class Areas_Administration_Views_Admin_MsgContactForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SocialMedia.ViewModels.Contacts.ContactsInputModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\Admin\MsgContactForm.cshtml"
  
    this.ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>

    div.contact-div {
        margin-bottom: 50px;
        display: block;
        /*margin: 20px;*/
        border-radius: 12px;
        border: 1px solid lightblue;
        border-radius: 4px;
        padding:0px;
    }
</style>

");
#nullable restore
#line 19 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\Admin\MsgContactForm.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container contact-div\">\r\n        <h2>");
#nullable restore
#line 22 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\Admin\MsgContactForm.cshtml"
       Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h3>");
#nullable restore
#line 23 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\Admin\MsgContactForm.cshtml"
       Write(item.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p>");
#nullable restore
#line 24 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\Admin\MsgContactForm.cshtml"
      Write(item.Messages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n        <span>");
#nullable restore
#line 26 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\Admin\MsgContactForm.cshtml"
         Write(item.SentOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\kosto\source\repos\SocialMedia\SocialMedia\Areas\Administration\Views\Admin\MsgContactForm.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SocialMedia.ViewModels.Contacts.ContactsInputModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

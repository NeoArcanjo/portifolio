#pragma checksum "C:\Users\neo_a\OneDrive\Documentos\Dotnet\Views\Home\Application.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a06cb0137d1b2e5c4bc8a7bb08af478e2fe3faf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Application), @"mvc.1.0.view", @"/Views/Home/Application.cshtml")]
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
#line 1 "C:\Users\neo_a\OneDrive\Documentos\Dotnet\Views\_ViewImports.cshtml"
using Dotnet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\neo_a\OneDrive\Documentos\Dotnet\Views\_ViewImports.cshtml"
using Dotnet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a06cb0137d1b2e5c4bc8a7bb08af478e2fe3faf7", @"/Views/Home/Application.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e28dfff7a82c3018e957afc6fd87e7b334de3883", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Application : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a06cb0137d1b2e5c4bc8a7bb08af478e2fe3faf73224", async() => {
                WriteLiteral(@"
    <title>Chat</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css""
        integrity=""sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.5.0/css/all.css""
        integrity=""sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU"" crossorigin=""anonymous"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js""></script>
    <link rel=""stylesheet"" type=""text/css""
        href=""https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css"">
    <script type=""text/javascript""
        src=""https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.js""></script>
    <link rel=""stylesheet"" type=""text/css"" href=""css/all.css"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a06cb0137d1b2e5c4bc8a7bb08af478e2fe3faf75182", async() => {
                WriteLiteral(@"
    <div class=""msg_box"" style=""right: 400px;"" rel=""skp"">
        <div class=""msg_head card-header"">
            <div><i style=""position: absolute;""></i></div>
            <span class=""img_cont"">
                <img src=""https://i.pinimg.com/originals/bc/4c/59/bc4c59e9d6d9f03153bd9a197a2384ba.jpg""
                    class=""rounded-circle user_img"">
                <span class=""online_icon""></span></span>
            <span class=""person-name user_info"">Chat com Kratos</span>
            <span><i class=""fas fa-video""></i></span>
            <span><i class=""fas fa-phone""></i></span>
            <span id=""action_menu_btn""><i class=""fas fa-ellipsis-v""></i></span>
            <span id=count class=""alert-msg"">0</span>
        </div>
        <div class=""msg_wrap"">
            <div id=""main"" class=""message-content msg_card_body"">
                <div class=""msg_push"">
                </div>
            </div>
            <div id=footer class=""card-footer"">
                <div class=""input-group");
                WriteLiteral("\">\r\n                    <div class=\"input-group-append\">\r\n                        <span class=\"input-group-text attach_btn\"><i class=\"fas fa-paperclip\"></i></span>\r\n                    </div>\r\n                    <textarea id=\"message\"");
                BeginWriteAttribute("name", " name=\"", 2266, "\"", 2273, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control type_msg""
                        placeholder=""Digite sua mensagem..""></textarea>
                    <div class=""input-group-append"">
                        <span type=""submit"" value=""send"" id=""button"" class=""input-group-text send_btn""><i
                                class=""fas fa-location-arrow""></i></span>
                    </div>
                </div>
            </div>
        </div>
	</div>
	<script type=""application/javascript"" defer=""defer"" src=""js/application.js""></script>
	<script type=""text/javascript"" src=""js/wrap.js""></script>
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
            WriteLiteral("\r\n\r\n</html>\r\n");
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

#pragma checksum "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbdf293f7ab728aa928abbbb47d43123e40e105e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Profile), @"mvc.1.0.view", @"/Views/Profile/Profile.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Profile/Profile.cshtml", typeof(AspNetCore.Views_Profile_Profile))]
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
#line 1 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\_ViewImports.cshtml"
using AutoInsuranceForum;

#line default
#line hidden
#line 2 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\_ViewImports.cshtml"
using AutoInsuranceForum.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbdf293f7ab728aa928abbbb47d43123e40e105e", @"/Views/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9176ec390a22ed95d465698cfcc774ad121fbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProfileViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/profile/profile.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Themes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark my-btn-create-theme"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(33, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cbdf293f7ab728aa928abbbb47d43123e40e105e5403", async() => {
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
            EndContext();
            BeginContext(91, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
  
    ViewData["Title"] = "Themes";

#line default
#line hidden
            BeginContext(137, 120, true);
            WriteLiteral("\r\n<div class=\"main\">\r\n    <div class=\"block\">\r\n        <div class=\"container\">\r\n            <div class=\"my-container\">\r\n");
            EndContext();
#line 13 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                 foreach (var user in Model)
                {

#line default
#line hidden
            BeginContext(322, 76, true);
            WriteLiteral("                    <div class=\"user-profile\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 398, "\"", 413, 1);
#line 16 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
WriteAttributeValue("", 404, user.Img, 404, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(414, 168, true);
            WriteLiteral(" alt=\"User\" class=\"mr-3 mt-2 rounded-circle\">\r\n                    </div>\r\n                    <div class=\"user-profile-void\">\r\n                        <p>Логин: <span>");
            EndContext();
            BeginContext(583, 10, false);
#line 19 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                                   Write(user.Login);

#line default
#line hidden
            EndContext();
            BeginContext(593, 53, true);
            WriteLiteral("</span></p>\r\n                        <p>Email: <span>");
            EndContext();
            BeginContext(647, 10, false);
#line 20 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                                   Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(657, 109, true);
            WriteLiteral("</span></p>\r\n                        <p>Никнейм: <a href=\"profile.php\" style=\"color: red\" title=\"role\"><span>");
            EndContext();
            BeginContext(767, 13, false);
#line 21 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                                                                                           Write(user.Nickname);

#line default
#line hidden
            EndContext();
            BeginContext(780, 58, true);
            WriteLiteral("</span></a></p>\r\n                        <p>Страна: <span>");
            EndContext();
            BeginContext(839, 12, false);
#line 22 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                                    Write(user.Country);

#line default
#line hidden
            EndContext();
            BeginContext(851, 53, true);
            WriteLiteral("</span></p>\r\n                        <p>Город: <span>");
            EndContext();
            BeginContext(905, 9, false);
#line 23 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                                   Write(user.Ciry);

#line default
#line hidden
            EndContext();
            BeginContext(914, 64, true);
            WriteLiteral("</span></p>\r\n                        <p>Дата регистрации: <span>");
            EndContext();
            BeginContext(979, 12, false);
#line 24 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                                              Write(user.RegDate);

#line default
#line hidden
            EndContext();
            BeginContext(991, 67, true);
            WriteLiteral("</span></p>\r\n                        <p>Кол-во созданых тем: <span>");
            EndContext();
            BeginContext(1059, 10, false);
#line 25 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                                                 Write(user.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1069, 41, true);
            WriteLiteral("</span></p>\r\n                    </div>\r\n");
            EndContext();
#line 27 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Profile\Profile.cshtml"
                }

#line default
#line hidden
            BeginContext(1129, 44, true);
            WriteLiteral("            </div>\r\n        </div>\r\n        ");
            EndContext();
            BeginContext(1173, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbdf293f7ab728aa928abbbb47d43123e40e105e11420", async() => {
                BeginContext(1273, 12, true);
                WriteLiteral("Создать тему");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1289, 129, true);
            WriteLiteral("\r\n        <button type=\"button\" class=\"btn btn-dark btn-lg btn-block redact\">Редактировать профиль</button>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProfileViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3975713dcfa86b0c58e20da396e7a823d1a3bb7f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Themes_Theme), @"mvc.1.0.view", @"/Views/Themes/Theme.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Themes/Theme.cshtml", typeof(AspNetCore.Views_Themes_Theme))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3975713dcfa86b0c58e20da396e7a823d1a3bb7f", @"/Views/Themes/Theme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9176ec390a22ed95d465698cfcc774ad121fbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Themes_Theme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ThemesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/themes/theme/theme.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(26, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3975713dcfa86b0c58e20da396e7a823d1a3bb7f4893", async() => {
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
            BeginContext(87, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
  
    ViewData["Title"] = "Themes";

#line default
#line hidden
            BeginContext(133, 240, true);
            WriteLiteral("\r\n<div class=\"main\">\r\n    <div class=\"block\">\r\n        <div class=\"my-container\">\r\n            <div class=\"flex-my-container\">\r\n                <div class=\"user\">\r\n                    <div class=\"user-profile\">\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 373, "\"", 389, 1);
#line 15 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
WriteAttributeValue("", 379, Model.img, 379, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(390, 181, true);
            WriteLiteral(" alt=\"User\" class=\"mr-2 mt-2 rounded-circle\" style=\"width:80px; height: 80px;\">\r\n                    </div>\r\n                    <span><a href=\"#\" style=\"color: white\" title=\"роль\">");
            EndContext();
            BeginContext(572, 12, false);
#line 17 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                                                                   Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(584, 100, true);
            WriteLiteral("</a></span>\r\n                </div>\r\n                <div class=\"theme\">\r\n                    <span>");
            EndContext();
            BeginContext(685, 21, false);
#line 20 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                     Write(Model.CreateThemeDate);

#line default
#line hidden
            EndContext();
            BeginContext(706, 243, true);
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <div class=\"theme-text\">\r\n                <div class=\"theme-text-name\">\r\n                    <div class=\"backlight\"><span>Тема:</span></div>\r\n                    <div class=\"me\">");
            EndContext();
            BeginContext(950, 15, false);
#line 26 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                               Write(Model.NameTheme);

#line default
#line hidden
            EndContext();
            BeginContext(965, 222, true);
            WriteLiteral("</div>\r\n                </div>\r\n                <div class=\"theme-text-area\">\r\n                    <div class=\"backlight\"><span>Текст:</span></div>\r\n                    <div class=\"theme-content\">\r\n                        ");
            EndContext();
            BeginContext(1188, 15, false);
#line 31 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                   Write(Model.TextTheme);

#line default
#line hidden
            EndContext();
            BeginContext(1203, 283, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""block"">
        <h3>Комментарии</h3>
        <div class=""block"">
            <!--        Вывод комментов                -->
            <div class=""com_users"">
");
            EndContext();
#line 42 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                 foreach (var com in Model.Comments)
                {

#line default
#line hidden
            BeginContext(1559, 79, true);
            WriteLiteral("                    <span>Пользователь: <a href=\"\" style=\"color: red\" title=\"\">");
            EndContext();
            BeginContext(1639, 17, false);
#line 44 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                                                                          Write(com.AuthorComment);

#line default
#line hidden
            EndContext();
            BeginContext(1656, 53, true);
            WriteLiteral("</a></span>\r\n                    <p>Дата комментария:");
            EndContext();
            BeginContext(1710, 15, false);
#line 45 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                                   Write(com.DateComment);

#line default
#line hidden
            EndContext();
            BeginContext(1725, 30, true);
            WriteLiteral("</p>\r\n                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1755, "\"", 1770, 1);
#line 46 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
WriteAttributeValue("", 1761, com.Icon, 1761, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1771, 84, true);
            WriteLiteral(" style=\"width: 80px; height: 80px; border-radius: 20px;\" />\r\n                    <p>");
            EndContext();
            BeginContext(1856, 8, false);
#line 47 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                  Write(com.Text);

#line default
#line hidden
            EndContext();
            BeginContext(1864, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 48 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
                }

#line default
#line hidden
            BeginContext(1889, 235, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"block\">\r\n        <span>Ваш ник: <a href=\"profile.php\" style=\"margin-left: 0;\" title=\"role\"><span>NICKNAME</span></a></span>\r\n        <div class=\"comments\">\r\n            ");
            EndContext();
            BeginContext(2124, 450, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3975713dcfa86b0c58e20da396e7a823d1a3bb7f12237", async() => {
                BeginContext(2154, 172, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label style=\"color: white\">Ваш комментарий</label>\r\n                    <input type=\"hidden\" name=\"page_id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2326, "\"", 2343, 1);
#line 59 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Theme.cshtml"
WriteAttributeValue("", 2334, Model.Id, 2334, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2344, 223, true);
                WriteLiteral(" />\r\n                    <textarea class=\"form-control\" name=\"comment\" rows=\"3\"></textarea>\r\n                </div>\r\n                <input type=\'button\' name=\"submit\" value=\'Отправить\' class=\"btn btn-dark\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2574, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThemesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
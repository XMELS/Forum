#pragma checksum "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Themes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e5adc01dc3dc06ca863ebe176be2aeb44a7f237"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Themes_Themes), @"mvc.1.0.view", @"/Views/Themes/Themes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Themes/Themes.cshtml", typeof(AspNetCore.Views_Themes_Themes))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e5adc01dc3dc06ca863ebe176be2aeb44a7f237", @"/Views/Themes/Themes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e9176ec390a22ed95d465698cfcc774ad121fbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Themes_Themes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ThemesViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/themes/themes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Themes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Theme", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(32, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7e5adc01dc3dc06ca863ebe176be2aeb44a7f2375013", async() => {
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
            BeginContext(88, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Themes.cshtml"
  
    ViewData["Title"] = "Themes";

#line default
#line hidden
            BeginContext(134, 378, true);
            WriteLiteral(@"
<div class=""main"">
    <div class=""block"">
        <!--Таблица-->
        <div class=""container"">
            <div class=""name-info"">
                <div class=""name-t"">
                    <h1>Темы</h1>
                </div>
                <div class=""name-s"">
                    <h1>Создатели</h1>
                </div>
            </div>
            <hr>
");
            EndContext();
#line 22 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Themes.cshtml"
             foreach (var theme in Model)
            {

#line default
#line hidden
            BeginContext(570, 76, true);
            WriteLiteral("                <div class=\"container-theme\">\r\n                    <p>Тема: ");
            EndContext();
            BeginContext(646, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e5adc01dc3dc06ca863ebe176be2aeb44a7f2377304", async() => {
                BeginContext(705, 15, false);
#line 25 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Themes.cshtml"
                                                                                  Write(theme.NameTheme);

#line default
#line hidden
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(724, 139, true);
            WriteLiteral("</p>\r\n                    <div class=\"container-theme-user\">\r\n                        <div class=\"media\">\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 863, "\"", 879, 1);
#line 28 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Themes.cshtml"
WriteAttributeValue("", 869, theme.img, 869, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(880, 291, true);
            WriteLiteral(@" alt=""img"" class=""mr-0"" style=""width:50px; height: 50px; border-radius: 50%;"">
                            <div class=""media-body"">
                                <ul class=""listInline"">
                                    <li>Создал: <a href=""#"" style=""color: white"" title=""Роль""><span>");
            EndContext();
            BeginContext(1172, 12, false);
#line 31 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Themes.cshtml"
                                                                                               Write(theme.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1184, 76, true);
            WriteLiteral("</span></a></li>\r\n                                    <li>Дата: <a href=\"#\">");
            EndContext();
            BeginContext(1261, 21, false);
#line 32 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Themes.cshtml"
                                                     Write(theme.CreateThemeDate);

#line default
#line hidden
            EndContext();
            BeginContext(1282, 192, true);
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <hr>\r\n");
            EndContext();
#line 39 "C:\Users\Max\Source\Repos\AutoInsuranceForum\AutoInsuranceForum\Views\Themes\Themes.cshtml"
            }

#line default
#line hidden
            BeginContext(1489, 36, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ThemesViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\Portfolio\ExperienceIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b31fa5b4ec54338120d25debcae7c59af159c59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portfolio_ExperienceIndex), @"mvc.1.0.view", @"/Views/Portfolio/ExperienceIndex.cshtml")]
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
#line 1 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\_ViewImports.cshtml"
using PortfolioApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\_ViewImports.cshtml"
using PortfolioApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\_ViewImports.cshtml"
using PortfolioApp.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b31fa5b4ec54338120d25debcae7c59af159c59", @"/Views/Portfolio/ExperienceIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3dc19a65b4e14afe0251238e35acaf584954cef1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Portfolio_ExperienceIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortfolioApp.Models.WorkExperience>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Portfolio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\Portfolio\ExperienceIndex.cshtml"
  
    ViewData["Title"] = "IndexE";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"myContainer\">\r\n\r\n    <div class=\"title\">\r\n        <style>\r\n            h2 {\r\n                text-align: center;\r\n            }</style>\r\n        <h2 text-align: center;>My Experiences</h2>\r\n    </div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\Portfolio\ExperienceIndex.cshtml"
      foreach  (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <div class=\"card mb-3\" style=\"max-width: 350px;\">\r\n        <div class=\"w3-panel w3-card w3-yellow\"></div>\r\n      <div class=\"card-body\">\r\n        <h3 class=\"card-title\"> Experience: ");
#nullable restore
#line 23 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\Portfolio\ExperienceIndex.cshtml"
                                       Write(item.WorkExperiences);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"card-text\">Role: ");
#nullable restore
#line 24 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\Portfolio\ExperienceIndex.cshtml"
                              Write(item.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Location: ");
#nullable restore
#line 25 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\Portfolio\ExperienceIndex.cshtml"
                                  Write(item.Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p class=\"card-text\">Year: ");
#nullable restore
#line 26 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\Portfolio\ExperienceIndex.cshtml"
                              Write(item.Years);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n      </div>\r\n      </div>\r\n");
#nullable restore
#line 29 "C:\Users\Decagon\Documents\c sharp\.Net Tasks\PortfolioApp\PortfolioApp\Views\Portfolio\ExperienceIndex.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
            WriteLiteral("<div class=\"container\">\r\n                 ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b31fa5b4ec54338120d25debcae7c59af159c597145", async() => {
                WriteLiteral("\r\n                     <button type=\"submit\">Contact Me</button>\r\n                 ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n             </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortfolioApp.Models.WorkExperience>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
#pragma checksum "D:\AAGitTest\DailyShopStoreReport\Views\LandingPage\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807cd6a4965624b7ff630a69460dbc861bdde0ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LandingPage_Index), @"mvc.1.0.view", @"/Views/LandingPage/Index.cshtml")]
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
#line 1 "D:\AAGitTest\DailyShopStoreReport\Views\_ViewImports.cshtml"
using DailyShopStoreReport;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AAGitTest\DailyShopStoreReport\Views\_ViewImports.cshtml"
using DailyShopStoreReport.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\AAGitTest\DailyShopStoreReport\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807cd6a4965624b7ff630a69460dbc861bdde0ba", @"/Views/LandingPage/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0cc4f23a8ca5d8ce68d5c551afebe4ee454495", @"/Views/_ViewImports.cshtml")]
    public class Views_LandingPage_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/main/img/core-img/work-progress.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\AAGitTest\DailyShopStoreReport\Views\LandingPage\Index.cshtml"
  
    ViewBag.Title = "Landing Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""mosh-workflow-area section_padding_100_0 clearfix"" style=""margin-top: 50px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""section-heading text-center mb-0"">
                    <p>The best app to store daily income and expense</p>
                    <h2>Features of this app</h2>
                </div>
            </div>
        </div>
    </div>

    <div class=""workflow-img"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "807cd6a4965624b7ff630a69460dbc861bdde0ba4696", async() => {
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
            WriteLiteral(@"
    </div>

    <div class=""workflow-slides-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""mosh-workflow-slides owl-carousel"">
                        <!-- Single Service Area -->
                        <div class=""single-workflow-area d-flex"">
                            <div class=""workflow-content ml-15"">
                                <h4>Record Income</h4>
                                <p>Companies can keep daily incomes for different purposes using cash or cheque.</p>
                            </div>
                        </div>
                        <!-- Single Service Area -->
                        <div class=""single-workflow-area d-flex"">
                            <div class=""workflow-content ml-15"">
                                <h4>Record Expense</h4>
                                <p>Companies can keep daily expense for different purposes using cash or cheque.</p>
      ");
            WriteLiteral(@"                      </div>
                        </div>
                        <!-- Single Service Area -->
                        <div class=""single-workflow-area d-flex"">
                            <div class=""workflow-content ml-15"">
                                <h4>Generate Reports</h4>
                                <p>Companies can generate monthly income and expense report with yearly profit reports.</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e497e508c8c97917e2e7af5f96e67c94645562f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Report_ViewMonthlyIncome), @"mvc.1.0.view", @"/Views/Report/ViewMonthlyIncome.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e497e508c8c97917e2e7af5f96e67c94645562f6", @"/Views/Report/ViewMonthlyIncome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0cc4f23a8ca5d8ce68d5c551afebe4ee454495", @"/Views/_ViewImports.cshtml")]
    public class Views_Report_ViewMonthlyIncome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Income>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "month", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("month"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "year", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("year"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
  
    ViewBag.Title = "ViewMonthlyIncome";
    int i = 0;
    string month = ViewBag.Month;
    string year = ViewBag.Year;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container col-md-8\" style=\"margin-top: 150px;margin-bottom: 100px;\">\r\n    <h2>");
#nullable restore
#line 11 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <div class=\"panel panel-default\">\r\n        <div class=\"panel-title\">\r\n            <h4>View monthly income(s)</h4>\r\n        </div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e497e508c8c97917e2e7af5f96e67c94645562f66259", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e497e508c8c97917e2e7af5f96e67c94645562f66627", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 19 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Helper.GetMonths();

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-4\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e497e508c8c97917e2e7af5f96e67c94645562f68541", async() => {
                    WriteLiteral("   ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 22 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.GetYear;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-4\">\r\n                    <button class=\"btn btn-success pull-right\" id=\"getData\" type=\"submit\"> Show </button>\r\n                </div>\r\n                <br /><br />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""panel-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered table-striped"" id=""dataTable"">
                    <thead>
                        <tr>
                            <th>Sl</th>
                            <th>Date</th>
                            <th style=""text-align: center"">Amount</th>
                            <th>Cash/Cheque</th>
                            <th>Cheque Details</th>
                            <th>Particular</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 44 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                         foreach (Income income in Model)
                        {
                            i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 48 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 49 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                               Write(income.Date.ToString("yyyy MMMM dd"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td style=\"text-align: center\">");
#nullable restore
#line 50 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                                                          Write(income.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 51 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                               Write(income.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n");
#nullable restore
#line 53 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                                     if (income.Type == "Cheque")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>Check No: ");
#nullable restore
#line 55 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                                                   Write(income.ChequeNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br /> Bank Name: ");
#nullable restore
#line 55 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                                                                                      Write(income.BankName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 56 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>N/A</span>\r\n");
#nullable restore
#line 60 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td>");
#nullable restore
#line 62 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                               Write(income.Particular);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 64 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                    <thead>\r\n                        <tr>\r\n                            <th colspan=\"2\">Total</th>\r\n                            <th style=\"text-align: center\">");
#nullable restore
#line 69 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                                                      Write(Model.Sum(x => x.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th style=\"text-align:>\r\n                            <th colspan=\"3\"></th>\r\n                        </tr>\r\n                    </thead>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n            $(function () {\r\n                $(\'#month\').val(\'");
#nullable restore
#line 81 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                            Write(month);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n                $(\'#year\').val(\'");
#nullable restore
#line 82 "D:\AAGitTest\DailyShopStoreReport\Views\Report\ViewMonthlyIncome.cshtml"
                           Write(year);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');\r\n            });\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Income>> Html { get; private set; }
    }
}
#pragma warning restore 1591

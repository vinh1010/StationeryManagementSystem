#pragma checksum "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bca03538ad2ced458855904b43c136e464e56e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_Index), @"mvc.1.0.view", @"/Views/Feedback/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedback/Index.cshtml", typeof(AspNetCore.Views_Feedback_Index))]
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
#line 1 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\_ViewImports.cshtml"
using StationeryManagementSystem;

#line default
#line hidden
#line 2 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\_ViewImports.cshtml"
using StationeryManagementSystem.Models;

#line default
#line hidden
#line 2 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bca03538ad2ced458855904b43c136e464e56e0", @"/Views/Feedback/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c266a878bcfccc594e46064d6d221720abc8c0", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<StationeryManagementSystem.Models.Feedbacks>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Feedback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: green"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Update information"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: red;padding-left: 20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete stationery"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(147, 382, true);
            WriteLiteral(@"
<section class=""content"" style=""padding-top: 20px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Feedback List</h3>
                        <div class=""card-tools"">
                            ");
            EndContext();
            BeginContext(529, 703, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a907d6a849342299942ca3a09d77e5e", async() => {
                BeginContext(593, 632, true);
                WriteLiteral(@"
                                <div class=""input-group input-group-sm"" style=""width: 350px;"">
                                    <input type=""number"" name=""Search"" class=""form-control float-right"" placeholder=""Enter id employee"">
                                    <div class=""input-group-append"">
                                        <button type=""submit"" class=""btn btn-default"">
                                            <i class=""fas fa-search""></i>
                                        </button>
                                    </div>
                                </div>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1232, 133, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        ");
            EndContext();
            BeginContext(1365, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a3de807945d49e29eb804cb8b99799e", async() => {
                BeginContext(1438, 14, true);
                WriteLiteral("Send Feedback ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1456, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 30 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                         if (TempData["success"] != null)
                        {

#line default
#line hidden
            BeginContext(1544, 132, true);
            WriteLiteral("                            <div class=\"alert alert-success\" role=\"alert\" style=\"margin-top:20px\">\r\n                                ");
            EndContext();
            BeginContext(1677, 29, false);
#line 33 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                           Write(Html.Raw(TempData["success"]));

#line default
#line hidden
            EndContext();
            BeginContext(1706, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 35 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1771, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 36 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                         if (TempData["eror"] != null)
                        {

#line default
#line hidden
            BeginContext(1854, 131, true);
            WriteLiteral("                            <div class=\"alert alert-danger\" role=\"alert\" style=\"margin-top:20px\">\r\n                                ");
            EndContext();
            BeginContext(1986, 26, false);
#line 39 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                           Write(Html.Raw(TempData["eror"]));

#line default
#line hidden
            EndContext();
            BeginContext(2012, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 41 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2077, 573, true);
            WriteLiteral(@"                        <table class=""table table-bordered"" style=""margin-top: 20px"">
                            <thead>
                                <tr>
                                    <th>ID Feedback</th>
                                    <th>ID Employee</th>
                                    <th>Date Create</th>
                                    <th>Status</th>
                                    <th style=""width: 8%"">Tools</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 53 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                 foreach (var feedback in Model)
                                {

#line default
#line hidden
            BeginContext(2751, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(2838, 19, false);
#line 56 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                       Write(feedback.Idfeedback);

#line default
#line hidden
            EndContext();
            BeginContext(2857, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2909, 19, false);
#line 57 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                       Write(feedback.Idemployee);

#line default
#line hidden
            EndContext();
            BeginContext(2928, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2980, 52, false);
#line 58 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                       Write(String.Format("{0:yyyy/MM/dd}", feedback.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(3032, 53, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n");
            EndContext();
#line 60 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                             if (feedback.Status == 1)
                                            {

#line default
#line hidden
            BeginContext(3204, 92, true);
            WriteLiteral("                                                <span class=\"badge bg-success\">Show</span>\r\n");
            EndContext();
#line 63 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                            }
                                            else
                                            {


#line default
#line hidden
            BeginContext(3442, 93, true);
            WriteLiteral("                                                <span class=\"badge bg-danger\">Hidden</span>\r\n");
            EndContext();
#line 68 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3582, 137, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(3719, 181, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "edda9be9ad004b46aa2433f7173bb285", async() => {
                BeginContext(3852, 44, true);
                WriteLiteral("<i class=\"fa fa-eye\" aria-hidden=\"true\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                                                                                                    WriteLiteral(feedback.Idfeedback);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3900, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(3946, 199, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b0b47de04a946348ed2a15e29d7120b", async() => {
                BeginContext(4095, 46, true);
                WriteLiteral("<i class=\"fa fa-trash\" aria-hidden=\"true\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                                                                                                                     WriteLiteral(feedback.Idfeedback);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4145, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 75 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(4272, 265, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                    <div class=""card-footer clearfix"">
                        <ul class=""pagination pagination-sm m-0 float-right"">
                            ");
            EndContext();
            BeginContext(4538, 400, false);
#line 82 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\Feedback\Index.cshtml"
                       Write(Html.PagedListPager(Model, page => Url.Action("Index", new { page = page }),
                             new PagedListRenderOptions
                                {
                                    LiElementClasses = new string[] { "page-item" },
                                    PageClasses = new string[] { "page-link" }
                                }
                            ));

#line default
#line hidden
            EndContext();
            BeginContext(4938, 147, true);
            WriteLiteral("\r\n                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<StationeryManagementSystem.Models.Feedbacks>> Html { get; private set; }
    }
}
#pragma warning restore 1591

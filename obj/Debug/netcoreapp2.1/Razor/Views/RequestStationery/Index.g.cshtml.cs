#pragma checksum "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6261fbda1fd78efd019b8e4f6b57fd69b330031d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RequestStationery_Index), @"mvc.1.0.view", @"/Views/RequestStationery/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RequestStationery/Index.cshtml", typeof(AspNetCore.Views_RequestStationery_Index))]
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
#line 2 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6261fbda1fd78efd019b8e4f6b57fd69b330031d", @"/Views/RequestStationery/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c266a878bcfccc594e46064d6d221720abc8c0", @"/Views/_ViewImports.cshtml")]
    public class Views_RequestStationery_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<StationeryManagementSystem.Models.RequestStationery>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RequestStationery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: green"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(155, 346, true);
            WriteLiteral(@"
<section class=""content"" style=""padding-top: 20px"">
    
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-12"">

                <div class=""card"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">Request Stationery List</h3>
                        ");
            EndContext();
            BeginContext(501, 1281, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a754d381b0274f33ac8f5cbb37747ff2", async() => {
                BeginContext(574, 1201, true);
                WriteLiteral(@"
                            <div class=""card-tools float-right"">
                                <div class=""input-group input-group-sm"">
                                    <b>From:</b> <input style=""margin-left: 5px"" type=""date"" name=""From"" class=""form-control float-right"">
                                    <b style=""margin-left: 10px"">To:</b> <input style=""margin-left: 5px"" type=""date"" name=""To"" class=""form-control float-right"">
                                    <div class=""input-group input-group-sm"" style=""width: 350px;margin-left: 10px"">
                                        <input type=""number"" name=""Search"" class=""form-control float-right"" placeholder=""Enter id employee"">
                                    </div>
                                    <div class=""input-group-append"">
                                        <button style=""margin-left: 10px"" type=""submit"" class=""btn btn-default"">
                                            <i class=""fas fa-search""></i>
                  ");
                WriteLiteral("                      </button>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        ");
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
            BeginContext(1782, 101, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        ");
            EndContext();
            BeginContext(1883, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "914cd1601f7c4d91be05620759fb7913", async() => {
                BeginContext(1965, 24, true);
                WriteLiteral("Send Request Stationery ");
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
            BeginContext(1993, 32, true);
            WriteLiteral("\r\n                            \r\n");
            EndContext();
#line 37 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                         if (TempData["success"] != null)
                        {

#line default
#line hidden
            BeginContext(2111, 132, true);
            WriteLiteral("                            <div class=\"alert alert-success\" role=\"alert\" style=\"margin-top:20px\">\r\n                                ");
            EndContext();
            BeginContext(2244, 29, false);
#line 40 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                           Write(Html.Raw(TempData["success"]));

#line default
#line hidden
            EndContext();
            BeginContext(2273, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 42 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2338, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 43 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                         if (TempData["eror"] != null)
                        {

#line default
#line hidden
            BeginContext(2421, 131, true);
            WriteLiteral("                            <div class=\"alert alert-danger\" role=\"alert\" style=\"margin-top:20px\">\r\n                                ");
            EndContext();
            BeginContext(2553, 26, false);
#line 46 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                           Write(Html.Raw(TempData["eror"]));

#line default
#line hidden
            EndContext();
            BeginContext(2579, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 48 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2644, 836, true);
            WriteLiteral(@"                        <table class=""table table-bordered"" style=""margin-top: 20px"">
                            <thead>
                                <tr>
                                    <th title=""ID Request Stationery"">ID</th>
                                    <th title=""ID Employee"">ID Epl</th>
                                    <th>Name Stationery</th>
                                    <th>Quantity</th>
                                    <th>Price</th>
                                    <th>Toatl Price</th>
                                    <th>Date Create</th>
                                    <th>Status</th>
                                    <th style=""width: 8%"">Tools</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 64 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                 foreach (var rs in Model)
                                {

#line default
#line hidden
            BeginContext(3575, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(3662, 22, false);
#line 67 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                       Write(rs.IdrequestStationery);

#line default
#line hidden
            EndContext();
            BeginContext(3684, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3736, 13, false);
#line 68 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                       Write(rs.Idemployee);

#line default
#line hidden
            EndContext();
            BeginContext(3749, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3801, 42, false);
#line 69 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                       Write(rs.IdstationerieNavigation.NameStationerie);

#line default
#line hidden
            EndContext();
            BeginContext(3843, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(3895, 11, false);
#line 70 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                       Write(rs.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3906, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3908, 40, false);
#line 70 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                                    Write(rs.IdstationerieNavigation.UnitOfMeasure);

#line default
#line hidden
            EndContext();
            BeginContext(3948, 52, true);
            WriteLiteral("</td>\r\n                                        <td>$");
            EndContext();
            BeginContext(4001, 32, false);
#line 71 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                        Write(rs.IdstationerieNavigation.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4033, 52, true);
            WriteLiteral("</td>\r\n                                        <td>$");
            EndContext();
            BeginContext(4087, 46, false);
#line 72 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                         Write(rs.IdstationerieNavigation.Price * rs.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(4134, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(4186, 46, false);
#line 73 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                       Write(String.Format("{0:yyyy/MM/dd}", rs.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(4232, 53, true);
            WriteLiteral("</td>\r\n                                        <td>\r\n");
            EndContext();
#line 75 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                             if (rs.Status == 0)
                                            {

#line default
#line hidden
            BeginContext(4398, 95, true);
            WriteLiteral("                                                <span class=\"badge bg-warning\">Pending</span>\r\n");
            EndContext();
#line 78 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                            }
                                            else if (rs.Status == 1)
                                            {

#line default
#line hidden
            BeginContext(4657, 115, true);
            WriteLiteral("                                                <span class=\"badge bg-info\">Approved accounting department</span>\r\n");
            EndContext();
#line 82 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                            }
                                            else if (rs.Status == 2)
                                            {

#line default
#line hidden
            BeginContext(4936, 121, true);
            WriteLiteral("                                                <span class=\"badge bg-success\">Approved company management board</span>\r\n");
            EndContext();
#line 86 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                            }
                                            else if (rs.Status == 3)
                                            {


#line default
#line hidden
            BeginContext(5223, 103, true);
            WriteLiteral("                                                <span class=\"badge bg-danger\">Request canceled</span>\r\n");
            EndContext();
#line 91 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(5373, 137, true);
            WriteLiteral("                                        </td>\r\n                                        <td>\r\n                                            ");
            EndContext();
            BeginContext(5510, 191, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ad6200625184266acad39d8c28d3f71", async() => {
                BeginContext(5653, 44, true);
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
#line 94 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                                                                                                           WriteLiteral(rs.IdrequestStationery);

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
            BeginContext(5701, 46, true);
            WriteLiteral("\r\n                                            ");
            EndContext();
            BeginContext(5747, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4556d34f5a3445149a46b78cbad4b1e2", async() => {
                BeginContext(5908, 46, true);
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
#line 95 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                                                                                                                              WriteLiteral(rs.IdrequestStationery);

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
            BeginContext(5958, 92, true);
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 98 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(6085, 265, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>

                    <div class=""card-footer clearfix"">
                        <ul class=""pagination pagination-sm m-0 float-right"">
                            ");
            EndContext();
            BeginContext(6351, 403, false);
#line 105 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Index.cshtml"
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
            BeginContext(6754, 147, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<StationeryManagementSystem.Models.RequestStationery>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3fd717d35cdaa00bd41c3fbe022401f3e7f7ea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RequestStationery_Edit), @"mvc.1.0.view", @"/Views/RequestStationery/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RequestStationery/Edit.cshtml", typeof(AspNetCore.Views_RequestStationery_Edit))]
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
#line 2 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3fd717d35cdaa00bd41c3fbe022401f3e7f7ea4", @"/Views/RequestStationery/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0c266a878bcfccc594e46064d6d221720abc8c0", @"/Views/_ViewImports.cshtml")]
    public class Views_RequestStationery_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StationeryManagementSystem.Models.RequestStationery>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("60%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "RequestStationery", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info float-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Browse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(210, 463, true);
            WriteLiteral(@"
<section class=""content"" style=""padding-top: 20px"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""invoice p-3 mb-3"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <h4>
                                <i class=""fas fa-globe""></i> HMT Technologies.
                                <small class=""float-right"">Date: ");
            EndContext();
            BeginContext(674, 49, false);
#line 17 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                                            Write(String.Format("{0:yyyy/MM/dd}", Model.DateCreate));

#line default
#line hidden
            EndContext();
            BeginContext(723, 336, true);
            WriteLiteral(@"</small>
                            </h4>
                        </div>
                    </div>

                    <div class=""row invoice-info"">
                        <div class=""col-sm-4 invoice-col"">
                            Employee
                            <address>
                                <strong>");
            EndContext();
            BeginContext(1060, 39, false);
#line 26 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                   Write(Model.IdemployeeNavigation.NameEmployee);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 54, true);
            WriteLiteral("</strong><br>\r\n                                Email: ");
            EndContext();
            BeginContext(1154, 34, false);
#line 27 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                  Write(Model.IdemployeeNavigation.EmailId);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 255, true);
            WriteLiteral("\r\n                            </address>\r\n                        </div>\r\n\r\n                        <div class=\"col-sm-4 invoice-col\">\r\n                            Stationery\r\n                            <address>\r\n                                <strong>");
            EndContext();
            BeginContext(1444, 45, false);
#line 34 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                   Write(Model.IdstationerieNavigation.NameStationerie);

#line default
#line hidden
            EndContext();
            BeginContext(1489, 57, true);
            WriteLiteral("</strong><br>\r\n                                Quantity: ");
            EndContext();
            BeginContext(1547, 14, false);
#line 35 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                     Write(Model.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1561, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1563, 43, false);
#line 35 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                                     Write(Model.IdstationerieNavigation.UnitOfMeasure);

#line default
#line hidden
            EndContext();
            BeginContext(1606, 939, true);
            WriteLiteral(@"
                            </address>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-12 table-responsive"">
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>ID</th>
                                        <th>Name Stationerie</th>
                                        <th style=""width: 10%"">Image</th>
                                        <th>Price</th>
                                        <th>Quantity</th>
                                        <th>Totail Price</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr>
                                        <td>");
            EndContext();
            BeginContext(2546, 25, false);
#line 55 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                       Write(Model.IdrequestStationery);

#line default
#line hidden
            EndContext();
            BeginContext(2571, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2623, 45, false);
#line 56 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                       Write(Model.IdstationerieNavigation.NameStationerie);

#line default
#line hidden
            EndContext();
            BeginContext(2668, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2719, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6235c8a2def9491097acbefba7c4b986", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2729, "~/stationeries/", 2729, 15, true);
#line 57 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
AddHtmlAttributeValue("", 2744, Model.IdstationerieNavigation.Image, 2744, 36, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 57 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
AddHtmlAttributeValue("", 2787, Model.IdstationerieNavigation.NameStationerie, 2787, 46, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2847, 52, true);
            WriteLiteral("</td>\r\n                                        <td>$");
            EndContext();
            BeginContext(2900, 35, false);
#line 58 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                        Write(Model.IdstationerieNavigation.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2935, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(2987, 14, false);
#line 59 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                       Write(Model.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(3001, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3003, 43, false);
#line 59 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                                       Write(Model.IdstationerieNavigation.UnitOfMeasure);

#line default
#line hidden
            EndContext();
            BeginContext(3046, 52, true);
            WriteLiteral("</td>\r\n                                        <td>$");
            EndContext();
            BeginContext(3100, 52, false);
#line 60 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                         Write(Model.Quantity * Model.IdstationerieNavigation.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3153, 692, true);
            WriteLiteral(@"</td>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                    <div class=""row"">

                        <div class=""col-6"">
                        </div>
                        <div class=""col-6"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <tbody>
                                        <tr>
                                            <th style=""width:50%"">Subtotal:</th>
                                            <td>$");
            EndContext();
            BeginContext(3847, 52, false);
#line 77 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                             Write(Model.Quantity * Model.IdstationerieNavigation.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3900, 210, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th>Total:</th>\r\n                                            <td>$");
            EndContext();
            BeginContext(4112, 52, false);
#line 81 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                             Write(Model.Quantity * Model.IdstationerieNavigation.Price);

#line default
#line hidden
            EndContext();
            BeginContext(4165, 362, true);
            WriteLiteral(@"</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>

                    <div class=""row no-print"">
                        <div class=""col-12"">
                            ");
            EndContext();
            BeginContext(4527, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f31af5a32f2e4f828733cbc0c55857a2", async() => {
                BeginContext(4616, 123, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-list-ul\" aria-hidden=\"true\"></i> Go to list\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4743, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(4773, 264, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0e46540126e4f43939e6e2d09a5bbde", async() => {
                BeginContext(4908, 125, true);
                WriteLiteral("\r\n                                <i class=\"fa fa-times\" aria-hidden=\"true\"></i> Cancel request\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                                                                        WriteLiteral(Model.IdrequestStationery);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5037, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 97 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                             if (HttpContextAccessor.HttpContext.Session.GetInt32("roleId") == 1 || HttpContextAccessor.HttpContext.Session.GetInt32("roleId") == 2)
                            {

#line default
#line hidden
            BeginContext(5236, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(5268, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5456338693cc4f8bba92a88af4eff058", async() => {
                BeginContext(5428, 133, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-check\" aria-hidden=\"true\"></i> Browse request\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 99 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                                                                            WriteLiteral(Model.IdrequestStationery);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5565, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 102 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                            }

#line default
#line hidden
            BeginContext(5598, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 103 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                             if (HttpContextAccessor.HttpContext.Session.GetInt32("roleId") == 3 && HttpContextAccessor.HttpContext.Session.GetString("departmentId").Equals("DAD"))
                            {

#line default
#line hidden
            BeginContext(5811, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(5843, 297, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86be7dd5ff624d4d9d727236e1b12140", async() => {
                BeginContext(6003, 133, true);
                WriteLiteral("\r\n                                    <i class=\"fa fa-check\" aria-hidden=\"true\"></i> Browse request\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 105 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                                                                                            WriteLiteral(Model.IdrequestStationery);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6140, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 108 "C:\Users\101020\OneDrive\Documents\E-project SEM III\E-project\web based Stationery Management System\StationeryManagementSystem\Views\RequestStationery\Edit.cshtml"
                            }

#line default
#line hidden
            BeginContext(6173, 146, true);
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StationeryManagementSystem.Models.RequestStationery> Html { get; private set; }
    }
}
#pragma warning restore 1591
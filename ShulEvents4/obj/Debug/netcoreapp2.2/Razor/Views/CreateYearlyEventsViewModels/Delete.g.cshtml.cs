#pragma checksum "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "000c7b52953eef3cf231ecad122046be7ea91a85"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CreateYearlyEventsViewModels_Delete), @"mvc.1.0.view", @"/Views/CreateYearlyEventsViewModels/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CreateYearlyEventsViewModels/Delete.cshtml", typeof(AspNetCore.Views_CreateYearlyEventsViewModels_Delete))]
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
#line 1 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\_ViewImports.cshtml"
using ShulEvents4;

#line default
#line hidden
#line 2 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\_ViewImports.cshtml"
using ShulEvents4.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000c7b52953eef3cf231ecad122046be7ea91a85", @"/Views/CreateYearlyEventsViewModels/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfc619cc52c9a57d885cc0677b9cad9895d53d6d", @"/Views/_ViewImports.cshtml")]
    public class Views_CreateYearlyEventsViewModels_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShulEvents4.ViewModels.CreateYearlyEventsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(103, 197, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>CreateYearlyEventsViewModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(301, 40, false);
#line 15 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(341, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(405, 39, false);
#line 18 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.User.Id));

#line default
#line hidden
            EndContext();
            BeginContext(444, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(513, 48, false);
#line 21 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StartingDate));

#line default
#line hidden
            EndContext();
            BeginContext(561, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(625, 44, false);
#line 24 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartingDate));

#line default
#line hidden
            EndContext();
            BeginContext(669, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(732, 45, false);
#line 27 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(777, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(841, 41, false);
#line 30 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StartTime));

#line default
#line hidden
            EndContext();
            BeginContext(882, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(945, 46, false);
#line 33 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndingDate));

#line default
#line hidden
            EndContext();
            BeginContext(991, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1055, 42, false);
#line 36 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndingDate));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1160, 43, false);
#line 39 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EndTime));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1267, 39, false);
#line 42 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EndTime));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1369, 49, false);
#line 45 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpecialEvents));

#line default
#line hidden
            EndContext();
            BeginContext(1418, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1482, 45, false);
#line 48 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpecialEvents));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1590, 52, false);
#line 51 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SpecialShabassos));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1706, 48, false);
#line 54 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SpecialShabassos));

#line default
#line hidden
            EndContext();
            BeginContext(1754, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1817, 42, false);
#line 57 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Months));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1923, 38, false);
#line 60 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Months));

#line default
#line hidden
            EndContext();
            BeginContext(1961, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2024, 44, false);
#line 63 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Parshios));

#line default
#line hidden
            EndContext();
            BeginContext(2068, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2132, 40, false);
#line 66 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Parshios));

#line default
#line hidden
            EndContext();
            BeginContext(2172, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2235, 46, false);
#line 69 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LifeEvents));

#line default
#line hidden
            EndContext();
            BeginContext(2281, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2345, 42, false);
#line 72 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LifeEvents));

#line default
#line hidden
            EndContext();
            BeginContext(2387, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2450, 52, false);
#line 75 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EventDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2502, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2566, 48, false);
#line 78 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EventDescription));

#line default
#line hidden
            EndContext();
            BeginContext(2614, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2652, 206, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "000c7b52953eef3cf231ecad122046be7ea91a8515015", async() => {
                BeginContext(2678, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2688, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "000c7b52953eef3cf231ecad122046be7ea91a8515408", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 83 "C:\Users\dkami\source\repos\ShulEvents4\ShulEvents4\Views\CreateYearlyEventsViewModels\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2724, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2807, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "000c7b52953eef3cf231ecad122046be7ea91a8517335", async() => {
                    BeginContext(2829, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2845, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2858, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShulEvents4.ViewModels.CreateYearlyEventsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
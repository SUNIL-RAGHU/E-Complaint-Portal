#pragma checksum "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f65a3e1c9dee14d31d49016c8c156dfe2662e220"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SaveForm), @"mvc.1.0.view", @"/Views/Home/SaveForm.cshtml")]
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
#line 1 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\_ViewImports.cshtml"
using EIssue;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\_ViewImports.cshtml"
using EIssue.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f65a3e1c9dee14d31d49016c8c156dfe2662e220", @"/Views/Home/SaveForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"433d812900772776f99c15fe15eed7fd3952987e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SaveForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"
  
    ViewData["Title"] = "SaveForm";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<ul class=""nav nav-pills"">
    <li class=""nav-item"">
        <a class=""nav-link active"" aria-current=""page"" href=""#"">Home</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">Contact</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" href=""#"">Logout</a>
    </li>
");
            WriteLiteral("</ul>\r\n\r\n<br />\r\n<br />\r\n\r\n<div>\r\n    <h3>My Requests</h3>\r\n    <div class=\"float-container\" style=\"display:flex;\">\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"
         foreach (var issueDetail in (IEnumerable<EIssue.ViewModel.Details>)ViewData["IssueDetails"])
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"float-child\" style=\" width: 500px; height:250px;padding: 10px;border: 1px solid gray;margin: 0;\">\r\n                <p> Category: ");
#nullable restore
#line 32 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"
                         Write(issueDetail.category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p> Description: ");
#nullable restore
#line 33 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"
                            Write(issueDetail.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                <p> Municipility: ");
#nullable restore
#line 34 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"
                             Write(issueDetail.Municipility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p> Status: ");
#nullable restore
#line 35 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"
                       Write(issueDetail.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a href=\"#\"> Click here to view </a>\r\n            </div>\r\n");
#nullable restore
#line 38 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n<br />\r\n<br />\r\n<div>\r\n    <h3>Raise a New Request</h3>\r\n    <div style=\"padding:10px;border: 1px solid gray\">\r\n");
#nullable restore
#line 64 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"
         using (@Html.BeginForm("CreateRequest", "Home", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label for=""Email"">Email</label>
                    <input type=""email"" class=""form-control"" id=""Email"" placeholder=""Email"" name=""Email"">
                </div>
            </div>
");
            WriteLiteral(@"            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label for=""inputCategory"">Category</label>
                    <select id=""inputCategory"" name=""inputCategory"" class=""form-control"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65a3e1c9dee14d31d49016c8c156dfe2662e2206646", async() => {
                WriteLiteral("Choose Category...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65a3e1c9dee14d31d49016c8c156dfe2662e2207951", async() => {
                WriteLiteral("Road");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65a3e1c9dee14d31d49016c8c156dfe2662e2208931", async() => {
                WriteLiteral("Street Light");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </select>
                </div>
                <div class=""form-group col-md-4"">
                    <label for=""inputMunicipility"">Municipility</label>
                    <select id=""inputMunicipility"" name=""inputMunicipility"" class=""form-control"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65a3e1c9dee14d31d49016c8c156dfe2662e22010206", async() => {
                WriteLiteral("Choose Municipility...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65a3e1c9dee14d31d49016c8c156dfe2662e22011516", async() => {
                WriteLiteral("Arani");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65a3e1c9dee14d31d49016c8c156dfe2662e22012498", async() => {
                WriteLiteral("Chennai");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f65a3e1c9dee14d31d49016c8c156dfe2662e22013482", async() => {
                WriteLiteral("Vellore");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </select>\r\n                </div>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""form-group"">
                <label for=""inputAddress"">Address</label>
                <input type=""text""  multiple class=""form-control"" id=""inputAddress"" name=""inputAddress"" placeholder=""Enter your Address"">
            </div>
");
            WriteLiteral(@"            <div class=""form-group"">
                <label for=""Description"">Description</label>
                <input type=""text"" maxlength=""1000"" multiple class=""form-control"" id=""Description"" name=""Description"" placeholder=""Tell us your issue"">
            </div>
");
            WriteLiteral(@"            <div class=""form-group"">
                <label for=""image"">Attach Image</label>
                <input type=""file"" class=""form-control-file"" id=""image"" name=""image"">
            </div>
            <button type=""submit"" class=""btn btn-primary"">Submit Form</button>
");
#nullable restore
#line 108 "C:\Users\Madhan\source\repos\EIssue\EIssue\Views\Home\SaveForm.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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

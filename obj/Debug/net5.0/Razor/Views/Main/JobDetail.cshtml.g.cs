#pragma checksum "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5627460ef635e223fb71f5ff593c6343bd560daa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_JobDetail), @"mvc.1.0.view", @"/Views/Main/JobDetail.cshtml")]
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
#line 1 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/_ViewImports.cshtml"
using JobMatching_OOPII_FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/_ViewImports.cshtml"
using JobMatching_OOPII_FinalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5627460ef635e223fb71f5ff593c6343bd560daa", @"/Views/Main/JobDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a346c62ed2bc154178971b8be6d9be5978e9e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_JobDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.projectModels.Job>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float: right;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("JobDetail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
  
    Layout ="~/Views/Shared/_MainViewLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link rel=""preconnect"" href=""https://fonts.gstatic.com"">
<link href=""https://fonts.googleapis.com/css2?family=Suez+One&display=swap"" rel=""stylesheet"">

    
<link rel=""preconnect"" href=""https://fonts.gstatic.com"">
<link href=""https://fonts.googleapis.com/css2?family=Yanone+Kaffeesatz:wght@200;700&display=swap"" rel=""stylesheet""> 
<link rel=""preconnect"" href=""https://fonts.gstatic.com"">
<link href=""https://fonts.googleapis.com/css2?family=ZCOOL+KuaiLe&display=swap"" rel=""stylesheet"">



<div class=""row"">
    <div class=""col-md-12"">
        <h1>Job Detail</h1>
    </div>
</div>



<div class=""row"">


                  <div class=""Container"">
                <div class=""card shadow pl-5 ml-5 card my-sm-5""  style=""width:1000px ; margin-left : 200px""");
            BeginWriteAttribute("style", "  style=\"", 846, "\"", 855, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <div class=\"card-body\">\n                        <h3 style=\"font-family: \'Yanone Kaffeesatz\', sans-serif;\" class=\"card-title\">");
#nullable restore
#line 32 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                                                                                Write(Model.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        <img style=\"float:right\" src=$\"{");
#nullable restore
#line 33 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                                   Write(Model.CompanyNameLogo);

#line default
#line hidden
#nullable disable
            WriteLiteral("}\">   <br>   \n\n                        </h3>\n                        <a");
            BeginWriteAttribute("href", " href=\"", 1168, "\"", 1175, 0);
            EndWriteAttribute();
            WriteLiteral(" >CompanyName :  ");
#nullable restore
#line 36 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                              Write(Model.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a >\n\n                        <hr>\n\n                                    <br>\n                                    <br>\n                                \n                                    <p>");
#nullable restore
#line 43 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                  Write(Model.JobDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

                                    <br>
                                

                                <table style=""width:100%"">
                                <tr>
                                    <th>Job Type</th>
                                    <th>Salary Range</th>
                                </tr>
                                <tr>
                                    <td>");
#nullable restore
#line 54 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                   Write(Model.JobType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                    <td>$");
#nullable restore
#line 55 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                    Write(Model.SalaryRange);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                </tr>\n                             \n                            \n                                </table>\n                                <br><br>\n\n                            <a");
            BeginWriteAttribute("href", " href=\"", 2117, "\"", 2124, 0);
            EndWriteAttribute();
            WriteLiteral(">Number of applicants till now: ");
#nullable restore
#line 62 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                                                 Write(ViewData["NumberofApplicants"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\n\n\n\n                        <hr>\n\n                        <span><a style=\"text-decoration: none;font-family: \'ZCOOL KuaiLe\', cursive;\"");
            BeginWriteAttribute("href", " href=\"", 2327, "\"", 2334, 0);
            EndWriteAttribute();
            WriteLiteral("> post date: ");
#nullable restore
#line 68 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                                                                                                    Write(Model.dateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5627460ef635e223fb71f5ff593c6343bd560daa10340", async() => {
                WriteLiteral("\n\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5627460ef635e223fb71f5ff593c6343bd560daa10629", async() => {
                    WriteLiteral(" Apply ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-user", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                        WriteLiteral(User.Identity.Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["user"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-user", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["user"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                            WriteLiteral(Model.JobTitle);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["jobTitle"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-jobTitle", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["jobTitle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/JobDetail.cshtml"
                                               WriteLiteral(Model.CompanyName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["companyName"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-companyName", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["companyName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                \n                \n                    </div>\n                </div>\n            </div>\n \n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.projectModels.Job> Html { get; private set; }
    }
}
#pragma warning restore 1591

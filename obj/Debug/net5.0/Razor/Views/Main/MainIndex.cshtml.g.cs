#pragma checksum "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5fcb934b659068a6076750e568c3205b55d4612"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_MainIndex), @"mvc.1.0.view", @"/Views/Main/MainIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5fcb934b659068a6076750e568c3205b55d4612", @"/Views/Main/MainIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a346c62ed2bc154178971b8be6d9be5978e9e01", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_MainIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Models.projectModels.Job>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n\n");
#nullable restore
#line 6 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml"
                                          
    Layout ="";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5fcb934b659068a6076750e568c3205b55d46124584", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 12 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" | Job-matching</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5fcb934b659068a6076750e568c3205b55d46125224", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d5fcb934b659068a6076750e568c3205b55d46126385", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<div class=\"text-center m-4 p-4\">\n");
            WriteLiteral("    <h1>\n        Main Index\n    </h1>\n</div>\n\n\n\n\n<div class=\"row\">\n    <div class=\"col-md-12\">\n        <h1>List of avaliable Jobs</h1>\n    </div>\n</div>\n<div class=\"row\">\n    <div class=\"col-md-12\">\n      \n            \n");
#nullable restore
#line 36 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml"
                        foreach(var item in Model)

                            {



#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card\"");
            BeginWriteAttribute("style", " style=\"", 965, "\"", 973, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                            <img src=\"...\" class=\"card-img-top\" alt=\"...\">\n                            <div class=\"card-body\">\n                                <h5 class=\"card-title\">");
#nullable restore
#line 44 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml"
                                                  Write(item.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                <p>");
#nullable restore
#line 45 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml"
                              Write(item.JobDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <a href=\"#\" class=\"btn btn-primary\">");
#nullable restore
#line 46 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml"
                                                               Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                <p>");
#nullable restore
#line 47 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml"
                              Write(item.dateTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            </div>\n                            </div>\n");
#nullable restore
#line 50 "/home/eharry/Documents/Projects/JobMatching-OOPII-FinalProject/Views/Main/MainIndex.cshtml"
                                    
                             
                                
                                
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n             \n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Models.projectModels.Job>> Html { get; private set; }
    }
}
#pragma warning restore 1591
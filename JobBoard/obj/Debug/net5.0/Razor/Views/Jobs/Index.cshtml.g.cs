#pragma checksum "/Users/arthurbuck/Desktop/projects/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3766daf579445c32599fd8da134fd91ef2c08b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jobs_Index), @"mvc.1.0.view", @"/Views/Jobs/Index.cshtml")]
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
#line 2 "/Users/arthurbuck/Desktop/projects/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
using JobBoard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3766daf579445c32599fd8da134fd91ef2c08b", @"/Views/Jobs/Index.cshtml")]
    public class Views_Jobs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Epicodus Job Board</h1>\n");
#nullable restore
#line 5 "/Users/arthurbuck/Desktop/projects/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>There are no items on the job board.</p>\n");
#nullable restore
#line 8 "/Users/arthurbuck/Desktop/projects/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<ul>\n");
#nullable restore
#line 10 "/Users/arthurbuck/Desktop/projects/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
   foreach (Job job in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li><a");
            BeginWriteAttribute("href", " href=\'", 176, "\'", 196, 2);
            WriteAttributeValue("", 183, "/jobs/", 183, 6, true);
#nullable restore
#line 12 "/Users/arthurbuck/Desktop/projects/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
WriteAttributeValue("", 189, job.Id, 189, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 12 "/Users/arthurbuck/Desktop/projects/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
                           Write(job.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 13 "/Users/arthurbuck/Desktop/projects/JobBoard.Solution/JobBoard/Views/Jobs/Index.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<a href=\"/jobs/new\">Add a new job.</a>\n\n<form action=\"/jobs/delete\" method=\"post\">\n  <button type=\"submit\" name=\"button\">Clear All Jobs (not recommended)</button>\n</form>");
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
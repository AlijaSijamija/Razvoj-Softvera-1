#pragma checksum "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eea698c90e8df13d39d53c1f2ff104f7ee567e37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 2 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\_ViewImports.cshtml"
using RS1_Ispit_asp.net_core.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eea698c90e8df13d39d53c1f2ff104f7ee567e37", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0db78f4393188327d4a133dd5df580026037eaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Index";



#line default
#line hidden
            BeginContext(37, 35, true);
            WriteLiteral("\n<h2>\n    IB170108\n</h2>\n\n\n\n<br />\n");
            EndContext();
            BeginContext(73, 49, false);
#line 15 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Home\Index.cshtml"
Write(Html.ActionLink("Ajax text", "Index", "AjaxTest"));

#line default
#line hidden
            EndContext();
            BeginContext(122, 8, true);
            WriteLiteral("\n<br />\n");
            EndContext();
            BeginContext(131, 44, false);
#line 17 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Home\Index.cshtml"
Write(Html.ActionLink("DB text", "TestDB", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(175, 109, true);
            WriteLiteral("   << -- Prije nego što kliknete prepravite Connection string. Upišite vaš broj indeksa u naziv DB-a.\n<br />\n");
            EndContext();
            BeginContext(285, 58, false);
#line 19 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Home\Index.cshtml"
Write(Html.ActionLink("Takmicenje/Index", "Index", "Takmicenje"));

#line default
#line hidden
            EndContext();
            BeginContext(343, 31, true);
            WriteLiteral(" << -- Potrebno implementirati!");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

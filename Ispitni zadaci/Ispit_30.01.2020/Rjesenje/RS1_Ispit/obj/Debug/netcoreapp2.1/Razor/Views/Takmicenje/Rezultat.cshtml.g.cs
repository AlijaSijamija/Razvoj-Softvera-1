#pragma checksum "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95494c22cc4a542443dc3f6a6f211f56454643e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Takmicenje_Rezultat), @"mvc.1.0.view", @"/Views/Takmicenje/Rezultat.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Takmicenje/Rezultat.cshtml", typeof(AspNetCore.Views_Takmicenje_Rezultat))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95494c22cc4a542443dc3f6a6f211f56454643e0", @"/Views/Takmicenje/Rezultat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0db78f4393188327d4a133dd5df580026037eaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Takmicenje_Rezultat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TakmicenjeRezultatVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Zakljucaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Dodaj", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
  
    ViewData["Title"] = "Rezultat";

#line default
#line hidden
            BeginContext(75, 58, true);
            WriteLiteral("<h2>Rezultat</h2>\r\n\r\n<label>Škola domaćin:</label>\r\n<span>");
            EndContext();
            BeginContext(134, 18, false);
#line 9 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
 Write(Model.SkolaDomacin);

#line default
#line hidden
            EndContext();
            BeginContext(152, 48, true);
            WriteLiteral("</span>\r\n<br />\r\n<label>Predmet:</label>\r\n<span>");
            EndContext();
            BeginContext(201, 13, false);
#line 12 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
 Write(Model.Predmet);

#line default
#line hidden
            EndContext();
            BeginContext(214, 47, true);
            WriteLiteral("</span>\r\n<br />\r\n<label>Razred:</label>\r\n<span>");
            EndContext();
            BeginContext(262, 12, false);
#line 15 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
 Write(Model.Razred);

#line default
#line hidden
            EndContext();
            BeginContext(274, 46, true);
            WriteLiteral("</span>\r\n<br />\r\n<label>Datum:</label>\r\n<span>");
            EndContext();
            BeginContext(321, 11, false);
#line 18 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
 Write(Model.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(332, 17, true);
            WriteLiteral("</span>\r\n<br />\r\n");
            EndContext();
#line 20 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
 if (Model.Zakljucaj)
{

#line default
#line hidden
            BeginContext(375, 28, true);
            WriteLiteral("    <span>Zakljucaj</span>\r\n");
            EndContext();
#line 23 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(415, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(419, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15e32e2f733b4f1590bbb14a0ba9bceb", async() => {
                BeginContext(507, 9, true);
                WriteLiteral("Zakljucaj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tkmID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
                                                           WriteLiteral(Model.TakmicenjeID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tkmID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-tkmID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tkmID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(520, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
}

#line default
#line hidden
            BeginContext(525, 70, true);
            WriteLiteral("<br/>\r\n<div id=\"ajaxID\" style=\"border:1px solid black\"></div>\r\n<br/>\r\n");
            EndContext();
            BeginContext(595, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "969a6e4633b540f1acc0d7d520617026", async() => {
                BeginContext(683, 15, true);
                WriteLiteral("Novo takmicenje");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-skolaID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
                                                     WriteLiteral(Model.SkolaDomacinID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["skolaID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-skolaID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["skolaID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(702, 88, true);
            WriteLiteral("\r\n<br/>\r\n\r\n<script>\r\n    $(function () {\r\n        $.get(\"/Ajax/UcesniciTakmicenja?tkmID=");
            EndContext();
            BeginContext(791, 18, false);
#line 36 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Takmicenje\Rezultat.cshtml"
                                         Write(Model.TakmicenjeID);

#line default
#line hidden
            EndContext();
            BeginContext(809, 89, true);
            WriteLiteral("\", function (data) {\r\n            $(\"#ajaxID\").html(data);\r\n        })\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TakmicenjeRezultatVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
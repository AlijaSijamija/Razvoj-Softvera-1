#pragma checksum "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9422ae32a212b841be564b592c5181de8b3c81d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Takmicenje_Index), @"mvc.1.0.view", @"/Views/Takmicenje/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Takmicenje/Index.cshtml", typeof(AspNetCore.Views_Takmicenje_Index))]
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
#line 2 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\_ViewImports.cshtml"
using RS1_Ispit_asp.net_core.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9422ae32a212b841be564b592c5181de8b3c81d2", @"/Views/Takmicenje/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33d09324bd1d75a73b9b385bb78b4521d0b8c31c", @"/Views/_ViewImports.cshtml")]
    public class Views_Takmicenje_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TakmicenjeIndexVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Rezultati", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(69, 46, true);
            WriteLiteral("\r\n<h2>Prikaz takmičenja</h2>\r\n<br />\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(115, 395, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d8acb199f0646bba40e1bb7c7724957", async() => {
                BeginContext(141, 51, true);
                WriteLiteral("\r\n        <label>Filter za škole:</label>\r\n        ");
                EndContext();
                BeginContext(192, 225, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cfc24a5e9281438482c8d0b903b56eba", async() => {
                    BeginContext(264, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 14 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
             if (Model.SkolaID==0)
            {

#line default
#line hidden
                    BeginContext(317, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                    BeginContext(333, 50, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a447ad5919d4402592e865de9330e0d0", async() => {
                        BeginContext(361, 13, true);
                        WriteLiteral("Odaberi skolu");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(383, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 17 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
            }

#line default
#line hidden
                    BeginContext(400, 8, true);
                    WriteLiteral("        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 13 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SkolaID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 13 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Model.Skole;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(417, 86, true);
                WriteLiteral("\r\n        <br />\r\n        <input type=\"submit\" value=\"Odaberi\" />\r\n        <br/>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(510, 397, true);
            WriteLiteral(@"

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Škola</th>
            <th>Razred</th>
            <th>Datum</th>
            <th>Predmet</th>
            <th>
                Najbolji učesnik
                (Škola | Odjeljenje |
                Ime i prezime)
            </th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 40 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
         foreach (var x in Model.podaci)
        {

#line default
#line hidden
            BeginContext(960, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(999, 7, false);
#line 43 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
               Write(x.Skola);

#line default
#line hidden
            EndContext();
            BeginContext(1006, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1034, 8, false);
#line 44 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
               Write(x.Razred);

#line default
#line hidden
            EndContext();
            BeginContext(1042, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1070, 7, false);
#line 45 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
               Write(x.Datum);

#line default
#line hidden
            EndContext();
            BeginContext(1077, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1105, 9, false);
#line 46 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
               Write(x.Predmet);

#line default
#line hidden
            EndContext();
            BeginContext(1114, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1142, 12, false);
#line 47 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
               Write(x.NajUcesnik);

#line default
#line hidden
            EndContext();
            BeginContext(1154, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1203, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e2450a32a434cc1bae5c09facb4a956", async() => {
                BeginContext(1257, 9, true);
                WriteLiteral("Rezultati");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-TkmID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 49 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
                                                   WriteLiteral(x.takmID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TkmID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TkmID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TkmID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1270, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1325, 32, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<br />\r\n");
            EndContext();
#line 56 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
 if (Model.SkolaID != 0)
{

#line default
#line hidden
            BeginContext(1386, 30, true);
            WriteLiteral("    <a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1416, "\"", 1460, 2);
            WriteAttributeValue("", 1423, "/Takmicenje/Dodaj?skID=", 1423, 23, true);
#line 58 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
WriteAttributeValue("", 1446, Model.SkolaID, 1446, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1461, 12, true);
            WriteLiteral(">Dodaj</a>\r\n");
            EndContext();
#line 59 "C:\Users\admin\Desktop\SEPT\RS1\Ispitni zadaci\Ispit_06.07.2020\Rjesenje\RS1_Ispit\Views\Takmicenje\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TakmicenjeIndexVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

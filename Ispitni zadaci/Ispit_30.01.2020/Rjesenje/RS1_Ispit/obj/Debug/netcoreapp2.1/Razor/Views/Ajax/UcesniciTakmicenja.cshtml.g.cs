#pragma checksum "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a53949c0e90c1d95317a806df5fcb5e82263645c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ajax_UcesniciTakmicenja), @"mvc.1.0.view", @"/Views/Ajax/UcesniciTakmicenja.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ajax/UcesniciTakmicenja.cshtml", typeof(AspNetCore.Views_Ajax_UcesniciTakmicenja))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a53949c0e90c1d95317a806df5fcb5e82263645c", @"/Views/Ajax/UcesniciTakmicenja.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0db78f4393188327d4a133dd5df580026037eaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Ajax_UcesniciTakmicenja : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AjaxPrikazVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-poziv", new global::Microsoft.AspNetCore.Html.HtmlString("da"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ajax-rezultat", new global::Microsoft.AspNetCore.Html.HtmlString("ajaxID"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateBod", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Uredi", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DodajUcesnika", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
  
    ViewData["Title"] = "UcesniciTakmicenja";

#line default
#line hidden
            BeginContext(78, 311, true);
            WriteLiteral(@"<h2>UcesniciTakmicenja</h2>

<table class=""table table-bordered text-center"">
    <thead>
        <tr>
            <th>Odjeljenje</th>
            <th>Broj u dnevniku</th>
            <th>Pristupio</th>
            <th>Bodovi</th>
            <th>Akcija</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 19 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
         foreach (var x in Model.redovi)
        {

#line default
#line hidden
            BeginContext(442, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(473, 12, false);
#line 22 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
           Write(x.Odjeljenje);

#line default
#line hidden
            EndContext();
            BeginContext(485, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(509, 13, false);
#line 23 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
           Write(x.BrUDnevniku);

#line default
#line hidden
            EndContext();
            BeginContext(522, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 24 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
             if (Model.Zakljucano)
            {

#line default
#line hidden
            BeginContext(580, 44, true);
            WriteLiteral("                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 624, "\"", 704, 4);
            WriteAttributeValue("", 632, "padding:8px;", 632, 12, true);
            WriteAttributeValue(" ", 644, "color:white;", 645, 13, true);
            WriteAttributeValue(" ", 657, "background-color:", 658, 18, true);
#line 27 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
WriteAttributeValue("", 675, x.Pristupio? "green":"red", 675, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(705, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(734, 21, false);
#line 28 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                    Write(x.Pristupio?"DA":"NE");

#line default
#line hidden
            EndContext();
            BeginContext(756, 97, true);
            WriteLiteral("\r\n                    </a>\r\n                </td>\r\n                <td style=\"text-align:center\">");
            EndContext();
            BeginContext(854, 8, false);
#line 31 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                                         Write(x.Bodovi);

#line default
#line hidden
            EndContext();
            BeginContext(862, 34, true);
            WriteLiteral("</td>\r\n                <td></td>\r\n");
            EndContext();
#line 33 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(944, 42, true);
            WriteLiteral("                <td>\r\n                    ");
            EndContext();
            BeginContext(986, 325, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ae415c84a7c4450a8c843827bda3248e", async() => {
                BeginContext(1235, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1263, 21, false);
#line 40 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                    Write(x.Pristupio?"DA":"NE");

#line default
#line hidden
                EndContext();
                BeginContext(1285, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 5, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 996, "padding:8px;", 996, 12, true);
            AddHtmlAttributeValue(" ", 1008, "background-color:", 1009, 18, true);
#line 37 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
AddHtmlAttributeValue("", 1026, x.Pristupio? "green":"red", 1026, 29, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 1055, ";", 1055, 1, true);
            AddHtmlAttributeValue(" ", 1056, "color:white", 1057, 12, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#line 38 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                        WriteLiteral(x.Pristupio?"UcesnikNijePrisutpio":"UcesnikJePristupio");

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ucesnikID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                                WriteLiteral(x.TakmicenjeUcesnikID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ucesnikID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ucesnikID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ucesnikID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1311, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1378, 405, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "effe72d5d47e4024b56c839372827623", async() => {
                BeginContext(1480, 63, true);
                WriteLiteral("\r\n                        <input type=\"hidden\" name=\"ucesnikID\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1543, "\"", 1573, 1);
#line 45 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
WriteAttributeValue("", 1551, x.TakmicenjeUcesnikID, 1551, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1574, 49, true);
                WriteLiteral(" />\r\n                        <input name=\"bodovi\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1623, "\"", 1640, 1);
#line 46 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
WriteAttributeValue("", 1631, x.Bodovi, 1631, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 1641, "\"", 1675, 2);
                WriteAttributeValue("", 1646, "bodovi-", 1646, 7, true);
#line 46 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
WriteAttributeValue("", 1653, x.TakmicenjeUcesnikID, 1653, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1676, 100, true);
                WriteLiteral(" />\r\n                        <input type=\"submit\" style=\"visibility:hidden\" />\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1388, "forma-", 1388, 6, true);
#line 44 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
AddHtmlAttributeValue("", 1394, x.TakmicenjeUcesnikID, 1394, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            BeginContext(1783, 67, true);
            WriteLiteral("\r\n                    <script>\r\n                        $(\"#bodovi-");
            EndContext();
            BeginContext(1851, 21, false);
#line 50 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                              Write(x.TakmicenjeUcesnikID);

#line default
#line hidden
            EndContext();
            BeginContext(1872, 222, true);
            WriteLiteral("\").change(function () {\r\n                            $.ajax{\r\n                                type: \"POST\",\r\n                                    url: \"/Ajax/UpdateBod\",\r\n                                    data: $(\"#forma-");
            EndContext();
            BeginContext(2095, 21, false);
#line 54 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                                               Write(x.TakmicenjeUcesnikID);

#line default
#line hidden
            EndContext();
            BeginContext(2116, 131, true);
            WriteLiteral("\").serialize(),\r\n                                    success: function(data) {\r\n                                        $(\"#bodovi-");
            EndContext();
            BeginContext(2248, 21, false);
#line 56 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                                              Write(x.TakmicenjeUcesnikID);

#line default
#line hidden
            EndContext();
            BeginContext(2269, 210, true);
            WriteLiteral("\").html(data);\r\n                                    }\r\n                            }\r\n                        })\r\n                    </script>\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2479, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24e27c39e7b44f16b543f4d39ddff9a2", async() => {
                BeginContext(2610, 5, true);
                WriteLiteral("Uredi");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ucesnikID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
                                WriteLiteral(x.TakmicenjeUcesnikID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ucesnikID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ucesnikID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ucesnikID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2619, 25, true);
            WriteLiteral("\r\n                </td>\r\n");
            EndContext();
#line 66 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
            }

#line default
#line hidden
            BeginContext(2659, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 68 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
        }

#line default
#line hidden
            BeginContext(2685, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(2709, 154, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9401bdbbdc45451f9748530ba8e87bf6", async() => {
                BeginContext(2845, 14, true);
                WriteLiteral("Dodaj učesnika");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tkmID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 72 "C:\Users\admin\Desktop\SEPT\RS1\Do kraja rijeseni\Rjesenje\RS1_Ispit\Views\Ajax\UcesniciTakmicenja.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AjaxPrikazVM> Html { get; private set; }
    }
}
#pragma warning restore 1591

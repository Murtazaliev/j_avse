#pragma checksum "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e42187582e712c6e350a9f9be0bdc5b8166742d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editions_Index), @"mvc.1.0.view", @"/Views/Editions/Index.cshtml")]
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
#line 1 "F:\Проекты\AVSE\JournalAVSE\Views\_ViewImports.cshtml"
using VURO.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Проекты\AVSE\JournalAVSE\Views\_ViewImports.cshtml"
using VURO.UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e42187582e712c6e350a9f9be0bdc5b8166742d", @"/Views/Editions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    public class Views_Editions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Home/PartialHeader.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e42187582e712c6e350a9f9be0bdc5b8166742d3347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<!-- #header -->
<!-- start banner Area -->
<section class=""banner-area relative about-banner"">
    <div class=""overlay overlay-bg""></div>
    <div class=""container"">
        <div class=""row d-flex align-items-center justify-content-center"">
            <div class=""about-content col-lg-12"">

            </div>
        </div>
    </div>
</section>
<!-- End banner Area -->
<div class="" bd-primary mg-t-20"">
    <div class=""row"" style=""margin: 15px 0; padding-top:15px;"">
        <div class=""col-md-3"" style=""min-height:500px; "">
            <div class=""card-header  tx-white"">
                <div class=""row align-baseline"">
");
#nullable restore
#line 26 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                     if ( MainViewModel.Language  != "EN")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>Список выпусков</h2>\r\n");
#nullable restore
#line 29 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h2>Edition List</h2>\r\n");
#nullable restore
#line 33 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n            </div>\r\n\r\n\r\n");
#nullable restore
#line 38 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
             foreach (var item in Model.DataYearList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <fieldset class=\" p-2 mt-2 text-right\">\r\n                    <legend style=\" font-size:15px; width:40px;\">\r\n                        ");
#nullable restore
#line 42 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                   Write(item.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </legend>\r\n                    <div id=\"editions\" class=\"float-left\">\r\n");
#nullable restore
#line 46 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                         foreach (var edition in Model.DataEditionList.Where(x => x.IdYear == item.Id).OrderBy(x => x.Edition))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" class=\"genric-btn primary-border circle \" style=\"width:35px; text-align:center\" data-select-edition data-idedition=\"");
#nullable restore
#line 49 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                                                                                                                                                       Write(edition.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\r\n                                <span style=\"width:40px; text-align:center\">\r\n                                    ");
#nullable restore
#line 52 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                               Write(edition.Edition);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 53 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                                     if (@edition.AdditionalEdition != null)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <span>-");
#nullable restore
#line 55 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                                          Write(edition.AdditionalEdition);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 56 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n\r\n                            </a>\r\n");
#nullable restore
#line 61 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </fieldset>\r\n");
#nullable restore
#line 65 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n            <div id=\"articles\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<input type=\"hidden\" id=\"idedition\"");
            BeginWriteAttribute("value", " value=\"", 2428, "\"", 2454, 1);
#nullable restore
#line 74 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
WriteAttributeValue("", 2436, ViewBag.idedition, 2436, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<script>\r\n    $(document).ready(function () {\r\n        if ($(\"#idedition\").val() != \"\") {\r\n            $.ajax({\r\n                method: \"POST\",\r\n                url: \"");
#nullable restore
#line 80 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                 Write(Url.Action("Articles", "Editions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                data: { idedition: $(""#idedition"").val() },
                success: function (content) {
                    $('#articles').html(content);

                }
            });
        }
        else {
            $.ajax({
                method: ""POST"",
                url: """);
#nullable restore
#line 91 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
                 Write(Url.Action("LastArticles", "Editions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
                success: function (content) {
                    $('#articles').html(content);

                }
            });
        }
    });

    $(""[data-select-edition]"").click(function () {

        var x = document.getElementsByClassName(""active"");
        var i;
        for (i = 0; i < x.length; i++) {
            x[i].classList.add(""primary-border"");
            x[i].classList.remove(""primary"", ""active"");
        }

        $(this).removeClass(""primary-border"");
        $(this).addClass(""primary active"");
        $.ajax({
            method: ""POST"",
            url: """);
#nullable restore
#line 113 "F:\Проекты\AVSE\JournalAVSE\Views\Editions\Index.cshtml"
             Write(Url.Action("Articles", "Editions"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            data: { idedition: $(this).data(\'idedition\') },\r\n            success: function (content) {\r\n                $(\'#articles\').html(content);\r\n            }\r\n        });\r\n    });\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

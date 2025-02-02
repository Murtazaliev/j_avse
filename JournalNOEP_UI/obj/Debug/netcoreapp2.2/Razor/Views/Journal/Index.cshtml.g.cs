#pragma checksum "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "209ac5e3bac09cd9237d638fd44711dc8b70fe36"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Journal_Index), @"mvc.1.0.view", @"/Views/Journal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Journal/Index.cshtml", typeof(AspNetCore.Views_Journal_Index))]
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
#line 1 "F:\Проекты\AVSE\JournalNOEP_UI\Views\_ViewImports.cshtml"
using JournalNOEP_UI;

#line default
#line hidden
#line 2 "F:\Проекты\AVSE\JournalNOEP_UI\Views\_ViewImports.cshtml"
using JournalNOEP_UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"209ac5e3bac09cd9237d638fd44711dc8b70fe36", @"/Views/Journal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d35fa53177c7a4309be633976b2f00ed9b3987", @"/Views/_ViewImports.cshtml")]
    public class Views_Journal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 1106, true);
            WriteLiteral(@"
<div class=""sh-pagetitle-left"">
    <div class=""sh-pagetitle-icon""><i class=""icon ion-ios-book mg-t-3""></i></div>
    <div class=""sh-pagetitle-title"">
        <span>Администратор журнала</span>
        <h2>Журнал</h2>
    </div><!-- sh-pagetitle-left-title -->
</div><!-- sh-pagetitle-left -->

<div id=""modDialog"" class=""modal fade p-0""></div>
<div class=""card bd-primary mg-t-20"">
    <div class=""row"" style=""    margin: 15px 0; padding-top:15px;"">
        <div class=""col-md-3"" style=""min-height:500px; "">
            <div class=""card-header bg-primary tx-white"">
                <div class=""row align-baseline"">
                    <div class=""col-md-9 pt-2"">Список выпусков</div>
                    <div class=""col-md-3 text-right"">
                        <a href=""#"" class=""btn btn-outline-secondary btn-icon mg-r-5"" data-edit-year-click>
                            <div>
                                <i class=""fa fa-plus mg-r-1""></i>
                            </div>
                    ");
            WriteLiteral("    </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 27 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
             foreach (var item in Model.DataYearList)
            {

#line default
#line hidden
            BeginContext(1198, 154, true);
            WriteLiteral("                <fieldset class=\"border p-2 mt-2 text-right\">\r\n                    <legend style=\" font-size:15px; width:120px\">\r\n                        ");
            EndContext();
            BeginContext(1353, 9, false);
#line 31 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                   Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 60, true);
            WriteLiteral("\r\n                        <a href=\"#\" class=\"\" data-idyear=\"");
            EndContext();
            BeginContext(1423, 7, false);
#line 32 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                                                     Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1430, 185, true);
            WriteLiteral("\" data-edit-year-click>\r\n\r\n                            <i class=\"fa fa-edit p-2\"></i>\r\n\r\n                        </a>\r\n                        <a href=\"#\" class=\" mg-b-10\" data-idyear=\"");
            EndContext();
            BeginContext(1616, 7, false);
#line 37 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                                                             Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1623, 212, true);
            WriteLiteral("\" data-remove-year-click>\r\n\r\n                            <i class=\"fa fa-remove text-danger p-2\"></i>\r\n\r\n                        </a>\r\n                    </legend>\r\n                    <div class=\"float-left\">\r\n");
            EndContext();
#line 44 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                         foreach (var edition in Model.DataEditionList.Where(x => x.IdYear == item.Id).OrderBy(x=>x.Edition))
                        {

#line default
#line hidden
            BeginContext(1989, 124, true);
            WriteLiteral("                            <a href=\"#\" class=\"btn btn-outline-primary btn-icon mg-r-5\" data-select-edition data-idedition=\"");
            EndContext();
            BeginContext(2114, 10, false);
#line 46 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                                                                                                                       Write(edition.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2124, 169, true);
            WriteLiteral("\">\r\n                                <div>\r\n                                    <span>\r\n                                        \r\n                                        ");
            EndContext();
            BeginContext(2294, 15, false);
#line 50 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                                   Write(edition.Edition);

#line default
#line hidden
            EndContext();
            BeginContext(2309, 47, true);
            WriteLiteral("\r\n                                        <sup>");
            EndContext();
            BeginContext(2357, 25, false);
#line 51 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                                        Write(edition.AdditionalEdition);

#line default
#line hidden
            EndContext();
            BeginContext(2382, 165, true);
            WriteLiteral("</sup>\r\n                                    \r\n                                    </span>\r\n                                </div>\r\n                            </a>\r\n");
            EndContext();
#line 56 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2574, 106, true);
            WriteLiteral("                        <a href=\"#\" class=\"btn btn-primary btn-icon mg-r-5\" data-add-edition data-idyear=\"");
            EndContext();
            BeginContext(2681, 7, false);
#line 57 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
                                                                                                     Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2688, 229, true);
            WriteLiteral("\">\r\n                            <div>\r\n                                <i class=\"fa fa-plus mg-r-1\"></i>\r\n                            </div>\r\n                        </a>\r\n                    </div>\r\n                </fieldset>\r\n");
            EndContext();
#line 64 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2932, 174, true);
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n            <div id=\"articles\">\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<input type=\"hidden\" id=\"idedition\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3106, "\"", 3132, 1);
#line 73 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
WriteAttributeValue("", 3114, ViewBag.idedition, 3114, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3133, 166, true);
            WriteLiteral(" />\r\n<script>\r\n    $(document).ready(function () {\r\n        if ($(\"#idedition\").val() != \"\") {\r\n            $.ajax({\r\n            method: \"POST\",\r\n             url: \"");
            EndContext();
            BeginContext(3300, 32, false);
#line 79 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
              Write(Url.Action("Edition", "Journal"));

#line default
#line hidden
            EndContext();
            BeginContext(3332, 335, true);
            WriteLiteral(@""",
             data: { idedition: $(""#idedition"").val() },
                         success: function (content) {
                $('#articles').html(content);

            }
        });
        }
    });
    $(""[data-edit-year-click]"").click(function () {
         $.ajax({
            method: ""POST"",
             url: """);
            EndContext();
            BeginContext(3668, 40, false);
#line 91 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
              Write(Url.Action("PartialEditYear", "Journal"));

#line default
#line hidden
            EndContext();
            BeginContext(3708, 366, true);
            WriteLiteral(@""",
             data: { Id: $(this).data('idyear') },
                         success: function (content) {
                $('#modDialog').html(content);
                $('#modDialog').modal('show');
            }
        });
    })
    $(""[data-remove-year-click]"").click(function () {
         $.ajax({
            method: ""POST"",
             url: """);
            EndContext();
            BeginContext(4075, 42, false);
#line 102 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
              Write(Url.Action("PartialRemoveYear", "Journal"));

#line default
#line hidden
            EndContext();
            BeginContext(4117, 360, true);
            WriteLiteral(@""",
             data: { Id: $(this).data('idyear') },
                         success: function (content) {
                $('#modDialog').html(content);
                $('#modDialog').modal('show');
            }
        });
    })
    $(""[data-add-edition]"").click(function () {
         $.ajax({
            method: ""POST"",
             url: """);
            EndContext();
            BeginContext(4478, 43, false);
#line 113 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
              Write(Url.Action("PartialEditEdition", "Journal"));

#line default
#line hidden
            EndContext();
            BeginContext(4521, 367, true);
            WriteLiteral(@""",
             data: { IdYear: $(this).data('idyear') },
                         success: function (content) {
                $('#modDialog').html(content);
                $('#modDialog').modal('show');
            }
        });
    })
    $(""[data-select-edition]"").click(function () {
         $.ajax({
            method: ""POST"",
             url: """);
            EndContext();
            BeginContext(4889, 32, false);
#line 124 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Index.cshtml"
              Write(Url.Action("Edition", "Journal"));

#line default
#line hidden
            EndContext();
            BeginContext(4921, 218, true);
            WriteLiteral("\",\r\n             data: { idedition: $(this).data(\'idedition\') },\r\n                         success: function (content) {\r\n                $(\'#articles\').html(content);\r\n\r\n            }\r\n        });\r\n    })\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

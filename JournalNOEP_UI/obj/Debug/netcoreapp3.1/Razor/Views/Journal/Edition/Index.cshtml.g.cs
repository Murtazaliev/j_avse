#pragma checksum "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33f788d08f977dae5554d26bec2bde85a6a1e64a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Journal_Edition_Index), @"mvc.1.0.view", @"/Views/Journal/Edition/Index.cshtml")]
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
#line 1 "F:\Проекты\AVSE\JournalNOEP_UI\Views\_ViewImports.cshtml"
using JournalNOEP_UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Проекты\AVSE\JournalNOEP_UI\Views\_ViewImports.cshtml"
using JournalNOEP_UI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f788d08f977dae5554d26bec2bde85a6a1e64a", @"/Views/Journal/Edition/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d35fa53177c7a4309be633976b2f00ed9b3987", @"/Views/_ViewImports.cshtml")]
    public class Views_Journal_Edition_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JournalNOEP_DOMAIN.Articles>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div id=\"modDialogArticle\" class=\"modal fade p-0\"></div>\r\n");
#nullable restore
#line 5 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
   int i = 0; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card border-secondary mg-t-100\">\r\n    <div class=\"card-header bg-primary tx-white\" style=\"margin-top:-100px\">\r\n        <div class=\"row align-baseline\">\r\n            <div class=\"col-md-9 pt-2\">\r\n                Выпуск №");
#nullable restore
#line 10 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                   Write(ViewBag.EditionNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                           Write(ViewBag.EditionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(" г.\r\n");
#nullable restore
#line 11 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                 if (ViewBag.DateLastArticle != null && ViewBag.DateLastArticle != "")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <small> (Дата послендего приема статей : <b>");
#nullable restore
#line 13 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                           Write(ViewBag.DateLastArticle);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</b> </small>\r\n");
#nullable restore
#line 14 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"#\" data-idedition=\"");
#nullable restore
#line 15 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                       Write(ViewBag.IdEdition);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#dialogContent\" data-edit-edition>\r\n                    <i class=\"fa fa-edit p-2 text-secondary\"></i>\r\n                </a>\r\n\r\n                <a href=\"#\" data-idedition=\"");
#nullable restore
#line 19 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                       Write(ViewBag.IdEdition);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-toggle=""modal"" data-target=""#dialogContent"" data-remove-edition>
                    <i class=""fa fa-remove text-danger p-2""></i>
                </a>

            </div>
            
            <div class=""col-md-3 text-right"">
                <a href=""#"" class=""btn btn-outline-secondary"" data-toggle=""modal"" data-target=""#dialogContent"" data-idedition=""");
#nullable restore
#line 26 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                                                                                          Write(ViewBag.IdEdition);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-edit-article>
                    <i class=""fa fa-plus mg-r-10""></i>
                    Добавить
                </a>
            </div>
        </div>
    </div>
    <div class=""card-body"">
        <div class=""table-wrapper"">
            <div class=""row mg-t-20  btn input-group p-0"" style=""margin-bottom:-15px;"">
                <div class=""col-md-12 input-group p-2 pd-b-0 align-baseline"">
                    <i class=""fa fa-2x fa-file-pdf-o pd-b-0""></i>
                    <h3 class="" pd-b-0"">PDF</h3>
");
#nullable restore
#line 39 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                      if (ViewBag.EditionFile == null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" data-idedition=\"");
#nullable restore
#line 41 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                   Write(ViewBag.IdEdition);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn-outline-primary btn-icon btn-sm p-0 mg-l-5"" data-toggle=""modal"" data-target=""#dialogContent"" data-edit-edition-file>
                                <div>
                                    <i class=""fa fa-plus""></i>
                                </div>
                            </a>
");
#nullable restore
#line 46 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a href=\"#\" data-idedition=\"");
#nullable restore
#line 49 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                   Write(ViewBag.IdEdition);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn-outline-warning btn-icon btn-sm p-0 mg-l-5"" data-toggle=""modal"" data-target=""#dialogContent"" data-show-edition-file>
                                <div>
                                    <i class=""fa fa-window-restore""></i>
                                </div>
                            </a>
                            <a href=""#"" data-idedition=""");
#nullable restore
#line 54 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                   Write(ViewBag.IdEdition);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn-outline-primary btn-icon btn-sm p-0 mg-l-5"" data-toggle=""modal"" data-target=""#dialogContent"" data-edit-edition-file>
                                <div>
                                    <i class=""fa fa-edit""></i>
                                </div>
                            </a>
                            <a href=""#"" data-idedition=""");
#nullable restore
#line 59 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                   Write(ViewBag.IdEdition);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn-outline-danger btn-icon btn-sm p-0 mg-l-5"" data-toggle=""modal"" data-target=""#dialogContent"" data-remove-edition-file>
                                <div>
                                    <i class=""fa fa-remove""></i>
                                </div>
                            </a>
");
#nullable restore
#line 64 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                </div>
            <hr />
                <table id=""datatable1"" class=""table display responsive mg-t-10"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>УДК</th>
                            <th>Название</th>
                            <th>Действия</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 79 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr class=\"gradeX\">\r\n                                <td>\r\n                                    ");
#nullable restore
#line 83 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                Write(i = i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    <b>\r\n                                        UDK:");
#nullable restore
#line 87 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                       Write(item.ArtUdk);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </b>\r\n                                </td>\r\n                                <td>\r\n                                    ");
#nullable restore
#line 91 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                               Write(item.ArtName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    <br /> \r\n                                    <ion-icon name=\"person\"></ion-icon>\r\n");
#nullable restore
#line 94 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                     foreach (var author in @item.DataArticleAuthors.OrderBy(x=>x.AuthorPos))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i style=\"font-size:12px;\">");
#nullable restore
#line 96 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                              Write(author.Author.AuthFio);

#line default
#line hidden
#nullable disable
            WriteLiteral("; </i>\r\n");
#nullable restore
#line 97 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </td>\r\n                                <td style=\"width:205px\">\r\n                                    <a href=\"#\" class=\"btn btn-outline-dark btn-icon mg-r-5\" placeholder=\"XML\" data-idarticle=\"");
#nullable restore
#line 100 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-edit-article-xml >
                                        <div>
                                            <i class=""ionicons ion-ios-paper-outline""></i>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""btn btn-outline-secondary btn-icon mg-r-5"" placeholder=""PDF"" data-idarticle=""");
#nullable restore
#line 105 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                                                                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-edit-article-file>
                                        <div>
                                            <i class=""icon ion-document-text""></i>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""btn btn-outline-primary btn-icon mg-r-5"" data-idarticle=""");
#nullable restore
#line 110 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                                                                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-idedition=\"");
#nullable restore
#line 110 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                                                                                                     Write(item.EditionId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" data-edit-article>
                                        <div>
                                            <i class=""icon ion-edit""></i>
                                        </div>
                                    </a>
                                    <a href=""#"" class=""btn btn-outline-danger btn-icon mg-r-5"" data-remove-article data-idarticle=""");
#nullable restore
#line 115 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                                                                                                                              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                        <div>
                                            <i class=""icon ion-trash-a""></i>
                                        </div>
                                    </a>

                                </td>
                            </tr>
");
#nullable restore
#line 123 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n    </div>\r\n</div>\r\n<script>\r\n\r\n    $(\'[data-edit-edition]\').click(function () {\r\n        $.ajax({\r\n            method: \"POST\",\r\n             url: \"");
#nullable restore
#line 134 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
              Write(Url.Action("PartialEditEdition", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { IdEdition: $(this).data('idedition') },

            success: function (content) {
                $('#modDialogArticle').html(content);
                $('#modDialogArticle').modal('show');
            }
        });
    });
    $('[data-remove-edition]').click(function () {
        $.ajax({
            method: ""POST"",
             url: """);
#nullable restore
#line 146 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
              Write(Url.Action("PartialRemoveEdition", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { IdEdition: $(this).data('idedition') },

            success: function (content) {
                $('#modDialogArticle').html(content);
                $('#modDialogArticle').modal('show');
            }
        });
    });
    $('[data-edit-article]').click(function () {
        $.ajax({
            method: ""POST"",
            url: """);
#nullable restore
#line 158 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
             Write(Url.Action("PartialEditArticle", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { Id: $(this).data('idarticle'), IdEdition: $(this).data('idedition') },
            success: function (content) {
                $('#modDialogArticle').html(content);
                $('#modDialogArticle').modal('show');
            }
        });
    });
    $('[data-edit-article-xml]').click(function () {
        $.ajax({
            method: ""POST"",
             url: """);
#nullable restore
#line 169 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
              Write(Url.Action("PartialEditArticleFileXml", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { Id: $(this).data('idarticle') },

            success: function (content) {
                $('#modDialogArticle').html(content);
                $('#modDialogArticle').modal('show');
            }
        });
    });
    $('[data-edit-article-file]').click(function () {
        $.ajax({
            method: ""POST"",
             url: """);
#nullable restore
#line 181 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
              Write(Url.Action("PartialEditArticleFile", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { Id: $(this).data('idarticle') },

            success: function (content) {
                $('#modDialogArticle').html(content);
                $('#modDialogArticle').modal('show');
            }
        });
    });
    $('[ data-edit-edition-file]').click(function () {
        $.ajax({
            method: ""POST"",
             url: """);
#nullable restore
#line 193 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
              Write(Url.Action("PartialEditEditionFile", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { Id: $(this).data('idedition') },

            success: function (content) {
                $('#modDialogArticle').html(content);
                $('#modDialogArticle').modal('show');
            }
        });
    });
    $('[data-show-edition-file]').click(function () {
        $.ajax({
            method: ""POST"",
             url: """);
#nullable restore
#line 205 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
              Write(Url.Action("PartialShowFiles", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { id: $(this).data('idedition') },

            success: function (content) {
                $('#modDialogArticle').html(content);
                $('#modDialogArticle').modal('show');
            }
        });
    });
    $('[data-remove-edition-file]').click(function () {
        $.ajax({
            method: ""POST"",
             url: """);
#nullable restore
#line 217 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
              Write(Url.Action("PartialRemoveEditionFile", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            data: { id: $(this).data('idedition') },

            success: function (content) {
                $('#modDialogArticle').html(content);
                $('#modDialogArticle').modal('show');
            }
        });
    });
            $('[data-remove-article]').click(function (e) {
            $.ajax({
                method: ""POST"",
                url: """);
#nullable restore
#line 229 "F:\Проекты\AVSE\JournalNOEP_UI\Views\Journal\Edition\Index.cshtml"
                 Write(Url.Action("PartialRemoveArticle", "Journal"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n                data: { Id : $(this).data(\'idarticle\') },\r\n            success: function (content) {\r\n                $(\'#modDialog\').html(content);\r\n                $(\'#modDialog\').modal(\'show\');\r\n            }\r\n        });\r\n    });\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JournalNOEP_DOMAIN.Articles>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "373b929d942a7b21ec87427b715e9c197de8a2b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editions_Edition_PartialArticleAnnotation), @"mvc.1.0.view", @"/Views/Editions/Edition/PartialArticleAnnotation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Editions/Edition/PartialArticleAnnotation.cshtml", typeof(AspNetCore.Views_Editions_Edition_PartialArticleAnnotation))]
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
#line 1 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\_ViewImports.cshtml"
using JournalNEOP;

#line default
#line hidden
#line 2 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\_ViewImports.cshtml"
using JournalNEOP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373b929d942a7b21ec87427b715e9c197de8a2b4", @"/Views/Editions/Edition/PartialArticleAnnotation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b5c2bfa5ef64e4106d9981fefd3fb6e4517879", @"/Views/_ViewImports.cshtml")]
    public class Views_Editions_Edition_PartialArticleAnnotation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(23, 122, true);
            WriteLiteral("<div class=\"modal-header\"></div>\r\n<div class=\"modal-body\">\r\n    <div style=\"height:340px; overflow-y:auto;\">\r\n        <h3>");
            EndContext();
            BeginContext(146, 21, false);
#line 5 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
       Write(Model.Article.ArtName);

#line default
#line hidden
            EndContext();
            BeginContext(167, 22, true);
            WriteLiteral("</h3>\r\n\r\n        <i>\r\n");
            EndContext();
#line 8 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
             foreach (var item in Model.DataArticleAuthorsList)
            {
                

#line default
#line hidden
            BeginContext(286, 19, false);
#line 10 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
           Write(item.Author.AuthFio);

#line default
#line hidden
            EndContext();
#line 10 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
                                    ;
            }

#line default
#line hidden
            BeginContext(323, 54, true);
            WriteLiteral("        </i>\r\n        <div class=\"mt-2\">\r\n            ");
            EndContext();
            BeginContext(378, 27, false);
#line 14 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
       Write(Model.Article.ArtAnnotation);

#line default
#line hidden
            EndContext();
            BeginContext(405, 47, true);
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <i>\r\n");
            EndContext();
#line 18 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
             if (Model.Article.ArtKeywordsEng.Length > 1)
            {

#line default
#line hidden
            BeginContext(526, 41, true);
            WriteLiteral("                <span>   Ключевые слова: ");
            EndContext();
            BeginContext(568, 25, false);
#line 20 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
                                    Write(Model.Article.ArtKeywords);

#line default
#line hidden
            EndContext();
            BeginContext(593, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 21 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
            }

#line default
#line hidden
            BeginContext(617, 44, true);
            WriteLiteral("        </i>\r\n\r\n\r\n        <h4 class=\"mt-20\">");
            EndContext();
            BeginContext(662, 24, false);
#line 25 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
                     Write(Model.Article.ArtNameEng);

#line default
#line hidden
            EndContext();
            BeginContext(686, 22, true);
            WriteLiteral("</h4>\r\n\r\n        <i>\r\n");
            EndContext();
#line 28 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
             foreach (var item in Model.DataArticleAuthorsList)
            {
                

#line default
#line hidden
            BeginContext(805, 22, false);
#line 30 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
           Write(item.Author.AuthFioEng);

#line default
#line hidden
            EndContext();
#line 30 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
                                       ;
            }

#line default
#line hidden
            BeginContext(845, 54, true);
            WriteLiteral("        </i>\r\n        <div class=\"mt-2\">\r\n            ");
            EndContext();
            BeginContext(900, 30, false);
#line 34 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
       Write(Model.Article.ArtAnnotationEng);

#line default
#line hidden
            EndContext();
            BeginContext(930, 47, true);
            WriteLiteral("\r\n        </div>\r\n        <br />\r\n        <i>\r\n");
            EndContext();
#line 38 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
             if (Model.Article.ArtKeywordsEng.Length > 1)
            {

#line default
#line hidden
            BeginContext(1051, 35, true);
            WriteLiteral("                <span>   Keywords: ");
            EndContext();
            BeginContext(1087, 28, false);
#line 40 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
                              Write(Model.Article.ArtKeywordsEng);

#line default
#line hidden
            EndContext();
            BeginContext(1115, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 41 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
            }

#line default
#line hidden
            BeginContext(1139, 84, true);
            WriteLiteral("        </i>\r\n    </div>\r\n</div>\r\n<div class=\"modal-footer\">\r\n    <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1223, "\"", 1292, 2);
            WriteAttributeValue("", 1230, "http://admin.noep.ru/Files/ArticleFiles/", 1230, 40, true);
#line 46 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\PartialArticleAnnotation.cshtml"
WriteAttributeValue("", 1270, Model.Article.ArtFile, 1270, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1293, 79, true);
            WriteLiteral("> Открыть файл <i class=\"fa fa-file-pdf-o pd-b-0 float-left\"></i></a>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

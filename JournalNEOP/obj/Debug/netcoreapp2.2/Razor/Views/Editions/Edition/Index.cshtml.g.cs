#pragma checksum "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "910ea8816e10aced46cbca17f840e0762c07528b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Editions_Edition_Index), @"mvc.1.0.view", @"/Views/Editions/Edition/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Editions/Edition/Index.cshtml", typeof(AspNetCore.Views_Editions_Edition_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"910ea8816e10aced46cbca17f840e0762c07528b", @"/Views/Editions/Edition/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b5c2bfa5ef64e4106d9981fefd3fb6e4517879", @"/Views/_ViewImports.cshtml")]
    public class Views_Editions_Edition_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JournalNOEP_DOMAIN.Articles>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 908, true);
            WriteLiteral(@"
<style>
    body {
        padding: 0;
        margin: 0;
    }

    span {
        cursor: pointer
    }

    .modal {
        position: fixed;
        width: 800px;
        top: -100%;
        padding: 20px;
        background: #fff;
        border: 1px solid #333;
        z-index: 9999;
        transition: all 0.5s ease-in;

    }

    .overflow {
        width: 100%;
        height: 100%;
        z-index: 9998;
        background: rgba(0,0,0,0.7);
        position: fixed;
        min-height: 1080px;
        top: 0;
    }

    .gradeX {
        cursor: pointer;
    }
    .myClass:hover {
    background-color:#f3f3f3;
    }
</style>




<div class=""modal"">

</div>


<div class=""  mg-t-90"">

    <div class="" tx-white"">
        <div class=""row align-baseline"" style=""height:50px; padding-bottom:5px; "">
            <div class=""col-md-9 pt-4"">
");
            EndContext();
#line 56 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                 if (MainViewModel.Language != "EN")
                {

#line default
#line hidden
            BeginContext(1030, 34, true);
            WriteLiteral("                    <h3>  Выпуск №");
            EndContext();
            BeginContext(1065, 21, false);
#line 58 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                             Write(ViewBag.EditionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1086, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1089, 19, false);
#line 58 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                     Write(ViewBag.EditionYear);

#line default
#line hidden
            EndContext();
            BeginContext(1108, 11, true);
            WriteLiteral(" г. </h3>\r\n");
            EndContext();
#line 59 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1179, 35, true);
            WriteLiteral("                    <h3>  Edition №");
            EndContext();
            BeginContext(1215, 21, false);
#line 62 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                              Write(ViewBag.EditionNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1236, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1239, 19, false);
#line 62 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                      Write(ViewBag.EditionYear);

#line default
#line hidden
            EndContext();
            BeginContext(1258, 11, true);
            WriteLiteral(" y. </h3>\r\n");
            EndContext();
#line 63 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1288, 61, true);
            WriteLiteral("            </div>\r\n            <div class=\"col-md-3 pt-2\">\r\n");
            EndContext();
#line 66 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                  if (ViewBag.EditionFile != null)
                    {

#line default
#line hidden
            BeginContext(1424, 50, true);
            WriteLiteral("                                <a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1474, "\"", 1541, 2);
            WriteAttributeValue("", 1481, "http://admin.noep.ru/Files/EditionFiles/", 1481, 40, true);
#line 68 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
WriteAttributeValue("", 1521, ViewBag.EditionFile, 1521, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1542, 139, true);
            WriteLiteral(" style=\" text-align:center; float:right\"\r\n                                   class=\"genric-btn primary circle arrow pl-3 pr-3 pt-2 pb-2\">\r\n");
            EndContext();
#line 70 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                     if (MainViewModel.Language != "EN")
                                    {

#line default
#line hidden
            BeginContext(1794, 62, true);
            WriteLiteral("                                        <p> Весь выпуск </p>\r\n");
            EndContext();
#line 73 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(1976, 148, true);
            WriteLiteral("                                        <p>\r\n                                            All edition\r\n                                        </p>\r\n");
            EndContext();
#line 79 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2163, 243, true);
            WriteLiteral("                                    <i class=\"fa fa-file-pdf-o pd-b-0 float-left\"></i>\r\n                                    <span class=\"lnr lnr-arrow-right\">\r\n                                    </span>\r\n                                </a>\r\n");
            EndContext();
#line 84 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                    }

                

#line default
#line hidden
            BeginContext(2450, 416, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
    <div id=""art"" class=""row"">





        <!-- Start menu-list Area -->
        <section class="" section-gap""  style=""width:98%"">
            <div class="""">
                <div class=""row pb-0""  style=""margin-top:-40px"">
                    <div class=""menu-cat mx-auto"">
                        <ul class=""nav nav-pills"" id=""pills-tab"" role=""tablist"">
");
            EndContext();
#line 102 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                               Guid sectId = Guid.Empty; 

#line default
#line hidden
            BeginContext(2926, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 103 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                             foreach (var sect in Model.OrderBy(x => x.Section.SectionPos))
                            {
                                if (sect.SectionId != sectId)
                                {
                                    if (sect.SectionId.ToString() == "7f20d361-afac-48ee-93d7-99bf4521021b")
                                    {

#line default
#line hidden
            BeginContext(3297, 167, true);
            WriteLiteral("                                        <li class=\"nav-item\">\r\n                                            <a class=\"nav-link active\" id=\"pizza-tab\" data-toggle=\"pill\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3464, "\"", 3487, 2);
            WriteAttributeValue("", 3471, "#", 3471, 1, true);
#line 110 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
WriteAttributeValue("", 3472, sect.SectionId, 3472, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3488, 57, true);
            WriteLiteral(" role=\"tab\" aria-controls=\"pizza\" aria-selected=\"true\">\r\n");
            EndContext();
#line 111 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                 if ( MainViewModel.Language  != "EN")
                                                {

#line default
#line hidden
            BeginContext(3684, 105, true);
            WriteLiteral("                                                <p>\r\n                                                    ");
            EndContext();
            BeginContext(3790, 24, false);
#line 114 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                               Write(sect.Section.SectionName);

#line default
#line hidden
            EndContext();
            BeginContext(3814, 56, true);
            WriteLiteral("\r\n                                                </p>\r\n");
            EndContext();
#line 116 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(4026, 105, true);
            WriteLiteral("                                                <p>\r\n                                                    ");
            EndContext();
            BeginContext(4132, 27, false);
#line 120 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                               Write(sect.Section.SectionNameEng);

#line default
#line hidden
            EndContext();
            BeginContext(4159, 56, true);
            WriteLiteral("\r\n                                                </p>\r\n");
            EndContext();
#line 122 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(4266, 97, true);
            WriteLiteral("                                            </a>\r\n                                        </li>\r\n");
            EndContext();
#line 125 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(4483, 166, true);
            WriteLiteral("                                        <li class=\"nav-item\">\r\n                                            <a class=\"nav-link\" id=\"pills-bread-tab\" data-toggle=\"pill\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4649, "\"", 4672, 2);
            WriteAttributeValue("", 4656, "#", 4656, 1, true);
#line 129 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
WriteAttributeValue("", 4657, sect.SectionId, 4657, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4673, 66, true);
            WriteLiteral(" role=\"tab\" aria-controls=\"pills-bread\" aria-selected=\"false\">\r\n\r\n");
            EndContext();
#line 131 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                 if ( MainViewModel.Language  != "EN")
                                                {

#line default
#line hidden
            BeginContext(4878, 105, true);
            WriteLiteral("                                                <p>\r\n                                                    ");
            EndContext();
            BeginContext(4984, 24, false);
#line 134 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                               Write(sect.Section.SectionName);

#line default
#line hidden
            EndContext();
            BeginContext(5008, 56, true);
            WriteLiteral("\r\n                                                </p>\r\n");
            EndContext();
#line 136 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(5220, 105, true);
            WriteLiteral("                                                <p>\r\n                                                    ");
            EndContext();
            BeginContext(5326, 27, false);
#line 140 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                               Write(sect.Section.SectionNameEng);

#line default
#line hidden
            EndContext();
            BeginContext(5353, 56, true);
            WriteLiteral("\r\n                                                </p>\r\n");
            EndContext();
#line 142 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                }

#line default
#line hidden
            BeginContext(5460, 99, true);
            WriteLiteral("\r\n                                            </a>\r\n                                        </li>\r\n");
            EndContext();
#line 146 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                    }
                                    sectId = sect.SectionId;
                                }
                            }

#line default
#line hidden
            BeginContext(5726, 230, true);
            WriteLiteral("                        </ul>\r\n                        <hr />\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div id=\"pills-tabContent\" class=\"tab-content absolute\" style=\"width:100%; margin-top:-80px\">\r\n");
            EndContext();
#line 157 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                     foreach (var sect in Model.GroupBy(x => x.SectionId))
                    {


#line default
#line hidden
            BeginContext(6057, 58, true);
            WriteLiteral("                    <div class=\"tab-pane fade show active\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 6115, "\"", 6129, 1);
#line 160 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
WriteAttributeValue("", 6120, sect.Key, 6120, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6130, 69, true);
            WriteLiteral(" role=\"tabpanel\" style=\"width:100%;\" aria-labelledby=\"pizza-tab\">\r\n\r\n");
            EndContext();
#line 162 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                         foreach (var item in Model.OrderBy(x => x.ArtPos))
                            {
                                if (item.SectionId == sect.Key)
                                {
                        

#line default
#line hidden
#line 166 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                         if ( MainViewModel.Language  != "EN")
                        {

#line default
#line hidden
            BeginContext(6496, 133, true);
            WriteLiteral("<div class=\"single-menu-list row justify-content-between align-items-center myClass\" style=\"cursor:pointer; width:100%;\" data-artid=\"");
            EndContext();
            BeginContext(6630, 7, false);
#line 167 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                                                                                                                         Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(6637, 98, true);
            WriteLiteral("\">\r\n                            <div class=\"col-lg-12\">\r\n                                <h6>УДК: ");
            EndContext();
            BeginContext(6736, 11, false);
#line 169 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                    Write(item.ArtUdk);

#line default
#line hidden
            EndContext();
            BeginContext(6747, 121, true);
            WriteLiteral("</h6>\r\n\r\n                                <span class=\"fz-18\" style=\"color:#d1ab7f\">\r\n                                    ");
            EndContext();
            BeginContext(6869, 12, false);
#line 172 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                               Write(item.ArtName);

#line default
#line hidden
            EndContext();
            BeginContext(6881, 126, true);
            WriteLiteral("\r\n                                </span><br />\r\n                                <div style=\"width:100%; text-align:right;\">\r\n");
            EndContext();
#line 175 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                     foreach (var author in item.DataArticleAuthors.OrderBy(x => x.AuthorPos))
                                        {

#line default
#line hidden
            BeginContext(7162, 45, true);
            WriteLiteral("                                    <i><span>");
            EndContext();
            BeginContext(7208, 21, false);
#line 177 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                        Write(author.Author.AuthFio);

#line default
#line hidden
            EndContext();
            BeginContext(7229, 14, true);
            WriteLiteral(";</span></i>\r\n");
            EndContext();
#line 178 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                        }

#line default
#line hidden
            BeginContext(7286, 108, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 182 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                        }
                        else
                        {
                            if (item.ArtNameEng != null && item.ArtNameEng.Length > 3)
                            {

#line default
#line hidden
            BeginContext(7595, 133, true);
            WriteLiteral("<div class=\"single-menu-list row justify-content-between align-items-center myClass\" style=\"cursor:pointer; width:100%;\" data-artid=\"");
            EndContext();
            BeginContext(7729, 7, false);
#line 186 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                                                                                                                                             Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(7736, 98, true);
            WriteLiteral("\">\r\n                            <div class=\"col-lg-12\">\r\n                                <h6>UDK: ");
            EndContext();
            BeginContext(7835, 11, false);
#line 188 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                    Write(item.ArtUdk);

#line default
#line hidden
            EndContext();
            BeginContext(7846, 121, true);
            WriteLiteral("</h6>\r\n\r\n                                <span class=\"fz-18\" style=\"color:#d1ab7f\">\r\n                                    ");
            EndContext();
            BeginContext(7968, 15, false);
#line 191 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                               Write(item.ArtNameEng);

#line default
#line hidden
            EndContext();
            BeginContext(7983, 126, true);
            WriteLiteral("\r\n                                </span><br />\r\n                                <div style=\"width:100%; text-align:right;\">\r\n");
            EndContext();
#line 194 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                     foreach (var author in item.DataArticleAuthors.OrderBy(x => x.AuthorPos))
                                            {

#line default
#line hidden
            BeginContext(8268, 45, true);
            WriteLiteral("                                    <i><span>");
            EndContext();
            BeginContext(8314, 24, false);
#line 196 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                        Write(author.Author.AuthFioEng);

#line default
#line hidden
            EndContext();
            BeginContext(8338, 14, true);
            WriteLiteral(";</span></i>\r\n");
            EndContext();
#line 197 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(8399, 108, true);
            WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n");
            EndContext();
#line 201 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                            }
                        }

#line default
#line hidden
#line 202 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                         
                                }
                            }

#line default
#line hidden
            BeginContext(8631, 30, true);
            WriteLiteral("\r\n                    </div>\r\n");
            EndContext();
#line 207 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(8684, 774, true);
            WriteLiteral(@"                </div>
                </div>
        </section>
        <!-- End menu-list Area -->

    </div>
</div>
<script>




    var modal = document.querySelector('.modal');
    var overflow = document.createElement('div');

    $('[data-artid]').click(function openWin() {
        overflow.className = ""overflow"";
        document.body.appendChild(overflow);
        var articleId = $(this).data('artid');
        console.log(articleId);
        var height = modal.offsetHeight;
        modal.style.marginTop = - height / 2 + ""px"";
        modal.style.top = ""100px"";
        modal.style.margin = ""0 auto"";
        $.ajax
            ({
                type: ""POST"",
                data: { articleId: articleId },
                url: '");
            EndContext();
            BeginContext(9459, 47, false);
#line 236 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Editions\Edition\Index.cshtml"
                 Write(Url.Action("PartialAnnotationView", "Editions"));

#line default
#line hidden
            EndContext();
            BeginContext(9506, 546, true);
            WriteLiteral(@"',
                success: function (data) {
                    $('.modal').html(data);
                    $('.modal').show();
                }
            });
    });



    if (!Element.prototype.remove) {
        Element.prototype.remove = function remove() {
            if (this.parentNode) {
                this.parentNode.removeChild(this);
            }
        };
    }

    overflow.onclick = function () {
        modal.style.top = ""-100%"";
        overflow.remove();
        $('.modal').hide();
}
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JournalNOEP_DOMAIN.Articles>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6046585244573e34aee5d59d35b80941b6393b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authors_Index), @"mvc.1.0.view", @"/Views/Authors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Authors/Index.cshtml", typeof(AspNetCore.Views_Authors_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6046585244573e34aee5d59d35b80941b6393b9", @"/Views/Authors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52b5c2bfa5ef64e4106d9981fefd3fb6e4517879", @"/Views/_ViewImports.cshtml")]
    public class Views_Authors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables/jquery.dataTables.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/plugins/datatables/jquery.dataTables.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Home/PartialHeader.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 92, true);
            WriteLiteral("\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n");
            EndContext();
            BeginContext(114, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6046585244573e34aee5d59d35b80941b6393b94866", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(189, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(193, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6046585244573e34aee5d59d35b80941b6393b96122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(258, 769, true);
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
        max-height:600px;
    }

    .overflow {
        width: 100%;
        height: 100%;
        z-index: 1000;
        background: rgba(0,0,0,0.7);
        position: fixed;
        min-height: 1080px;
        top: 0;
    }

    .gradeX {
        cursor: pointer;
    }

    .myClass:hover {
        background-color: #f3f3f3;
    }
    .dataTables_filter input { width: 500px }

</style>

");
            EndContext();
            BeginContext(1027, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6046585244573e34aee5d59d35b80941b6393b98068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1079, 389, true);
            WriteLiteral(@"
<!-- #header -->
<!-- start banner Area -->
<section class=""banner-area relative about-banner"">
    <div class=""overlay overlay-bg""></div>

    <div class=""d-flex align-items-center justify-content-center"">
        <div class=""about-content col-lg-12"">

        </div>
    </div>

</section>
<div class=""modal"">

</div>
<div class=""container"" style=""margin-top:50PX;"">

");
            EndContext();
            BeginContext(1601, 453, true);
            WriteLiteral(@"


    <table id=""tableAuthors"" class=""table-hover row"">
        <thead>
            <tr style=""height:0px; width:0px; border:none;"">
                <th style=""height:0px; width:0px; border:none;""></th>
                <th style=""height:0px; width:0px; border:none;""></th>
                <th style=""height:0px; width:0px; border:none;""></th>
            </tr>
        </thead>
        <tbody id=""myTable"" style=""border:none; width:100%;"">
");
            EndContext();
#line 82 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
             foreach (var item in Model.ArticleList)
            {


#line default
#line hidden
            BeginContext(2125, 143, true);
            WriteLiteral("                <tr class=\"single-menu-list col-12 row justify-content-between align-items-center myClass\" style=\"cursor:pointer;\" data-artid=\"");
            EndContext();
            BeginContext(2269, 7, false);
#line 85 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                                                                                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2276, 49, true);
            WriteLiteral("\">\r\n                    <td class=\"col-md-8\">\r\n\r\n");
            EndContext();
#line 88 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                         if (MainViewModel.Language != "EN")
                        {


#line default
#line hidden
            BeginContext(2416, 37, true);
            WriteLiteral("                            <h6>УДК: ");
            EndContext();
            BeginContext(2454, 11, false);
#line 91 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                Write(item.ArtUdk);

#line default
#line hidden
            EndContext();
            BeginContext(2465, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
            BeginContext(2474, 101, true);
            WriteLiteral("                            <p class=\"fz-18\" style=\"color:#d1ab7f\">\r\n                                ");
            EndContext();
            BeginContext(2576, 12, false);
#line 94 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                           Write(item.ArtName);

#line default
#line hidden
            EndContext();
            BeginContext(2588, 127, true);
            WriteLiteral("\r\n                            </p><br />\r\n                            <div style=\"width:100%; text-align:right; float:right\">\r\n");
            EndContext();
#line 97 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                 foreach (var author in item.DataArticleAuthors.OrderBy(x => x.AuthorPos))
                                {

#line default
#line hidden
            BeginContext(2858, 45, true);
            WriteLiteral("                                    <i><span>");
            EndContext();
            BeginContext(2904, 21, false);
#line 99 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                        Write(author.Author.AuthFio);

#line default
#line hidden
            EndContext();
            BeginContext(2925, 14, true);
            WriteLiteral(";</span></i>\r\n");
            EndContext();
#line 100 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2974, 36, true);
            WriteLiteral("                            </div>\r\n");
            EndContext();
#line 102 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"


                        }
                        else
                        {
                            if (item.ArtNameEng != null && item.ArtNameEng.Length > 3)
                            {




#line default
#line hidden
            BeginContext(3223, 41, true);
            WriteLiteral("                                <h6>UDK: ");
            EndContext();
            BeginContext(3265, 11, false);
#line 112 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                    Write(item.ArtUdk);

#line default
#line hidden
            EndContext();
            BeginContext(3276, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
            BeginContext(3285, 109, true);
            WriteLiteral("                                <p class=\"fz-18\" style=\"color:#d1ab7f\">\r\n                                    ");
            EndContext();
            BeginContext(3395, 15, false);
#line 115 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                               Write(item.ArtNameEng);

#line default
#line hidden
            EndContext();
            BeginContext(3410, 123, true);
            WriteLiteral("\r\n                                </p><br />\r\n                                <div style=\"width:100%; text-align:right;\">\r\n");
            EndContext();
#line 118 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                     foreach (var author in item.DataArticleAuthors.OrderBy(x => x.AuthorPos))
                                    {

#line default
#line hidden
            BeginContext(3684, 49, true);
            WriteLiteral("                                        <i><span>");
            EndContext();
            BeginContext(3734, 24, false);
#line 120 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                            Write(author.Author.AuthFioEng);

#line default
#line hidden
            EndContext();
            BeginContext(3758, 14, true);
            WriteLiteral(";</span></i>\r\n");
            EndContext();
#line 121 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(3811, 40, true);
            WriteLiteral("                                </div>\r\n");
            EndContext();
#line 123 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"



                            }
                        }

#line default
#line hidden
            BeginContext(3915, 133, true);
            WriteLiteral("                    </td>\r\n                    <td class=\"col-md-2 mt-10\" style=\"text-align:center;\">\r\n\r\n                        <h2>");
            EndContext();
            BeginContext(4049, 34, false);
#line 131 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                       Write(item.Edition.IdYearNavigation.Year);

#line default
#line hidden
            EndContext();
            BeginContext(4083, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 132 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                         if (MainViewModel.Language != "EN")
                        {

#line default
#line hidden
            BeginContext(4179, 40, true);
            WriteLiteral("                            <p>год</p>\r\n");
            EndContext();
#line 135 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4303, 43, true);
            WriteLiteral("                            <p> year </p>\r\n");
            EndContext();
#line 139 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4373, 125, true);
            WriteLiteral("                    </td>\r\n                    <td class=\"col-md-2\" style=\"text-align:center;\">\r\n                        <h2>");
            EndContext();
            BeginContext(4499, 20, false);
#line 142 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                       Write(item.Edition.Edition);

#line default
#line hidden
            EndContext();
            BeginContext(4519, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 143 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                         if (MainViewModel.Language != "EN")
                        {

#line default
#line hidden
            BeginContext(4615, 45, true);
            WriteLiteral("                            <p> выпуск </p>\r\n");
            EndContext();
#line 146 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4744, 46, true);
            WriteLiteral("                            <p> edition </p>\r\n");
            EndContext();
#line 150 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4817, 54, true);
            WriteLiteral("\r\n\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 155 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"

            }

#line default
#line hidden
            BeginContext(4888, 2087, true);
            WriteLiteral(@"        </tbody>
    </table>
</div>


<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.1.0/css/bootstrap.min.css"">
<link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
<!-- End banner Area -->
<script>

    $(document).ready(function () {
        $('table').dataTable( {
  ""lengthChange"": false,
             ""order"": [[ 1, ""desc"" ], [ 2, ""desc"" ], [ 0, ""by"" ] ]
} ).dataTable();
         $('.dataTable').each(function(){
             var datatable = $(this);
             var search_div = datatable.closest('.dataTables_wrapper').find('div[id$=_filter]');
             search_div.attr('style', 'width:600px;');

        // SEARCH - Add the placeholder for Search and Turn this into in-line form control
        var search_input = datatable.closest('.dataTables_wrapper').find('div[id$=_filter] input');
        search_input.attr('placeholder', 'Search');
        search_input.attr('style', 'width:600px;');
        se");
            WriteLiteral(@"arch_input.addClass('form-control input-lg');
        // LENGTH - Inline-Form control
        var length_sel = datatable.closest('.dataTables_wrapper').find('div[id$=_length] select');
        length_sel.addClass('form-control input-sm');
    });
        //$(""#myInput"").on(""keyup"", function () {
        //    var value = $(this).val().toLowerCase();
        //    $(""#myTable tr"").filter(function () {
        //        $(this).toggle($(this).text().toLowerCase().indexOf(value) > -1)
        //    });
        //});
    });
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
                data: { articleI");
            WriteLiteral("d: articleId },\r\n                url: \'");
            EndContext();
            BeginContext(6976, 47, false);
#line 206 "C:\Users\Murad\Documents\GitHub\NOEP\JournalNEOP\Views\Authors\Index.cshtml"
                 Write(Url.Action("PartialAnnotationView", "Editions"));

#line default
#line hidden
            EndContext();
            BeginContext(7023, 659, true);
            WriteLiteral(@"',
                success: function (data) {
                    $('.modal').html(data);
                    $('.modal').show();
                }
            });
    });
     var modal = document.querySelector('.modal');
    var overflow = document.createElement('div');




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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MainViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

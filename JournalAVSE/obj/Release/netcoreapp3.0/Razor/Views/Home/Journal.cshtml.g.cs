#pragma checksum "F:\Проекты\AVSE\JournalAVSE\Views\Home\Journal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df6a8b9a217577cceb0cd08e2245dceb08b104a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Journal), @"mvc.1.0.view", @"/Views/Home/Journal.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df6a8b9a217577cceb0cd08e2245dceb08b104a0", @"/Views/Home/Journal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cc7b2f7c641de99223589afbf76b67188aad705", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Journal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MainViewModel>
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "df6a8b9a217577cceb0cd08e2245dceb08b104a03321", async() => {
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
<div class=""container"">
    <div id=""infoPageDiv"">
");
            WriteLiteral("    </div>\r\n</div>\r\n<script>\r\n    window.onload = function () {\r\n        var infoId = \'");
#nullable restore
#line 24 "F:\Проекты\AVSE\JournalAVSE\Views\Home\Journal.cshtml"
                 Write(ViewBag.InfoId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        $.ajax(\r\n            {\r\n                type: \'POST\',\r\n                url: \'");
#nullable restore
#line 28 "F:\Проекты\AVSE\JournalAVSE\Views\Home\Journal.cshtml"
                 Write(Url.Action("PartialInfoPage", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: { id: infoId },
                success: function (data) {
                    $('#infoPageDiv').html(data);
                }
            }
        );

    }

    $(""[data-info-link]"").click(function () {
        var infoId = $(this).data(""routeId"");
        console.log(infoId)
");
            WriteLiteral("    });\r\n</script>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>");
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

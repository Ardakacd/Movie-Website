#pragma checksum "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "acf5490fe55787440002072bbbe9832aaf85ea00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Director_list), @"mvc.1.0.view", @"/Views/Director/list.cshtml")]
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
#line 2 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/_ViewImports.cshtml"
using data.Abstract;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/_ViewImports.cshtml"
using data.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/_ViewImports.cshtml"
using entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/_ViewImports.cshtml"
using webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acf5490fe55787440002072bbbe9832aaf85ea00", @"/Views/Director/list.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcdd11361ff2fdadd3010dc8b778c8a29e4b42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Director_list : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DirectorListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-image img-fluid w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container mt-5\">\n\n    <div class=\"row\">\n\n");
#nullable restore
#line 11 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"
         foreach (var item in @Model.directors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-3\">\n                <div class=\"card\">\n\n        <div class=\"card-body\">\n            \n            \n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "acf5490fe55787440002072bbbe9832aaf85ea004641", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 315, "~/images/", 315, 9, true);
#nullable restore
#line 19 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"
AddHtmlAttributeValue("", 324, item.PhotoUrl, 324, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n            <h5 class=\"card-title\">");
#nullable restore
#line 22 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n            <p class=\"card-text\">Yaşı:");
#nullable restore
#line 24 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"
                                 Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n            <p class=\"card-text\">Imdb:");
#nullable restore
#line 26 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"
                                 Write(item.Imdb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n<p class=\"card-text\">Doğum Tarihi:");
#nullable restore
#line 28 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"
                             Write(item.Birthday.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        \n\n        </div>\n\n        <div class=\"card-footer d-flex justify-content-center\">\n            \n\n            <a");
            BeginWriteAttribute("href", " href=\"", 734, "\"", 774, 2);
            WriteAttributeValue("", 741, "/director-detail/", 741, 17, true);
#nullable restore
#line 36 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"
WriteAttributeValue("", 758, item.DirectorId, 758, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Detay</a>\n        </div>\n\n                </div>\n            </div>   \n");
#nullable restore
#line 41 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Director/list.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n    </div>\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DirectorListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

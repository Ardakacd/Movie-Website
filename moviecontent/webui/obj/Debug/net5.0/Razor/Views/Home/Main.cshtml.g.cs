#pragma checksum "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2041088b584032be858dcab8235ac2c19420244b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Main), @"mvc.1.0.view", @"/Views/Home/Main.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2041088b584032be858dcab8235ac2c19420244b", @"/Views/Home/Main.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcdd11361ff2fdadd3010dc8b778c8a29e4b42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Main : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CategoryMovieListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("movie-photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-image img-fluid w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
  
    Layout = "_Layout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<style>\n\n    .carousel-item {\n  height: 500px;\n}\n\n.carousel-item img {\n    position: absolute;\n    top: 0;\n    left: 0;\n    min-height: 500px;\n    object-fit: contain;\n}\n</style>\n\n<div class=\"container mt-5\">\n\n");
#nullable restore
#line 24 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
   if(@TempData["login"] != null){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\n        ");
#nullable restore
#line 27 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
   Write(TempData["Login"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 29 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""carouselExampleIndicators"" class=""carousel slide mb-5""  data-ride=""carousel"">
  <ol class=""carousel-indicators"">
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""3""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""4""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""5""></li>
    <li data-target=""#carouselExampleIndicators"" data-slide-to=""6""></li>

  </ol>
  <div class=""carousel-inner "">

");
#nullable restore
#line 44 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
       for (int i = 0; i < @Model.movies.Count(); i++)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <div");
            BeginWriteAttribute("class", " class=\"", 1156, "\"", 1199, 2);
            WriteAttributeValue("", 1164, "carousel-item", 1164, 13, true);
#nullable restore
#line 46 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
WriteAttributeValue(" ", 1177, i == 0?"active":"", 1178, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n<a");
            BeginWriteAttribute("href", " href=\"", 1204, "\"", 1249, 2);
            WriteAttributeValue("", 1211, "/movie-detail/", 1211, 14, true);
#nullable restore
#line 47 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
WriteAttributeValue("", 1225, Model.movies[i].MovieId, 1225, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2041088b584032be858dcab8235ac2c19420244b7626", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1261, "~/images/", 1261, 9, true);
#nullable restore
#line 47 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
AddHtmlAttributeValue("", 1270, Model.movies[i].PhotoUrl, 1270, 25, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\n  <div class=\"carousel-caption d-none d-md-block \">\n    <h5>");
#nullable restore
#line 49 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
   Write(Model.movies[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n    \n  </div>\n</div>    \n");
#nullable restore
#line 53 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
      }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"      

      
   
  <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Previous</span>
  </a>
  <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
    <span class=""sr-only"">Next</span>
  </a>
</div>


");
#nullable restore
#line 69 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
 foreach (var item in @Model.categories)
{
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row mt-5\">\n\n<p class=\"lead d-block\"><span style=\"color:purple\">");
#nullable restore
#line 74 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
                                              Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <span class=\"mr-3\">Adlı Kategorideki Filmler</span>          <a");
            BeginWriteAttribute("href", " href=\"", 2144, "\"", 2179, 2);
            WriteAttributeValue("", 2151, "/categories/", 2151, 12, true);
#nullable restore
#line 74 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
WriteAttributeValue("", 2163, item.CategoryId, 2163, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Daha fazla...</a></p>\n\n</div>\n");
            WriteLiteral("<div class=\"row\">\n\n");
#nullable restore
#line 80 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
 foreach (var mov in @item.movies.Take(4))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-3\">\n\n    <div class=\"card\">\n\n        <div class=\"card-body\">\n            \n            \n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2041088b584032be858dcab8235ac2c19420244b11790", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2405, "~/images/", 2405, 9, true);
#nullable restore
#line 89 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
AddHtmlAttributeValue("", 2414, mov.movie.PhotoUrl, 2414, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            <h5 class=\"card-title mt-2 mb-1 text-center\">");
#nullable restore
#line 90 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
                                                    Write(mov.movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n\n        </div>\n\n        <div class=\"card-footer text-center\">\n           \n\n            <a");
            BeginWriteAttribute("href", " href=\"", 2646, "\"", 2685, 2);
            WriteAttributeValue("", 2653, "/movie-detail/", 2653, 14, true);
#nullable restore
#line 98 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"
WriteAttributeValue("", 2667, mov.movie.MovieId, 2667, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success ml-3 \">Detay</a>\n        </div>\n\n                </div>\n            \n            </div>\n");
#nullable restore
#line 104 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n");
#nullable restore
#line 108 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Home/Main.cshtml"





}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CategoryMovieListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

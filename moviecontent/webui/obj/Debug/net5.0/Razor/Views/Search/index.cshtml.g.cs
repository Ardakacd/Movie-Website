#pragma checksum "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e13f014982468632fadbb0adf47c4c194f755a13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_index), @"mvc.1.0.view", @"/Views/Search/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e13f014982468632fadbb0adf47c4c194f755a13", @"/Views/Search/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcdd11361ff2fdadd3010dc8b778c8a29e4b42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AllModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-image img-fluid w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-image img-fluid  w-100 h-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container\">\n");
#nullable restore
#line 8 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
 if(@Model.categories.Count != 0){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"lead mt-5\">Kategoriler ile ilgili arama sonuçları:</h5>\n");
            WriteLiteral("         <p class=\"card-text d-inline\">\n");
#nullable restore
#line 15 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                for (int i = 0; i < @Model.categories.Count(); i++)
               {
                   

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                    if(i == @Model.categories.Count-1){

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <a");
            BeginWriteAttribute("href", " href=\"", 395, "\"", 450, 2);
            WriteAttributeValue("", 402, "/category-detail/", 402, 17, true);
#nullable restore
#line 18 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
WriteAttributeValue("", 419, Model.categories[i].CategoryId, 419, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 18 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                                                                             Write(Model.categories[i].CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n");
#nullable restore
#line 19 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                   }else{

#line default
#line hidden
#nullable disable
            WriteLiteral("                       <a");
            BeginWriteAttribute("href", " href=\"", 541, "\"", 596, 2);
            WriteAttributeValue("", 548, "/category-detail/", 548, 17, true);
#nullable restore
#line 20 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
WriteAttributeValue("", 565, Model.categories[i].CategoryId, 565, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                                                                             Write(Model.categories[i].CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</a>\n");
#nullable restore
#line 21 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"

                   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                    
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\n");
#nullable restore
#line 25 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
    


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 30 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
 if(@Model.movies.Count != 0){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"lead mt-5\">Diziler ile ilgili arama sonuçları:</h5>\n");
#nullable restore
#line 34 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
     foreach (var mov in @Model.movies)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-3\">\n\n    <div class=\"card\">\n\n        <div class=\"card-body\">\n            \n            \n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e13f014982468632fadbb0adf47c4c194f755a138470", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 978, "~/images/", 978, 9, true);
#nullable restore
#line 43 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
AddHtmlAttributeValue("", 987, mov.PhotoUrl, 987, 13, false);

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
            WriteLiteral("\n            <h5 class=\"card-title mt-2 mb-1 text-center\">");
#nullable restore
#line 44 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                                                    Write(mov.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n\n        </div>\n\n        <div class=\"card-footer text-center\">\n           \n\n            <a");
            BeginWriteAttribute("href", " href=\"", 1207, "\"", 1240, 2);
            WriteAttributeValue("", 1214, "/movie-detail/", 1214, 14, true);
#nullable restore
#line 52 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
WriteAttributeValue("", 1228, mov.MovieId, 1228, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success ml-3 \">Detay</a>\n        </div>\n\n                </div>\n            \n            </div>\n");
#nullable restore
#line 58 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
 
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 63 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
 if(@Model.players.Count != 0){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"lead mt-5\">Oyuncular ile ilgili arama sonuçları:</h5>\n");
#nullable restore
#line 67 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
       foreach (var item in @Model.players)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-3\">\n                <div class=\"card\">\n\n        <div class=\"card-body\">\n            \n            \n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e13f014982468632fadbb0adf47c4c194f755a1312019", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1665, "~/images/", 1665, 9, true);
#nullable restore
#line 75 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
AddHtmlAttributeValue("", 1674, item.PhotoUrl, 1674, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n            <h5 class=\"card-title\">");
#nullable restore
#line 78 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n        \n\n        </div>\n\n        <div class=\"card-footer d-flex justify-content-center\">\n            \n\n            <a");
            BeginWriteAttribute("href", " href=\"", 1905, "\"", 1941, 2);
            WriteAttributeValue("", 1912, "/player-detail/", 1912, 15, true);
#nullable restore
#line 87 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
WriteAttributeValue("", 1927, item.PlayerId, 1927, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Detay</a>\n        </div>\n\n                </div>\n            </div>   \n");
#nullable restore
#line 92 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
         


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 98 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
 if(@Model.directors.Count != 0){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5 class=\"lead mt-5\">Yönetmenler ile ilgili arama sonuçları:</h5>\n");
#nullable restore
#line 102 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
        foreach (var item in @Model.directors)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-3\">\n                <div class=\"card\">\n\n        <div class=\"card-body\">\n            \n            \n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e13f014982468632fadbb0adf47c4c194f755a1315574", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2366, "~/images/", 2366, 9, true);
#nullable restore
#line 110 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
AddHtmlAttributeValue("", 2375, item.PhotoUrl, 2375, 14, false);

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
#line 113 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n\n                \n\n        </div>\n\n        <div class=\"card-footer d-flex justify-content-center\">\n            \n\n            <a");
            BeginWriteAttribute("href", " href=\"", 2613, "\"", 2653, 2);
            WriteAttributeValue("", 2620, "/director-detail/", 2620, 17, true);
#nullable restore
#line 122 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
WriteAttributeValue("", 2637, item.DirectorId, 2637, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Detay</a>\n        </div>\n\n                </div>\n            </div>   \n");
#nullable restore
#line 127 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
         


}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n");
#nullable restore
#line 137 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"
 if(@Model.directors.Count == 0 && @Model.movies.Count == 0 && @Model.categories.Count == 0 && @Model.players.Count == 0 ){


#line default
#line hidden
#nullable disable
            WriteLiteral("    <strong class=\"mt-5\">Pardon aradığınız isimle eşlesen bir şey bulamadık.</strong>\n");
#nullable restore
#line 140 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Search/index.cshtml"



}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AllModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

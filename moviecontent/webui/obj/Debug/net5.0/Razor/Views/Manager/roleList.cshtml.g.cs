#pragma checksum "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85418100bba0c113f503ab830a5207c0b1d9ddd9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_roleList), @"mvc.1.0.view", @"/Views/Manager/roleList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85418100bba0c113f503ab830a5207c0b1d9ddd9", @"/Views/Manager/roleList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcdd11361ff2fdadd3010dc8b778c8a29e4b42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_roleList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
 if(@TempData["RoleAdded"] != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\n        ");
#nullable restore
#line 8 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
   Write(TempData["RoleAdded"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 10 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 12 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
 if(@TempData["RoleDeleteMessage"] != null){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-info\">\n        ");
#nullable restore
#line 14 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
   Write(TempData["RoleDeleteMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n");
#nullable restore
#line 16 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n<div class=\"container mt-5 mb-5 w-50\">\n\n");
#nullable restore
#line 22 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
 if(Model.Count() == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\n        Herhangi bir rol yok!\n    </div>\n");
#nullable restore
#line 26 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
}else{


#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\n\n<tr>\n    <th");
            BeginWriteAttribute("class", " class=\"", 519, "\"", 527, 0);
            EndWriteAttribute();
            WriteLiteral(">Rol ismi</th>\n    <th>Rol işlemler</th>\n</tr>\n\n");
#nullable restore
#line 35 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
 foreach (var item in @Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n        <td>\n            ");
#nullable restore
#line 39 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </td>\n\n        <td>\n            <a");
            BeginWriteAttribute("href", " href=\"", 695, "\"", 731, 2);
            WriteAttributeValue("", 702, "/manager/roleDetails/", 702, 21, true);
#nullable restore
#line 43 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
WriteAttributeValue("", 723, item.Id, 723, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info \">Düzenle</a>\n\n              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85418100bba0c113f503ab830a5207c0b1d9ddd97800", async() => {
                WriteLiteral("\n                <button class=\"btn btn-danger \" type=\"submit\">Sil</button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 796, "/manager/deleteRole/", 796, 20, true);
#nullable restore
#line 45 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
AddHtmlAttributeValue("", 816, item.Id, 816, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n        </td>\n\n\n    </tr>\n");
#nullable restore
#line 54 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n\n\n</table>\n");
#nullable restore
#line 63 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/roleList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591

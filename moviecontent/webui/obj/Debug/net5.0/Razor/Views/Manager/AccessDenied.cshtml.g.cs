#pragma checksum "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/AccessDenied.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f36d3ffcb0c3b10af7d5f3215f02444f11577284"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_AccessDenied), @"mvc.1.0.view", @"/Views/Manager/AccessDenied.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f36d3ffcb0c3b10af7d5f3215f02444f11577284", @"/Views/Manager/AccessDenied.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adcdd11361ff2fdadd3010dc8b778c8a29e4b42a", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_AccessDenied : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/ardakabadayi/Desktop/movieapp/moviecontent/webui/Views/Manager/AccessDenied.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container mt-5 mb-5\">\n\n\n    <div class=\"alert alert-danger\">\n        Dikkat! Buraya giriş izniniz yok.\n    </div>\n\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

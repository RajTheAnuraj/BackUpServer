#pragma checksum "/Users/Anuraj/Documents/Programming/BackUpServer/BackUpServerWeb/Views/FileUpload/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d40842d477e7a8fb3b9e58c683fda6f2697d72e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileUpload_Index), @"mvc.1.0.view", @"/Views/FileUpload/Index.cshtml")]
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
#line 1 "/Users/Anuraj/Documents/Programming/BackUpServer/BackUpServerWeb/Views/_ViewImports.cshtml"
using BackUpServerWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/Anuraj/Documents/Programming/BackUpServer/BackUpServerWeb/Views/_ViewImports.cshtml"
using BackUpServerWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d40842d477e7a8fb3b9e58c683fda6f2697d72e4", @"/Views/FileUpload/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64ba3ebce517ad52903e140ecd49366c08c777d5", @"/Views/_ViewImports.cshtml")]
    public class Views_FileUpload_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/Anuraj/Documents/Programming/BackUpServer/BackUpServerWeb/Views/FileUpload/Index.cshtml"
 using (Html.BeginForm("Upload", "FileUpload", FormMethod.Post, new { enctype = "multipart/form-data" }))
{ 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"file\" name=\"file\" multiple />\n    <input type=\"submit\" name=\"Submit\" id=\"Submit\" value=\"Upload\" />\n");
#nullable restore
#line 5 "/Users/Anuraj/Documents/Programming/BackUpServer/BackUpServerWeb/Views/FileUpload/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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

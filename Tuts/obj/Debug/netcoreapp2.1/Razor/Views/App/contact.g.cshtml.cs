#pragma checksum "C:\Users\emre.karatasoglu\source\repos\Tuts\Tuts\Views\App\contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29943f041245e8b5059f2eca62920058ea43cdec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_contact), @"mvc.1.0.view", @"/Views/App/contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/contact.cshtml", typeof(AspNetCore.Views_App_contact))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29943f041245e8b5059f2eca62920058ea43cdec", @"/Views/App/contact.cshtml")]
    public class Views_App_contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\emre.karatasoglu\source\repos\Tuts\Tuts\Views\App\contact.cshtml"
  
    ViewData["Title"] = "contact";

#line default
#line hidden
            BeginContext(45, 220, true);
            WriteLiteral("\r\n<h2>contact</h2>\r\n\r\n<form method=\"POST\">\r\n    <input type=\"text\" name=\"name\"/>\r\n    <input type=\"text\" name=\"surname\"/>\r\n    <input type=\"text\" name=\"subject\"/>\r\n    <input type=\"submit\" name=\"Submit Form\"/>\r\n\r\n</form>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Stuart\source\repos\rnsdevelopment\SRMVCTest\Web\Views\Shared\Components\NavBarItems\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c9381eb59cbe431642e0d43be2468f60076947"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_NavBarItems_Default), @"mvc.1.0.view", @"/Views/Shared/Components/NavBarItems/Default.cshtml")]
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
#line 1 "C:\Users\Stuart\source\repos\rnsdevelopment\SRMVCTest\Web\Views\_ViewImports.cshtml"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Stuart\source\repos\rnsdevelopment\SRMVCTest\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c9381eb59cbe431642e0d43be2468f60076947", @"/Views/Shared/Components/NavBarItems/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74b0619e1a302f0598271da1847e697c39d57b88", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_NavBarItems_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Business.Details.NavItemDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>Priority Items</h3>\r\n<ul>\r\n");
#nullable restore
#line 5 "C:\Users\Stuart\source\repos\rnsdevelopment\SRMVCTest\Web\Views\Shared\Components\NavBarItems\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
#nullable restore
#line 7 "C:\Users\Stuart\source\repos\rnsdevelopment\SRMVCTest\Web\Views\Shared\Components\NavBarItems\Default.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 8 "C:\Users\Stuart\source\repos\rnsdevelopment\SRMVCTest\Web\Views\Shared\Components\NavBarItems\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Business.Details.NavItemDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591

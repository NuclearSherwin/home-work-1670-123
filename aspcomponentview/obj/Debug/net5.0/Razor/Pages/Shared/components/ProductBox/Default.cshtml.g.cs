#pragma checksum "A:\work\class\1670-mai-dinh-phong\aspcomponentview\Pages\Shared\components\ProductBox\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc059b50aefc878559a43c62ac30178728df48f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspcomponentview.Pages.Shared.components.ProductBox.Pages_Shared_components_ProductBox_Default), @"mvc.1.0.view", @"/Pages/Shared/components/ProductBox/Default.cshtml")]
namespace aspcomponentview.Pages.Shared.components.ProductBox
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
#line 1 "A:\work\class\1670-mai-dinh-phong\aspcomponentview\Pages\_ViewImports.cshtml"
using aspcomponentview;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "A:\work\class\1670-mai-dinh-phong\aspcomponentview\Pages\Shared\components\ProductBox\Default.cshtml"
using Phong;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cc059b50aefc878559a43c62ac30178728df48f", @"/Pages/Shared/components/ProductBox/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3f539c4c4be647b2dd6b87cc711634936aae77e", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Shared_components_ProductBox_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"list-group\">\r\n");
#nullable restore
#line 5 "A:\work\class\1670-mai-dinh-phong\aspcomponentview\Pages\Shared\components\ProductBox\Default.cshtml"
     foreach (var item in Model)
    {   

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">\r\n            ");
#nullable restore
#line 8 "A:\work\class\1670-mai-dinh-phong\aspcomponentview\Pages\Shared\components\ProductBox\Default.cshtml"
       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <strong>");
#nullable restore
#line 8 "A:\work\class\1670-mai-dinh-phong\aspcomponentview\Pages\Shared\components\ProductBox\Default.cshtml"
                          Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </li>\r\n");
#nullable restore
#line 10 "A:\work\class\1670-mai-dinh-phong\aspcomponentview\Pages\Shared\components\ProductBox\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

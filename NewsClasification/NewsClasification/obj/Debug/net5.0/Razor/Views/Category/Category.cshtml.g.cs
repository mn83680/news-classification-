#pragma checksum "D:\VS\NewsClasification\NewsClasification\Views\Category\Category.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "23cace0c9ff4d86cb91f383eeefc0329e927271d212a70f4ded157ae0a03564a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Category), @"mvc.1.0.view", @"/Views/Category/Category.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\VS\NewsClasification\NewsClasification\Views\_ViewImports.cshtml"
using NewsClasification;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS\NewsClasification\NewsClasification\Views\_ViewImports.cshtml"
using NewsClasification.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"23cace0c9ff4d86cb91f383eeefc0329e927271d212a70f4ded157ae0a03564a", @"/Views/Category/Category.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3a4cdd7041d7cd9e6be2814fa3e46a408bb24c8bb121e0930abb5c5b07593090", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Category_Category : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NewsClasification.Models.Category>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- list Categores -->\r\n");
            WriteLiteral("\r\n<table class=\"table table-borderd table-hover\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Name</th>\r\n\r\n    </tr>\r\n    \r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NewsClasification.Models.Category>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
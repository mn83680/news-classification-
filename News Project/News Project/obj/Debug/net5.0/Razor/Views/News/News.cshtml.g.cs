#pragma checksum "D:\VS\News Project\News Project\Views\News\News.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "a20e59d49ba896258b6a62f1ee1139bcbd43ea9929b6ee53c80c4d67ef26c38e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_News), @"mvc.1.0.view", @"/Views/News/News.cshtml")]
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
#line 1 "D:\VS\News Project\News Project\Views\_ViewImports.cshtml"
using News_Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS\News Project\News Project\Views\_ViewImports.cshtml"
using News_Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a20e59d49ba896258b6a62f1ee1139bcbd43ea9929b6ee53c80c4d67ef26c38e", @"/Views/News/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"a5a499d5f4dd7547b17d2c45668360f3213cba5d9dad5513bbd41effc9caf9c8", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_News_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!-- list News -->\r\n");
            WriteLiteral("<table class=\"table table-borderd table-hover\">\r\n    <tr>\r\n        <th>NewsId</th>\r\n        <th>NewsTitle</th>\r\n        <th>NewsText</th>\r\n        <th>NewsImage</th>\r\n        <th>AdminId</th>\r\n        <th>CategoryId</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 13 "D:\VS\News Project\News Project\Views\News\News.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "D:\VS\News Project\News Project\Views\News\News.cshtml"
           Write(item.NewsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "D:\VS\News Project\News Project\Views\News\News.cshtml"
           Write(item.NewsTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "D:\VS\News Project\News Project\Views\News\News.cshtml"
           Write(item.NewsText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "D:\VS\News Project\News Project\Views\News\News.cshtml"
           Write(item.NewsImage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "D:\VS\News Project\News Project\Views\News\News.cshtml"
           Write(item.AdminId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "D:\VS\News Project\News Project\Views\News\News.cshtml"
           Write(item.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 24 "D:\VS\News Project\News Project\Views\News\News.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

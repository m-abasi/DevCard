#pragma checksum "D:\Atriya Course\DevCardApp\DevCard\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "625ef4f05725d1bb751db404bba22bab296636acf8cab832fdd1c85e501bac5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Atriya Course\DevCardApp\DevCard\Views\_ViewImports.cshtml"
using DevCard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Atriya Course\DevCardApp\DevCard\Views\_ViewImports.cshtml"
using DevCard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"625ef4f05725d1bb751db404bba22bab296636acf8cab832fdd1c85e501bac5c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"06a59e8cb0ef90c789efd639c1bd0d373e2b9f5fb90c7dacc774f8cc4ed74187", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Atriya Course\DevCardApp\DevCard\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"about-me-section p-3 p-lg-5 theme-bg-light\">\r\n    <div class=\"container\">\r\n        <div class=\"profile-teaser media flex-column flex-lg-row\">\r\n            <img class=\"profile-image mb-3 mb-lg-0 ml-lg-5 mr-md-0\" src=\"assets/images/me.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 300, "\"", 306, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            <div class=""media-body"">
                <h2 class=""name font-weight-bold mb-1"">مهدی عباسی </h2>
                <div class=""tagline mb-3"">برنامه نویس جونیور</div>
                <div class=""bio mb-4"">
                    لورم ایپسوم متن ساختگی با تولید سادگی نامفهوم از صنعت چاپ، و با استفاده از
                    طراحان گرافیک است، چاپگرها و متون بلکه روزنامه و مجله در ستون و سطرآنچنان که لازم است، و
                    جوابگوی سوالات پیوسته اهل دنیای موجود طراحی اساسا مورد استفاده قرار گیرد.
                </div>
                <div class=""mb-4"">
                    <a class=""btn btn-primary mr-2 mb-3"" href=""http://www.atriya.com"">
                        <i class=""fas fa-arrow-alt-circle-right ml-2"">
                        </i>
                        <span class=""d-none d-md-inline"">
                            برو
                            به
                        </span> گیت هاب
                    </a>
                    <a class=""btn btn-secondary mb-3"" href=""");
            WriteLiteral(@"#"">
                        <i class=""fas fa-file-alt ml-2""></i>
                        <span class=""d-none d-md-inline"">مشاهده </span> نمونه کارها
                    </a>
                </div>
            </div>

        </div>
    </div>
</section>

");
#nullable restore
#line 37 "D:\Atriya Course\DevCardApp\DevCard\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Projects"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    <hr>\r\n</div>\r\n");
#nullable restore
#line 42 "D:\Atriya Course\DevCardApp\DevCard\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("Articles"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

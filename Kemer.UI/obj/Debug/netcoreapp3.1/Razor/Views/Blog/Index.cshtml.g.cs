#pragma checksum "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36b815f271dcbbca75e3b4ee3f8289ee15b59d27"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
#line 2 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\_ViewImports.cshtml"
using Kemer.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b815f271dcbbca75e3b4ee3f8289ee15b59d27", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c913b40c2230b807411d77b65fe74d60250f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36b815f271dcbbca75e3b4ee3f8289ee15b59d274037", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <meta name=""description"" content=""Kurumsam Web Sitesi"">
        <meta name=""keywords"" content=""Kurumsal, Bloglar, Dimaik web Sitesi nedir"">
        <meta name=""author"" content=""Uygulamabu"">

        <meta name=""robots"" content=""index, archive"">

        <title>Bloglar</title>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36b815f271dcbbca75e3b4ee3f8289ee15b59d275352", async() => {
                WriteLiteral(@"


        <div class=""w-100"">

            <div class=""d-flex flex-column w-100"">
                <div class=""page-title d-flex align-items-center bg-image py-5"" data-img-src=""/images/upload/page-title-bg-13.jpg"" style=""background-image: url(&quot;/images/upload/page-title-bg-13.jpg&quot;);"">
                    <div class=""container page-title-container"">
                        <div class=""row py-5"">
                            <div class=""col text-center"">

                                <h1 class=""display-3 font-weight-800 text-white mb-1"">
                                    Bloglar
                                </h1>



                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div class=""container"">
                <div class=""row"">
                    <div class=""col"">
                        <div class=""bg-primary py-4 mt-up50 rounded-xl shadow-lg"">

                            <d");
                WriteLiteral(@"iv data-height=""6px"" style=""height: 6px;""></div>

                            <nav aria-label=""breadcrumb"">
                                <ol class=""breadcrumb breadcrumb-light-2 justify-content-center mb-0"">
                                    <li class=""breadcrumb-item text-uppercase""><a href=""#"">Homepage</a></li>
                                    <li class=""breadcrumb-item text-uppercase active"" aria-current=""page"">Bloglar</li>
                                </ol>
                            </nav>

                            <div data-height=""6px"" style=""height: 6px;""></div>

                        </div>
                    </div>
                </div>
            </div>

        </div>

        <div class=""main-content pb-0"">

            <!-- Blog Masonry -->
            <div class=""section py-5"">
                <div class=""container"">

                    <div class=""row pb-5 mb-5"">
                        <div class=""col-md-10 offset-md-1 col-lg-8 offset-lg-2 col-xl-");
                WriteLiteral(@"6 offset-xl-3"">
                            <div class=""text-center"">

                                <h2 class=""h1 section-title-3 font-weight-800"">Bloglar</h2>

                               

                            </div>
                        </div>
                    </div>

                    <div class=""row mb-5"">
                        <div class=""col"">

                            <!-- Masonry blog filter -->
                            <div class=""grid-item-filter mb-5"" data-target=""#masonryBlog"">
                                <ul class=""nav nav-pills justify-content-center"">
                                    <li class=""nav-item mb-2"">
                                        <a class=""nav-link active"" href=""#"" data-filter="".cat-all"">All categories</a>
                                    </li>
");
#nullable restore
#line 92 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                     foreach (var item in @ViewBag.BlogCategory)
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li class=\"nav-item mb-2\">\r\n                                        <a class=\"nav-link\" href=\"#\" data-filter=\".");
#nullable restore
#line 96 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                                                              Write(item.BlogCategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" accesskey=\"g\">\r\n\r\n                                            ");
#nullable restore
#line 98 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                       Write(item.BlogCategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n");
#nullable restore
#line 101 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                   

                                </ul>
                            </div>

                            <!-- Masonry blog container -->
                            <div id=""masonryBlog"" class=""row grid-item-layout blog-container mb-3"" data-gutter=""32"" data-layout-mode=""masonry"" style=""margin-left: -16px; margin-right: -16px; position: relative; height: 3635.96px;"">

                             

                                <!-- Grid item -->
");
#nullable restore
#line 114 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <div");
                BeginWriteAttribute("class", " class=\"", 4470, "\"", 4549, 5);
                WriteAttributeValue("", 4478, "col-md-6", 4478, 8, true);
                WriteAttributeValue(" ", 4486, "col-lg-4", 4487, 9, true);
                WriteAttributeValue(" ", 4495, "grid-item", 4496, 10, true);
                WriteAttributeValue(" ", 4505, "cat-all", 4506, 8, true);
#nullable restore
#line 116 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
WriteAttributeValue(" ", 4513, item.BlogCategory.BlogCategoryName, 4514, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" style=""margin-bottom: 32px; padding-left: 16px; padding-right: 16px; position: absolute; left: 0px; top: 0px;"">
                                        <div class=""card card-blog-entry border-0 plain-card"">
                                            <div class=""card-blog-img hover-item hover-scale hover-uncaption"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36b815f271dcbbca75e3b4ee3f8289ee15b59d2711984", async() => {
                    WriteLiteral(@"
                                                    <div class=""hover-transition"">
                                                        <div class=""hover-down"">
                                                            <i class=""fas fa-link fa-2x hover-icon""></i>
                                                        </div>
                                                    </div>
                                                    <figure>
                                                        <img class=""img-fluid""");
                    BeginWriteAttribute("src", " src=\"", 5533, "\"", 5569, 2);
                    WriteAttributeValue("", 5539, "/images/imgs/", 5539, 13, true);
#nullable restore
#line 126 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5552, item.ImageUrlOne, 5552, 17, false);

#line default
#line hidden
#nullable disable
                    EndWriteAttribute();
                    WriteLiteral(" alt=\"Blog\">\r\n                                                    </figure>\r\n                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                                                                                     WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </div>
                                            <div class=""card-body pt-0"">
                                                <div class=""category-btn"">
                                                    <a href=""#"" class=""btn btn-round btn-sm btn-primary"">");
#nullable restore
#line 132 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                                                                                    Write(item.BlogCategory.BlogCategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                </div>\r\n                                                <h5 class=\"font-weight-700 mt-3\">\r\n                                                    <a href=\"#\" class=\"text-dark-gray\">");
#nullable restore
#line 135 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                                                                  Write(item.Header);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a>
                                                </h5>
                                                <ul class=""meta-entry"">
                                                    <li class=""meta-entry-item"">
                                                        <a href=""#"">");
#nullable restore
#line 139 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                                               Write(item.CreateDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                    </li>\r\n                                                    <li class=\"meta-entry-item\">\r\n                                                        <a href=\"#\">");
#nullable restore
#line 142 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                                               Write(item.AuthorName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a>\r\n                                                    </li>\r\n                                                </ul>\r\n                                                <p class=\"card-text\">");
#nullable restore
#line 145 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                                                Write(item.ContentOne);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                            </div>\r\n                                            \r\n                                        </div>\r\n                                    </div>\r\n");
#nullable restore
#line 150 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\Blog\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    <!-- Grid item -->


                                </div>

                            <!-- Pagination -->
                          

                        </div>
                    </div>

                </div>
            </div>

       

        </div>



      

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591

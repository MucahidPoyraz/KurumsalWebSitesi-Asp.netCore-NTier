#pragma checksum "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8069cbe8b20f2498d3f2a6724870768bf2cba8d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetail_Index), @"mvc.1.0.view", @"/Views/ProductDetail/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8069cbe8b20f2498d3f2a6724870768bf2cba8d3", @"/Views/ProductDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c913b40c2230b807411d77b65fe74d60250f41d", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductSlider>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KVKK", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("target", new global::Microsoft.AspNetCore.Html.HtmlString("_blank"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark font-weight-500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("px-md-4 px-lg-0 px-xl-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ProductDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8069cbe8b20f2498d3f2a6724870768bf2cba8d35918", async() => {
                WriteLiteral(@"


    <div class=""main-content pb-0"">

        <!-- Portfolio content section -->
        <div class=""section pt-3"">
            <div class=""container"">
                <div class=""row mb-5"">
                    <div class=""col-lg-10 offset-lg-1"">

                        <!-- Author and Share -->
                        <div class=""row align-items-center mb-5"">

                            <div class=""col-xl-6"">
                                <div class=""d-xl-flex align-items-center text-center text-xl-left pb-3 pb-xl-0 mb-4 mb-xl-0"">



                                    <div class=""pl-xl-4"">
                                        <h3 class=""font-weight-800 mb-0"">");
#nullable restore
#line 29 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"
                                                                    Write(ViewBag.Product.Header);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h3>

                                    </div>

                                </div>
                            </div>



                        </div>

                        <!-- Synced gallery -->
                        <div class=""gallery-sync carousel-nav-lg mb-5"" data-dots=""true"" data-gutter=""10"" data-thumb-md=""4"" data-thumb-lg=""7"" data-thumb-xl=""7"">

                            <!-- Main images -->

                            <div class=""gallery-sync-main arrow-nav-overflow"" style=""margin-bottom: 10px;"">
                                <div class=""owl-carousel owl-loaded owl-drag"">

                                    <div class=""owl-stage-outer"">

                                        <div class=""owl-stage"" transition: all 0.6s ease 0s; width: 7140px;"">
");
#nullable restore
#line 51 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"
                                             foreach (var item in Model)
                                            {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <div class=""owl-item"" style=""width: 510px;"">
                                                    <div class=""gallery-sync-main-item rounded-lg"">
                                                        <img class=""img-fluid""");
                BeginWriteAttribute("src", " src=\"", 1997, "\"", 2034, 2);
                WriteAttributeValue("", 2003, "/images/imgs/", 2003, 13, true);
#nullable restore
#line 56 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 2016, item.PruductImage, 2016, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Kaçkar Otel Balık\">\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 59 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"

                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        </div>

                                    </div>

                                    <div class=""owl-nav disabled"">
                                        <button type=""button"" role=""presentation"" class=""owl-prev""><span aria-label=""Previous"">‹</span></button>
                                        <button type=""button"" role=""presentation"" class=""owl-next""><span aria-label=""Next"">›</span></button>
                                    </div>
                                </div>

                                <a class=""carousel-control-prev"" href=""#"">
                                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                                    <span class=""sr-only"">Previous</span>
                                </a>
                                <a class=""carousel-control-next"" href=""#"">
                                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
         ");
                WriteLiteral(@"                           <span class=""sr-only"">Next</span>
                                </a>

                            </div>

                            <!-- Thumbnail images -->
                            <div class=""gallery-sync-thumb"">
                                <div class=""owl-carousel owl-theme owl-loaded owl-drag"">

                                    <div class=""owl-stage-outer"">
                                        <div class=""owl-stage"" transition: all 0.5s ease 0s; width: 2427px;"">
");
#nullable restore
#line 89 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"
                                             foreach (var item in Model)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                                <div class=""owl-item"" style=""width: 163.333px; margin-right: 10px;"">

                                                    <div class=""gallery-sync-thumb-item rounded-lg"">
                                                        <figure>
                                                            <img class=""img-fluid""");
                BeginWriteAttribute("src", " src=\"", 4269, "\"", 4306, 2);
                WriteAttributeValue("", 4275, "/images/imgs/", 4275, 13, true);
#nullable restore
#line 95 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"
WriteAttributeValue("", 4288, item.PruductImage, 4288, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"image\">\r\n                                                        </figure>\r\n                                                    </div>\r\n\r\n                                                </div>\r\n");
#nullable restore
#line 100 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                        </div>
                                    </div>
                                    <div class=""owl-nav disabled"">
                                        <button type=""button"" role=""presentation"" class=""owl-prev""><span aria-label=""Previous"">‹</span></button>
                                        <button type=""button"" role=""presentation"" class=""owl-next""><span aria-label=""Next"">›</span></button>
                                    </div>

                                </div>
                            </div>



                        </div>

                        <br /> <br /> <br />

                        <!-- Description -->
                        <div class=""pb-4"">

                            <p>");
#nullable restore
#line 122 "C:\Users\Five Ajans\source\repos\Kemer\Kemer.UI\Views\ProductDetail\Index.cshtml"
                          Write(ViewBag.Product.Content);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>

                        </div>

                        <!-- Blockquote -->
                        <div class=""row py-5"">
                            <div class=""col-lg-10 offset-lg-1"">

                                <div class=""text-center pb-3 mb-4"">
                                    <img src=""/images/upload/camera-ios.svg"" alt=""icon"" data-width=""60px"" data-height=""60px"" style=""width: 60px; height: 60px;"">
                                </div>

                                <blockquote class=""blockquote text-center mb-0"">
                                    <p class=""mb-0"">En kaliteli ürünler en uygun fiyatlar ile</p>

                                </blockquote>

                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>

        <!-- Related works section -->
        <!-- Call to action section -->



        <div class=""section pt-5 bg-image"" data-img-src=""/images/uploa");
                WriteLiteral(@"d/about-us-cta-bg-02.jpg"" style=""background-image: url(&quot;/images/upload/about-us-cta-bg-02.jpg&quot;);"">
            <div class=""container"">
                <div class=""row mt-5 mt-md-0"">
                    <div class=""col"">

                        <div class=""d-none d-md-block"" data-height=""200px"" style=""height: 200px;""></div>

                        <div class=""bg-white rounded-ultra shadow-lg px-4 py-5 p-md-5 mt-5 mt-md-0"">

                            <div class=""row my-4"">
                                <div class=""col-md-10 offset-md-1 col-xl-8 offset-xl-2"">
                                    <div class=""text-center mt-2 mb-4 my-md-4"">
                                        <h2 class=""h1 section-title-3 font-weight-800 text-center"">SİZİNLE İLETİŞİME GEÇELİM</h2>

                                    </div>
                                </div>
                            </div>

                            <div class=""row mb-4"">
                                <div class=""co");
                WriteLiteral("l-lg-10 offset-lg-1\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8069cbe8b20f2498d3f2a6724870768bf2cba8d316024", async() => {
                    WriteLiteral(@"
                                        <div class=""form-row"">

                                            <div class=""col-lg-6"">
                                                <div class=""px-1 pb-3 mb-3"">
                                                    <div class=""input-group input-group-lg input-group-round"">
                                                        <div class=""input-group-inner"">
                                                            <div class=""input-group-prepend"">
                                                                <span class=""input-group-text input-group-icon""><i class=""far fa-user""></i></span>
                                                            </div>
                                                            <input type=""text"" name=""Name"" class=""form-control form-control-lg"" required placeholder=""Your name"">
                                                            <div class=""input-focus-bg""></div>
                                       ");
                    WriteLiteral(@"                 </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class=""col-lg-6"">
                                                <div class=""px-1 pb-3 mb-3"">
                                                    <div class=""input-group input-group-lg input-group-round"">
                                                        <div class=""input-group-inner"">
                                                            <div class=""input-group-prepend"">
                                                                <span class=""input-group-text input-group-icon""><i class=""far fa-user""></i></span>
                                                            </div>
                                                            <input type=""text"" name=""Surname"" class=""form-control form-control-lg"" required placeholder=""Your surname"">
  ");
                    WriteLiteral(@"                                                          <div class=""input-focus-bg""></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class=""col-lg-6"">
                                                <div class=""px-1 pb-3 mb-3"">
                                                    <div class=""input-group input-group-lg input-group-round"">
                                                        <div class=""input-group-inner"">
                                                            <div class=""input-group-prepend"">
                                                                <span class=""input-group-text input-group-icon""><i class=""far fa-envelope""></i></span>
                                                            </div>
                                  ");
                    WriteLiteral(@"                          <input type=""email"" name=""Email"" class=""form-control form-control-lg"" required placeholder=""Email address"">
                                                            <div class=""input-focus-bg""></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class=""col-lg-6"">
                                                <div class=""px-1 mb-5"">
                                                    <div class=""input-group input-group-lg input-group-round"">
                                                        <div class=""input-group-inner"">
                                                            <div class=""input-group-prepend"">
                                                                <span class=""input-group-text input-group-icon""><i class=""");
                    WriteLiteral(@"fas fa-mobile-alt""></i></span>
                                                            </div>
                                                            <input type=""tel"" name=""Phone"" class=""form-control form-control-lg"" required placeholder=""Phone number"">
                                                            <div class=""input-focus-bg""></div>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>

                                            <div class=""col-lg-6 offset-lg-3"">
                                                <div class=""px-1"">
                                                    <div class=""px-3"">

                                                        <div class=""form-group row d-flex justify-content-center"">

                                                            <label for=""agreeTerms"">
  ");
                    WriteLiteral("                                                              <input type=\"checkbox\" name=\"myCheck\" id=\"agreeTerms\" required>");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8069cbe8b20f2498d3f2a6724870768bf2cba8d321846", async() => {
                        WriteLiteral("&nbsp;&nbsp;Kişisel Verileri Krouma Kanunu");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"'nu okudum ve onaylıyorum.
                                                            </label>
                                                        </div>
                                                    </div>
                                                </div>
                                            </div>



                                            <div class=""col-lg-6 offset-lg-3"">
                                                <div class=""px-1"">
                                                    <button type=""submit"" onclick=""myFunction()"" class=""btn btn-lg btn-round btn-block btn-indigo"">Mesaj gönder</button>
                                                </div>
                                            </div>
                                        </div>
                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>


    </div>

    <script>
        function myFunction() {
            var x = document.getElementById(""myCheck"").required;
            document.getElementById(""demo"").innerHTML = x;
        }
    </script>
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductSlider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
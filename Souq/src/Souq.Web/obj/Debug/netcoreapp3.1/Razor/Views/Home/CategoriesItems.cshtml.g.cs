#pragma checksum "E:\my baby\Souq.com\Souq\src\Souq.Web\Views\Home\CategoriesItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e67e4948281e51ef0b50e41a496741aaf40e439"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CategoriesItems), @"mvc.1.0.view", @"/Views/Home/CategoriesItems.cshtml")]
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
#line 1 "E:\my baby\Souq.com\Souq\src\Souq.Web\Views\_ViewImports.cshtml"
using Souq.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e67e4948281e51ef0b50e41a496741aaf40e439", @"/Views/Home/CategoriesItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8ce2be43a95574f1cdac1b5161d03021d732354", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CategoriesItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Clean.Architecture.Core.Entities.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/CategoriesItems.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\my baby\Souq.com\Souq\src\Souq.Web\Views\Home\CategoriesItems.cshtml"
  
    ViewData["Title"] = "CategoriesItems";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<link href=\"//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css\" rel=\"stylesheet\" id=\"bootstrap-css\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0e67e4948281e51ef0b50e41a496741aaf40e4394688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js""></script>
<script src=""//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<!------ Include the above in your HEAD tag ---------->

<link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" rel=""stylesheet"" integrity=""sha384-wvfXpqpZZVQGK6TAh5PVlGOfQNHSoD2xbE+QkPxCAFlNEevoEH3Sl0sibVcOQVnN"" crossorigin=""anonymous"">

<nav class=""navbar navbar-expand-md navbar-dark bg-dark"">
    <div class=""container"">
        <a class=""navbar-brand"" href=""index.html"">Simple Ecommerce</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarsExampleDefault"" aria-controls=""navbarsExampleDefault"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse justify-content-end"" id=""navbarsExampleDefault"">
            <ul class=""navbar-nav m-");
            WriteLiteral(@"auto"">
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""index.html"">Home</a>
                </li>
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""category.html"">Categories <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""product.html"">Product</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""cart.html"">Cart</a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""contact.html"">Contact</a>
                </li>
            </ul>

            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e67e4948281e51ef0b50e41a496741aaf40e4397685", async() => {
                WriteLiteral(@"
                <div class=""input-group input-group-sm"">
                    <input type=""text"" class=""form-control"" aria-label=""Small"" aria-describedby=""inputGroup-sizing-sm"" placeholder=""Search..."">
                    <div class=""input-group-append"">
                        <button type=""button"" class=""btn btn-secondary btn-number"">
                            <i class=""fa fa-search""></i>
                        </button>
                    </div>
                </div>
                <a class=""btn btn-success btn-sm ml-3"" href=""cart.html"">
                    <i class=""fa fa-shopping-cart""></i> Cart
                    <span class=""badge badge-light"">3</span>
                </a>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
</nav>
<section class=""jumbotron text-center"">
    <div class=""container"">
        <h1 class=""jumbotron-heading"">E-COMMERCE CATEGORY</h1>
        <p class=""lead text-muted mb-0"">Le Lorem Ipsum est simplement du faux texte employ?? dans la composition et la mise en page avant impression. Le Lorem Ipsum est le faux texte standard de l'imprimerie depuis les ann??es 1500, quand un peintre anonyme assembla ensemble des morceaux de texte pour r??aliser un livre sp??cimen de polices de texte...</p>
    </div>
</section>
<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                    <li class=""breadcrumb-item""><a href=""category.html"">Category</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Sub-category</li>
                </ol>
            </nav>
 ");
            WriteLiteral(@"       </div>
    </div>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-12 col-sm-3"">
            <div class=""card bg-light mb-3"">
                <div class=""card-header bg-primary text-white text-uppercase""><i class=""fa fa-list""></i> Categories</div>
                <ul class=""list-group category_block"">
");
#nullable restore
#line 85 "E:\my baby\Souq.com\Souq\src\Souq.Web\Views\Home\CategoriesItems.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"list-group-item\"><a href=\"category.html\">");
#nullable restore
#line 87 "E:\my baby\Souq.com\Souq\src\Souq.Web\Views\Home\CategoriesItems.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 88 "E:\my baby\Souq.com\Souq\src\Souq.Web\Views\Home\CategoriesItems.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    
                </ul>
            </div>
            <div class=""card bg-light mb-3"">
                <div class=""card-header bg-success text-white text-uppercase"">Last product</div>
                <div class=""card-body"">
                    <img class=""img-fluid"" src=""https://dummyimage.com/600x400/55595c/fff"" />
                    <h5 class=""card-title"">Product title</h5>
                    <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <p class=""bloc_left_price"">99.00 $</p>
                </div>
            </div>
        </div>
        <div class=""col"">
            <div class=""row"">
                <div class=""col-12 col-md-6 col-lg-4"">
                    <div class=""card"">
                        <img class=""card-img-top"" src=""https://dummyimage.com/600x400/55595c/fff"" alt=""Card image cap"">
                        <div class=""card-body"">
                            <h4");
            WriteLiteral(@" class=""card-title""><a href=""product.html"" title=""View Product"">Product title</a></h4>
                            <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""btn btn-danger btn-block"">99.00 $</p>
                                </div>
                                <div class=""col"">
                                    <a href=""#"" class=""btn btn-success btn-block"">Add to cart</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-6 col-lg-4"">
                    <div class=""card"">
                        <img class=""card-img-top"" src=""https://dummyimage.com/600x400/55595c/fff"" alt=""Card image cap"">
                        <div class=""c");
            WriteLiteral(@"ard-body"">
                            <h4 class=""card-title""><a href=""product.html"" title=""View Product"">Product title</a></h4>
                            <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""btn btn-danger btn-block"">99.00 $</p>
                                </div>
                                <div class=""col"">
                                    <a href=""#"" class=""btn btn-success btn-block"">Add to cart</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-6 col-lg-4"">
                    <div class=""card"">
                        <img class=""card-img-top"" src=""https://dummyimage.com/600x400/55595c/fff"" alt=""Card image c");
            WriteLiteral(@"ap"">
                        <div class=""card-body"">
                            <h4 class=""card-title""><a href=""product.html"" title=""View Product"">Product title</a></h4>
                            <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""btn btn-danger btn-block"">99.00 $</p>
                                </div>
                                <div class=""col"">
                                    <a href=""#"" class=""btn btn-success btn-block"">Add to cart</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-6 col-lg-4"">
                    <div class=""card"">
                        <img class=""card-img-top"" src=""https://dummyimag");
            WriteLiteral(@"e.com/600x400/55595c/fff"" alt=""Card image cap"">
                        <div class=""card-body"">
                            <h4 class=""card-title""><a href=""product.html"" title=""View Product"">Product title</a></h4>
                            <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""btn btn-danger btn-block"">99.00 $</p>
                                </div>
                                <div class=""col"">
                                    <a href=""#"" class=""btn btn-success btn-block"">Add to cart</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-6 col-lg-4"">
                    <div class=""card"">
                        <img ");
            WriteLiteral(@"class=""card-img-top"" src=""https://dummyimage.com/600x400/55595c/fff"" alt=""Card image cap"">
                        <div class=""card-body"">
                            <h4 class=""card-title""><a href=""product.html"" title=""View Product"">Product title</a></h4>
                            <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""btn btn-danger btn-block"">99.00 $</p>
                                </div>
                                <div class=""col"">
                                    <a href=""#"" class=""btn btn-success btn-block"">Add to cart</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12 col-md-6 col-lg-4"">
                    <div c");
            WriteLiteral(@"lass=""card"">
                        <img class=""card-img-top"" src=""https://dummyimage.com/600x400/55595c/fff"" alt=""Card image cap"">
                        <div class=""card-body"">
                            <h4 class=""card-title""><a href=""product.html"" title=""View Product"">Product title</a></h4>
                            <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <div class=""row"">
                                <div class=""col"">
                                    <p class=""btn btn-danger btn-block"">99.00 $</p>
                                </div>
                                <div class=""col"">
                                    <a href=""#"" class=""btn btn-success btn-block"">Add to cart</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-12"">
 ");
            WriteLiteral(@"                   <nav aria-label=""..."">
                        <ul class=""pagination"">
                            <li class=""page-item disabled"">
                                <a class=""page-link"" href=""#"" tabindex=""-1"">Previous</a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                            <li class=""page-item active"">
                                <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                            </li>
                            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                            <li class=""page-item"">
                                <a class=""page-link"" href=""#"">Next</a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
        </div>

    </div>
</div>

<!-- Footer -->
<footer class=""text-light"">
    <div cla");
            WriteLiteral(@"ss=""container"">
        <div class=""row"">
            <div class=""col-md-3 col-lg-4 col-xl-3"">
                <h5>About</h5>
                <hr class=""bg-white mb-2 mt-0 d-inline-block mx-auto w-25"">
                <p class=""mb-0"">
                    Le Lorem Ipsum est simplement du faux texte employ?? dans la composition et la mise en page avant impression.
                </p>
            </div>

            <div class=""col-md-2 col-lg-2 col-xl-2 mx-auto"">
                <h5>Informations</h5>
                <hr class=""bg-white mb-2 mt-0 d-inline-block mx-auto w-25"">
                <ul class=""list-unstyled"">
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 13288, "\"", 13295, 0);
            EndWriteAttribute();
            WriteLiteral(">Link 1</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 13340, "\"", 13347, 0);
            EndWriteAttribute();
            WriteLiteral(">Link 2</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 13392, "\"", 13399, 0);
            EndWriteAttribute();
            WriteLiteral(">Link 3</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 13444, "\"", 13451, 0);
            EndWriteAttribute();
            WriteLiteral(@">Link 4</a></li>
                </ul>
            </div>

            <div class=""col-md-3 col-lg-2 col-xl-2 mx-auto"">
                <h5>Others links</h5>
                <hr class=""bg-white mb-2 mt-0 d-inline-block mx-auto w-25"">
                <ul class=""list-unstyled"">
                    <li><a");
            BeginWriteAttribute("href", " href=\"", 13763, "\"", 13770, 0);
            EndWriteAttribute();
            WriteLiteral(">Link 1</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 13815, "\"", 13822, 0);
            EndWriteAttribute();
            WriteLiteral(">Link 2</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 13867, "\"", 13874, 0);
            EndWriteAttribute();
            WriteLiteral(">Link 3</a></li>\r\n                    <li><a");
            BeginWriteAttribute("href", " href=\"", 13919, "\"", 13926, 0);
            EndWriteAttribute();
            WriteLiteral(@">Link 4</a></li>
                </ul>
            </div>

            <div class=""col-md-4 col-lg-3 col-xl-3"">
                <h5>Contact</h5>
                <hr class=""bg-white mb-2 mt-0 d-inline-block mx-auto w-25"">
                <ul class=""list-unstyled"">
                    <li><i class=""fa fa-home mr-2""></i> My company</li>
                    <li><i class=""fa fa-envelope mr-2""></i> email@example.com</li>
                    <li><i class=""fa fa-phone mr-2""></i> + 33 12 14 15 16</li>
                    <li><i class=""fa fa-print mr-2""></i> + 33 12 14 15 16</li>
                </ul>
            </div>
            <div class=""col-12 copyright mt-3"">
                <p class=""float-left"">
                    <a href=""#"">Back to top</a>
                </p>
                <p class=""text-right text-muted"">created with <i class=""fa fa-heart""></i> by <a href=""https://t-php.fr/43-theme-ecommerce-bootstrap-4.html""><i>t-php</i></a> | <span>v. 1.0</span></p>
            </div>
        </di");
            WriteLiteral("v>\r\n    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Clean.Architecture.Core.Entities.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591

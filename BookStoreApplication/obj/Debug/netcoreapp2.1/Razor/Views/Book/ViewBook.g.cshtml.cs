#pragma checksum "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "355a1dcf9b6940a4136a3630913d1ea5bddc571f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_ViewBook), @"mvc.1.0.view", @"/Views/Book/ViewBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/ViewBook.cshtml", typeof(AspNetCore.Views_Book_ViewBook))]
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
#line 1 "D:\OnlineBookStore\BookStoreApplication\Views\_ViewImports.cshtml"
using BookStoreApplication;

#line default
#line hidden
#line 2 "D:\OnlineBookStore\BookStoreApplication\Views\_ViewImports.cshtml"
using BookStoreApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"355a1dcf9b6940a4136a3630913d1ea5bddc571f", @"/Views/Book/ViewBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86eaecdd000890fc07b3bf0849fe94670258f063", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_ViewBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStoreWebService.Models.BookDB.Book>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 26, true);
            WriteLiteral("\n\n<!DOCTYPE html>\n\n<html>\n");
            EndContext();
            BeginContext(86, 209, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "802a77051ade4a67b78f1335c6591fa8", async() => {
                BeginContext(92, 196, true);
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css\">\n\n    <meta name=\"viewport\" content=\"width=device-width\" />\n    <title>ViewBook</title>\n");
                EndContext();
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
            EndContext();
            BeginContext(295, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(296, 2429, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0381073416704fb6a14a037b750807d1", async() => {
                BeginContext(302, 61, true);
                WriteLiteral("\n    <div class=\"container-fluid card\" style=\"width:40rem;\">\n");
                EndContext();
#line 16 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
                BeginContext(410, 48, true);
                WriteLiteral("            <br><h2 style=\"text-align: center;\">");
                EndContext();
                BeginContext(459, 14, false);
#line 18 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                                           Write(item.BookTitle);

#line default
#line hidden
                EndContext();
                BeginContext(473, 207, true);
                WriteLiteral("</h2>\n            <div class=\"row\">\n\n                <div class=\"col-sm-4\">\n                    <br />\n                    <img class=\"img-fluid img-thumbnail img-circle mx-auto d-block align-content-center\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 680, "\"", 697, 1);
#line 23 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
WriteAttributeValue("", 686, item.Image, 686, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(698, 289, true);
                WriteLiteral(@" style=""width:200px;height:250px ; "">
                </div>
                <div class=""col-sm-8"">
                    <br /><br /><br />
                    <table class=""table table-striped"">
                        <tr>
                            <th>
                                ");
                EndContext();
                BeginContext(988, 41, false);
#line 30 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1029, 100, true);
                WriteLiteral("\n                            </th>\n                            <td>\n                                ");
                EndContext();
                BeginContext(1130, 40, false);
#line 33 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(1170, 159, true);
                WriteLiteral("\n                            </td>\n                        </tr>\n                        <tr>\n                            <th>\n                                ");
                EndContext();
                BeginContext(1330, 49, false);
#line 38 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.SubCategoryId));

#line default
#line hidden
                EndContext();
                BeginContext(1379, 100, true);
                WriteLiteral("\n                            </th>\n                            <td>\n                                ");
                EndContext();
                BeginContext(1480, 48, false);
#line 41 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SubCategoryId));

#line default
#line hidden
                EndContext();
                BeginContext(1528, 159, true);
                WriteLiteral("\n                            </td>\n                        </tr>\n                        <tr>\n                            <th>\n                                ");
                EndContext();
                BeginContext(1688, 46, false);
#line 46 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.SupplierId));

#line default
#line hidden
                EndContext();
                BeginContext(1734, 100, true);
                WriteLiteral("\n                            </th>\n                            <td>\n                                ");
                EndContext();
                BeginContext(1835, 45, false);
#line 49 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                           Write(Html.DisplayFor(modelItem => item.SupplierId));

#line default
#line hidden
                EndContext();
                BeginContext(1880, 159, true);
                WriteLiteral("\n                            </td>\n                        </tr>\n                        <tr>\n                            <th>\n                                ");
                EndContext();
                BeginContext(2040, 46, false);
#line 54 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                           Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
                EndContext();
                BeginContext(2086, 100, true);
                WriteLiteral("\n                            </th>\n                            <td>\n                                ");
                EndContext();
                BeginContext(2187, 45, false);
#line 57 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CategoryId));

#line default
#line hidden
                EndContext();
                BeginContext(2232, 138, true);
                WriteLiteral("\n                            </td>\n                        </tr>\n                    </table>\n\n                </div>\n\n            </div>\n");
                EndContext();
#line 65 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
        }

#line default
#line hidden
                BeginContext(2380, 104, true);
                WriteLiteral("        <div style=\"text-align:center\">\n            <button class=\"btn btn-primary\" style=\"margin:20px;\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2484, "\"", 2563, 1);
#line 67 "D:\OnlineBookStore\BookStoreApplication\Views\Book\ViewBook.cshtml"
WriteAttributeValue("", 2494, "window.location.href='" + @Url.Action("SearchBook", "Book") + "'", 2494, 69, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2564, 154, true);
                WriteLiteral(">Go Back</button>|\n            <button type=\"button\" class=\"btn btn-primary\" style=\"margin:20px;\">Delete</button>|\n            \n        </div>\n    </div>\n");
                EndContext();
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
            EndContext();
            BeginContext(2725, 9, true);
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookStoreWebService.Models.BookDB.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591

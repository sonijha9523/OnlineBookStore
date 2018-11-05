#pragma checksum "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77113bb64974089065068c7ecd5a3221ebb89fb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ProcessOrder), @"mvc.1.0.view", @"/Views/Order/ProcessOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/ProcessOrder.cshtml", typeof(AspNetCore.Views_Order_ProcessOrder))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77113bb64974089065068c7ecd5a3221ebb89fb8", @"/Views/Order/ProcessOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86eaecdd000890fc07b3bf0849fe94670258f063", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ProcessOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStoreApplication.Models.ProcessOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
  
    ViewData["Title"] = "ProcessOrder";
    var list = (List<ProcessOrder>)ViewData["products"];

#line default
#line hidden
            BeginContext(163, 32, true);
            WriteLiteral("\n<h2>ProcessOrder</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(195, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b27a9de62e924ae0a58435c8990def18", async() => {
                BeginContext(218, 9, true);
                WriteLiteral("View Cart");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(231, 87, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n\n            <th>\n                ");
            EndContext();
            BeginContext(319, 42, false);
#line 17 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.BookId));

#line default
#line hidden
            EndContext();
            BeginContext(361, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(414, 41, false);
#line 20 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(455, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(508, 41, false);
#line 23 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(549, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(602, 44, false);
#line 26 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(646, 53, true);
            WriteLiteral("\n            </th>\n\n            <th>\n                ");
            EndContext();
            BeginContext(700, 39, false);
#line 30 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
           Write(Html.DisplayNameFor(model => model.sum));

#line default
#line hidden
            EndContext();
            BeginContext(739, 59, true);
            WriteLiteral("\n            </th>\n\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 36 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
         for (var i = 0; i < list.Count; i++)
        {

#line default
#line hidden
            BeginContext(854, 89, true);
            WriteLiteral("            <tr>\n\n                <td>\n                    <div>\n                        ");
            EndContext();
            BeginContext(944, 44, false);
#line 42 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => list[i].BookId));

#line default
#line hidden
            EndContext();
            BeginContext(988, 122, true);
            WriteLiteral("\n                    </div>\n\n                </td>\n                <td>\n                    <div>\n                        ");
            EndContext();
            BeginContext(1111, 43, false);
#line 48 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => list[i].Title));

#line default
#line hidden
            EndContext();
            BeginContext(1154, 145, true);
            WriteLiteral("\n                       \n                    </div>\n                </td>\n                <td>\n                    <div>\n                        ");
            EndContext();
            BeginContext(1300, 43, false);
#line 54 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => list[i].Price));

#line default
#line hidden
            EndContext();
            BeginContext(1343, 145, true);
            WriteLiteral("\n                       \n                    </div>\n                </td>\n                <td>\n                    <div>\n                        ");
            EndContext();
            BeginContext(1489, 46, false);
#line 60 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => list[i].Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1535, 144, true);
            WriteLiteral("\n                      \n                    </div>\n                </td>\n                <td>\n                    <div>\n                        ");
            EndContext();
            BeginContext(1680, 41, false);
#line 66 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                   Write(Html.DisplayFor(modelItem => list[i].sum));

#line default
#line hidden
            EndContext();
            BeginContext(1721, 94, true);
            WriteLiteral("\n                       \n                    </div>\n                </td>\n\n\n            </tr>\n");
            EndContext();
#line 73 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"

        }

#line default
#line hidden
            BeginContext(1826, 25, true);
            WriteLiteral("\n    </tbody>\n</table>\n\n\n");
            EndContext();
            BeginContext(1851, 652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb468152d0ea43f1b2d2873be86da2db", async() => {
                BeginContext(1915, 1, true);
                WriteLiteral("\n");
                EndContext();
#line 81 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
     for (var i = 0; i < list.Count; i++)
    {

#line default
#line hidden
                BeginContext(1964, 98, true);
                WriteLiteral("        <div class=\"container\">\n            <div class=\"row\">\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2062, "\"", 2080, 3);
                WriteAttributeValue("", 2069, "[", 2069, 1, true);
#line 85 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2070, i, 2070, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2072, "].BookId", 2072, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2081, "\"", 2104, 1);
#line 85 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2089, list[i].BookId, 2089, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2105, 40, true);
                WriteLiteral(" />\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2145, "\"", 2162, 3);
                WriteAttributeValue("", 2152, "[", 2152, 1, true);
#line 86 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2153, i, 2153, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2155, "].Title", 2155, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2163, "\"", 2185, 1);
#line 86 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2171, list[i].Title, 2171, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2186, 40, true);
                WriteLiteral(" />\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2226, "\"", 2243, 3);
                WriteAttributeValue("", 2233, "[", 2233, 1, true);
#line 87 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2234, i, 2234, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2236, "].Price", 2236, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2244, "\"", 2266, 1);
#line 87 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2252, list[i].Price, 2252, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2267, 40, true);
                WriteLiteral(" />\n                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2307, "\"", 2327, 3);
                WriteAttributeValue("", 2314, "[", 2314, 1, true);
#line 88 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2315, i, 2315, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2317, "].Quantity", 2317, 10, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2328, "\"", 2353, 1);
#line 88 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2336, list[i].Quantity, 2336, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2354, 41, true);
                WriteLiteral(" />\n\n\n\n            </div>\n        </div>\n");
                EndContext();
#line 94 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"

    }

#line default
#line hidden
                BeginContext(2402, 94, true);
                WriteLiteral("    <div>\n        <input type=\"submit\" class=\"btn-dark\" value=\"Proceed To Pay\" />\n    </div>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2503, 1, true);
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookStoreApplication.Models.ProcessOrder>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1048d1aea58c4fe61325676f1e2413688815fdf7"
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
#line 1 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
using BookStoreLibrary;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1048d1aea58c4fe61325676f1e2413688815fdf7", @"/Views/Order/ProcessOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86eaecdd000890fc07b3bf0849fe94670258f063", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ProcessOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
  
    ViewData["Title"] = "ProcessOrder";
    // var list = (List<ProcessOrder>)ViewData["products"];
    var list = (ProductViewModelCart[])ViewData["products"];

#line default
#line hidden
            BeginContext(197, 80, true);
            WriteLiteral("<div class=\"login-form\">\r\n    <div class=\"main-div1\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(277, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "af5bd8d351aa43de83c979e20236b03b", async() => {
                BeginContext(300, 9, true);
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
            BeginContext(313, 578, true);
            WriteLiteral(@"
        </p>
        <table class=""table"">
            <thead>
                <tr>
                    <th>
                        BookId
                    </th>
                    <th>
                        Title
                    </th>
                    <th>
                        Price
                    </th>
                    <th>
                        Quantity
                    </th>
                    <th>
                        sum
                    </th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 33 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                 foreach (var item in list)
                {

#line default
#line hidden
            BeginContext(955, 123, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(1079, 11, false);
#line 38 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                           Write(item.BookId);

#line default
#line hidden
            EndContext();
            BeginContext(1090, 166, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(1257, 10, false);
#line 43 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                           Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1267, 168, true);
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(1436, 10, false);
#line 49 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                           Write(item.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1446, 166, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(1613, 13, false);
#line 54 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1626, 168, true);
            WriteLiteral("\r\n\r\n                            </div>\r\n                        </td>\r\n                        <td>\r\n                            <div>\r\n                                ");
            EndContext();
            BeginContext(1795, 48, false);
#line 60 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
                           Write(string.Format("{0}", item.Quantity * item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1843, 98, true);
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n\r\n                    </tr>\r\n");
            EndContext();
#line 65 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"

                }

#line default
#line hidden
            BeginContext(1962, 113, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n        <div>\r\n            <input class=\"btn-dark\" value=\"Proceed To Pay\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2075, "\"", 2152, 1);
#line 70 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ProcessOrder.cshtml"
WriteAttributeValue("", 2085, "window.location.href='" + @Url.Action("Payment", "Order") + "'", 2085, 67, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2153, 43, true);
            WriteLiteral(" />\r\n        </div>\r\n        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1fff0c303fd7802e7bf0d990fe125b3e75b7071"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ViewCart), @"mvc.1.0.view", @"/Views/Order/ViewCart.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/ViewCart.cshtml", typeof(AspNetCore.Views_Order_ViewCart))]
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
#line 1 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
using BookStoreLibrary;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1fff0c303fd7802e7bf0d990fe125b3e75b7071", @"/Views/Order/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86eaecdd000890fc07b3bf0849fe94670258f063", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProductViewModelCart>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProcessOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
  
    ViewData["Title"] = "ViewCart";
    var list = (List<ProductViewModelCart>)ViewData["products"];
    Layout = "~/Views/Shared/LogoutLayout.cshtml";


#line default
#line hidden
            BeginContext(234, 562, true);
            WriteLiteral(@"
<div class=""login-form main-div1"">


    <div class=""container order"">
        <div class=""row"">
            <div class=""col-md-3 order"">
                BookId

            </div>
            <div class=""col-md-3 order"">
                Book Title

            </div>
            <div class=""col-md-2 order"">
                Book price

            </div>
            <div class=""col-md-2 order"">
                Quantity
            </div>
            <div class=""col-md-2 order"">

            </div>
        </div>
    </div>

    ");
            EndContext();
            BeginContext(796, 1690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5b4252b99d0439fb290bee6a52879eb", async() => {
                BeginContext(865, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 38 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
         for (var i = 0; i < list.Count; i++)
        {

#line default
#line hidden
                BeginContext(925, 124, true);
                WriteLiteral("            <div class=\"container\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-3 order-div\">");
                EndContext();
                BeginContext(1050, 14, false);
#line 42 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                               Write(list[i].BookId);

#line default
#line hidden
                EndContext();
                BeginContext(1064, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1091, "\"", 1109, 3);
                WriteAttributeValue("", 1098, "[", 1098, 1, true);
#line 42 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1099, i, 1099, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1101, "].BookId", 1101, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1110, "\"", 1133, 1);
#line 42 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1118, list[i].BookId, 1118, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1134, 57, true);
                WriteLiteral(" />\r\n                    <div class=\"col-md-3 order-div\">");
                EndContext();
                BeginContext(1192, 13, false);
#line 43 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                               Write(list[i].Title);

#line default
#line hidden
                EndContext();
                BeginContext(1205, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1232, "\"", 1249, 3);
                WriteAttributeValue("", 1239, "[", 1239, 1, true);
#line 43 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1240, i, 1240, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1242, "].Title", 1242, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1250, "\"", 1272, 1);
#line 43 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1258, list[i].Title, 1258, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1273, 57, true);
                WriteLiteral(" />\r\n                    <div class=\"col-md-2 order-div\">");
                EndContext();
                BeginContext(1331, 13, false);
#line 44 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                               Write(list[i].Price);

#line default
#line hidden
                EndContext();
                BeginContext(1344, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1371, "\"", 1388, 3);
                WriteAttributeValue("", 1378, "[", 1378, 1, true);
#line 44 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1379, i, 1379, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1381, "].Price", 1381, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1389, "\"", 1411, 1);
#line 44 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1397, list[i].Price, 1397, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1412, 124, true);
                WriteLiteral(" />\r\n                    <br />\r\n                    <div class=\"col-md-2 order order-div\">\r\n                        <select");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1536, "\"", 1556, 3);
                WriteAttributeValue("", 1543, "[", 1543, 1, true);
#line 47 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1544, i, 1544, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1546, "].Quantity", 1546, 10, true);
                EndWriteAttribute();
                BeginContext(1557, 31, true);
                WriteLiteral(">\r\n                            ");
                EndContext();
                BeginContext(1588, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343874d06e86474db236e9291c794755", async() => {
                    BeginContext(1606, 1, true);
                    WriteLiteral("1");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1616, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1646, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03224925a7fb4a92b526fdad6f55344b", async() => {
                    BeginContext(1664, 1, true);
                    WriteLiteral("2");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1674, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1704, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32d5bef6e8e64fafaa3e532b08c0668c", async() => {
                    BeginContext(1722, 1, true);
                    WriteLiteral("3");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1732, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1762, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ada65bcc8f9742c6a43774be518fab7b", async() => {
                    BeginContext(1780, 1, true);
                    WriteLiteral("4");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1790, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1820, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d540ac168daf4b7ea799b323173e92df", async() => {
                    BeginContext(1838, 1, true);
                    WriteLiteral("5");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1848, 239, true);
                WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                    <br />\r\n                    <div class=\"col-md-2 order-div\">\r\n                        <button class=\"btn btn-secondary \" type=\"button\" style=\"color:black\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2087, "\"", 2193, 1);
#line 57 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 2097, "window.location.href='" + @Url.Action("UpdateCart", "Order",new {id = list[i].BookId}) + "'", 2097, 96, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2194, 152, true);
                WriteLiteral(">\r\n                            Remove\r\n                        </button>\r\n                    </div>\r\n\r\n\r\n\r\n                </div>\r\n            </div>\r\n");
                EndContext();
#line 66 "D:\OnlineBookStore\BookStoreApplication\Views\Order\ViewCart.cshtml"

        }

#line default
#line hidden
                BeginContext(2359, 120, true);
                WriteLiteral("        <div>\r\n            <input type=\"submit\" class=\"btn btn-lg btn-dark\" value=\"Place Order\" />\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2486, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProductViewModelCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591

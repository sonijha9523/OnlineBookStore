#pragma checksum "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbeb45315e6164a7b0b47ea6e7bd11c9b51851fc"
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
#line 1 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\_ViewImports.cshtml"
using BookStoreApplication;

#line default
#line hidden
#line 2 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\_ViewImports.cshtml"
using BookStoreApplication.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbeb45315e6164a7b0b47ea6e7bd11c9b51851fc", @"/Views/Order/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4cd9bb444bef839053be6cf1d50c971c91cdb80", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_ViewCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStoreApplication.Models.ProductViewModelCart>>
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
            BeginContext(70, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
  
    ViewData["Title"] = "ViewCart";
    var list = (List<ProductViewModelCart>)ViewData["products"];



#line default
#line hidden
            BeginContext(186, 467, true);
            WriteLiteral(@"
<h2>ViewCart</h2>

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
            BeginContext(653, 1520, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a483aa6e78fe458da6afbe1eb85c14f1", async() => {
                BeginContext(722, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 36 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
     for (var i = 0; i < list.Count; i++)
    {

#line default
#line hidden
                BeginContext(774, 112, true);
                WriteLiteral("        <div class=\"container\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-3 order-div\">");
                EndContext();
                BeginContext(887, 14, false);
#line 40 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                           Write(list[i].BookId);

#line default
#line hidden
                EndContext();
                BeginContext(901, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 928, "\"", 946, 3);
                WriteAttributeValue("", 935, "[", 935, 1, true);
#line 40 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 936, i, 936, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 938, "].BookId", 938, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 947, "\"", 970, 1);
#line 40 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 955, list[i].BookId, 955, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(971, 53, true);
                WriteLiteral(" />\r\n                <div class=\"col-md-3 order-div\">");
                EndContext();
                BeginContext(1025, 13, false);
#line 41 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                           Write(list[i].Title);

#line default
#line hidden
                EndContext();
                BeginContext(1038, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1065, "\"", 1082, 3);
                WriteAttributeValue("", 1072, "[", 1072, 1, true);
#line 41 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1073, i, 1073, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1075, "].Title", 1075, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1083, "\"", 1105, 1);
#line 41 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1091, list[i].Title, 1091, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1106, 53, true);
                WriteLiteral(" />\r\n                <div class=\"col-md-2 order-div\">");
                EndContext();
                BeginContext(1160, 13, false);
#line 42 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                           Write(list[i].Price);

#line default
#line hidden
                EndContext();
                BeginContext(1173, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1200, "\"", 1217, 3);
                WriteAttributeValue("", 1207, "[", 1207, 1, true);
#line 42 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1208, i, 1208, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1210, "].Price", 1210, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1218, "\"", 1240, 1);
#line 42 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1226, list[i].Price, 1226, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1241, 80, true);
                WriteLiteral(" />\r\n\r\n                <div class=\"col-md-2 order\">\r\n                    <select");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1321, "\"", 1341, 3);
                WriteAttributeValue("", 1328, "[", 1328, 1, true);
#line 45 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1329, i, 1329, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1331, "].Quantity", 1331, 10, true);
                EndWriteAttribute();
                BeginContext(1342, 27, true);
                WriteLiteral(">\r\n                        ");
                EndContext();
                BeginContext(1369, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab8ca6cc0c70466cbc02a33bf842a9d8", async() => {
                    BeginContext(1387, 1, true);
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
                BeginContext(1397, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1423, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13e238fdd07a49dda65f519ccb8f77ac", async() => {
                    BeginContext(1441, 1, true);
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
                BeginContext(1451, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1477, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0f98fc5ee624baf8adc2b4fc83fb03a", async() => {
                    BeginContext(1495, 1, true);
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
                BeginContext(1505, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1531, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b2a3ba965124adf91a2b7a81f91a43e", async() => {
                    BeginContext(1549, 1, true);
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
                BeginContext(1559, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(1585, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f6c9d46f96a42b9872b70a99f41da7d", async() => {
                    BeginContext(1603, 1, true);
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
                BeginContext(1613, 190, true);
                WriteLiteral("\r\n                    </select>\r\n                </div>\r\n                <div class=\"col-md-2 order\">\r\n                    <button class=\"btn btn-secondary\" type=\"button\" style=\"color:black\"");
                EndContext();
                BeginWriteAttribute("onclick", "  onclick=\"", 1803, "\"", 1910, 1);
#line 54 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 1814, "window.location.href='" + @Url.Action("UpdateCart", "Order",new {id = list[i].BookId}) + "'", 1814, 96, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1911, 133, true);
                WriteLiteral(" >\r\n                        Remove\r\n                    </button>\r\n                </div>\r\n\r\n\r\n\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 63 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"

        }

#line default
#line hidden
                BeginContext(2057, 109, true);
                WriteLiteral("        <div>\r\n            <input type=\"submit\" class=\"btn-dark\" value=\"Place Order\" />\r\n        </div>\r\n    ");
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
            BeginContext(2173, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookStoreApplication.Models.ProductViewModelCart>> Html { get; private set; }
    }
}
#pragma warning restore 1591

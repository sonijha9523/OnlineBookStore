#pragma checksum "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da4c83bbaade2ad28da10cdae89743dab38e7d58"
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
#line 1 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
using BookStoreLibrary;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da4c83bbaade2ad28da10cdae89743dab38e7d58", @"/Views/Order/ViewCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4cd9bb444bef839053be6cf1d50c971c91cdb80", @"/Views/_ViewImports.cshtml")]
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
#line 4 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
  
    ViewData["Title"] = "ViewCart";
    var list = (List<ProductViewModelCart>)ViewData["products"];
    Layout = "~/Views/Shared/LogoutLayout.cshtml";



#line default
#line hidden
            BeginContext(236, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
  
    if (list.Count == 0)
    {

#line default
#line hidden
            BeginContext(275, 592, true);
            WriteLiteral(@"        <div class=""container"">
            <div class=""row login-form main-div"">
                <div class=""col-12"">
                    <h1 style=""font-size:30px;color:red;text-align:center""><b>Sorry , Cart is Empty!</b></h1>

                    <img src=""https://media.tenor.com/images/566837eba034cef161f09e090d191bb1/tenor.gif"" style=""width:250px;height:250px;padding:20px 20px 20px 20px"" />

                </div> 
                <marquee><h4 style=""color:darkred""><i>Hey...don't worry Lets Buy Something..!!!</i></h4></marquee>
                <button class=""btn btn-dark""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 867, "\"", 947, 1);
#line 24 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 877, "window.location.href='" + @Url.Action("GetCategory", "Book") + "'", 877, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(948, 69, true);
            WriteLiteral(">CONTINUE SHOPPING</button>\r\n                </div>\r\n        </div>\r\n");
            EndContext();
#line 27 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(1041, 720, true);
            WriteLiteral(@"        <div class=""login-form main-div1"">


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
            BeginContext(1761, 1930, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "284044234e92491fa43ec6f12cae1427", async() => {
                BeginContext(1830, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 57 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
                 for (var i = 0; i < list.Count; i++)
                {

#line default
#line hidden
                BeginContext(1906, 148, true);
                WriteLiteral("                    <div class=\"container\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-3 order-div\">");
                EndContext();
                BeginContext(2055, 14, false);
#line 61 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                                       Write(list[i].BookId);

#line default
#line hidden
                EndContext();
                BeginContext(2069, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2096, "\"", 2114, 3);
                WriteAttributeValue("", 2103, "[", 2103, 1, true);
#line 61 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 2104, i, 2104, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2106, "].BookId", 2106, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2115, "\"", 2138, 1);
#line 61 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 2123, list[i].BookId, 2123, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2139, 65, true);
                WriteLiteral(" />\r\n                            <div class=\"col-md-3 order-div\">");
                EndContext();
                BeginContext(2205, 13, false);
#line 62 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                                       Write(list[i].Title);

#line default
#line hidden
                EndContext();
                BeginContext(2218, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2245, "\"", 2262, 3);
                WriteAttributeValue("", 2252, "[", 2252, 1, true);
#line 62 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 2253, i, 2253, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2255, "].Title", 2255, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2263, "\"", 2285, 1);
#line 62 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 2271, list[i].Title, 2271, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2286, 65, true);
                WriteLiteral(" />\r\n                            <div class=\"col-md-2 order-div\">");
                EndContext();
                BeginContext(2352, 13, false);
#line 63 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
                                                       Write(list[i].Price);

#line default
#line hidden
                EndContext();
                BeginContext(2365, 27, true);
                WriteLiteral("</div> <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2392, "\"", 2409, 3);
                WriteAttributeValue("", 2399, "[", 2399, 1, true);
#line 63 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 2400, i, 2400, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2402, "].Price", 2402, 7, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2410, "\"", 2432, 1);
#line 63 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 2418, list[i].Price, 2418, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2433, 148, true);
                WriteLiteral(" />\r\n                            <br />\r\n                            <div class=\"col-md-2 order order-div\">\r\n                                <select");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2581, "\"", 2601, 3);
                WriteAttributeValue("", 2588, "[", 2588, 1, true);
#line 66 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 2589, i, 2589, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 2591, "].Quantity", 2591, 10, true);
                EndWriteAttribute();
                BeginContext(2602, 39, true);
                WriteLiteral(">\r\n                                    ");
                EndContext();
                BeginContext(2641, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57de7d0a10d3414994b90b3f18ec6a09", async() => {
                    BeginContext(2659, 1, true);
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
                BeginContext(2669, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2707, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7772c71478d14ef690c8feefe293fa7f", async() => {
                    BeginContext(2725, 1, true);
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
                BeginContext(2735, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2773, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "852efba6f92445bb924889c41899f485", async() => {
                    BeginContext(2791, 1, true);
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
                BeginContext(2801, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2839, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96ecc23b91c940a49b8c7df2d426534b", async() => {
                    BeginContext(2857, 1, true);
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
                BeginContext(2867, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2905, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bcf0d84459341e88fc61e87a8782e06", async() => {
                    BeginContext(2923, 1, true);
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
                BeginContext(2933, 279, true);
                WriteLiteral(@"
                                </select>
                            </div>
                            <br />
                            <div class=""col-md-2 order-div"">
                                <button class=""btn btn-secondary "" type=""button"" style=""color:black""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 3212, "\"", 3318, 1);
#line 76 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"
WriteAttributeValue("", 3222, "window.location.href='" + @Url.Action("UpdateCart", "Order",new {id = list[i].BookId}) + "'", 3222, 96, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3319, 192, true);
                WriteLiteral(">\r\n                                    Remove\r\n                                </button>\r\n                            </div>\r\n\r\n\r\n\r\n                        </div>\r\n                    </div>\r\n");
                EndContext();
#line 85 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"

                }

#line default
#line hidden
                BeginContext(3532, 152, true);
                WriteLiteral("                <div>\r\n                    <input type=\"submit\" class=\"btn btn-lg btn-dark\" value=\"Place Order\" />\r\n                </div>\r\n            ");
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
            BeginContext(3691, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 92 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\ViewCart.cshtml"

    }

#line default
#line hidden
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

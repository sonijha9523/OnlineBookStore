#pragma checksum "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d058031b30bb993d15e1ea9c8b2100932cf96a0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Payment), @"mvc.1.0.view", @"/Views/Order/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Payment.cshtml", typeof(AspNetCore.Views_Order_Payment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d058031b30bb993d15e1ea9c8b2100932cf96a0b", @"/Views/Order/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4cd9bb444bef839053be6cf1d50c971c91cdb80", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStoreApplication.Models.ProcessOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Payment.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("LoginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
  
    ViewData["Title"] = "Payment";
    var list = (List<ProcessOrder>)ViewData["products"];

#line default
#line hidden
#line 6 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(190, 29, true);
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(219, 424, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035625ca381243fab917caea94c8873c", async() => {
                BeginContext(225, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(231, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "96e415bd2d1d4e80bea99df17c6378d9", async() => {
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
                EndContext();
                BeginContext(281, 355, true);
                WriteLiteral(@"
    <link href=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">

    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">

    <link rel=""stylesheet"" href=""http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"">
");
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
            BeginContext(643, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(645, 4618, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39fbf940f4340c7882f84df681ffa57", async() => {
                BeginContext(666, 2514, true);
                WriteLiteral(@"

    <div class=""container card-deck bg-dark mb-3"" style=""width:50rem;"">
        <div class=""login-form"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""invoice-title"" style=""text-align:center"">
                        <h2>Invoice</h2>
                    </div>
                    <hr>
                    <div class=""row"">
                        <div class=""col-xs-6"">
                            <address>
                                <strong>Billed To:</strong><br>
                                John Smith<br>
                                1234 Main<br>
                                Apt. 4B<br>
                                Springfield, ST 54321
                            </address>
                        </div>
                        <div class=""col-xs-6 text-right"">
                            <address>
                                <strong>Shipped To:</strong><br>
                                Jane Smith<br>
");
                WriteLiteral(@"                                1234 Main<br>
                                Apt. 4B<br>
                                Springfield, ST 54321
                            </address>
                        </div>
                    </div>

                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <h3 class=""panel-title""><strong>Order summary</strong></h3>
                        </div>
                        <div class=""panel-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-condensed"">
                                    <thead>
                                        <tr>
                                            <td><strong>ITEM</strong></td>
                                            <td class=""text-center""><strong>PRIC");
                WriteLiteral(@"E</strong></td>
                                            <td class=""text-center""><strong>QUANTITY</strong></td>
                                            <td class=""text-right""><strong>TOTAL</strong></td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <!-- foreach ($order->lineItems as $line) or some such thing here -->


");
                EndContext();
#line 76 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                         foreach (var item in list)
                                        {

#line default
#line hidden
                BeginContext(3292, 102, true);
                WriteLiteral("                                            <tr>\r\n                                                <td>");
                EndContext();
                BeginContext(3395, 10, false);
#line 79 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                               Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(3405, 79, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
                EndContext();
                BeginContext(3485, 10, false);
#line 80 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                                                   Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(3495, 79, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
                EndContext();
                BeginContext(3575, 13, false);
#line 81 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                                                   Write(item.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(3588, 78, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-right\">");
                EndContext();
                BeginContext(3667, 8, false);
#line 82 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                                                  Write(item.sum);

#line default
#line hidden
                EndContext();
                BeginContext(3675, 58, true);
                WriteLiteral("</td>\r\n                                            </tr>\r\n");
                EndContext();
#line 84 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                        }

#line default
#line hidden
                BeginContext(3776, 48, true);
                WriteLiteral("\r\n                                        <tr>\r\n");
                EndContext();
#line 87 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                              
                                                int total = 0;
                                                foreach (var item in list)
                                                {
                                                    total = item.sum + total;
                                                }

#line default
#line hidden
                BeginContext(4193, 338, true);
                WriteLiteral(@"                                                <td class=""no-line""></td>
                                                <td class=""no-line""></td>
                                                <td class=""no-line text-center""><strong>Total</strong></td>
                                                <td class=""no-line text-right"">");
                EndContext();
                BeginContext(4532, 5, false);
#line 96 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                                                          Write(total);

#line default
#line hidden
                EndContext();
                BeginContext(4537, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
                BeginContext(4591, 332, true);
                WriteLiteral(@"
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <button class=""btn btn-success btn-primary""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 4923, "\"", 4996, 1);
#line 107 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
WriteAttributeValue("", 4933, "window.location.href='" + @Url.Action("Pay", "Order") + "'", 4933, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4997, 47, true);
                WriteLiteral(">PAY</button>\r\n        </div>\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(5044, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a89259a5e0e2496894b89c7244e0252c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5095, 161, true);
                WriteLiteral("\r\n    <script src=\"//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js\"></script>\r\n    <script src=\"//code.jquery.com/jquery-1.11.1.min.js\"></script>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5263, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
#pragma checksum "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ad799d0af0580dd30abbe56881a335cec0d8c90"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ad799d0af0580dd30abbe56881a335cec0d8c90", @"/Views/Order/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4cd9bb444bef839053be6cf1d50c971c91cdb80", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookStoreApplication.Models.ProcessOrder>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("LoginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(219, 3143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f76205c5d6694d05a611c632185ec6c5", async() => {
                BeginContext(225, 3130, true);
                WriteLiteral(@"
    <style>
        .invoice-title h2, .invoice-title h3 {
            display: inline-block;
        }

        .table > tbody > tr > .no-line {
            border-top: none;
        }

        .table > thead > tr > .no-line {
            border-bottom: none;
        }

        .table > tbody > tr > .thick-line {
            border-top: 2px solid;
        }

        body#LoginForm {
            background-repeat: no-repeat;
            background-position: center;
            background-size: cover;
            padding: 10px;
        }

        .form-heading {
            color: #fff;
            font-size: 23px;
        }

        .panel h2 {
            color: #444444;
            font-size: 18px;
            margin: 0 0 8px 0;
        }

        .panel p {
            color: #777777;
            font-size: 14px;
            margin-bottom: 30px;
            line-height: 24px;
        }

        .login-form .form-control {
            background: #f7f7f7 none rep");
                WriteLiteral(@"eat scroll 0 0;
            border: 2px solid double;
            border-radius: 4px;
            font-size: 14px;
            height: 50px;
            line-height: 50px;
        }

        .main-div {
            background: #ffffff none repeat scroll 0 0;
            border-radius: 2px;
            margin: 10px auto 30px;
            max-width: 38%;
            padding: 50px 70px 70px 71px;
        }

        .login-form .form-group {
            margin-bottom: 10px;
        }

        .login-form {
            text-align: center;
        }

        .forgot a {
            color: #777777;
            font-size: 14px;
            text-decoration: underline;
        }

        .login-form .btn.btn-primary {
            border-color: black;
            color: #ffffff;
            font-size: 14px;
            width: 100%;
            height: 50px;
            line-height: 50px;
            padding: 0;
        }

        .forgot {
            text-align: left;
         ");
                WriteLiteral(@"   margin-bottom: 30px;
        }

        .botto-text {
            color: #ffffff;
            font-size: 14px;
            margin: auto;
        }



        .back {
            text-align: left;
            margin-top: 10px;
        }

            .back a {
                color: #444444;
                font-size: 13px;
                text-decoration: none;
            }
    </style>
    <link href=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//netdna.bootstrapcdn.com/bootstrap/3.0.0/js/bootstrap.min.js""></script>
    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
    <script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
    <link rel=""stylesheet"" href=""http://maxcdn.bootst");
                WriteLiteral("rapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css\">\r\n");
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
            BeginContext(3362, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3364, 9197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e0738143f64d19abae6d00a9c6394f", async() => {
                BeginContext(3386, 2573, true);
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
                                            <td class=""text-c");
                WriteLiteral(@"enter""><strong>PRICE</strong></td>
                                            <td class=""text-center""><strong>QUANTITY</strong></td>
                                            <td class=""text-right""><strong>TOTAL</strong></td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <!-- foreach ($order->lineItems as $line) or some such thing here -->
                                        

");
                EndContext();
#line 184 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                         foreach (var item in list)
                                        {

#line default
#line hidden
                BeginContext(6071, 102, true);
                WriteLiteral("                                            <tr>\r\n                                                <td>");
                EndContext();
                BeginContext(6174, 10, false);
#line 187 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                               Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(6184, 79, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
                EndContext();
                BeginContext(6264, 10, false);
#line 188 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                                                   Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(6274, 79, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
                EndContext();
                BeginContext(6354, 13, false);
#line 189 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                                                   Write(item.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(6367, 78, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-right\">");
                EndContext();
                BeginContext(6446, 8, false);
#line 190 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                                                  Write(item.sum);

#line default
#line hidden
                EndContext();
                BeginContext(6454, 58, true);
                WriteLiteral("</td>\r\n                                            </tr>\r\n");
                EndContext();
#line 192 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
                                        }

#line default
#line hidden
                BeginContext(6555, 1156, true);
                WriteLiteral(@"                                        <tr>
                                            <td class=""thick-line""></td>
                                            <td class=""thick-line""></td>
                                            <td class=""thick-line text-center""><strong>Subtotal</strong></td>
                                            <td class=""thick-line text-right"">$670.99</td>
                                        </tr>
                                        <tr>
                                            <td class=""no-line""></td>
                                            <td class=""no-line""></td>
                                            <td class=""no-line text-center""><strong>Total</strong></td>
                                            <td class=""no-line text-right"">$685.99</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </d");
                WriteLiteral("iv>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <button class=\"btn btn-success btn-primary\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 7711, "\"", 7784, 1);
#line 212 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Order\Payment.cshtml"
WriteAttributeValue("", 7721, "window.location.href='" + @Url.Action("Pay", "Order") + "'", 7721, 63, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7785, 43, true);
                WriteLiteral(">PAY</button>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
                BeginContext(12550, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12561, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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

#pragma checksum "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c501a4fdf2e7897342380a484eebc21097750c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Pay), @"mvc.1.0.view", @"/Views/Order/Pay.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Pay.cshtml", typeof(AspNetCore.Views_Order_Pay))]
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
#line 1 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
using BookStoreLibrary;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c501a4fdf2e7897342380a484eebc21097750c4", @"/Views/Order/Pay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86eaecdd000890fc07b3bf0849fe94670258f063", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Pay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Success", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("javascript:void(0);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("payment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(90, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
  
    ViewData["Title"] = "Pay";
    //var list = (List<ProcessOrder>)ViewData["products"];
    var list = (ProductViewModelCart[])ViewData["products"];

#line default
#line hidden
#line 8 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(280, 10, true);
            WriteLiteral("\r\n<html>\r\n");
            EndContext();
            BeginContext(290, 2978, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c1909fcfdf64e0cbf4f64d7617e5e51", async() => {
                BeginContext(296, 2309, true);
                WriteLiteral(@"
    <style>
        /* Padding - just for asthetics on Bootsnipp.com */
        body {
            margin-top: 20px;
        }

        /* CSS for Credit Card Payment form */
        .credit-card-box .panel-title {
            display: inline;
            font-weight: bold;
        }

        .credit-card-box .form-control.error {
            border-color: red;
            outline: 0;
            box-shadow: inset 0 1px 1px rgba(0,0,0,0.075),0 0 8px rgba(255,0,0,0.6);
        }
        #payment {
            border-color: black;
            border-collapse:collapse;
            margin: 30px 30px 30px 30px;
            padding: 30px 30px 30px 30px;
        }
        .credit-card-box label.error {
            font-weight: bold;
            color: red;
            padding: 2px 8px;
            margin-top: 2px;
        }

        .credit-card-box .payment-errors {
            font-weight: bold;
            color: red;
            padding: 2px 8px;
            margin-top: 2px;
");
                WriteLiteral(@"        }

        .credit-card-box label {
            display: block;
        }
        /* The old ""center div vertically"" hack */
        .credit-card-box .display-table {
            display: table;
        }

        .credit-card-box .display-tr {
            display: table-row;
        }

        .credit-card-box .display-td {
            display: table-cell;
            vertical-align: middle;
            width: 50%;
        }
        /* Just looks nicer */
        .credit-card-box .panel-heading img {
            min-width: 180px;
        }
        div.main {
            width: 320px;
            padding: 10px 60px 15px;
            box-shadow: 0 0 10px;
            border-radius: 2px;
            font-size: 13px;
            margin: 0 auto 50px;
        }

        /*span {
            margin-right: 17px;
            font-size: 15px;
        }*/

        input[type=radio] {
            margin: 10px 10px 0 10px;
            transform: scale(2,2);
        }

   ");
                WriteLiteral(@"     /*label {
            color: #464646;
            font-size: 15px;
            font-weight: bold;
        }*/


    </style>
    <link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
    ");
                EndContext();
                BeginContext(2605, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b65c34192839404580fd5dc0bf04da13", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2656, 605, true);
                WriteLiteral(@"

    <script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
    <link rel=""stylesheet"" href=""http://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"">
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.13.1/jquery.validate.min.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/jquery.payment/1.2.3/jquery.payment.min.js""></script>
    <!-- If you're using Stripe for payments -->
    <script type=""text/javascript"" src=""https://js.stripe.com/v2/""></script>
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
            BeginContext(3268, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3270, 9553, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee379ca3e402477ebe96fba2ad5a8da7", async() => {
                BeginContext(3289, 379, true);
                WriteLiteral(@"

    <div class=""container"">
        <div class=""row"">
            <!-- You can make it whatever width you want. I'm making it full width
                 on <= small devices and 4/12 page width on >= medium devices -->
            <div class=""col-xs-12 col-md-6"">


                <div class=""main"">
                    <h3>PAYMENT OPTIONS</h3>
                    ");
                EndContext();
                BeginContext(3668, 763, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1283baab62334c8ab20cf64cd818fc17", async() => {
                    BeginContext(3742, 682, true);
                    WriteLiteral(@"

                        <input type=""radio"" name=""PayMode"" value=""COD"" id=""enable"" checked>

                        <label>Cash On Delivery </label>
                        <br />
                        <input type=""radio"" name=""PayMode"" value=""CC"" id=""disable"">

                        <label>Credit Card</label>
                        <br />
                        <input type=""radio"" name=""PayMode"" value=""DC"" id=""disable"">

                        <label>Debit Card</label>
                        <div>
                            <button type=""submit"" class=""btn btn-success btn-primary"" >PAY</button>
                        </div>
                    ");
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
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4431, 706, true);
                WriteLiteral(@"
                </div>

                <!-- CREDIT CARD FORM STARTS HERE -->

                <div class=""panel panel-default credit-card-box"" id=""divcard"">
                    <div class=""panel-heading display-table"">
                        <div class=""row display-tr"">
                            <h3 class=""panel-title display-td"">Payment Details</h3>
                            <div class=""display-td"">
                                <img class=""img-responsive pull-right"" src=""http://i76.imgup.net/accepted_c22e0.png"">
                            </div>
                        </div>
                    </div>
                    <div class=""panel-body"">
                        ");
                EndContext();
                BeginContext(5137, 3347, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06743479261046f99ad42b8b7170c4b3", async() => {
                    BeginContext(5216, 2798, true);
                    WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-xs-12"">
                                    <div class=""form-group"">
                                        <label for=""cardNumber"">CARD NUMBER</label>
                                        <div class=""input-group"">
                                            <input type=""tel""
                                                   class=""form-control""
                                                   name=""cardNumber""
                                                   placeholder=""Valid Card Number""
                                                   autocomplete=""cc-number""
                                                   required autofocus />
                                            <span class=""input-group-addon""><i class=""fa fa-credit-card""></i></span>
                                        </div>
                                    </div>
                                </div>
             ");
                    WriteLiteral(@"               </div>
                            <div class=""row"">
                                <div class=""col-xs-7 col-md-7"">
                                    <div class=""form-group"">
                                        <label for=""cardExpiry""><span class=""hidden-xs"">EXPIRATION</span><span class=""visible-xs-inline"">EXP</span> DATE</label>
                                        <input type=""tel""
                                               class=""form-control""
                                               name=""cardExpiry""
                                               placeholder=""MM / YY""
                                               autocomplete=""cc-exp""
                                               required />
                                    </div>
                                </div>
                                <div class=""col-xs-5 col-md-5 pull-right"">
                                    <div class=""form-group"">
                                        <label fo");
                    WriteLiteral(@"r=""cardCVC"">CV CODE</label>
                                        <input type=""tel""
                                               class=""form-control""
                                               name=""cardCVC""
                                               placeholder=""CVC""
                                               autocomplete=""cc-csc""
                                               required />
                                    </div>
                                </div>
                            </div>

                            <div class=""row"">
                                <div class=""col-xs-12"">
                                    <button class=""subscribe btn btn-success btn-lg btn-block"" type=""button""");
                    EndContext();
                    BeginWriteAttribute("onclick", " onclick=\"", 8014, "\"", 8091, 1);
#line 195 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
WriteAttributeValue("", 8024, "window.location.href='" + @Url.Action("Success", "Order") + "'", 8024, 67, false);

#line default
#line hidden
                    EndWriteAttribute();
                    BeginContext(8092, 385, true);
                    WriteLiteral(@">Pay</button>
                                </div>
                            </div>
                            <div class=""row"" style=""display:none;"">
                                <div class=""col-xs-12"">
                                    <p class=""payment-errors""></p>
                                </div>
                            </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8484, 1430, true);
                WriteLiteral(@"
                    </div>
                </div>
                <!-- CREDIT CARD FORM ENDS HERE -->


            </div>

            <div class=""col-xs-12 col-md-6"" style=""font-size: 12pt; line-height: 2em;"">
                <div class=""container card-deck bg-dark mb-3"" style=""width:50rem;"">
                    <div class=""panel panel-default"">
                        <div class=""panel-heading"">
                            <h3 class=""panel-title""><strong>Order Details</strong></h3>
                        </div>
                        <div class=""panel-body"">
                            <div class=""table-responsive"">
                                <table class=""table table-condensed"">
                                    <thead>
                                        <tr>
                                            <td><strong>ITEM</strong></td>
                                            <td class=""text-center""><strong>PRICE</strong></td>
                                           ");
                WriteLiteral(@" <td class=""text-center""><strong>QUANTITY</strong></td>
                                            <td class=""text-right""><strong>TOTAL</strong></td>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <!-- foreach ($order->lineItems as $line) or some such thing here -->


");
                EndContext();
#line 232 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
                                         foreach (var item in list)
                                        {

#line default
#line hidden
                BeginContext(10026, 102, true);
                WriteLiteral("                                            <tr>\r\n                                                <td>");
                EndContext();
                BeginContext(10129, 10, false);
#line 235 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
                                               Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(10139, 79, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
                EndContext();
                BeginContext(10219, 10, false);
#line 236 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
                                                                   Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(10229, 79, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-center\">");
                EndContext();
                BeginContext(10309, 13, false);
#line 237 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
                                                                   Write(item.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(10322, 78, true);
                WriteLiteral("</td>\r\n                                                <td class=\"text-right\">");
                EndContext();
                BeginContext(10401, 48, false);
#line 238 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
                                                                  Write(string.Format("{0}", item.Quantity * item.Price));

#line default
#line hidden
                EndContext();
                BeginContext(10449, 58, true);
                WriteLiteral("</td>\r\n                                            </tr>\r\n");
                EndContext();
#line 240 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
                                        }

#line default
#line hidden
                BeginContext(10550, 48, true);
                WriteLiteral("\r\n                                        <tr>\r\n");
                EndContext();
#line 243 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
                                              

                                                int total = 0;
                                                foreach (var item in list)
                                                {
                                                    total += (int)@item.Price * @item.Quantity;
                                                }

#line default
#line hidden
                BeginContext(10987, 338, true);
                WriteLiteral(@"                                                <td class=""no-line""></td>
                                                <td class=""no-line""></td>
                                                <td class=""no-line text-center""><strong>Total</strong></td>
                                                <td class=""no-line text-right"">");
                EndContext();
                BeginContext(11326, 5, false);
#line 253 "D:\OnlineBookStore\BookStoreApplication\Views\Order\Pay.cshtml"
                                                                          Write(total);

#line default
#line hidden
                EndContext();
                BeginContext(11331, 7, true);
                WriteLiteral("</td>\r\n");
                EndContext();
                BeginContext(11385, 315, true);
                WriteLiteral(@"
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>




                </div>
            </div>

        </div>
    </div>
");
                EndContext();
                BeginContext(12503, 313, true);
                WriteLiteral(@"
    <script>
        $('#divcard').hide();
        $('input[type=radio]').change(function (e) {
            var val = e.target.value;
            if (val == 'CC' || val == 'DC')
                $('#divcard').show();
            else
                $('#divcard').hide();
        });


    </script>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12823, 19, true);
            WriteLiteral("\r\n\r\n</html>\r\n\r\n\r\n\r\n");
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

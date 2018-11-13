#pragma checksum "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56f72353a2f97135f09328700601bb5a4d7cbc55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ReorderLevel), @"mvc.1.0.view", @"/Views/Admin/ReorderLevel.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ReorderLevel.cshtml", typeof(AspNetCore.Views_Admin_ReorderLevel))]
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
#line 1 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
using BookStoreWebService.Models.BookDB;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56f72353a2f97135f09328700601bb5a4d7cbc55", @"/Views/Admin/ReorderLevel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86eaecdd000890fc07b3bf0849fe94670258f063", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ReorderLevel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStoreLibrary.ReorderLevelDetails[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateQuantity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
  
    ViewData["Title"] = "ReorderLevel";
    var list = (List<Book>)ViewData["Books"];
    int x = 0;

#line default
#line hidden
            BeginContext(200, 232, true);
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <br />\r\n        <div class=\"table-striped table-bordered table-success\">\r\n            <table>\r\n                <thead>\r\n\r\n                </thead>\r\n                <tbody>\r\n                    ");
            EndContext();
            BeginContext(432, 1665, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "231c52f632e84793847d2ccb16428487", async() => {
                BeginContext(515, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 18 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
                         for(var i=0;i<list.Count;i++)
                        {

#line default
#line hidden
                BeginContext(600, 233, true);
                WriteLiteral("                            <div class=\"container\">\r\n                                <div class=\"row table-striped\">\r\n                                    <div class=\"col-md-3 order-div \">\r\n                                        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 833, "\"", 853, 1);
#line 23 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
WriteAttributeValue("", 839, list[i].Image, 839, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(854, 245, true);
                WriteLiteral(" style=\"width:100px;height:130px\" />\r\n                                    </div>\r\n                                    <div class=\"col-md-3 order-div \">\r\n                                        <br />\r\n                                        <h4>");
                EndContext();
                BeginContext(1100, 17, false);
#line 27 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
                                       Write(list[i].BookTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1117, 214, true);
                WriteLiteral("</h4>\r\n                                    </div>\r\n                                    <div class=\"col-md-3 order-div \">\r\n                                        <br />\r\n                                        <h4>");
                EndContext();
                BeginContext(1332, 20, false);
#line 31 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
                                       Write(list[i].BookQuantity);

#line default
#line hidden
                EndContext();
                BeginContext(1352, 236, true);
                WriteLiteral("</h4>\r\n                                    </div>\r\n                                    <div class=\"col-xs-3 form-group\">\r\n                                        <br /><br />\r\n                                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1588, "\"", 1606, 3);
                WriteAttributeValue("", 1595, "[", 1595, 1, true);
#line 35 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
WriteAttributeValue("", 1596, i, 1596, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1598, "].BookId", 1598, 8, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1607, "\"", 1630, 1);
#line 35 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
WriteAttributeValue("", 1615, list[i].BookId, 1615, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1631, 64, true);
                WriteLiteral("/>\r\n                                        <input type=\"number\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 1695, "\"", 1715, 3);
                WriteAttributeValue("", 1702, "[", 1702, 1, true);
#line 36 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"
WriteAttributeValue("", 1703, i, 1703, 2, false);

#line default
#line hidden
                WriteAttributeValue("", 1705, "].Quantity", 1705, 10, true);
                EndWriteAttribute();
                BeginContext(1716, 158, true);
                WriteLiteral(" class=\"form-control\" id=\"quantity\">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
                EndContext();
#line 40 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\ReorderLevel.cshtml"

                           
                            
                        }

#line default
#line hidden
                BeginContext(1962, 128, true);
                WriteLiteral(" <button type=\"submit\" style=\"margin: auto; display: block\" class=\"btn btn-primary\">PLACE ORDER</button>\r\n\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2097, 66, true);
            WriteLiteral("\r\n</tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n  \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStoreLibrary.ReorderLevelDetails[]> Html { get; private set; }
    }
}
#pragma warning restore 1591

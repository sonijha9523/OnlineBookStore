#pragma checksum "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b30ba8c8ef90d83276a6612144dc61a01941507e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Index.cshtml", typeof(AspNetCore.Views_Admin_Index))]
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
#line 1 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
using BookStoreWebService.Models.BookDB;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b30ba8c8ef90d83276a6612144dc61a01941507e", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86eaecdd000890fc07b3bf0849fe94670258f063", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<BookStoreWebService.Models.BookDB.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slider1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slider2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slider3.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slider4.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slider5.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/slider6.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/im.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/hpimage.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/images.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("LoginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(95, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "HomePage";
    ViewData["Title"] = "Index";
    var book = ViewBag.AllBooks;

#line default
#line hidden
#line 9 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
  
    IEnumerable<Category> categories = ViewData["Categories"] as IEnumerable<Category>;

#line default
#line hidden
            BeginContext(296, 8, true);
            WriteLiteral("\n<html>\n");
            EndContext();
            BeginContext(304, 134, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ce6e72b8d4744a7aa07ffd6d93f77e1", async() => {
                BeginContext(310, 121, true);
                WriteLiteral("  \n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\n");
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
            BeginContext(438, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(439, 6100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4df03532385c4e78b6530e7c4fd18ccb", async() => {
                BeginContext(460, 782, true);
                WriteLiteral(@"
   
    <marquee><b style=""color:black"">.....THAT'S THE THING ABOUT BOOKS, THEY LET YOU TRAVEL WITHOUT MOVING YOUR FEET.....</b></marquee>
    <nav class=""navbar navbar-expand-md navbar-dark bg-dark fixed-top"">
        <a class=""navbar-brand"" style=""color:white"">BOOK STORE</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarsExampleDefault""
                aria-controls=""navbarsExampleDefault"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse"" id=""navbarsExampleDefault"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link active""");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1242, "\"", 1316, 1);
#line 30 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1252, "window.location.href='" + @Url.Action("Index", "Home") + "'", 1252, 64, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1317, 155, true);
                WriteLiteral(">Home <span class=\"sr-only\">(current)</span></a>\n                </li>\n                <li class=\"nav-item active\">\n                    <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1472, "\"", 1549, 1);
#line 33 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1482, "window.location.href='" + @Url.Action("Contact", "Admin") + "'", 1482, 67, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1550, 158, true);
                WriteLiteral(">Contact <span class=\"sr-only\">(current)</span></a>\n                </li>\n                <li class=\"nav-item active\">\n                    <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1708, "\"", 1783, 1);
#line 36 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1718, "window.location.href='" + @Url.Action("About", "Admin") + "'", 1718, 65, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1784, 156, true);
                WriteLiteral(">About <span class=\"sr-only\">(current)</span></a>\n                </li>\n                <li class=\"nav-item active\">\n                    <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1940, "\"", 2018, 1);
#line 39 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
WriteAttributeValue("", 1950, "window.location.href='" + @Url.Action("Register", "Admin") + "'", 1950, 68, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2019, 157, true);
                WriteLiteral(">SignUp <span class=\"sr-only\">(current)</span></a>\n                </li>\n                <li class=\"nav-item active\">\n                    <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2176, "\"", 2251, 1);
#line 42 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2186, "window.location.href='" + @Url.Action("Login", "Admin") + "'", 2186, 65, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2252, 157, true);
                WriteLiteral("> Login <span class=\"sr-only\">(current)</span></a>\n                </li>\n                <li class=\"nav-item active\">\n                    <a class=\"nav-link\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 2409, "\"", 2489, 1);
#line 45 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
WriteAttributeValue("", 2419, "window.location.href='" + @Url.Action("LoginAdmin", "Admin") + "'", 2419, 70, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2490, 154, true);
                WriteLiteral(">AdminLogin <span class=\"sr-only\">(current)</span></a>\n                </li>\n            </ul>\n            <div class=\"search-container\">\n                ");
                EndContext();
                BeginContext(2644, 213, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83189c3a0ea749fca11b3b847b4a6822", async() => {
                    BeginContext(2676, 174, true);
                    WriteLiteral("\n                    <input type=\"text\" placeholder=\"Search..\" name=\"search\">\n                    <button type=\"submit\"><i class=\"fa fa-search\"></i></button>\n                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2857, 281, true);
                WriteLiteral(@"
            </div>
        </div>
    </nav>

    <br />
    <div id=""slider"">

        <div id=""carouselExampleControls"" class=""carousel slide"" data-ride=""carousel"">
            <div class=""carousel-inner"">
                <div class=""carousel-item active"">

                    ");
                EndContext();
                BeginContext(3138, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e2303f0c1eee476293464d2eae5b7dab", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3195, 89, true);
                WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n\n                    ");
                EndContext();
                BeginContext(3284, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "88b8a74a6e7d48ab876f1070ade2fd38", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3341, 89, true);
                WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n\n                    ");
                EndContext();
                BeginContext(3430, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "05d6c26fb3894d1b82c2c00ca1a05dbf", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3487, 89, true);
                WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n\n                    ");
                EndContext();
                BeginContext(3576, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "297a989d5b284a849a4f33a1033acb72", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3633, 89, true);
                WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n\n                    ");
                EndContext();
                BeginContext(3722, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "79dc9a2fd7e04adabf5dff70a5d5c792", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3779, 89, true);
                WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n\n                    ");
                EndContext();
                BeginContext(3868, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "078fb26bb75e44b59a3398ce887a2855", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3925, 89, true);
                WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n\n                    ");
                EndContext();
                BeginContext(4014, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "12891d90272249f990d5012621376ba5", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4066, 90, true);
                WriteLiteral("\n                </div>\n                <div class=\"carousel-item\">\n\n\n                    ");
                EndContext();
                BeginContext(4156, 57, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ce26ea33f5914923a777f49f005fb57a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4213, 95, true);
                WriteLiteral("\n                </div>\n                <div class=\"carousel-item acti\">\n\n\n                    ");
                EndContext();
                BeginContext(4308, 56, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "916dfe8e28c94b1b95da694c3aea23c2", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4364, 948, true);
                WriteLiteral(@"
                </div>
            </div>
            <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
    <br /><hr />
    <div class=""container"">
        <div class=""row"">

            <div class=""col-md-4"">
                <nav>
                    <button class=""btn btn-secondary btn-block"" style=""background-color:black;border: 1px solid;color: white;padding: 10px 50px;cursor: pointer;width: 100%;display: block;"" type=""button"">CATEGORIES</button>

");
                EndContext();
#line 119 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
                     foreach (var c in categories)
                    {

#line default
#line hidden
                BeginContext(5385, 138, true);
                WriteLiteral("                        <div>\n\n                            <button class=\"btn btn-secondary btn-block btn-cat\" role=\"group\"  type=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", "   onclick=\"", 5523, "\"", 5625, 1);
#line 123 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
WriteAttributeValue("", 5535, "window.location.href='" + @Url.Action("Index", "Admin",new { id = c.CategoryId}) + "'", 5535, 90, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5626, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(5628, 15, false);
#line 123 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
                                                                                                                                                                                                              Write(c.CategoryTitle);

#line default
#line hidden
                EndContext();
                BeginContext(5643, 41, true);
                WriteLiteral("</button>\n                        </div>\n");
                EndContext();
#line 125 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
                    }

#line default
#line hidden
                BeginContext(5706, 137, true);
                WriteLiteral("                </nav>\n            </div>\n            <div class=\"col-md-8\">\n                <div class=\"row text-center text-lg-left\">\r\n");
                EndContext();
#line 130 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
                         foreach (var obj in Model)
                        {


#line default
#line hidden
                BeginContext(5925, 250, true);
                WriteLiteral("                            <div class=\"card card-body text-center border-secondary\" style=\"align-items:center;width: 10rem;margin:10px; padding: 1px 1px 1px 1px;display: table;clear: both;\">\r\n                                <img class=\"card-img-top\"");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 6175, "\"", 6191, 1);
#line 134 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
WriteAttributeValue("", 6181, obj.Image, 6181, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6192, 109, true);
                WriteLiteral(" alt=\"Card image cap\" style=\"margin:10px ;width: 100px;height: 150px;\">\r\n                                <h6>");
                EndContext();
                BeginContext(6302, 13, false);
#line 135 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
                               Write(obj.BookTitle);

#line default
#line hidden
                EndContext();
                BeginContext(6315, 43, true);
                WriteLiteral("</h6>\r\n                                <h6>");
                EndContext();
                BeginContext(6359, 9, false);
#line 136 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"
                               Write(obj.Price);

#line default
#line hidden
                EndContext();
                BeginContext(6368, 43, true);
                WriteLiteral("</h6>\r\n                            </div>\r\n");
                EndContext();
#line 138 "D:\OnlineBookStore\BookStoreApplication\Views\Admin\Index.cshtml"


                        }                   

#line default
#line hidden
                BeginContext(6460, 72, true);
                WriteLiteral("                </div>\n\n            </div>\n        </div>\n    </div>\n  \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6539, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<BookStoreWebService.Models.BookDB.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591

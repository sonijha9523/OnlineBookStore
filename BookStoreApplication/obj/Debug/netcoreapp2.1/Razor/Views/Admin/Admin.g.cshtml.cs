#pragma checksum "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc1360d1063d3f31ad275d9a0360d8833d4407d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Admin), @"mvc.1.0.view", @"/Views/Admin/Admin.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Admin.cshtml", typeof(AspNetCore.Views_Admin_Admin))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc1360d1063d3f31ad275d9a0360d8833d4407d7", @"/Views/Admin/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4cd9bb444bef839053be6cf1d50c971c91cdb80", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\Admin.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
            BeginContext(43, 28, true);
            WriteLiteral("\r\n<h2>Admin</h2>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(71, 818, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d86be88d3313406ea77b9b5263eab4c8", async() => {
                BeginContext(77, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(889, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(891, 566, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4cef3e082d24d64b04cda269d85bbd9", async() => {
                BeginContext(897, 37, true);
                WriteLiteral("\r\n\r\n   \r\n\r\n    <button class=\"button\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 934, "\"", 1011, 1);
#line 49 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 944, "window.location.href='" + @Url.Action("AddBook", "Admin") + "'", 944, 67, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1012, 53, true);
                WriteLiteral(">AddBook</button>\r\n    <button class=\"button button2\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1065, "\"", 1143, 1);
#line 50 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 1075, "window.location.href='" + @Url.Action("GetBooks", "Admin") + "'", 1075, 68, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1144, 56, true);
                WriteLiteral(">UpdateBook</button>\r\n    <button class=\"button button3\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1200, "\"", 1278, 1);
#line 51 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 1210, "window.location.href='" + @Url.Action("GetBooks", "Admin") + "'", 1210, 68, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1279, 56, true);
                WriteLiteral(">DeleteBook</button>\r\n    <button class=\"button button4\"");
                EndContext();
                BeginWriteAttribute("onclick", " onclick=\"", 1335, "\"", 1419, 1);
#line 52 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\Admin.cshtml"
WriteAttributeValue("", 1345, "window.location.href='" + @Url.Action("RemoveCustomer", "Admin") + "'", 1345, 74, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1420, 30, true);
                WriteLiteral(">RemoveCustomer</button>\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1457, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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

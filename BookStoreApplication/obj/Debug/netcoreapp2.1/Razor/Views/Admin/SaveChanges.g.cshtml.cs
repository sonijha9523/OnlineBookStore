#pragma checksum "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\SaveChanges.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce435f7ce36480fd44be214484a50181c5e9bc7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SaveChanges), @"mvc.1.0.view", @"/Views/Admin/SaveChanges.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/SaveChanges.cshtml", typeof(AspNetCore.Views_Admin_SaveChanges))]
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
#line 1 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\SaveChanges.cshtml"
using BookStoreWebService.Models.BookDB;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce435f7ce36480fd44be214484a50181c5e9bc7a", @"/Views/Admin/SaveChanges.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4cd9bb444bef839053be6cf1d50c971c91cdb80", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SaveChanges : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<BookStoreWebService.Models.BookDB.Book>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(96, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\SaveChanges.cshtml"
  
    ViewData["Title"] = "GetBooks";
    var book = ViewBag.AllBooks;

#line default
#line hidden
            BeginContext(551, 230, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <table class=\"table table-striped\">\r\n        <thead>\r\n            <tr>\r\n                <th>BookId</th>\r\n                <th>BookTitle</th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 40 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\SaveChanges.cshtml"
             foreach
(var obj in
Model)
            {

#line default
#line hidden
            BeginContext(839, 81, true);
            WriteLiteral("                <tr>\r\n                    <td><input type=\"text\" name=\"BookTitle\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 920, "", 941, 1);
#line 45 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\SaveChanges.cshtml"
WriteAttributeValue("", 927, obj.BookTitle, 927, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(941, 69, true);
            WriteLiteral(" /></td>\r\n                    <td><input type=\"text\" name=\"BookPrice\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1010, "", 1027, 1);
#line 46 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\SaveChanges.cshtml"
WriteAttributeValue("", 1017, obj.Price, 1017, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1027, 72, true);
            WriteLiteral(" /></td>\r\n                    <td><input type=\"text\" name=\"BookQuantity\"");
            EndContext();
            BeginWriteAttribute("value", " value=", 1099, "", 1123, 1);
#line 47 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\SaveChanges.cshtml"
WriteAttributeValue("", 1106, obj.BookQuantity, 1106, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1123, 141, true);
            WriteLiteral(" /></td>\r\n                    <td> <button type=\"submit\" id=\"save\" class=\"btn btn-primary\">SaveChanges</button></td>\r\n                </tr>\r\n");
            EndContext();
#line 50 "C:\Users\Training\Desktop\Finaltill10thOctobe - Copy\OnlineBookStoreSystem\BookStoreApplication\Views\Admin\SaveChanges.cshtml"

            }

#line default
#line hidden
            BeginContext(1281, 23, true);
            WriteLiteral("    </table>>\r\n</div>\r\n");
            EndContext();
            BeginContext(1304, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aeec708e39b7442b967771aed935f8ac", async() => {
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
            BeginContext(1355, 770, true);
            WriteLiteral(@"
<script>


    $(document).ready(function () {
        $('input').attr(""disabled"", ""disabled"");

        $('#edit-btn').click(function (e) {

            $('input').removeAttr(""disabled"");

        });
        $('#save').click(function (e) {

            //$.ajax function is used to make ajax requests to the home controller and its actions
            $.ajax({
                crossDomain: true,
                url: 'http://localhost:64966/AdminService/EditNewBook' //Home controller and GetSubCategories action
                type: 'GET',
                // we want to make a HTTPGET request
                success: function (data) {
                    alert(data)
                }
            });


        });
    });
</script>

");
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
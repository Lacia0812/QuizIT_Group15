#pragma checksum "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e1ca972167fb7dea609903b5e0e136130d6c20cbf4a5eb3e84186ab77349c403"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_QuestionAdmin_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/QuestionAdmin/Create.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml"
 using QuizIT.Service.Entities

#nullable disable
    ;
#nullable restore
#line 2 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml"
 using QuizIT.Service.Models

#nullable disable
    ;
#nullable restore
#line 3 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml"
 using QuizIT.Common.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e1ca972167fb7dea609903b5e0e136130d6c20cbf4a5eb3e84186ab77349c403", @"/Areas/Admin/Views/QuestionAdmin/Create.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_QuestionAdmin_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/question.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/cau-hoi"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/cau-hoi/tao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml"
  
    ViewData["Title"] = "QuizIT Admin | Thêm câu hỏi";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    var categoryLst = ViewBag.CategoryLst as List<Category>;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ca972167fb7dea609903b5e0e136130d6c20cbf4a5eb3e84186ab77349c4035127", async() => {
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
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<h1 class=\"cotent-title\">Thêm câu hỏi</h1>\r\n<ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ca972167fb7dea609903b5e0e136130d6c20cbf4a5eb3e84186ab77349c4036427", async() => {
                WriteLiteral("Danh sách câu hỏi");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </li>\r\n    <li class=\"breadcrumb-item active\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ca972167fb7dea609903b5e0e136130d6c20cbf4a5eb3e84186ab77349c4037591", async() => {
                WriteLiteral("Thêm câu hỏi");
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
            WriteLiteral(@"</li>
</ol>
<div class=""content-card mt-4"">
    <h1 class=""form-sub-title"">Thông tin cơ bản</h1>
    <form id=""form-question"">
        <div class=""form-group"">
            <span class=""form-title required"">Chủ đề</span>
            <select class=""form-input"" type=""text"" name=""CategoryId"">
");
#nullable restore
#line 27 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml"
                 foreach (var category in categoryLst)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 1002, "\"", 1022, 1);
            WriteAttributeValue("", 1010, 
#nullable restore
#line 29 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml"
                                    category.Id

#line default
#line hidden
#nullable disable
            , 1010, 12, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 29 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml"
                                                  category?.CategoryName.Trim()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</option>\r\n");
#nullable restore
#line 30 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\QuestionAdmin\Create.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"            </select>
        </div>
        <div class=""form-group"">
            <span class=""form-title required"">Câu hỏi</span>
            <textarea class=""form-input"" type=""text"" name=""Content"" cols=""5""></textarea>
        </div>
        <div class=""form-group"">
            <span class=""form-title required"">Đáp án A</span>
            <textarea class=""form-input"" type=""text"" name=""AnswerA"" cols=""5""></textarea>
        </div>
        <div class=""form-group"">
            <span class=""form-title required"">Đáp án B</span>
            <textarea class=""form-input"" type=""text"" name=""AnswerB"" cols=""5""></textarea>
        </div>
        <div class=""form-group"">
            <span class=""form-title required"">Đáp án C</span>
            <textarea class=""form-input"" type=""text"" name=""AnswerC"" cols=""5""></textarea>
        </div>
        <div class=""form-group"">
            <span class=""form-title required"">Đáp án D</span>
            <textarea class=""form-input"" type=""text"" name=""AnswerD"" cols=""5"">");
            WriteLiteral(@"</textarea>
        </div>
        <div class=""form-group"">
            <span class=""form-title required"">Đáp án đúng</span>
            <select class=""form-input"" type=""text"" name=""AnswerCorrect"">
                <option value=""A"">A</option>
                <option value=""B"">B</option>
                <option value=""C"">C</option>
                <option value=""D"">D</option>
            </select>
        </div>
    </form>
</div>
<div class=""d-flex justify-content-end mt-4"">
    <button class=""btn-base m-btn-primary text-white"" id=""btn-create"">Lưu</button>
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e50647"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Areas_Admin_Views_ExamAdmin_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ExamAdmin/Index.cshtml")]
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
#line 1 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
 using QuizIT.Service.Entities

#nullable disable
    ;
#nullable restore
#line 2 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
 using QuizIT.Service.Models

#nullable disable
    ;
#nullable restore
#line 3 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
 using QuizIT.Common.Models

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e50647", @"/Areas/Admin/Views/ExamAdmin/Index.cshtml")]
    #nullable restore
    internal sealed class Areas_Admin_Views_ExamAdmin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 4 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
       List<Exam>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/admin/exam.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-base m-btn-grey text-white ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/bo-de/thong-ke"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-base m-btn-primary text-white ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/admin/bo-de/tao"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 6 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
  
    ViewData["Title"] = "QuizIT Admin | Danh sách bộ đề";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    var paginationModel = ViewBag.PaginationModel as PaginationModel;
    var filter = ViewBag.Filter as FilterExam;
    var categoryLst = ViewBag.CategoryLst as List<Category>;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e506476171", async() => {
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
            WriteLiteral("<h1 class=\"cotent-title\">Danh sách bộ đề</h1>\r\n<div class=\"d-flex justify-content-end mt-4\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e506477454", async() => {
                WriteLiteral("\r\n        <i class=\'bx bx-bar-chart\'></i>\r\n        Thống kê\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e506478707", async() => {
                WriteLiteral("\r\n        <i class=\"bx bx-plus\"></i>\r\n        Thêm bộ đề\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<div class=""content-card"">
    <div class=""filter-group"">
        <div class=""container-fluid p-0"">
            <form id=""form-filter"">
                <div class=""row"">
                    <div class=""col-md-3 col-12 mb-3"">
                        <input type=""text"" class=""form-input"" placeholder=""Bộ đề""");
            BeginWriteAttribute("value", " value=\"", 1196, "\"", 1216, 1);
            WriteAttributeValue("", 1204, 
#nullable restore
#line 34 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                                                          filter.Name

#line default
#line hidden
#nullable disable
            , 1204, 12, false);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    </div>\r\n                    <div class=\"col-md-3 col-12 mb-3\">\r\n                        <select class=\"form-input\">\r\n                            <option value=\"-1\"");
            BeginWriteAttribute("selected", " selected=\"", 1405, "\"", 1455, 1);
            WriteAttributeValue("", 1416, 
#nullable restore
#line 38 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                           -1 == filter.Category ? true : false

#line default
#line hidden
#nullable disable
            , 1416, 39, false);
            EndWriteAttribute();
            WriteLiteral(">Chủ đề: Tất cả</option>\r\n");
#nullable restore
#line 39 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                             foreach (var category in categoryLst)
                            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                                <option");
            BeginWriteAttribute("value", " value=\"", 1620, "\"", 1640, 1);
            WriteAttributeValue("", 1628, 
#nullable restore
#line 41 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                category.Id

#line default
#line hidden
#nullable disable
            , 1628, 12, false);
            EndWriteAttribute();
            BeginWriteAttribute("selected", " selected=\"", 1641, "\"", 1700, 1);
            WriteAttributeValue("", 1652, 
#nullable restore
#line 41 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                                         category.Id == filter.Category ? true : false

#line default
#line hidden
#nullable disable
            , 1652, 48, false);
            EndWriteAttribute();
            WriteLiteral(">Chủ đề: ");
            Write(
#nullable restore
#line 41 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                                                                                                  category?.CategoryName.Trim()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</option>\r\n");
#nullable restore
#line 42 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                        </select>
                    </div>
                    <div class=""col-md-3 col-12 mb-3"">
                        <button class=""btn-base m-btn-secondary text-white"">
                            <i class=""bx bx-search""></i>
                            Tìm kiếm
                        </button>
                    </div>
                </div>
            </form>
        </div>
    </div>
");
#nullable restore
#line 55 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
     if (Model.Count == 0)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <p class=\"text-center mt-4\">Không có dữ liệu</p>\r\n");
#nullable restore
#line 58 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
    }
    else
    {
        int index = 1;

#line default
#line hidden
#nullable disable

            WriteLiteral(@"        <div class=""table-responsive mt-4"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th>STT</th>
                        <th>Bộ đề</th>
                        <th>Chủ đề</th>
                        <th>Trạng thái</th>
                        <th>Thời gian làm</th>
                        <th>Số lượng câu</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 75 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                     foreach (var question in Model)
                    {

#line default
#line hidden
#nullable disable

            WriteLiteral("                        <tr>\r\n                            <td>");
            Write(
#nullable restore
#line 78 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                  (filter.PageNumber - 1)*filter.PageSize + index

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td class=\"mx-200\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e5064715937", async() => {
                Write(
#nullable restore
#line 80 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                                                                                      question.ExamName.Trim()

#line default
#line hidden
#nullable disable
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3106, "~/admin/bo-de/chi-tiet/", 3106, 23, true);
            AddHtmlAttributeValue("", 3129, 
#nullable restore
#line 80 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                                 question.Id

#line default
#line hidden
#nullable disable
            , 3129, 12, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
            Write(
#nullable restore
#line 80 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                                                           question.ExamName.Trim()

#line default
#line hidden
#nullable disable
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-title", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
            Write(
#nullable restore
#line 82 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                 question.Category.CategoryName.Trim()

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td>");
            Write(
#nullable restore
#line 83 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                  question.IsActive == true ? "Hoạt động" : "Không hoạt động"

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td>");
            Write(
#nullable restore
#line 84 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                  question.Time.ToString() + " phút"

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                            <td>");
            Write(
#nullable restore
#line 85 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                 question.ExamDetail.Count

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 87 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                        index++;
                    }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n        <div class=\"pagination d-flex align-items-center\">\r\n            <ul class=\"d-flex align-items-center\">\r\n");
#nullable restore
#line 95 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                 if (paginationModel.PageNumber > 1)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e5064721028", async() => {
                WriteLiteral("<i class=\'bx bx-chevrons-left\'></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3939, "~/admin/bo-de", 3939, 13, true);
            AddHtmlAttributeValue("", 3952, 
#nullable restore
#line 97 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                filter.GetQueryString(1, filter.Name, filter.Category)

#line default
#line hidden
#nullable disable
            , 3952, 57, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e5064722798", async() => {
                WriteLiteral("<i class=\'bx bx-chevron-left\'></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4090, "~/admin/bo-de", 4090, 13, true);
            AddHtmlAttributeValue("", 4103, 
#nullable restore
#line 98 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                filter.GetQueryString(filter.PageNumber - 1, filter.Name, filter.Category)

#line default
#line hidden
#nullable disable
            , 4103, 77, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 99 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

#nullable restore
#line 100 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                 foreach (var item in paginationModel.Pages)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e5064725115", async() => {
                Write(
#nullable restore
#line 102 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                                                                                                                                           item

#line default
#line hidden
#nullable disable
                );
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4360, "~/admin/bo-de", 4360, 13, true);
            AddHtmlAttributeValue("", 4373, 
#nullable restore
#line 102 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                filter.GetQueryString(item, filter.Name, filter.Category)

#line default
#line hidden
#nullable disable
            , 4373, 60, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4442, 
#nullable restore
#line 102 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                                                                                     item == paginationModel.PageNumber ? "active" : ""

#line default
#line hidden
#nullable disable
            , 4442, 53, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 103 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
#nullable restore
#line 105 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                 if (paginationModel.PageNumber < paginationModel.TotalPage)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e5064728496", async() => {
                WriteLiteral("<i class=\'bx bx-chevron-right\'></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4664, "~/admin/bo-de", 4664, 13, true);
            AddHtmlAttributeValue("", 4677, 
#nullable restore
#line 107 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                filter.GetQueryString(filter.PageNumber + 1, filter.Name, filter.Category)

#line default
#line hidden
#nullable disable
            , 4677, 77, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db2a42a6aad101653ac32ff4b4cc4eeca1cc01027877161403cc0424e5064730287", async() => {
                WriteLiteral("<i class=\'bx bx-chevrons-right\'></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4835, "~/admin/bo-de", 4835, 13, true);
            AddHtmlAttributeValue("", 4848, 
#nullable restore
#line 108 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                                                filter.GetQueryString(paginationModel.TotalPage, filter.Name, filter.Category)

#line default
#line hidden
#nullable disable
            , 4848, 81, false);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 109 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </ul>\r\n        </div>\r\n");
#nullable restore
#line 112 "F:\Downloads\Lab5_DL\DATN_UTC_2023-oiou0s\DATN_UTC_2023\QuizIT\QuizIT.Web\Areas\Admin\Views\ExamAdmin\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Exam>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

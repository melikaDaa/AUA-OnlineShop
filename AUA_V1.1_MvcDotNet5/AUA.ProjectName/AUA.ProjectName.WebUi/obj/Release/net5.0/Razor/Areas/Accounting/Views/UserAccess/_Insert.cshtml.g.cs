#pragma checksum "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Accounting_Views_UserAccess__Insert), @"mvc.1.0.view", @"/Areas/Accounting/Views/UserAccess/_Insert.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.GeneralModels.LoginModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.EntitiesDto.Accounting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.BaseViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Common.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa73e1cbaa1510d8129a5572c8ac062cf7bd58db", @"/Areas/Accounting/Views/UserAccess/_Insert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec40a47aaa51d43fa0db7473b4a215be6ab3108", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Accounting_Views_UserAccess__Insert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserAccessDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control  effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
Write(await Component.InvokeAsync("ModalForm", new ModalFormVm
{
    ModalFormId = "_InsertModal",
    ActionName = "_Insert",
    ModalSize = "modal-lg",
    Title = "New app user",
    BtnTitle = "Save",
    ViewContent =
        item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    WriteLiteral("\r\n            <div class=\"row pt-3 px-3 justify-content-center\">\r\n\r\n                <div class=\"col-12 col-md-6 col-sm-5  input-effect\">\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db7405", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 15 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AccessCode);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db8839", async() => {
        WriteLiteral("\r\n                    ");
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 16 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AccessCode);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = Html.GetEnumSelectList<EUserAccess>();

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                </div>\r\n                <div class=\"col-12 col-md-6 col-sm-5  input-effect\">\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db11069", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 20 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db12499", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 21 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Title);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"col-12 col-md-6 col-sm-5  input-effect\">\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db14103", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 25 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageTitle);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db15537", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 26 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageTitle);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                </div>\r\n\r\n\r\n                <div class=\"col-12 col-md-6 col-sm-5  input-effect\">\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db17149", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 31 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db18577", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 32 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Url);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"col-12 col-md-6 col-sm-5  input-effect\">\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db20179", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 36 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ParentId);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db21612", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 37 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ParentId);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                </div>\r\n                <div class=\"col-12 col-md-6 col-sm-12  input-effect\">\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db23216", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 40 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageDescription);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db24656", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 41 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.PageDescription);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"col-12 col-md-6 col-sm-5  input-effect\">\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db26270", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 45 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsIndirect);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db27700", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 46 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsIndirect);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"col-12 col-md-6 col-sm-5  input-effect\">\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db29239", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 50 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsActive);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                    ");
    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa73e1cbaa1510d8129a5572c8ac062cf7bd58db30667", async() => {
    }
    );
    __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 51 "C:\Users\ABC\Desktop\New folder (12)\AUA_V1.1_MvcDotNet5(1)\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\UserAccess\_Insert.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsActive);

#line default
#line hidden
#nullable disable
    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
    if (!__tagHelperExecutionContext.Output.IsContentModified)
    {
        await __tagHelperExecutionContext.SetOutputContentAsync();
    }
    Write(__tagHelperExecutionContext.Output);
    __tagHelperExecutionContext = __tagHelperScopeManager.End();
    WriteLiteral("\r\n                </div>\r\n\r\n              \r\n                <br />\r\n                <hr />\r\n\r\n            </div>\r\n\r\n        ");
    PopWriter();
}
)
}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserAccessDto> Html { get; private set; }
    }
}
#pragma warning restore 1591

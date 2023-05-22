#pragma checksum "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Dashboard\Views\AdminDashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a1336a9a1ced1de598f363a2d004904c47a286b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Dashboard_Views_AdminDashboard_Index), @"mvc.1.0.view", @"/Areas/Dashboard/Views/AdminDashboard/Index.cshtml")]
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
#line 1 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.GeneralModels.LoginModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.EntitiesDto.Accounting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.BaseViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Common.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a1336a9a1ced1de598f363a2d004904c47a286b", @"/Areas/Dashboard/Views/AdminDashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec40a47aaa51d43fa0db7473b4a215be6ab3108", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Dashboard_Views_AdminDashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Dashboard\Views\AdminDashboard\Index.cshtml"
  
    ViewData["PageTitle"] = "Dashboard";
    Layout = "DashboardLayout/Admin/_AdminDashboardLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-sm-12"">
    <div class=""alert  alert-success alert-dismissible fade show"" role=""alert"">
        <span class=""badge badge-pill badge-success"">AUA</span> Asp.Net Unique Architecture.
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
</div>

<div class=""col-md-6 col-lg-3"">
    <div class=""card bg-flat-color-1 text-light"">
        <div class=""card-body"">
            <div class=""h4 m-0"">Performance</div>
            <div class=""progress-bar bg-light mt-2 mb-2"" role=""progressbar"" style=""width: 20%; height: 5px;"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            <small class=""text-light"">Use the latest methodology and tools to speed up and produce modern web applications. </small>
        </div>
    </div>
</div>
<!--/.col-->

<div class=""col-md-6 col-lg-3"">
    <div class=""card bg-flat-color-3 text-light"">
        <div class=""card-body""");
            WriteLiteral(@">
            <div class=""h4 m-0"">Reusability</div>
            <div class=""progress-bar bg-light mt-2 mb-2"" role=""progressbar"" style=""width: 20%; height: 5px;"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            <small class=""text-light"">The ability to reuse relies in an essential way on the ability to build larger things from smaller parts. </small>
        </div>
    </div>
</div>
<!--/.col-->

<div class=""col-md-6 col-lg-3"">
    <div class=""card bg-flat-color-4 text-light"">
        <div class=""card-body"">
            <div class=""h4 m-0"">Simplicity</div>
            <div class=""progress-bar bg-light mt-2 mb-2"" role=""progressbar"" style=""width: 20%; height: 5px;"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            <small class=""text-light"">Quick and satisfactory way of producing a database-driven web application.</small>
        </div>
    </div>
</div>

<div class=""col-md-6 col-lg-3"">
    <div class=""card bg-flat-color-2 text-light"">
     ");
            WriteLiteral(@"   <div class=""card-body"">
         
            <div class=""h4 m-0"">Well Design</div>
            <div class=""progress-bar bg-light mt-2 mb-2"" role=""progressbar"" style=""width: 20%; height: 5px;"" aria-valuenow=""20"" aria-valuemin=""0"" aria-valuemax=""100""></div>
            <small class=""text-light"">Clean Architecture, Clean Code, Code Refactoring, Domain-driven design (DDD)</small>
        </div>
    </div>
</div>
");
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
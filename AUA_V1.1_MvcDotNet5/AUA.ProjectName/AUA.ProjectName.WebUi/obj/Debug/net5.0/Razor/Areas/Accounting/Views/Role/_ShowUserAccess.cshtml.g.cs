#pragma checksum "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_ShowUserAccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b7b22ace18b0983cb0776ceeb495e65e513052f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Accounting_Views_Role__ShowUserAccess), @"mvc.1.0.view", @"/Areas/Accounting/Views/Role/_ShowUserAccess.cshtml")]
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
#line 1 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.GeneralModels.LoginModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.EntitiesDto.Accounting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.BaseViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.Accounting.RoleModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Models.ListModes.Accounting.AppUserModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\_ViewImports.cshtml"
using AUA.ProjectName.Common.Extensions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b7b22ace18b0983cb0776ceeb495e65e513052f", @"/Areas/Accounting/Views/Role/_ShowUserAccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ec40a47aaa51d43fa0db7473b4a215be6ab3108", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Accounting_Views_Role__ShowUserAccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleActionVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 4 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_ShowUserAccess.cshtml"
      
        foreach (var userAccess in Model.UserAccessVms)
        {
            var isChecked = Model.RoleDto?.UserRoleAccess.Any(p => p.UserAccessId == userAccess.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-md-4 col-sm-5  input-effect\">\r\n\r\n                <input name=\"UserAccessIds\" id=\"UserAccessIds\"");
            BeginWriteAttribute("value", " value=\"", 350, "\"", 372, 1);
#nullable restore
#line 10 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_ShowUserAccess.cshtml"
WriteAttributeValue("", 358, userAccess.Id, 358, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("checked", " checked=\"", 373, "\"", 393, 1);
#nullable restore
#line 10 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_ShowUserAccess.cshtml"
WriteAttributeValue("", 383, isChecked, 383, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"checkbox\">\r\n                <span>");
#nullable restore
#line 11 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_ShowUserAccess.cshtml"
                 Write(userAccess.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n");
#nullable restore
#line 13 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Areas\Accounting\Views\Role\_ShowUserAccess.cshtml"

        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleActionVm> Html { get; private set; }
    }
}
#pragma warning restore 1591

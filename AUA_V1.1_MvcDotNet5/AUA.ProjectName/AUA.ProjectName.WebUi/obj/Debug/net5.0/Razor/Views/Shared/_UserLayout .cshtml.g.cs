#pragma checksum "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\_UserLayout .cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a00727f82633ef83b134f61a87608d62e1b1886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__UserLayout_), @"mvc.1.0.view", @"/Views/Shared/_UserLayout .cshtml")]
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
#line 1 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Common.Consts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Common.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.BaseViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.DomainEntities.Entities.Shop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a00727f82633ef83b134f61a87608d62e1b1886", @"/Views/Shared/_UserLayout .cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f2ce1c6875551f76f1702b46de2d543cd35e7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__UserLayout_ : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a00727f82633ef83b134f61a87608d62e1b18864737", async() => {
                WriteLiteral(@"
    <title>ثبت نام در سایت</title>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--===============================================================================================-->
    <link rel=""icon"" type=""image/png"" href=""images/icons/favicon.ico"" />
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/user/vendor/bootstrap/css/bootstrap.min.css"">
    <!--===============================================================================================-->

    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/user/vendor/animate/animate.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/user/vendor/css-hamburgers/hamburger");
                WriteLiteral(@"s.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/user/vendor/animsition/css/animsition.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/user/vendor/select2/select2.min.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/user/vendor/daterangepicker/daterangepicker.css"">
    <!--===============================================================================================-->
    <link rel=""stylesheet"" type=""text/css"" href=""/user/css/util.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/user/css/main.css"">
    <!--===============================================================================================-->
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a00727f82633ef83b134f61a87608d62e1b18867804", async() => {
                WriteLiteral(@"

    <div class=""limiter"" dir=""rtl"">
        <div class=""container-login100"">
            <div class=""wrap-login100"">
                <div class=""login100-form validate-form"">
                    <span class=""login100-form-title p-b-26"">
                        خوش آمدید
                    </span>
                  
                    ");
#nullable restore
#line 38 "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\_UserLayout .cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                   
                </div>

            </div>
        </div>
    </div>


    <div id=""dropDownSelect1""></div>

    <!--===============================================================================================-->
    <script src=""/user/vendor/jquery/jquery-3.2.1.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/user/vendor/animsition/js/animsition.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/user/vendor/bootstrap/js/popper.js""></script>
    <script src=""/user/vendor/bootstrap/js/bootstrap.min.js""></script>
    <!--===============================================================================================-->
    <script src=""/user/vendor/select2/select2.min.js""></script>
    <!--===============================================================================================-");
                WriteLiteral(@"->
    <script src=""/user/vendor/daterangepicker/moment.min.js""></script>
    <script src=""/user/vendor/daterangepicker/daterangepicker.js""></script>
    <!--===============================================================================================-->
    <script src=""/user/vendor/countdowntime/countdowntime.js""></script>
    <!--===============================================================================================-->
    <script src=""/user/js/main.js""></script>

");
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
            WriteLiteral("\r\n</html>");
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

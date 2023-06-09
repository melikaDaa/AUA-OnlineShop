#pragma checksum "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79dbb16b4a2ba5732214f0e7658799153f2d6759"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MessageProvider__DialogMessage), @"mvc.1.0.view", @"/Views/Shared/MessageProvider/_DialogMessage.cshtml")]
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
#line 1 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Common.Consts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Common.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.Models.ViewModels.BaseViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\_ViewImports.cshtml"
using AUA.ProjectName.DomainEntities.Entities.Shop;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79dbb16b4a2ba5732214f0e7658799153f2d6759", @"/Views/Shared/MessageProvider/_DialogMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f2ce1c6875551f76f1702b46de2d543cd35e7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MessageProvider__DialogMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
  
    var messageProvider = TempData[MessageTypeConsts.MessageProvider];

    if (messageProvider != null)
    {
        var messages = messageProvider
            .ToString()
            .ObjectDeserialize<List<MessageProviderVm>>();

        if (messages.Any())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>\r\n");
#nullable restore
#line 13 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                 foreach (var message in messages)
                {
                    if (message.MessageType == MessageTypeConsts.Message)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                          swal(\'");
#nullable restore
#line 18 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                           Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n                        ");
#nullable restore
#line 19 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                               
                    }
                    if (message.MessageType == MessageTypeConsts.Error)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            swal(\"Error!\", \'");
#nullable restore
#line 24 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                                       Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \"error\");\r\n                        ");
#nullable restore
#line 25 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                               
                    }
                    if (message.MessageType == MessageTypeConsts.Notify)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            swal(\"info!\", \'");
#nullable restore
#line 30 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                                      Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \"info\");\r\n                        ");
#nullable restore
#line 31 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                               
                    }
                    if (message.MessageType == MessageTypeConsts.Success)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            swal(\"success!\", \'");
#nullable restore
#line 36 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                                         Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \"success\");\r\n                        ");
#nullable restore
#line 37 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                               
                    }
                    if (message.MessageType == MessageTypeConsts.Warning)
                    {
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                         swal(\"warning!\", \'");
#nullable restore
#line 42 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                                      Write(message.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\', \"warning\");\r\n                        ");
#nullable restore
#line 43 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"
                               
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </script>\r\n");
#nullable restore
#line 47 "D:\New folder\git source\Online Shop AuA\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\MessageProvider\_DialogMessage.cshtml"

            TempData.Remove(MessageTypeConsts.MessageProvider);
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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

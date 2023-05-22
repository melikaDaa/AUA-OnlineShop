#pragma checksum "D:\New folder\aua\AUA_V1.1_MvcDotNet5\AUA.ProjectName\AUA.ProjectName.WebUI\Views\Shared\DashboardLayout\Admin\_AdminDashboardLayoutJs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0a624280ddee18234d789ad45fd166562d9ea55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DashboardLayout_Admin__AdminDashboardLayoutJs), @"mvc.1.0.view", @"/Views/Shared/DashboardLayout/Admin/_AdminDashboardLayoutJs.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0a624280ddee18234d789ad45fd166562d9ea55", @"/Views/Shared/DashboardLayout/Admin/_AdminDashboardLayoutJs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f2ce1c6875551f76f1702b46de2d543cd35e7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DashboardLayout_Admin__AdminDashboardLayoutJs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script>

    function showUpdateModalForm(keyId) {
        const url = _updateUrl.replace(""__"", keyId);

        $.get(url, function (data) {
            $('#modal-form-placeholder').html(data);

            $('#_updateModalForm').modal('show');
        });
    }

    function showInsertModalForm() {
        $.get(_insertUrl, function (data) {
            $('#modal-form-placeholder').html(data);
 
            $('#_insertModalForm').modal('show');
        });
    }

    $(function () {
        var placeholderElement = $('#modal-form-placeholder');

        $('button[data-toggle=""ajax-modal""]').click(function (event) {
            var url = $(this).data('url');
            $.get(url).done(function (data) {
                placeholderElement.html(data);
                placeholderElement.find('.modal').modal('show');
            });
        });

        placeholderElement.on('click', '[data-save=""modal""]', function (event) {
            event.preventDefault();

            var ");
            WriteLiteral(@"form = $(this).parents('.modal').find('form');
            var actionUrl = form.attr('action');
            var dataToSend = form.serialize();

            $.post(actionUrl, dataToSend).done(function (data) {
                var newBody = $('.modal-body', data);
                placeholderElement.find('.modal-body').replaceWith(newBody);

                var isValid = newBody.find('[name=""IsValid""]').val() == 'True';
                if (isValid) {
                    placeholderElement.find('.modal').modal('hide');
                }
            });
        });
    });


    function deleteConfirm(id) {
        swal({
            title: ""Are you sure?"",
            text: ""Delete this Record "",
            type: ""warning"",
            showCancelButton: true,
            confirmButtonClass: ""btn-danger"",
            confirmButtonText: ""Yes, delete it!"",
            closeOnConfirm: false
        },
            function () {

                deleteAction(id);


            });
    ");
            WriteLiteral(@"}

    function deleteAction(id) {
        const url = _deleteUrl.replace(""__"", id);

        $.get(url,
            function (data) {
                if (data === true) {

                    window.location.reload(false);

                } else {
                    swal(""Error!"", 'You are unable to delete this record', ""error"");
                }

            });
    }
</script>");
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

using AUA.ProjectName.Common.Consts;
using AUA.ProjectName.Common.Enums;
using AUA.ProjectName.Common.Extensions;
using AUA.ProjectName.Models.ViewModels.BaseViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AUA.ProjectName.WebUI.Areas.Admin.Controllers
{
    [Area(AreasConsts.Admin)]

    public class HomeController : Controller
        {
            private readonly ILogger<HomeController> _logger;

            public HomeController(ILogger<HomeController> logger)
            {
                _logger = logger;
            }

            public IActionResult Index()
            {

                return View();
            }

            public IActionResult ErrorPage(EResultStatus resultStatus)
            {
                _logger.LogError(resultStatus.ToDescription());

                var errorPageVm = CreateErrorPageVm(resultStatus);

                return View(errorPageVm);
            }

            private static ErrorPageVm CreateErrorPageVm(EResultStatus resultStatus)
            {
                return new ErrorPageVm
                {
                    Message = resultStatus.ToDescription(),
                    ErrorCode = resultStatus.GetId()
                };
            }
        }
}

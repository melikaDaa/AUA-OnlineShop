﻿using System.ComponentModel.DataAnnotations;
using AUA.ProjectName.Models.BaseModel.BaseViewModels;

namespace AUA.ProjectName.Models.GeneralModels.LoginModels.Shop
{
    public class LoginShopVm : GeneralBaseVm
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string ReturnUrl { get; set; }

        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }

    }
}

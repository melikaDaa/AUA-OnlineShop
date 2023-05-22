﻿using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;
using AUA.ProjectName.Models.ViewModels.Accounting.AppUserModels;
using AUA.ProjectName.Models.ViewModels.Shop.UserModel;

namespace AUA.ProjectName.ValidationServices.Shop.User.Contracts
{
    public interface IUserUpdateVmValidationService
    {
        Task<ValidationResultVm> ValidationAsync(UserActionVm appUserVm);

    }
}

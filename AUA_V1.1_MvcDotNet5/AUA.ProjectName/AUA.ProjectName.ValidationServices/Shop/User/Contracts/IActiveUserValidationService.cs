using System.Threading.Tasks;
using AUA.ProjectName.Models.BaseModel.BaseValidationModels;

namespace AUA.ProjectName.ValidationServices.Shop.User.Contracts
{
    public interface IUserIdValidationService
    {
        Task<ValidationResultVm> ValidationAsync(long userId);

    }
}

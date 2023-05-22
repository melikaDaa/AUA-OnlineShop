using AUA.ProjectName.Common.Enums;

namespace AUA.ProjectName.Models.DataModels.LoginDataModels.Shop
{
    public class LoginDmShop
    {
        public long UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public bool IsAuthenticated { get; set; }

        public EResultStatus ResultStatus { get; set; }

    }
}

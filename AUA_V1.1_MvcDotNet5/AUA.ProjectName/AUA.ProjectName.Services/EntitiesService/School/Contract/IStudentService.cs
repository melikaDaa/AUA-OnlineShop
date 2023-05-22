using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.EntitiesDto.Accounting;
using AUA.ProjectName.Models.EntitiesDto.School;
using AUA.ProjectName.Models.ViewModels.Accounting.UserAccessModels;
using AUA.ProjectName.Models.ViewModels.School;
using AUA.ServiceInfrastructure.BaseServices;

namespace AUA.ProjectName.Services.EntitiesService.School.Contract
{
   public interface IStudentService:IGenericEntityService<Student, StudentDto>
    {
        Task<List<StudentVm>> GetStudentMappingVms();
    }
    
}

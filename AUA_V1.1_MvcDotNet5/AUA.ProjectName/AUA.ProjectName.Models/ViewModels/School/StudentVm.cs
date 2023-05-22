using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.School;

namespace AUA.ProjectName.Models.ViewModels.School
{
   public class StudentVm : IMapFrom<Student>
    {
        public  int id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}

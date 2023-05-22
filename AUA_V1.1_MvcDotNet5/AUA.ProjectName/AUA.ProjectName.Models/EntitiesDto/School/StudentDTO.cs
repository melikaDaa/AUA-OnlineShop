using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AUA.Mapping.Mapping.Contract;
using AUA.ProjectName.DomainEntities.Entities.School;
using AUA.ProjectName.Models.BaseModel.BaseDto;

namespace AUA.ProjectName.Models.EntitiesDto.School
{
    public class StudentDto : BaseEntityDto,IMapFrom<Student>
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }


    }
}

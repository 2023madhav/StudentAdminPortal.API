using AutoMapper;
using DataModels=StudentAdminPortal.API.DataModel;
using StudentAdminPortal.API.DomainModels;
using System.Data;

namespace StudentAdminPortal.API.Profiles
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModels.Student, Student>().ReverseMap();

            CreateMap<DataModels.Gender, Gender>().ReverseMap();  
            
            CreateMap<DataModels.Address, Address>().ReverseMap();  


        }    
    }
}

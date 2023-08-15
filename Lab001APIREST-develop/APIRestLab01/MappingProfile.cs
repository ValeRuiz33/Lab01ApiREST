using Entities.Models;
using Shared.DataTransferObjects;
using AutoMapper;



namespace APIRestLab01
{
    public class MappingProfile : Profile
    {
            public MappingProfile()
            {
                CreateMap<Company, CompanyDTO>()
                    .ForCtorParam("FullAddress",
                    opt => opt.MapFrom(x => string.Join(' ', x.Address, x.Country)));

            CreateMap<Employee, EmployeeDTO>();

            }

        }


    }


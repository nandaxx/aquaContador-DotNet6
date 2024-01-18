using AutoMapper;
using Domain.Entities;
using Service.DTO;

namespace Service.Mapping
{
    public class DomainToDto : Profile
    {
        public DomainToDto()
        {
            CreateMap<Person, PersonDTO>();
            CreateMap<Drink, DrinkDTO>();
        } 
        
    }
}

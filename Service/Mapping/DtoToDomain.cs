using AutoMapper;
using Domain.Entities;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapping
{
    public class DtoToDomain : Profile
    {
        public DtoToDomain()
        {
            CreateMap<PersonDTO, Person>();
            CreateMap<DrinkDTO, Drink>();
        }
    }
}

using Domain.Repositories;
using Service.DTO;
using Service.Interfaces;
using AutoMapper;
using Domain.Entities;
using System;

namespace Service.Services
{
    public class PersonService : IPersonService
    {
        private readonly IPersonRepository _repository;
        private readonly IMapper _mapper;

        public async Task<ICollection<PersonDTO>> FindAll()
        {
            var people = await _repository.FindAll();
            return _mapper.Map<ICollection<PersonDTO>>(people);
        }

        public async Task<PersonDTO> FindById(int id)
        {
            var result = await _repository.FindById(id);
            return _mapper.Map<PersonDTO>(result);
        }

        public async Task<PersonDTO> Create(PersonDTO person)
        {
            var result = await _repository.Create(_mapper.Map<Person>(person));
            return _mapper.Map<PersonDTO>(result) ;
        }

        public async Task<PersonDTO> Update(PersonDTO person)
        {
            var result = await _repository.Update(_mapper.Map<Person>(person));
            return _mapper.Map<PersonDTO>(result);
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _repository.Delete(id);
            return result;
        }
    }
}

using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using Service.DTO;
using Service.Interfaces;
using System;

namespace Service.Services
{
    public class DrinkService : IDrinkService
    {
        private readonly IDrinkRepository _repository;
        private readonly IMapper _mapper;

        public DrinkService(IDrinkRepository repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<ICollection<DrinkDTO>> FindAll()
        {
            var drinks = await _repository.FindAll();
            return _mapper.Map<ICollection<DrinkDTO>>(drinks);
        }

        public async Task<DrinkDTO> FindById(int id)
        {
            var result = await _repository.FindById(id);
            return _mapper.Map<DrinkDTO>(result);
        }

        public async Task<DrinkDTO> FindByDate(string date)
        {
            var result = await _repository.FindByDate(date);
            return _mapper.Map<DrinkDTO>(result);
        }

        public async Task<DrinkDTO> Create(DrinkDTO drink)
        {
            var result = await _repository.Create(_mapper.Map<Drink>(drink));
            return _mapper.Map<DrinkDTO>(result);
        }

        public async Task<DrinkDTO> Update(DrinkDTO drink)
        {
            var result = await _repository.Update(_mapper.Map<Drink>(drink));
            return _mapper.Map<DrinkDTO>(result);
        }

        public async Task<bool> Delete(int id)
        {
            var result = await _repository.Delete(id);
            return result;
        }
    }
}

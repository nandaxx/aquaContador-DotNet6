using Domain.Entities;
using Service.DTO;

namespace Service.Interfaces
{
    public interface IDrinkService
    {
        Task<ICollection<DrinkDTO>> FindAll();
        Task<DrinkDTO> FindById(int id);
        Task<DrinkDTO> FindByDate(string date);
        Task<DrinkDTO> Create(DrinkDTO drink);
        Task<DrinkDTO> Update(DrinkDTO drink);
        Task<bool> Delete(int id);
    }
}

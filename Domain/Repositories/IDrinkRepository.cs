using Domain.Entities;

namespace Domain.Repositories
{
    public interface IDrinkRepository
    {
        Task<ICollection<Drink>> FindAll();
        Task<Drink> FindById(int id);
        Task<Drink> FindByDate(string date);
        Task<Drink> Create(Drink drink);
        Task<Drink> Update(Drink drink);
        Task<bool> Delete(int id);
    }
}

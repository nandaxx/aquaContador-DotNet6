using Domain.Entities;
using Domain.Repositories;
using InfraData.Context;
using Microsoft.EntityFrameworkCore;

namespace InfraData.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        public readonly ContextDb _db;

        public DrinkRepository(ContextDb db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        //
        public async Task<ICollection<Drink>> FindAll()
        {
            var drinks = await _db.Drinks.Include(x => x.People).ToListAsync();
            return drinks;
        }

        public async Task<Drink> FindById(int id)
        {
            var drink = await _db.Drinks.Include(x => x.People).FirstOrDefaultAsync(x => x.Id == id);
            return drink;
        }

        public async Task<Drink> FindByDate(string date)
        {
            // converter a string para dateTime
            DateTime parsedDate = DateTime.Parse(date);

            var drink = await _db.Drinks.Include(x => x.People).FirstOrDefaultAsync(x => x.Type == date);
            return drink;
        }

        public async Task<Drink> Create(Drink drink)
        {
            _db.Drinks.Add(drink);
            await _db.SaveChangesAsync();
            return drink;
        }
        public async Task<Drink> Update(Drink drink)
        {
            _db.Drinks.Update(drink);
            await _db.SaveChangesAsync();
            return drink;
        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                var drink = await _db.Drinks.Where(u => u.Id == id).FirstOrDefaultAsync();
                if (drink == null) return false;
                _db.Drinks.Remove(drink);
                await _db.SaveChangesAsync();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }

       
    }
}

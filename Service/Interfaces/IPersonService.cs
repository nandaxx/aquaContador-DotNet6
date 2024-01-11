using Domain.Entities;
using Service.DTO;

namespace Service.Interfaces
{
    public interface IPersonService
    {

        Task<ICollection<PersonDTO>> FindAll();
        Task<PersonDTO> FindById(int id);
        Task<PersonDTO> Create(PersonDTO person);
        Task<PersonDTO> Update(PersonDTO person);
        Task<bool> Delete(int id);
    }
}

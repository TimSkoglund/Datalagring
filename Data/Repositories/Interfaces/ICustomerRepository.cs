using Data.Entities;

namespace Data.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
        Task AddAsync(CustomerEntity customerEntity);
        Task UpdateAsync(CustomerEntity customerEntity);
        Task<bool> DeleteAsync(int id);
    }
}
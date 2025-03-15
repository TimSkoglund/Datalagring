using Business.Models;

namespace Business.Services.Interfaces
{
    public interface ICustomerService
    {
        Task CreateCustomerAsync(Customer customer);
        Task<bool> DeleteCustomerAsync(int id);
        Task<Customer?> GetCustomerByCustomerNameAsync(string customerName);
        Task<Customer?> GetCustomerByIdAsync(int id);
        Task<IEnumerable<Customer>> GetCustomersAsync();
        Task<bool> UpdateCustomerAsync(Customer customer);
    }
}
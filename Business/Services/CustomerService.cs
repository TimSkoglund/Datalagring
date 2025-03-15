using Business.Factories;
using Business.Models;
using Business.Services.Interfaces;
using Data.Repositories;

namespace Business.Services;

public class CustomerService(CustomerRepository customerRepository) : ICustomerService
{
    private readonly CustomerRepository _customerRepository = customerRepository;

    public async Task CreateCustomerAsync(Customer customer)
    {
        var customerEntity = CustomerFactory.Create(customer);
        await _customerRepository.AddAsync(customerEntity!);
    }


    public async Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        var customerEntities = await _customerRepository.GetAsync();
        return customerEntities.Select(CustomerFactory.Create);
    }


    public async Task<Customer?> GetCustomerByIdAsync(int id)
    {
        var customerEntity = await _customerRepository.GetAsync(x => x.Id == id);
        return CustomerFactory.Create(customerEntity!);
    }

    public async Task<Customer?> GetCustomerByCustomerNameAsync(string customerName)
    {
        var customerEntity = await _customerRepository.GetAsync(x => x.Name == customerName);
        return CustomerFactory.Create(customerEntity!);
    }

    public async Task<bool> UpdateCustomerAsync(Customer customer)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> DeleteCustomerAsync(int id)
    {
        throw new NotImplementedException();
    }

}

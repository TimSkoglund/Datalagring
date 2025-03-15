using Business.Models;
using Data.Entities;

namespace Business.Factories;

public class CustomerFactory
{
	public static CustomerEntity Create(Customer customer) => customer == null ? null : new()
    {
        Name = customer.Name,
    };

    public static Customer Create(CustomerEntity entity) => entity == null ? null : new()
    {
        Id = entity.Id,
        Name = entity.Name
    };
}






using Data.Context;
using Data.Entities;
using Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class CustomerRepository(DataContext context) : BaseRepository<Entities.CustomerEntity>(context), ICustomerRepository
{


    //CREATE
    public async Task AddAsync(CustomerEntity customerEntity)
    {
        throw new NotImplementedException();
    }

    //READ

    //UPDATE

    //DELETE

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _context.Customers.FirstOrDefaultAsync(x => x.Id == id);
        if (entity != null)
        {
            _context.Customers.Remove(entity);
            await _context.SaveChangesAsync();
            return true;
        }
        return false;
    }

}

//5:00

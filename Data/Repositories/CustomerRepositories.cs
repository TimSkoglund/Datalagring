﻿using Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories;

public class CustomerRepositories(DataContext context)  
{
    private readonly DataContext _context = context;
    
    //CREATE

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

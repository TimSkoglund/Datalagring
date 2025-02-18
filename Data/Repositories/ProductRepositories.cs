using Data.Context;

namespace Data.Repositories;

public class ProductRepositories(DataContext context)
{
    private readonly DataContext _context = context;
}

using Data.Context;

namespace Data.Repositories;

public class UserRepositories(DataContext context)
{
    private readonly DataContext _context = context;
}

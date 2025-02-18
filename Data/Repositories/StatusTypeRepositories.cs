using Data.Context;

namespace Data.Repositories;

public class StatusTypeRepositories(DataContext context)
{
    private readonly DataContext _context = context;
}

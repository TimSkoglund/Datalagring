using Data.Context;

namespace Data.Repositories;

public class StatusTypeRepositories(DataContext context) : BaseRepository<Entities.StatusTypeEntity>(context)
{
    private readonly DataContext _context = context;
}

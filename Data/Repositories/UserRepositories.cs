using Data.Context;
using Data.Entities;

namespace Data.Repositories;

public class UserRepositories(DataContext context) : BaseRepository<Entities.UserEntity>(context)
{
    private readonly DataContext _context = context;
}

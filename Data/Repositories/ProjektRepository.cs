using Data.Context;

namespace Data.Repositories;


public class ProjektRepositories(DataContext context) : BaseRepository<Entities.ProjectEntity>(context)
{

}

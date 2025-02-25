using Data.Context;
using Data.Entities;

namespace Data.Repositories


    public class ProjektRepositories(DataContext context) : BaseRepository<Entities.ProjekEntity>(context)
{
	}

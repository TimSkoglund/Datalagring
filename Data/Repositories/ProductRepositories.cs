using Data.Context;
using Data.Entities;

namespace Data.Repositories;

public class ProductRepositories(DataContext context) : BaseRepository<ProductEntity>(context)
{
}

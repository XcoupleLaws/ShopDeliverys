using System.Data.Entity;
using EfRepository.Abstractions;
using Entities;

namespace EfRepository.Repositories
{
	public class GoodsRepository : GenericRepository<GoodsEntity>, IGoodsRepository
	{
		public GoodsRepository(ShopContext dataContext, DbSet<GoodsEntity> dataTable) : base(dataContext, dataTable) {  }
	}
}
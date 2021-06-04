using System.Data.Entity;
using EfRepository.Abstractions;
using Entities;

namespace EfRepository.Repositories
{
	public class WarehouseRepository: GenericRepository<WarehouseEntity>, IWarehouseRepository
	{
		public WarehouseRepository(ShopContext dataContext, DbSet<WarehouseEntity> dataTable)
			: base(dataContext, dataTable) {  }
	}
}
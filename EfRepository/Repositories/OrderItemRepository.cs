using System.Data.Entity;
using EfRepository.Abstractions;
using Entities;

namespace EfRepository.Repositories
{
	public class OrderItemRepository : GenericRepository<OrderItemEntity>, IOrderItemRepository
	{
		public OrderItemRepository(ShopContext dataContext, DbSet<OrderItemEntity> dataTable) : base(dataContext, dataTable) {  }
	}
}
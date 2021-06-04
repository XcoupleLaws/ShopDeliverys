using EfRepository;
using EfRepository.Abstractions;
using EfRepository.Repositories;
using Entities;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {

	    private readonly ShopContext _context;
	    
	    public UnitOfWork(ShopContext context)
        {
            _context = context;
            Goods = new GoodsRepository(context,context.GoodsData);
            Employees = new EmployeeRepository(context,context.EmployeesData);
            Warehouses = new WarehouseRepository(context,context.WarehousesData);
            Orders = new OrderRepository(context,context.OrdersData);
            OrderItems = new OrderItemRepository(context,context.OrderItemsData);
        }
	    
	    public IGoodsRepository Goods { get; set; }
	    public IEmployeeRepository Employees { get; set; }
	    public IWarehouseRepository Warehouses { get; set; }
	    public IOrderRepository Orders { get; set; }
         public IOrderItemRepository OrderItems { get; set; }
         
        public void CommitChanges() =>
		_context.SaveChanges();
    }
}
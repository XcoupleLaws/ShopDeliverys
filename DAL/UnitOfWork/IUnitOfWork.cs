using EfRepository;
using EfRepository.Abstractions;
using Entities;

namespace DAL.UnitOfWork
{
public interface IUnitOfWork
    { 
        IGoodsRepository Goods { get; set; }
        IEmployeeRepository Employees { get; set; }
        IWarehouseRepository Warehouses { get; set; }
        IOrderRepository Orders { get; set; }
        IOrderItemRepository OrderItems { get; set; }

        void CommitChanges();
    }
}
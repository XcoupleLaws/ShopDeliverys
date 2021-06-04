using System.Data.Entity;
using Entities;

namespace EfRepository
{
    public class ShopContext : DbContext
    {
        public ShopContext() : base("name=1") 
        {
            Database.SetInitializer(new DataInitializer());
        }
        
        public DbSet<GoodsEntity> GoodsData { get; set; }
        public DbSet<EmployeeEntity> EmployeesData { get; set; }
        public DbSet<WarehouseEntity> WarehousesData { get; set; }
        public DbSet<OrderItemEntity> OrderItemsData { get; set; }
        public DbSet<OrderEntity> OrdersData { get; set;  }
        
        public DbSet<EmployeeSpecialityEntity> EmployeeSpecialities { get; set; }
        
        public DbSet<GoodsTypeEntity> GoodsTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //todo some setup stuff
        }
    }
    
}
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Entities;
using Types;

namespace EfRepository
{
    public class DataInitializer : CreateDatabaseIfNotExists<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
	        var employeeTypes = new List<EmployeeSpecialityEntity>
	        {
		        new() { Speciality = Speciality.Driver },
		        new() { Speciality = Speciality.Manager }
	        };
	        employeeTypes.ForEach(item => context.EmployeeSpecialities.AddOrUpdate(item));
	        context.SaveChanges();
	        
	        var goodsTypes = new List<GoodsTypeEntity>
	        {
		        new() { Type = GoodsType.Їжа },
		        new() { Type = GoodsType.Телефони },
		        new() { Type = GoodsType.Меблі }
	        };
	        goodsTypes.ForEach(item => context.GoodsTypes.AddOrUpdate(item));
	        context.SaveChanges();
	        
            var goods = new List<GoodsEntity>
            {
                new() { Name = "Вафлі ванільні", Price = 39, GoodsTypeId = 1},
                new() { Name = "Шовковиця королівська", Price = 68, GoodsTypeId = 1},
                new() { Name = "Клюква", Price = 99, GoodsTypeId = 1},
                new() { Name = "Samsung Galaxy A52", Price = 9999, GoodsTypeId = 2},
                new() { Name = "Xiaomi Redmi Note 9", Price = 5299, GoodsTypeId = 2},
                new() { Name = "Samsung Galaxy A12", Price = 4499, GoodsTypeId = 2},
                new() { Name = "Motorola G9", Price = 4999, GoodsTypeId = 2},
                new() { Name = "Кутовий диван Вегас", Price = 11665, GoodsTypeId = 3},
                new() { Name = "Диван Британ", Price = 6350, GoodsTypeId = 3},
                new() { Name = "Диван Престиж", Price = 13320, GoodsTypeId = 3}
            };
            goods.ForEach(item => context.GoodsData.AddOrUpdate(item));
            context.SaveChanges();
            
            var warehouses = new List<WarehouseEntity>
            {
                new() { CompanyName = "1ТС", RelativeDistance = 100 },
                new() { CompanyName = "2ТС", RelativeDistance = 200 },
                new() { CompanyName = "3ТС", RelativeDistance = 500 },
                new() { CompanyName = "4ТС", RelativeDistance = 350 },
                new() { CompanyName = "5ТС", RelativeDistance = 1000 }
            };
            warehouses.ForEach(item => context.WarehousesData.AddOrUpdate(item));
            context.SaveChanges();

            var employees = new List<EmployeeEntity>
            {
                new() { Firstname = "Takumi", Lastname = "Fujiwara", Age = 21,EmployeeSpecialityId = 1 },
                new() { Firstname = "satra", Lastname = "saradip", Age = 22,EmployeeSpecialityId = 2 },
                new() { Firstname = "Kaneki", Lastname = "Ken", Age = 20,EmployeeSpecialityId = 1 },
                new() { Firstname = "Billy", Lastname = "Herrington", Age = 30,EmployeeSpecialityId = 2 }
            };
            employees.ForEach(item => context.EmployeesData.AddOrUpdate(item));
            context.SaveChanges();

            
        }
    }
}
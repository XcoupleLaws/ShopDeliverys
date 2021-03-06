using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using EfRepository.Abstractions;
using Entities;

namespace EfRepository.Repositories
{
	public class EmployeeRepository : GenericRepository<EmployeeEntity>, IEmployeeRepository
	{
		public EmployeeRepository(ShopContext dataContext, DbSet<EmployeeEntity> dataTable) : base(dataContext, dataTable) {  }

		
	}
}
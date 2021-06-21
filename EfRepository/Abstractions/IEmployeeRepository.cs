using System.Collections.Generic;
using Entities;

namespace EfRepository.Abstractions
{
	public interface IEmployeeRepository: IRepository<EmployeeEntity, int>
	{
	}
}
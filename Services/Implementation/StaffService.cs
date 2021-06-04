using System.Collections.Generic;
using System.Linq;
using DAL.UnitOfWork;
using Domain.EmployeesDomain;
using Mappers;
using Services.Abstractions;
using Types;

namespace Services.Implementation
{
    public class StaffService : IStaffService
    {
	    private readonly IUnitOfWork _unitOfWork;
	    private readonly EmployeeMapper _employeeMapper;


        public StaffService(IUnitOfWork unitOfWork, EmployeeMapper employeeMapper)
        {
            _unitOfWork = unitOfWork;
            _employeeMapper = employeeMapper;
        }

        public EmployeeModel GetLeastBusyEmployee(Speciality spec) => 
	        GetAll()
		        .Where(employee => employee.Speciality == spec)
		        .Aggregate((min, x) =>
			        min.LoadedHours > x.LoadedHours ? x : min);
        
        public void Update(EmployeeModel employee) =>
            _unitOfWork.Employees.Update(_employeeMapper.ToEntity(employee));

        public List<EmployeeModel> GetAll() =>
	        _unitOfWork.Employees.GetAll()
                .Select(_employeeMapper.ToModel)
                .ToList();
    }
}
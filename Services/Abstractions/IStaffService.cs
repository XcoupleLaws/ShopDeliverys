using System.Collections.Generic;
using Domain.EmployeesDomain;
using Domain.OrderDomain;
using Types;

namespace Services.Abstractions
{
    public interface IStaffService
    {
        EmployeeModel GetLeastBusyEmployee(Speciality spec);
        void Update(EmployeeModel employee);
    }
}
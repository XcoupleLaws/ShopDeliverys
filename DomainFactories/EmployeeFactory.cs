using System;
using Domain.EmployeesDomain;
using Types;

namespace DomainFactories
{
    public class EmployeeFactory
    {
        public EmployeeModel GetEmployee(Speciality spec) 
        {
            switch (spec)
                {
            case Speciality.Driver:
                return new DriverModel();
            case Speciality.Manager:
                return new ManagerModel();
            default:
                throw new Exception();
            }
    }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using Domain.OrderDomain;
using Types;

namespace Domain.EmployeesDomain
{
    public abstract class EmployeeModel
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int Age { get; set; }

        public List<OrderModel> Orders { get; set; }

        public TimeSpan LoadedHours
        {
	        get;
	        set;
        }

        public int SpecialityId { get; set; }

        public abstract Speciality Speciality { get; }

        public abstract void ProcessOrder(OrderModel order);
    }
}
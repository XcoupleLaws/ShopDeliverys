using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Types;

namespace Entities
{
    public class EmployeeEntity : IEntity
    {
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public int EmployeeSpecialityId { get; set; }
        
        public Int64 LoadedHoursTicks { get; set; }

        [NotMapped]
        public TimeSpan LoadedHours
        {
	        get => TimeSpan.FromTicks(LoadedHoursTicks);
	        set => LoadedHoursTicks = value.Ticks;
        }
        public virtual EmployeeSpecialityEntity EmployeeSpeciality { get; set; }
        public int Age { get; set; }
        
        public virtual ICollection<OrderEntity> Orders { get; set; }
        
    }
}
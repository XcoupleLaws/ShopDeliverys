using Types;

namespace Entities
{
	public class EmployeeSpecialityEntity : IEntity
	{

		public int Id { get; set; }
		public Speciality Speciality { get; set; }
	}
}
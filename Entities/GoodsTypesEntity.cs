using Types;

namespace Entities
{
	public class GoodsTypeEntity : IEntity
	{
		public int Id { get; set; }
		public GoodsType Type { get; set; }
	}
}
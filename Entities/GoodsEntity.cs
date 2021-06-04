using Types;

namespace Entities
{
    public class GoodsEntity : IEntity
    {
        public int Id { get; set; }

        public double Price { get; set; }
        public string Name { get; set; }
        public int GoodsTypeId { get; set; }
        public virtual GoodsTypeEntity GoodsType { get; set; }
    }
}
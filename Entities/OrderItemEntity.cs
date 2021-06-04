namespace Entities
{
    public class OrderItemEntity : IEntity
    {
        public int Id { get; set; }

        
        public int OrderId { get; set; }
        public virtual OrderEntity Order { get; set; }
        public int GoodsId { get; set; }
        public virtual GoodsEntity Goods { get; set; }
        public int Quantity { get; set; }
    }
}
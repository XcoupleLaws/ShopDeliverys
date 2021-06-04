using Domain.GoodsDomain;

namespace Domain.OrderDomain
{
	public class OrderItemModel
	{
		public int Id { get; set; }
		public GoodsModel Goods { get; set; }
		public int Quantity { get; set; }
	}
}
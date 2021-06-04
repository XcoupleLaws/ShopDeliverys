using System;
using Types;

namespace Domain.GoodsDomain
{
    public class FurnitureModel : GoodsModel
    {
        public override GoodsType Type =>
	        GoodsType.Меблі;

        public override TimeSpan ProcessTime =>
	        new TimeSpan(0, 30, 0);
    }
}
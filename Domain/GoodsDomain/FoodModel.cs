using System;
using Types;

namespace Domain.GoodsDomain
{
    public class FoodModel : GoodsModel
    {
        public override GoodsType Type
        {
            get => GoodsType.Їжа;
        }

        public override TimeSpan ProcessTime
        {
            get => new TimeSpan(0, 20, 0);
        }
    }
}
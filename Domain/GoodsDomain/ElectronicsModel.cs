using System;
using Types;

namespace Domain.GoodsDomain
{
    public class ElectronicsModel : GoodsModel
    {
        public override GoodsType Type
        {
            get => GoodsType.Телефони;
        }

        public override TimeSpan ProcessTime
        {
            get => new TimeSpan(1, 0, 0);
        }
    }
}
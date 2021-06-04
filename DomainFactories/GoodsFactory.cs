using System;
using Domain.GoodsDomain;
using Types;

namespace DomainFactories
{
    public class GoodsFactory
    {
        public GoodsModel GetGoods(GoodsType type)
        { 
            switch (type)
            {
                case GoodsType.Телефони:
                    return (GoodsModel) new ElectronicsModel();
                case GoodsType.Їжа:
                    return new FoodModel();
                case GoodsType.Меблі :
                    return new FurnitureModel();
                default:    
                    throw new Exception();
            }
        }
    }
}
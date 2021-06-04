using System.Collections.Generic;
using Domain.GoodsDomain;
using Domain.WarehouseDomain;

namespace View.Abstractions.ViewAbstractions
{
    public interface IMainView
    {
        List<GoodsModel> SelectedGoods { get; set; }
        WarehouseModel SelectedWarehouse { get; set; }
    }
}
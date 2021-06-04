using System.Collections.Generic;
using Domain.WarehouseDomain;

namespace View.Abstractions.ViewAbstractions
{
    public interface IOrderOptionsView : IOrderUserControl
    {
        void ShowAllWarehouses(List<WarehouseModel> warehouses);
    }
}
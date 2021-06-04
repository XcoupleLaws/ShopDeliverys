using System;
using System.Collections.Generic;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Domain.WarehouseDomain;

namespace View.Abstractions.ViewAbstractions
{
    public interface IOrderInfoUserControl : IOrderUserControl
    {
        public event EventHandler OrderCommitRequested;

        void ShowWarehouse(WarehouseModel warehouse);
        WarehouseModel GetSelectedWarehouse();
        OrderModel PendingOrder { get; set; }
        List<GoodsModel> GetSelectedGoods();
        void PresenterCreated();
        void ShowOrder(OrderModel order);
    }
}
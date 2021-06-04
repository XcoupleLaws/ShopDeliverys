using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Domain.WarehouseDomain;
using Services.Abstractions;
using Services.Services;
using View.Abstractions;
using View.Abstractions.PresentersAbstractions;
using View.Abstractions.ViewAbstractions;

namespace View.Presenters
{
    public class OrderInfoPresenter : IOrderInfoPresenter
    {
        private IOrderService OrderService { get; set; }

        private IOrderInfoUserControl View { get; set; }

        public OrderInfoPresenter(
            IOrderInfoUserControl view,
            IOrderService orderService,
            GoodsService goodsService,
            WarehouseService warehouseService
        )
        {
            View = view;
            OrderService = orderService;

            SubscribeOnViewEvents();
            View.PresenterCreated();
        }

        private void OrderSubmitClicked(object sender, EventArgs args) =>
            OrderService.Add(View.PendingOrder);

        private void LoadData(object sender, EventArgs args)
        {
            List<GoodsModel> selectedGoods = View.GetSelectedGoods();
            WarehouseModel selectedWarehouse = View.GetSelectedWarehouse();

            View.ShowAllGoods(selectedGoods);

            if (selectedWarehouse == null)
                return;
            View.ShowWarehouse(selectedWarehouse);
            
            OrderModel order = OrderService.MakeOrder(selectedGoods, selectedWarehouse);
            OrderService.ProcessOrder(order);
            View.PendingOrder = order;

            View.ShowOrder(order);
            
            View.UpdateChanges();
        }

        public void SubscribeOnViewEvents()
        {
            View.DataRequested += LoadData;
            View.OrderCommitRequested += OrderSubmitClicked;
        }
    }
}
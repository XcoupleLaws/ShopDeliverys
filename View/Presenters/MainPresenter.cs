using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DAL;
using Domain.GoodsDomain;
using Domain.WarehouseDomain;
using Services.Services;
using View.Abstractions.PresentersAbstractions;
using View.Views;

namespace View.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly GoodsService _goodsService;
        private readonly WarehouseService _warehouseService;
        private readonly StaffService _staffService;
        private readonly OrderService _orderService;

        private readonly MainMenuView _view;
        private IOptionsPresenter OptionsMenuPresenter { get; set; }
        private IOrderInfoPresenter InfoMenuPresenter { get; set; }

        public MainPresenter(Form view, IUnitOfWork unit)
        {
            _goodsService = new GoodsService(unit);
            _warehouseService = new WarehouseService(unit);
            _staffService = new StaffService(unit);
            _orderService = new OrderService(unit);

            _view = (MainMenuView) view;
            SubscribeOnViewEvents();
        }
        
        public void SubscribeOnViewEvents()
        {
            _view.OrderOptionsMenuSelected += OrderOptionsClicked;
            _view.OrderInfoMenuSelected += OrderInfoClicked;
        }

        private void OrderOptionsClicked(object sender, EventArgs args) =>
            OptionsMenuPresenter = new OrderOptionsPresenter(
                (OrderOptionsView) sender,
                _goodsService,
                _warehouseService,
                _staffService);

        private void OrderInfoClicked(object sender, EventArgs args) =>
            InfoMenuPresenter = new OrderInfoPresenter(
                (OrderInfoView) sender,
                _orderService,
                _goodsService,
                _warehouseService);
    }
}
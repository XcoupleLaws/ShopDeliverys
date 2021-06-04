using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using DAL;
using DAL.UnitOfWork;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Domain.WarehouseDomain;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstractions;

namespace WPFApp.ViewModels
{
	public class AppViewModel: INotifyPropertyChanged
	{ 
		private IWarehouseService _warehouseService;
		private IGoodsService     _goodsService;
		private IOrderService     _orderService;

		
		private WarehouseModel selectedWarehouse; //Байдинг вибраних верхаусів типу верхаус модел(обект класу верхаус модел)
		private OrderModel     pendingOrder;//тоже саме, ток це ще не созданний товар без верхауса
		private GoodsModel     selectedGoods;
		
		private ICommand addGoodsCommand;
		private ICommand commitOrderCommand;
		
		private string goodsQuantity;

		public ObservableCollection<GoodsModel> Goods { get; set; }
		public ObservableCollection<WarehouseModel> Warehouses { get; set; }
		
		public OrderDataViewModel OrderDataViewModel { get; }


		public GoodsModel SelectedGoods
		{
			get => selectedGoods;
			set {
				selectedGoods = value;
				OnPropertyChanged(); 
			}
		}

		public WarehouseModel SelectedWarehouse
		{
			get => selectedWarehouse;
			set {
				selectedWarehouse = value;
				OnPropertyChanged(); 
			}
		}
		
		public string GoodsQuantity
		{
			get => goodsQuantity;
			set
			{
				goodsQuantity = value;
				OnPropertyChanged();
			}
		}

		public ICommand AddGoodsCommand => addGoodsCommand ??= new CommandHandler( //розумний обработчик
			AddGoodsAction,
			() =>
				selectedGoods != null 
				&& int.TryParse(goodsQuantity, out _) 
				&& int.Parse(goodsQuantity) >= 1); 
		
		public ICommand CommitOrderCommand => commitOrderCommand ??= new CommandHandler(
			CommitGoodsAction, 
			() =>
				pendingOrder != null 
			       && selectedWarehouse != null 
			       && pendingOrder.OrderItems.Count != 0);

		public void AddGoodsAction()
		{
			pendingOrder ??= _orderService.MakeOrder();
			int.TryParse(GoodsQuantity, out var parsedQuantity);
			
			OrderItemModel orderItem = pendingOrder.OrderItems.Find(item =>
				item.Goods.Id == selectedGoods.Id);
			if (orderItem != null){
				orderItem.Quantity += parsedQuantity;
			}
			else
				pendingOrder.OrderItems.Add(new OrderItemModel
				{
					Goods = selectedGoods,
					Quantity = parsedQuantity
				});
		}

		public void CommitGoodsAction()
		{
			pendingOrder.Warehouse = selectedWarehouse;

			_orderService.ProcessOrder(pendingOrder);

			var services = _orderService.GetAll();
			pendingOrder = null;
			
			OrderDataViewModel.OnOrderListChanged();
		}

		
		public AppViewModel(IServiceProvider serviceProvider)
		{
			RegisterServices(serviceProvider);
			
			Warehouses = new ObservableCollection<WarehouseModel>(_warehouseService.GetAll());
			Goods      = new ObservableCollection<GoodsModel>(_goodsService.GetAll());

			OrderDataViewModel = new OrderDataViewModel(serviceProvider);
		}
		
		private void RegisterServices(IServiceProvider serviceProvider)
		{
			_goodsService     = serviceProvider.GetService<IGoodsService>();
			_warehouseService = serviceProvider.GetService<IWarehouseService>();
			_orderService     = serviceProvider.GetService<IOrderService>();
		}
 
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName]string prop = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
		}
	}
}
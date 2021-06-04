using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;
using DAL;
using DAL.UnitOfWork;
using Domain.Annotations;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstractions;

namespace WPFApp.ViewModels
{
	public class OrderDataViewModel : INotifyPropertyChanged
	{
		private IGoodsService _goodsService;
		private IOrderService _orderService;

		private ObservableCollection<OrderModel> _orders;
		private OrderModel _selectedOrder;

		public ObservableCollection<OrderModel> Orders
		{
			get => _orders;
			set
			{
				_orders = value;
				OnPropertyChanged();
			}
		}
		public OrderModel SelectedOrder
		{
			get => _selectedOrder;
			set {
				_selectedOrder = value;
				OnPropertyChanged();
			}
		}
		
		public OrderDataViewModel(IServiceProvider serviceProvider)
		{
			RegisterServices(serviceProvider);

			Orders = new ObservableCollection<OrderModel>(_orderService.GetAll());
		}

		private void RegisterServices(IServiceProvider serviceProvider)
		{
			_goodsService = serviceProvider.GetService<IGoodsService>();
			_orderService = serviceProvider.GetService<IOrderService>();
		}
		
		public void OnOrderListChanged()
		{
			Orders = new ObservableCollection<OrderModel>(_orderService.GetAll());
		}
		public event PropertyChangedEventHandler PropertyChanged;
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
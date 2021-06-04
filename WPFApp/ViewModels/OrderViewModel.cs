using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Domain.Annotations;
using Domain.EmployeesDomain;
using Domain.GoodsDomain;
using Domain.OrderDomain;
using Domain.WarehouseDomain;
using Types;

namespace WPFApp.ViewModels
{
	public class OrderViewModel: INotifyPropertyChanged
	{
			private OrderModel _orderModel;

			public WarehouseModel Warehouse => _orderModel.Warehouse;


			public string ProcessTime => _orderModel.EstimateProcessTime.ToString();

			public double TotalCost => _orderModel.TotalCost;
			

			public event PropertyChangedEventHandler PropertyChanged;
			[NotifyPropertyChangedInvocator]
			protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
			{
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}




	}
}
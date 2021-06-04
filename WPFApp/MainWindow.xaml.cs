using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows;
using DAL;
using DAL.UnitOfWork;
using EfRepository;
using Mappers;
using Microsoft.Extensions.DependencyInjection;
using Services.Abstractions;
using Services.Implementation;
using WPFApp.ViewModels;

namespace WPFApp
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			IServiceCollection services = new ServiceCollection();
			
			services.AddScoped<ShopContext>();
			services.AddScoped<IUnitOfWork,UnitOfWork>();

			services.AddTransient<GoodsMapper>();
			services.AddTransient<OrderMapper>();
			services.AddTransient<WarehouseMapper>();
			services.AddTransient<EmployeeMapper>();

			services.AddSingleton<IGoodsService, GoodsService>();
			services.AddSingleton<IWarehouseService, WarehouseService>();
			services.AddSingleton<IOrderService, OrderService>();
			services.AddSingleton<IStaffService, StaffService>();

			IServiceProvider serviceProvider = services.BuildServiceProvider();
			
			DataContext = new AppViewModel(serviceProvider);
		}
	}
}
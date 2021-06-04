using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Domain.Annotations;
using Domain.GoodsDomain;
using Types;

namespace WPFApp.ViewModels
{
	public class GoodsViewModel : INotifyPropertyChanged
	{
		private GoodsModel goods;


		public string Name
		{
			get => goods.Name;
			set
			{
				goods.Name = value;
				OnPropertyChanged(nameof(Name));

			}

		}
		
		public double Price 
		{
			get => goods.Price;
			set
			{
				goods.Price = value;
				OnPropertyChanged(nameof(Price));

			}
		}

		public string Type
		{
			get
			{
				Console.Write(Enum.GetName(typeof(GoodsType), goods.Type));
				return Enum.GetName(typeof(GoodsType), goods.Type);
			}
		}

		public string ProcessTime => goods.ProcessTime.ToString();


		public event PropertyChangedEventHandler PropertyChanged;
		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		
		
		
		
	}
}
using System;
using System.Windows.Input;

namespace WPFApp.ViewModels
{
	public class CommandHandler : ICommand
	{
		private readonly Action action;
		private readonly Func<bool> canExecute;

		public CommandHandler(Action action, Func<bool> canExecute = null) //функція обработчик
		{
			this.action = action;
			this.canExecute = canExecute;
		}

		public bool CanExecute(object parameter)
		{
			return canExecute.Invoke();
		}

		public void Execute(object parameter)
		{ 
			action.Invoke();
		}

		public event EventHandler CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}
	}
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Idle.Logic.Common
{

	// todo: write an "AsyncCommand" // when passing an async method to the current command then it is an async void
	// which will swollow exceptions // the AsyncCommand should return a Task
	public class Command : ICommand
	{
		private readonly Action _execute;
		private readonly Func<bool> _canExecute;

		public Command(Action execute) 
		{
			_execute = execute;
			_canExecute = () => true;
		}

		public Command(Action execute, Func<bool> canExecute) 
		{
			_execute = execute;
			_canExecute = canExecute;
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			var canExecute = _canExecute.Invoke();
			return canExecute;
		}

		public void Execute(object parameter)
		{
			if (!CanExecute(null)) return;
			_execute.Invoke();
		}
	}

	public class Command<TParameter> : ICommand
	{
		public event EventHandler CanExecuteChanged;

		private readonly Action<TParameter> _execute;
		private readonly Predicate<TParameter> _canExecute;


		public Command(Action<TParameter> execute)
		{
			_execute = execute;
			_canExecute = (_) => true;
		}

		public Command(Action<TParameter> execute, Predicate<TParameter> canExecute)
		{
			_execute = execute;
			_canExecute = canExecute;
		}

		public bool CanExecute(object parameter) =>
			_canExecute.Invoke((TParameter)parameter);

		public void Execute(object parameter)
		{
			if (!CanExecute((TParameter)parameter)) return;
			_execute.Invoke((TParameter)parameter);
		}
	}
}

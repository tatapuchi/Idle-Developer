using Idle.Logic.ModelViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Idle.Logic.ViewModels
{
	public class LanguagesViewModel : BaseViewModel
	{
		public ObservableCollection<LanguageViewModel> Items { get; } = new ObservableCollection<LanguageViewModel>();
	}
}

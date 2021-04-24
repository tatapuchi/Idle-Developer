﻿using Idle.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Idle.Logic.Common;
using Idle.DataAccess.Fields;

namespace Idle.Logic.Languages
{
	public class LanguagesViewModel : BaseViewModel
	{
		private readonly LanguageRepository _languageRepository;

		public LanguagesViewModel(LanguageRepository languageRepository)
		{
			_languageRepository = languageRepository;
		}

		public RangeObservableCollection<LanguageViewModel> Languages { get; } = new RangeObservableCollection<LanguageViewModel>();

		public async Task LoadAsync()
		{
			var languages = await _languageRepository.GetAllAsync();
			var languageViewModels = languages.Select(lang => new LanguageViewModel(lang));

			Languages.AddRange(languageViewModels);

		}

		public async Task PushAsync()
		{
			var languages = new List<Language>();
			foreach(LanguageViewModel vm in Languages)
            {
				languages.Add(vm._language);
            }

			await _languageRepository.UpdateAllAsync(languages);
		}

	}
}

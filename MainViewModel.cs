using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BurakBuyuktumturkOdev1
{
	public partial class MainViewModel : ObservableObject
	{
		public MainViewModel()
		{
			Items = new ObservableCollection<string>();
		}

		[ObservableProperty]
		ObservableCollection<string> items;

		[ObservableProperty]
		private string text;

		[RelayCommand]
		void Add()
		{
			if (string.IsNullOrEmpty(Text))
			{
				return;
			}
			Items.Add(text);
			Text = string.Empty;
		}

		[RelayCommand]
		void Delete(string s)
		{
			if (Items.Contains(s))
			{
				Items.Remove(Text);
			}
		}

	}
}

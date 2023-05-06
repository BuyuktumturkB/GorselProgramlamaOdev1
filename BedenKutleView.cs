using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurakBuyuktumturkOdev1
{
	public class BedenKutleWievModel : INotifyPropertyChanged
	{


		public event PropertyChangedEventHandler PropertyChanged;
		private double boy = 100.0;
		private double kilo = 15.0;
		private const double Step = 1.0;



		public double Boy { get => boy; set { boy = NextStep(value); BKEGuncelle(); } }

		public double Kilo { get => kilo; set { kilo = NextStep(value); BKEGuncelle(); } }
		public double BKE => Kilo / ((Boy * 0.01) * (Boy * 0.01));
		public string BedenGrubu
		{

			get
			{
				if (BKE < 16)
				{
					return "İleri Derece Zayıfsınız";
				}
				else if (BKE >= 16 && BKE <= 16.99)
				{
					return "Aşırı Derece Zayıfsınız";
				}
				else if (BKE >= 17 && BKE <= 18.49)
				{
					return "Hafif Düzeyde Zayıfsınız";
				}
				else if (BKE >= 18.59 && BKE <= 24.9)
				{
					return " Normal Kilolu";
				}
				else if (BKE >= 25 && BKE <= 29.99)
				{
					return "Hafif Şişman";
				}
				else if (BKE >= 30 && BKE <= 34.99)
					return "Birinci Derece Obez";
				else if (BKE >= 35 && BKE <= 39.99)
					return "İkinci Derece Obez";
				else
					return " Morbid Obez";

			}
		}
		private void BKEGuncelle()
		{
			RaiseProportyChanged(nameof(BKE));
			RaiseProportyChanged(nameof(BedenGrubu));
		}

		private void RaiseProportyChanged(string v)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
		}

		private double NextStep(double value) => Math.Round(value / Step) * Step;

	}
}

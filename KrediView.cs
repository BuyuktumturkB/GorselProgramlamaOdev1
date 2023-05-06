using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurakBuyuktumturkOdev1
{
	class KrediViewModel : INotifyPropertyChanged
	{


		private double vade = 10;
		private double anapara = 1000;
		private double faizoranı = 0.8;
		private double durum = 1;

		public double BSMV;
		public double KKDF;
		public double Vade { get => vade; set { vade = value; GuncelFiyat(); } }
		public double FaizOranı { get => faizoranı; set { faizoranı = value; GuncelFiyat(); } }
		public double AnaPara { get => anapara; set { anapara = value; GuncelFiyat(); } }
		public double Durum { get => durum; set { durum = value; GuncelFiyat(); } }

		public double BrutFaiz => (FaizOranı + (FaizOranı * BSMV) + (FaizOranı * KKDF)) / 100;
		public double Taksit => ((Math.Pow(1 + BrutFaiz, Vade) * BrutFaiz) / (Math.Pow(1 + BrutFaiz, Vade) - 1)) * AnaPara;
		public double Toplam => Taksit * Vade;



		public double Sonuc
		{
			get
			{

				if (Durum == 1)
				{
					BSMV = 0.1;
					KKDF = 0.15;
					return (Toplam);

				}
				else if (Durum == 2)
				{
					BSMV = 0;
					KKDF = 0;
					return (Toplam);
				}
				else if ((Durum == 3))
				{
					BSMV = 0;
					KKDF = 0.5;
					return (Toplam);
				}
				else
				{
					BSMV = 0.15;
					KKDF = 0.05;
					return (Toplam);
				}
			}


		}
		private void GuncelFiyat()
		{
			RaiseProportyChanged(nameof(Sonuc));


		}
		private void RaiseProportyChanged(string v)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));

		}

		public event PropertyChangedEventHandler PropertyChanged;

	}
}

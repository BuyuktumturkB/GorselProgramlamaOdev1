namespace BurakBuyuktumturkOdev1;

public partial class RenkPaleti : ContentPage
{
	private Color Arkaplan;
	private Random Rastgele = new Random();
	public RenkPaleti()
	{
		InitializeComponent();
	}
	private void DegerDegistir(object sender, EventArgs e)
	{
		int k�rm�z� = (int)K�rm�z�.Value;

		int yesil = (int)Ye�il.Value;

		int mavi = (int)Mavi.Value;

		RenkDuzenle(k�rm�z�, yesil, mavi);

	}

	private void RenkDuzenle(int k�rm�z�, int yesil, int mavi)
	{
		Arkaplan = Color.FromRgb(k�rm�z�, yesil, mavi);
		StackArkaPlan.BackgroundColor = Arkaplan;
		RenkKodu.Text = $"Renk Kodu :{Arkaplan.ToHex()} ";
	}
	private void RastgeleRenk(object sender, EventArgs e)
	{
		int k�rm�z� = Rastgele.Next(0, 255);
		int yesil = Rastgele.Next(0, 255);
		int mavi = Rastgele.Next(0, 255);

		RenkDuzenle(k�rm�z�, yesil, mavi);

		K�rm�z�.Value = k�rm�z�;
		Ye�il.Value = yesil;
		Mavi.Value = mavi;

	}
	private void RenkKopyala(object sender, EventArgs e)
	{
		Clipboard.Default.SetTextAsync(Arkaplan.ToHex());
	}
}
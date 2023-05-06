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
		int kýrmýzý = (int)Kýrmýzý.Value;

		int yesil = (int)Yeþil.Value;

		int mavi = (int)Mavi.Value;

		RenkDuzenle(kýrmýzý, yesil, mavi);

	}

	private void RenkDuzenle(int kýrmýzý, int yesil, int mavi)
	{
		Arkaplan = Color.FromRgb(kýrmýzý, yesil, mavi);
		StackArkaPlan.BackgroundColor = Arkaplan;
		RenkKodu.Text = $"Renk Kodu :{Arkaplan.ToHex()} ";
	}
	private void RastgeleRenk(object sender, EventArgs e)
	{
		int kýrmýzý = Rastgele.Next(0, 255);
		int yesil = Rastgele.Next(0, 255);
		int mavi = Rastgele.Next(0, 255);

		RenkDuzenle(kýrmýzý, yesil, mavi);

		Kýrmýzý.Value = kýrmýzý;
		Yeþil.Value = yesil;
		Mavi.Value = mavi;

	}
	private void RenkKopyala(object sender, EventArgs e)
	{
		Clipboard.Default.SetTextAsync(Arkaplan.ToHex());
	}
}
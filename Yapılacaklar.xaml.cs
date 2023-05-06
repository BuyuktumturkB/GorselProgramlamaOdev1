namespace BurakBuyuktumturkOdev1;

public partial class Yapılacaklar : ContentPage
{
	public Yapılacaklar()
	{
		InitializeComponent();
		BindingContext=new MainViewModel();
	}
}
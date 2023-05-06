namespace BurakBuyuktumturkOdev1;

public partial class BedenKutle : ContentPage
{
	public BedenKutle()
	{
		InitializeComponent();
		BindingContext=new BedenKutleWievModel();
	}
}
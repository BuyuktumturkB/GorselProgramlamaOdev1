namespace BurakBuyuktumturkOdev1;

public partial class KrediFaiz : ContentPage
{
	public KrediFaiz()
	{
		InitializeComponent();
		BindingContext=new KrediViewModel();
	}
}
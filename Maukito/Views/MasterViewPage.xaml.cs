namespace Maukito.Views;

public partial class MasterViewPage : ContentPage
{
	public MasterViewPage(MasterViewViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

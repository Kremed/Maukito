
namespace Maukito.Views;

public partial class MasterViewPage : ContentPage
{
    public MasterViewPage(MasterViewViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }

    protected override void LayoutChildren(double x, double y, double width, double height)
    {
        base.LayoutChildren(x, y, width, height);
    }
}

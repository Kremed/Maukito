

namespace Maukito.ViewModels;

public partial class MasterViewViewModel : BaseViewModel
{
    [ObservableProperty]
    public double displayHeight;

    [ObservableProperty]
    public double vidMargin;

    [ObservableProperty]
    public double vidWidth;
    [ObservableProperty]
    public double vidHight;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(newUserVisibility))]
    public bool loginVisibility = true;
    public bool newUserVisibility => !LoginVisibility;
    public MasterViewViewModel()
    {
        try
        {
            DisplayHeight = Application.Current.MainPage.Height;

            VidMargin = VidMargin - DisplayHeight;

            var ScreenHight = Application.Current.MainPage.Height;

            var HightToAdd = Application.Current.MainPage.Height / 5;

            var ScreenWidth = Application.Current.MainPage.Width;

            var WidthToAdd = Application.Current.MainPage.Width / 5;

            //To Add About 20% for Zooming The Video Media element =>

            VidHight = ScreenHight + HightToAdd;

            VidWidth = ScreenWidth + HightToAdd;
        }
        catch (Exception ex)
        {
            var msg = Snackbar.Make($"{ex.Message} - {ex.InnerException}", null, "X", TimeSpan.FromSeconds(10), BaseSnackbarOptions).Show();
        }
    }

    [RelayCommand]
    public async Task AuthFunction()
    {
        try
        {
            LoginVisibility = !LoginVisibility;
        }
        catch (Exception ex)
        {
            var msg = Snackbar.Make($"{ex.Message} - {ex.InnerException}", null, "X", TimeSpan.FromSeconds(10), BaseSnackbarOptions).Show();
        }
    }

    public SnackbarOptions BaseSnackbarOptions = new SnackbarOptions
    {
        BackgroundColor = Colors.Black,
        TextColor = Colors.White,
        ActionButtonTextColor = Colors.White,
        CornerRadius = new CornerRadius(0),
        Font = Microsoft.Maui.Font.SystemFontOfSize(9),

    };

}

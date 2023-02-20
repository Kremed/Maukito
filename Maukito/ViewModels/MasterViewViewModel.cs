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
            GetScreenSize();
        }
        catch (Exception ex)
        {
            var msg = Snackbar.Make($"{ex.Message} - {ex.InnerException}", null, "X", TimeSpan.FromSeconds(10), BaseSnackbarOptions).Show();
        }
    }

    [RelayCommand]
    public void GetScreenSize()
    {
        DisplayHeight = Application.Current.MainPage.Height;

        VidMargin = VidMargin - DisplayHeight;

        var ScreenHight = Application.Current.MainPage.Height;

        var HightToAdd = Application.Current.MainPage.Height / 5;

        var ScreenWidth = Application.Current.MainPage.Width;

        var WidthToAdd = Application.Current.MainPage.Width / 5;

        //To Add About 20% for Zooming The Video Media element =>

#if ANDROID

        //[ISSUE] TO Fix => For some reason, the Height and Width of the client's screen are not obtained in the
        //Android application for the main page of the application. We always get a value of -1 for Width & Hight.
        //This problem has been temporarily fixed by specifying a static Width & Hight in Android Platform.

        VidHight = 900;
        VidWidth = 600;
#elif IOS
        VidHight = ScreenHight + HightToAdd;
        VidWidth = ScreenWidth + WidthToAdd;
#endif
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

namespace Maukito;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMediaElement()
			.UseMauiMaps()
			.ConfigureFonts(fonts =>
			{

				fonts.AddFont("FontAwesome6FreeBrands.otf", "FontAwesomeBrands");
				fonts.AddFont("FontAwesome6FreeRegular.otf", "FontAwesomeRegular");
				fonts.AddFont("FontAwesome6FreeSolid.otf", "FontAwesomeSolid");
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");

                fonts.AddFont("EXPO-ARABIC-BOLD.TTF", "Bold");
                fonts.AddFont("EXPO-ARABIC-BOOK.TTF", "Medium");
                fonts.AddFont("EXPO-ARABIC-BOLD.TTF", "ExpoBold");
                fonts.AddFont("EXPO-ARABIC-BOOK.TTF", "ExpoBook");
            });

		builder.Services.AddSingleton<MasterViewViewModel>();

		builder.Services.AddSingleton<MasterViewPage>();

		return builder.Build();
	}
}

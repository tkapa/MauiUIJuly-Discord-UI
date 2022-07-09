using MauiUIJuly_Discord_UI.Resources.MockData;
using MauiUIJuly_Discord_UI.ViewModel;

namespace MauiUIJuly_Discord_UI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services
			.AddSingleton<MainPage>()
			.AddSingleton<MainPageModel>()
			.AddSingleton<MockMessages>()
			.AddSingleton<MockUsers>();

		return builder.Build();
	}
}

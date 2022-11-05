using CommunityToolkit.Maui;
using MauiAppOne.Models;

namespace MauiAppOne;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();

		// Initialise the toolkit
		builder.UseMauiApp<App>().UseMauiCommunityToolkit();

		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});


		builder.Services.AddSingleton<MainPage>();

		builder.Services.AddSingleton<MainPageModel>();


		return builder.Build();
	}
}

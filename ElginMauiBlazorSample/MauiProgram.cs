using Microsoft.AspNetCore.Components.WebView.Maui;
using ElginMauiBlazorSample.Data;

namespace ElginMauiBlazorSample;

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
			});

		builder.Services.AddMauiBlazorWebView();
		#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		builder.Services.AddSingleton<Services.IDialogService, Services.DialogService>();
		builder.Services.AddSingleton<Services.E1BridgeService>();

		builder.Services.AddSingleton<WeatherForecastService>();

		return builder.Build();
	}
}

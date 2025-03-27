using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace MauiApp1;

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

#if DEBUG
		builder.Logging.AddDebug();
#endif

		// รองรับการจัดการภาพใน Android
#if ANDROID
        builder.ConfigureMauiHandlers(handlers =>
        {
            handlers.AddHandler<Microsoft.Maui.Controls.Image, Microsoft.Maui.Handlers.ImageHandler>();
        });
#endif

		return builder.Build();
	}
}

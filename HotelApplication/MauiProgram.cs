using Microsoft.Extensions.Logging;

namespace HotelApplication;

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
				fonts.AddFont("IndieFlower-Regular.ttf", "IndieFlower");
				fonts.AddFont("Fashion-Fetish-Regular.ttf", "FashionFetish");
				fonts.AddFont("Fashion-Fetish-Bold.ttf", "FashionBold");
				fonts.AddFont("Fashion-Fetish-Light.ttf", "FashionLight");
				fonts.AddFont("Fashion-Fetish-LightItalic.ttf", "FashionLightItalic");
				fonts.AddFont("Fashion-Fetish-Italic.ttf", "FashionItalic");
				fonts.AddFont("Fashion-Fetish-Heavy.ttf", "FashionHeavy");
				fonts.AddFont("Fashion-Fetish-Outline.ttf", "FashionOutline");
				fonts.AddFont("Fashion-Fetish-SmallCaps.ttf", "FashionSmallCaps");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

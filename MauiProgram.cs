using System.Diagnostics;
using Microsoft.Extensions.Logging;

namespace meteorvsctest;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		Console.WriteLine("console.writeline");
		#if DEBUG
			Console.WriteLine("console.writeline debug");
		#endif
		Debug.WriteLine("debug.writeline");
		
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

		return builder.Build();
	}
}

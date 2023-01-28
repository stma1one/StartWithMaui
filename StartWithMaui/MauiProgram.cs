namespace StartWithMaui;

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
                fonts.AddFont("Pacifico-Regular.ttf", "Pacifico");
                fonts.AddFont("Cinzel-VariableFont_wght.ttf", "Cinzel");
				fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialIcons");
				
			});

		return builder.Build();
	}
}

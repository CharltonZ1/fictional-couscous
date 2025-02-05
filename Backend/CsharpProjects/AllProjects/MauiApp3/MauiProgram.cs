using Microsoft.Extensions.Logging;

namespace MauiApp3;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                //fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                //fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("PFBeauSansPro-Regular.ttf", "PFBeauSansProRegular");
                fonts.AddFont("PFBeauSansPro-SemiBold.ttf", "PFBeauSansProSemiBold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        // Add services to the container.
        builder.Services.AddSingleton<LoginViewModel>();

        // Add ContentViews to the app.
        builder.Services.AddTransient<KeypadView>();
        builder.Services.AddTransient<KeypadViewModel>();

        // Add Pages to the app.
        builder.Services.AddTransient<LoginPage>();

        return builder.Build();
    }
}

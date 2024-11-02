using Microsoft.Extensions.Logging;

namespace App_Hotel
{
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
                    fonts.AddFont("mojangles.ttf", "Mojangles");
                    fonts.AddFont("times.ttf", "Times");
                    fonts.AddFont("DeliusSwashCaps.ttf", "Delius");
                    fonts.AddFont("SpicyRice.ttf", "Spicy");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

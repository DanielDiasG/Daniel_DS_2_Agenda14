using Microsoft.Extensions.Logging;

namespace Agenda13
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
                    fonts.AddFont("IndieFlower-Regular.ttf", "IndieFlower");
                    fonts.AddFont("Tektur-Bold.ttf", "TekturBold");
                    fonts.AddFont("Tektur-ExtraBold.ttf", "TekturExtraBold");
                    fonts.AddFont("Tektur-Medium.ttf", "TekturMedium");
                    fonts.AddFont("Tektur-Regular.ttf", "TekturRegular");
                    fonts.AddFont("BadScript-Regular.ttf", "BadScriptRegular");


                });


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

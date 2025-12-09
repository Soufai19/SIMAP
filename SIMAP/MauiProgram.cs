using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using SIMAP.Services;

namespace SIMAP
{
    public static class MauiProgram
    {
        // Servicio global del inventario (instancia compartida)
        public static InventoryService InventoryService { get; } = new InventoryService();

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            return builder.Build();
        }
    }
}

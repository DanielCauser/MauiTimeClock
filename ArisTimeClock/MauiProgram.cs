using ArisTimeClock.ViewModels;
using ArisTimeClock.Views;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace ArisTimeClock;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .RegisterViewModels()
            .RegisterViews()
            .RegisterNavigation()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("FontAwesome5Free-Solid.ttf", "fontawesome");
                
            });


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<LoginViewModel>();
        mauiAppBuilder.Services.AddTransient<MainPageViewModel>();
        mauiAppBuilder.Services.AddTransient<MemosViewModel>();
        mauiAppBuilder.Services.AddTransient<ManualClockRequestViewModel>();
        //mauiAppBuilder.Services.AddTransient<HeaderViewModel>();

        // More view-models registered here.

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<LoginPage>();
        mauiAppBuilder.Services.AddTransient<MainPage>();
        mauiAppBuilder.Services.AddTransient<MemosPage>();
        mauiAppBuilder.Services.AddTransient<ManualClockRequestPage>();
        //mauiAppBuilder.Services.AddTransient<HeaderView>();

        // More views registered here.

        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterNavigation(this MauiAppBuilder mauiAppBuilder)
    {
        
        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(MemosPage), typeof(MemosPage));
        Routing.RegisterRoute(nameof(ManualClockRequestPage), typeof(ManualClockRequestPage));

        return mauiAppBuilder;
    }
}


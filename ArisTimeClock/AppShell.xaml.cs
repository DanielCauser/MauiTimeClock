using ArisTimeClock.Views;
using CommunityToolkit.Mvvm.Input;

namespace ArisTimeClock;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	}

    protected override void OnNavigated(ShellNavigatedEventArgs args)
    {
        base.OnNavigated(args);
        if(Shell.Current.CurrentPage is ManualClockRequestPage)
        {
            ManualClockHeader.RightCommand = new RelayCommand(() =>
            {
                Console.WriteLine("Navigated to add new manual entry");
            });
        }
    }

    //void TitleLogoutButton_Clicked(System.Object sender, System.EventArgs e)
    //{
    //    Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    //}
}


using ArisTimeClock.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ArisTimeClock.ViewModels
{
	public partial class LoginViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? password;

        [RelayCommand]
        private Task Login(string arg)
        {
            if (arg == "d")
            {
                Password = Password?.Remove(Password.Length - 1);
            }
            else if (arg == "0")
            {
                // append char
                //var value = int.Parse(arg);
                return Shell.Current.GoToAsync($"//{nameof(MainPage)}");
            }
            else
            {
                Password = string.Join(string.Empty, Password, arg);
            }

            return Task.CompletedTask;
        }
    }
}


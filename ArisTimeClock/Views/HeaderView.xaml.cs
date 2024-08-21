using System.Runtime.CompilerServices;
using System.Windows.Input;
using ArisTimeClock.ViewModels;
using Microsoft.Maui.Controls;

namespace ArisTimeClock.Views;

public partial class HeaderView : ContentView, IDisposable
{
    public HeaderView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty RightCommandProperty =
        BindableProperty.Create(nameof(RightCommand), typeof(ICommand), typeof(HeaderView), propertyChanged: RightCommandChanged);

    public static readonly BindableProperty PageTitleProperty =
        BindableProperty.Create(nameof(PageTitle), typeof(string), typeof(HeaderView), string.Empty, propertyChanged: TitleChange);

    public ICommand RightCommand
    {
        get => (ICommand)GetValue(RightCommandProperty);
        set => SetValue(RightCommandProperty, value);
    }

    public string PageTitle
    {
        get => (string)GetValue(PageTitleProperty);
        set => SetValue(PageTitleProperty, value);
    }

    private static void RightCommandChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (!(bindable is HeaderView hv)) return;

        var command = newValue as ICommand;

        hv.RightButton.IsVisible = true;
        hv.RightButton.Command = command;
    }

    private static void TitleChange(BindableObject bindable, object oldValue, object newValue)
    {
        if (!(bindable is HeaderView hv)) return;

        hv.TitleLabel.Text = newValue.ToString();
    }

    public void Logout_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }

    public void Dispose()
    {
        if (LogoutButton != null)
            LogoutButton.Clicked -= Logout_Clicked;
    }
}

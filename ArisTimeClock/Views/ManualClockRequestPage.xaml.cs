using ArisTimeClock.ViewModels;

namespace ArisTimeClock.Views;

public partial class ManualClockRequestPage : ContentPage
{
	public ManualClockRequestPage(ManualClockRequestViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
    }
}

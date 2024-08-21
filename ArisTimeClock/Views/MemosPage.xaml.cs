using ArisTimeClock.ViewModels;

namespace ArisTimeClock.Views;

public partial class MemosPage : ContentPage
{
	public MemosPage(MemosViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

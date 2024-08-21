﻿using ArisTimeClock.ViewModels;

namespace ArisTimeClock.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}



using System;
using ArisTimeClock.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ArisTimeClock.ViewModels
{
	public partial class ManualClockRequestViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<ManualClockEventGridModel> list;

        public ManualClockRequestViewModel()
        {
            list = new List<ManualClockEventGridModel>()
            {
                new ManualClockEventGridModel
                {
                    Date = "12/28/2018",
                    ClockStatus = "Auto",
                    Reason = "Read",
                    Time = "07:30 PM"
                },
                new ManualClockEventGridModel
                {
                    Date = "12/30/2018",
                    ClockStatus = "Auto",
                    Reason = "Read",
                    Time = "07:30 PM"
                },
                new ManualClockEventGridModel
                {
                    Date = "12/1/2018",
                    ClockStatus = "Auto",
                    Reason = "Read",
                    Time = "07:30 PM"
                },
                new ManualClockEventGridModel
                {
                    Date = "12/28/2018",
                    ClockStatus = "Auto",
                    Reason = "Read",
                    Time = "07:30 PM"
                },
                new ManualClockEventGridModel
                {
                    Date = "12/2/2018",
                    ClockStatus = "ryan",
                    Reason = "Read",
                    Time = "07:30 PM"
                },
                new ManualClockEventGridModel
                {
                    Date = "11/28/2024",
                    ClockStatus = "Auto",
                    Reason = "Read",
                    Time = "07:30 PM"
                },
            };
        }
    }
}


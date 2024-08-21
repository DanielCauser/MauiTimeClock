using ArisTimeClock.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ArisTimeClock.ViewModels
{
    public partial class MemosViewModel : ObservableObject
    {
        [ObservableProperty]
        public List<MessageModel> memos;

        [RelayCommand]
        private Task MemoSelected()
        {
            return Task.CompletedTask;
        }

        public MemosViewModel()
		{
            memos = new List<MessageModel>()
            {
                new MessageModel
                {
                    DateSent = "12/28/2018",
                    SentBy = "Auto",
                    Status = new MessageStatusModel{ Value = "Read" }
                },
                new MessageModel
                {
                    DateSent = "12/30/2018",
                    SentBy = "Auto",
                    Status = new MessageStatusModel{ Value = "Read" }
                },
                new MessageModel
                {
                    DateSent = "12/1/2018",
                    SentBy = "Auto",
                    Status = new MessageStatusModel{ Value = "Read" }
                },
                new MessageModel
                {
                    DateSent = "12/28/2018",
                    SentBy = "Auto",
                    Status = new MessageStatusModel{ Value = "Read" }
                },
                new MessageModel
                {
                    DateSent = "12/2/2018",
                    SentBy = "ryan",
                    Status = new MessageStatusModel{ Value = "Read" }
                },
                new MessageModel
                {
                    DateSent = "11/28/2024",
                    SentBy = "Auto",
                    Status = new MessageStatusModel{ Value = "Read" }
                },
            };
        }
    }
}


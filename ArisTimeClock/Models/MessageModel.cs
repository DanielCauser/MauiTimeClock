using System;
namespace ArisTimeClock.Models
{
    public class MessageModel
    {
        public string DispatchedMessageId { get; set; }
        public string Text { get; set; }
        public string SentBy { get; set; }
        public string DateSent { get; set; }
        public string TimeSent { get; set; }
        public MessageStatusModel Status { get; set; }
    }
}


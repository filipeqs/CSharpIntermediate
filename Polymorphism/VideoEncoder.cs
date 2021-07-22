using System;
using System.Collections.Generic;

namespace Polymorphism
{
    public class VideoEncoder
    {
        private readonly IList<INotificationChannel> NotificationChannels;
        public VideoEncoder()
        {
            NotificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            foreach (var chanell in NotificationChannels)
                chanell.Send(new Message());
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            NotificationChannels.Add(channel);
        }
    }
}

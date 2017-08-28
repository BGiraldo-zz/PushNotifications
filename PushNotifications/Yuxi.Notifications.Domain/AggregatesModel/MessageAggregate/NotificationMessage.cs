using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Domain.AggregatesModel.MessageAggregate
{
    public class NotificationMessage
    {
        public string NotificationUserId { get; private set; }

        public string[] PlaceHolderValues { get; private set; }

    }
}

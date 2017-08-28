using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yuxi.Notifications.API.Applications.Models
{
    public class NotificationMessage
    {

        public string NotificationUserId { get; private set; }

        public string[] PlaceHolderValues { get; private set; }

    }
}

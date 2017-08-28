using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yuxi.Notifications.Application.Commands.MessageCommand
{
    public class SendNotificationCommand : IRequest<bool>
    {


        public string NotificationUserId { get; private set; }

        public string[] PlaceHolderValues { get; private set; }


        public SendNotificationCommand(string notificationUserId, string[] placeHolderValues)
        {
            NotificationUserId = notificationUserId;
            PlaceHolderValues = placeHolderValues;
        }

    }
}

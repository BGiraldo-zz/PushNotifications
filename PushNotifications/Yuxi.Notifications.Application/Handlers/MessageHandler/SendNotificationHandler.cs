using MediatR;
using System;
using Yuxi.Notifications.Application.Commands.MessageCommand;


namespace Yuxi.Notifications.Application.Handlers.MessageHandler
{
    public class SendNotificationHandler : IRequestHandler<SendNotificationCommand, bool>
    {
        public bool Handle(SendNotificationCommand message)
        {
            throw new NotImplementedException();
        }
    }
}

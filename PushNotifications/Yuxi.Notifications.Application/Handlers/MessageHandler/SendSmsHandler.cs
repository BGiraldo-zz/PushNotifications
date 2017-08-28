using MediatR;
using System;
using Yuxi.Notifications.Application.Commands.MessageCommand;


namespace Yuxi.Notifications.Application.Handlers.MessageHandler
{
    public class SendSmsHandler : IRequestHandler<SendSmsCommand, bool>
    {
        public bool Handle(SendSmsCommand message)
        {
            throw new NotImplementedException();
        }
    }
}

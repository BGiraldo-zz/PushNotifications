using MediatR;
using System;
using Yuxi.Notifications.Application.Commands.MessageCommand;

namespace Yuxi.Notifications.Application.Handlers.MessageHandler
{
    public class SendEmailHandler : IRequestHandler<SendEmailCommand, bool>
    {


        
        public bool Handle(SendEmailCommand message)
        {
            throw new NotImplementedException();
        }
    }
}

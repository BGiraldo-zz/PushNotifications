using MediatR;
using System;
using Yuxi.Notifications.Application.Commands.TemplateCommand;

namespace Yuxi.Notifications.Application.Handlers.TemplateHandler
{
    public class RegisterTemplateHandler : IRequestHandler<RegisterTemplateCommand, bool>
    {

        public bool Handle(RegisterTemplateCommand message)
        {
            throw new NotImplementedException();
        }
    }
}

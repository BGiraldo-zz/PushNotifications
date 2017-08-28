using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Yuxi.Notifications.Application.Commands.TemplateCommand;

namespace Yuxi.Notifications.Application.Handlers.TemplateHandler
{
    public class UpdateTemplateHandler : IRequestHandler<UpdateTemplateCommand, bool>
    {
        public bool Handle(UpdateTemplateCommand message)
        {
            throw new NotImplementedException();
        }
    }
}

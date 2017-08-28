using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Yuxi.Notifications.Application.Commands.TemplateCommand;

namespace Yuxi.Notifications.Application.Handlers.TemplateHandler
{
    public class DeleteTemplateHandler : IRequestHandler<DeleteTemplateCommand, bool>
    {
        public bool Handle(DeleteTemplateCommand message)
        {
            throw new NotImplementedException();
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Application.Commands.TemplateCommand
{
    public class RegisterTemplateCommand : IRequest<bool>
    {
        public Guid Id { get; private set; }

        public string Body { get; private set; }

        public RegisterTemplateCommand(string body)
        {
            Id = Guid.NewGuid();
            Body = body;
        }
    }
}

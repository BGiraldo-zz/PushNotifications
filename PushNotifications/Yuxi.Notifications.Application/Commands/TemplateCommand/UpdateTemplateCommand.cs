using MediatR;
using System;

namespace Yuxi.Notifications.Application.Commands.TemplateCommand
{
   public class UpdateTemplateCommand : IRequest<bool>
    {

        public Guid Id { get; private set; }

        public string Body { get; private set; }


        public UpdateTemplateCommand(Guid id, string body)
        {
            Id = id;
            Body = body;
        }

    }
}

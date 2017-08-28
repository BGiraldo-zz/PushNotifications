using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Application.Commands.TemplateCommand
{
   public class DeleteTemplateCommand : IRequest<bool>
    {

        public Guid Id { get; private set; }

        public DeleteTemplateCommand(Guid id)
        {
            Id = id;
        }
        
    }
}

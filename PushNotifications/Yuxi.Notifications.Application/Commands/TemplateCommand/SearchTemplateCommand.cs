using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Application.Commands.TemplateCommand
{
    public class SearchTemplateCommand : IRequest<bool>
    {
   
        public Guid Id { get; private set; }

        public SearchTemplateCommand(Guid id)
        {
            Id = id;
        }


    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Yuxi.Notifications.Application.Commands.TemplateCommand;

namespace Yuxi.Notifications.Application.Handlers.TemplateHandler
{
    class SearchTemplateHandler : IRequestHandler<SearchTemplateCommand, bool>
    {
        public bool Handle(SearchTemplateCommand message)
        {
            throw new NotImplementedException();
        }
    }
}

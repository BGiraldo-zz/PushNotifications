using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yuxi.Notifications.API.Applications.Models;
using Yuxi.Notifications.Application.Commands.TemplateCommand;
using MediatR;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yuxi.Notifications.API.Controllers
{
    [Route("api/[controller]")]
    public class TemplateController : Controller
    {

        private readonly IMediator _mediator;

        public TemplateController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [Route("/register-template")]
        [HttpPost]
        public async Task<Guid> RegisterTemplate(string template)
        {
            bool commandResult = false;

            RegisterTemplateCommand command = new RegisterTemplateCommand(template);
           
            commandResult = await _mediator.Send(command);

            return command.Id;
        }

        [Route("/edit-template")]
        [HttpPost]
        public async Task<IActionResult> EditTemplate(Template template)
        {

            bool commandResult = false;

            UpdateTemplateCommand command = new UpdateTemplateCommand(template.Id, template.Body);

            commandResult = await _mediator.Send(command);

            return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();

        }

        [Route("/remove-template")]
        [HttpPost]
        public async Task<IActionResult> RemoveTemplate(Guid templateId)
        {
    
            bool commandResult = false;

            DeleteTemplateCommand command = new DeleteTemplateCommand(templateId);

            commandResult = await _mediator.Send(command);

            return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();

        }

        [Route("/search-template")]
        [HttpPost]
        public async Task<IActionResult> SearchTemplate(Guid templateId)
        {

            bool commandResult = false;

            SearchTemplateCommand command = new SearchTemplateCommand(templateId);

            commandResult = await _mediator.Send(command);

            return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();

        }


    }
}

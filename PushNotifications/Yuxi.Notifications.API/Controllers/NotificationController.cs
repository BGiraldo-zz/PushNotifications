using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Yuxi.Notifications.Application.Commands.MessageCommand;
using Yuxi.Notifications.Application.Commands.UserCommand;
using Yuxi.Notifications.API.Applications.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yuxi.Notifications.API.Controllers
{
    [Route ("api/[controller]")]
    public class NotificationController : Controller
    {

        private readonly IMediator _mediator;

        public NotificationController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
        

        [HttpPost("/send-sms")]
        public async Task<IActionResult> SendSmsMessage(SmsMessage message)
        {
            bool commandResult = false;

           SendSmsCommand smsCommand = new SendSmsCommand(message.FromCelphone, 
                                                          message.CountryCode, 
                                                          message.TemplateId,
                                                          message.PlaceHolderValues);
           commandResult = await _mediator.Send(smsCommand);

           return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();

        }


        [HttpPost("/send-email")]
        public async Task<IActionResult> SendEmailMessage(EmailMessage message)
        {
            bool commandResult = false;

            SendEmailCommand emailCommand = new SendEmailCommand(message.SendTo,
                                                                 message.Bbc,
                                                                 message.TemplateId,
                                                                 message.PlaceHolderValues,
                                                                 message.Subject,
                                                                 message.ReplyTo);
            commandResult = await _mediator.Send(emailCommand);

            return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();

        }


        [HttpPost("/send-notification")]
        public async Task<IActionResult> SendNotificationMessage(NotificationMessage message)
        {
            bool commandResult = false;

            SendNotificationCommand notificationCommand = new SendNotificationCommand(message.NotificationUserId, 
                                                                                      message.PlaceHolderValues);
             commandResult = await _mediator.Send(notificationCommand);

            return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();

        }


        [HttpPost("/register-user")]
        public async Task<IActionResult> RegisterUserNotification(UserRegistryMessage message)
        {
            bool commandResult = false;
        
           RegisterUserNotificationCommand userRegistryCommand = new RegisterUserNotificationCommand(message.PnsHandler, 
                                                                                                     message.DeviceId, 
                                                                                                     message.Platform,
                                                                                                     message.TemplateId,
                                                                                                     message.AppUserId);
           commandResult = await _mediator.Send(userRegistryCommand);

            return commandResult ? (IActionResult)Ok() : (IActionResult)BadRequest();

        }

    }
}

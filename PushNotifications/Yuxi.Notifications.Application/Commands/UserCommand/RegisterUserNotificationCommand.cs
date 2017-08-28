using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yuxi.Notifications.Application.Commands.UserCommand
{
    public class RegisterUserNotificationCommand : IRequest<bool>
    {

        public string PnsHandler { get; private set; }

        public string DeviceId { get; private set; }

        public string Platform { get; private set; }

        public string TemplateId { get; private set; }

        public string AppUserId { get; private set; }


        public RegisterUserNotificationCommand(string pnsHandler, string deviceId, string platform, string templateId, string appUserId)
        {
            PnsHandler = pnsHandler;
            DeviceId = deviceId;
            Platform = platform;
            TemplateId = templateId;
            AppUserId = appUserId;
        }
   
    }
}

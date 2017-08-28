using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Application.Services
{
    public class NotificationService : INotificationService
    {
        public string RegisterUserNotification(string pnsHandler, string deviceId, string platform, string templateId, string appUserId)
        {
            throw new NotImplementedException();
        }

        public void SendEmailMessage(string sendTo, string bcc, string templateId, string[] placeHolderValues, string subjet, string replyTo)
        {
            throw new NotImplementedException();
        }

        public void SendNotificationMessage(string notificationUserId, string[] placeHolderValues)
        {
            throw new NotImplementedException();
        }

        public void SendSmsMessage(string fromCelphone, string countryCode, string templateId, string[] placeHolderValues)
        {
            throw new NotImplementedException();
        }
    }
}

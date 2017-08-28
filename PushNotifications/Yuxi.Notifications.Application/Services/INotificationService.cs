using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Application.Services
{
    public interface INotificationService
    {

        void SendSmsMessage(string fromCelphone, string countryCode, string templateId,
                                string[] placeHolderValues);

        // Body SendSmsMessage

        void SendEmailMessage(string sendTo, string bcc, string templateId,
                                    string[] placeHolderValues, string subjet,
                                    string replyTo);

        // Body SendEmailMessage

        string RegisterUserNotification(string pnsHandler, string deviceId, string platform,
                                               string templateId, string appUserId);

        void SendNotificationMessage(string notificationUserId, string[] placeHolderValues);


    }
}

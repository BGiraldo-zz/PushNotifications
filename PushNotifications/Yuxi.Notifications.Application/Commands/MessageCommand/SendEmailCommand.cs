using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yuxi.Notifications.Application.Commands.MessageCommand
{
    public class SendEmailCommand : IRequest<bool>
    {

        public string SendTo { get; private set; }

        public string Bbc { get; private set; }

        public string TemplateId { get; private set; }

        public string[] PlaceHolderValues { get; private set; }

        public string Subject { get; private set; }

        public string ReplyTo { get; private set; }

        public SendEmailCommand(string sendTo, string bbc, string templateId, string[] placeHolderValues, string subject, string replyTo)
        {
            SendTo = sendTo;
            Bbc = bbc;
            TemplateId = templateId;
            PlaceHolderValues = placeHolderValues;
            Subject = subject;
            ReplyTo = replyTo;
        }
    }
}

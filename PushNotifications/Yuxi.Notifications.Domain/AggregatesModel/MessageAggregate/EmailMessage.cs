using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Domain.AggregatesModel.MessageAggregate
{
    public class EmailMessage
    {

        public string SendTo { get; private set; }

        public string Bbc { get; private set; }

        public string TemplateId { get; private set; }

        public string[] PlaceHolderValues { get; private set; }

        public string Subject { get; private set; }

        public string ReplyTo { get; private set; }

    }
}

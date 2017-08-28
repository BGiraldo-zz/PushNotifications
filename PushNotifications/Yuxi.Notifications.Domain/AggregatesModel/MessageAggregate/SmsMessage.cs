using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Domain.AggregatesModel.MessageAggregate
{
   public class SmsMessage
    {

        public string FromCelphone { get; private set; }

        public string CountryCode { get; private set; }

        public string TemplateId { get; private set; }

        public string[] PlaceHolderValues { get; private set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Yuxi.Notifications.Domain.AggregatesModel.MessageAggregate
{
   public class UserRegistryMessage
    {

        public string PnsHandler { get; private set; }

        public string DeviceId { get; private set; }

        public string Platform { get; private set; }

        public string TemplateId { get; private set; }

        public string AppUserId { get; private set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yuxi.Notifications.API.Applications.Models
{
    public class SmsMessage
    {
        public string FromCelphone { get; private set; }

        public string CountryCode { get; private set; }

        public string TemplateId { get; private set; }

        public string[] PlaceHolderValues { get; private set; }
    }
}

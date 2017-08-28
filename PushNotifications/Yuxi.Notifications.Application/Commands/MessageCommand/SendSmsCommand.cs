using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yuxi.Notifications.Application.Commands.MessageCommand
{

    public class SendSmsCommand : IRequest<bool>
    {

        public string FromCelphone { get; private set; }

        public string CountryCode { get; private set; }

        public string TemplateId { get; private set; }

        public string[] PlaceHolderValues { get; private set; }



        public SendSmsCommand(string fromCelphone, string countryCode, string templateId, string[] placeHolderValues)
        {
            FromCelphone = fromCelphone;
            CountryCode = countryCode;
            TemplateId = templateId;
            PlaceHolderValues = placeHolderValues;
        }
    }
}

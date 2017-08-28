using System;
using Yuxi.Notifications.Domain.SeedWork;

namespace Yuxi.Notifications.Domain.AggregatesModel.TemplateAggregate
{
    public class Template : IAggregateRoot
    {

        public Guid Id { get; private set; }

        public String Body { get; private set; }


        public Template(Guid id, string body)
        {
            Id = id;
            Body = body;
        }




    }
}

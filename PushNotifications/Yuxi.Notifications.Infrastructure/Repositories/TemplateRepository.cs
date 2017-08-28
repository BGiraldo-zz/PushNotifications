using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yuxi.Notifications.Domain.AggregatesModel.TemplateAggregate;

namespace Yuxi.Notifications.Infrastructure.Repositories
{
    public class TemplateRepository : ITemplateRepository
    {
        private readonly NotificationContext _context;

        public TemplateRepository(NotificationContext context)
        {
            _context = context;
        }

        public void Add(Template templateToInsert)
        {
            throw new NotImplementedException();
        }

        public Task<Template> FindAsync(Guid idTemplate)
        {
            throw new NotImplementedException();
        }

        public void Update(Template templateToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

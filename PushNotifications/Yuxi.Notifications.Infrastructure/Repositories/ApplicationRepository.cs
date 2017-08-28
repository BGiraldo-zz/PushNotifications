using System;
using System.Threading.Tasks;
using Yuxi.Notifications.Domain.AggregatesModel.ApplicationAggregate;

namespace Yuxi.Notifications.Infrastructure.Repositories
{
    public class ApplicationRepository : IApplicationRepository
    {

        private readonly NotificationContext _context;

        public ApplicationRepository(NotificationContext context)
        {
            _context = context;
        }

        public void Add(Application applicationToInsert)
        {
            throw new NotImplementedException();
           
        }

        public Task<Application> FindAsync(Guid idApplication)
        {
            throw new NotImplementedException();
        }

        public void Update(Application applicationToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Yuxi.Notifications.Domain.AggregatesModel.UserAggregate;

namespace Yuxi.Notifications.Infrastructure.Repositories
{
    public class UserRegistryRepository : IUserRegistryRepository
    {
        private readonly NotificationContext _context;

        public UserRegistryRepository(NotificationContext context)
        {
            _context = context;
        }

        public void Add(UserRegistry UserToInsert)
        {
            throw new NotImplementedException();
        }

        public Task<UserRegistry> FindAsync(Guid idUser)
        {
            throw new NotImplementedException();
        }

        public void Update(UserRegistry userToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}

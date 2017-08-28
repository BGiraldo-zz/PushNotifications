using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Yuxi.Notifications.Domain.SeedWork
{
    public interface IRepository<T> where T : IAggregateRoot
    {

        Task<T> FindAsync(Guid idObject);

        void Add(T objectToInsert);

        void Update(T objectToUpdate);

    }
}

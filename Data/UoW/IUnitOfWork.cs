using AwesomeNetwork.Data.Repository;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Collections.Generic;

namespace AwesomeNetwork.Data.UoW
{
    public interface IUnitOfWork: IDisposable
    {

        int SaveChanges(bool ensureAutoHistory = false);
        IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository =true) where TEntity : class;
    }
}

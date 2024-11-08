using AwesomeNetwork.Data.Repository;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace AwesomeNetwork.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private Dictionary<Type, object> _repositories;
        private ApplicationDbContext _appContext;
        public UnitOfWork(ApplicationDbContext app)
        {

            this._appContext = app;
        }

        public void Dispose()
        {}

        public IRepository<TEntity> GetRepository<TEntity>(bool hasCustomRepository = true) where TEntity : class
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<Type, object>();
            }

            if (hasCustomRepository)
            {
                var customRepo = _appContext.GetService<IRepository<TEntity>>();
                if (customRepo != null)
                {

                    return customRepo;
                }
            }

            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type))
            {
                _repositories[type] = new Repository<TEntity>(_appContext);
            }

             return (IRepository<TEntity>)_repositories[type];
           
        }
        public int SaveChanges(bool ensureAutoHistory = false)
        {

            throw new NotImplementedException();
        }
    }
}

using DDD.Domain.Entity;
using DDD.Domain.Interfaces.Repository;
using DDD.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Services
{
    class BaseService<TEntity> : IBaseService<TEntity> where TEntity : BaseEntity
    {
        protected readonly IBaseRepository<TEntity> repository;

        public BaseService(IBaseRepository<TEntity> repository)
        {
            this.repository = repository;
        }

        public int Add(TEntity entity)
        {
            this.repository.Add(entity);
        }

        public void Delete(int id)
        {
            this.repository.Delete(id);
        }

        public void Delete(TEntity entity)
        {
            this.repository.Delete(entity);
        }

        public TEntity GetById(int id)
        {
            return this.repository.GetById(id);
        }

        public IEnumerable<TEntity> ListAll()
        {
            return this.repository.ListAll();
        }

        public void Update(TEntity entity)
        {
            this.Update(entity);
        }
    }
}

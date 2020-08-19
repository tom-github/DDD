﻿using DDD.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.Interfaces.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        int Add(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
        void Update(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> ListAll();
    }
}

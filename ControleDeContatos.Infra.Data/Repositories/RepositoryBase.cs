﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ControleDeContatos.Domain.Interfaces.Repositories;
using ControleDeContatos.Infra.Data.Context;

namespace ControleDeContatos.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ControleDeContatoContext Db = new ControleDeContatoContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            // SaveChanges é para salvar o que eu estou fazendo
            Db.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

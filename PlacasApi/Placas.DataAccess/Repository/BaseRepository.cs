using Microsoft.EntityFrameworkCore;
using Placas.Entities.Domain;
using Placas.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Placas.DataAccess.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _dbSet;
        private readonly Data.PlacasContext _dbContext;
        public BaseRepository(Data.PlacasContext PlacasContext)
        {
            this._dbContext = PlacasContext;
            this._dbSet = _dbContext.Set<T>();
        }
        public void Add(T entiti)
        {
            _dbSet.Add(entiti);
            _dbContext.SaveChanges();

        }
        public void Delete(T entiti)
        {

            _dbSet.Remove(entiti);
            _dbContext.SaveChanges();

        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public IEnumerable<T> GetAll(string Argumento)
        {
            return _dbSet.Include(Argumento).ToList();
        }
        public IEnumerable<T> GetAll(string ArgumentOne, string ArgumentTwo, string ArgumentTre)
        {
            return _dbSet.Include(ArgumentOne).Include(ArgumentTwo).Include(ArgumentTre).ToList();
        }

        public T GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public T GetByExpression(Expression<Func<T, bool>> Expression)
        {
            return _dbSet.Where(Expression).FirstOrDefault();
        }
        public IEnumerable<T> GetByExpressionList(string ArgumentOne, string ArgumentTwo,
            Expression<Func<T, bool>> Expression)
        {
            return _dbSet.Include(ArgumentOne).Include(ArgumentTwo).Where(Expression).ToList();
        }

        public void Update(int id, T entiti)
        {
            var documento = _dbSet.Find(id);
            documento = entiti;
           
            _dbSet.Update(documento);
             _dbContext.SaveChanges();
        }
        public bool Any(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Any(expression);
        }
    }
}

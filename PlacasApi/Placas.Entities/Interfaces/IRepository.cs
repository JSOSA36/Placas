using Placas.Entities.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Placas.Entities.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entiti);
        void Update(int id, T entiti);

        T GetById(int Id);
        T GetByExpression(Expression<Func<T, bool>> expresion);
        IEnumerable<T> GetByExpressionList(string ArgumentOne, string ArgumentTwo,
            Expression<Func<T, bool>> expresion);
        void Delete(T entiti);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(string ArgumentOne);
        IEnumerable<T> GetAll(string ArgumentOne, string ArgumentTwo, string ArgumentTre);
        bool Any(Expression<Func<T, bool>> expression);
    }
}

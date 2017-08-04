using System.Collections.Generic;

namespace VacationPolicyBL.Repository.Base
{
    public interface IRepository<T> where T : class, IIdentity
    {
        void Create(T entity);
        List<T> GetAll();
        //IQueryable<T> Get();
        T GetById(int id);
        void Update(T entity);
        void Delete(int id);
        void Delete(T entity);
        void Commit();
    }
}

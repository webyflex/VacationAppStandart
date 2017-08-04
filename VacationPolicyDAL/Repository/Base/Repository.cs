using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using VacationPolicyBL.Repository.Base;

namespace VacationPolicyDAL.Repository.Base
{
    public class Repository<T> : IRepository<T> where T : class, IIdentity
    {
        private readonly UnitOfWork unitOfWork;

        public Repository(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Commit()
        {
            unitOfWork.Commit();
        }

        public void Create(T entity)
        {
            unitOfWork.DbContext.Entry(entity).State = EntityState.Added;
        }

        public void Delete(T entity)
        {
            Delete(entity.Id);
        }

        public void Delete(int id)
        {
            var entity = GetById(id);

            if (entity != null)
            {
                unitOfWork.DbContext.Entry(entity).State = EntityState.Deleted;
            }
        }

        public List<T> GetAll()
        {
            return unitOfWork.DbContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return unitOfWork.DbContext.Set<T>().Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(T entity)
        {
            unitOfWork.DbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}

using System.Data.Entity;
using VacationPolicyBL.Repository.Base;

namespace VacationPolicyDAL.Repository.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        public DbContext DbContext { get; private set; }

        public UnitOfWork(DbContext dbContext)
        {
            DbContext = dbContext;
        }

        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}

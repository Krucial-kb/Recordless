using Microsoft.Extensions.Logging;
using RecordlessDataAccess.DbModels;
using RecordlessDomain.DomainModels;
using RecordlessDomain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RecordlessDataAccess.Repositories
{
    public class AccountRepository : GenericRepository<Account>, IAccountContract
    {
        public AccountRepository(RecordlessContext context, ILogger logger) : base(context, logger)
        {
        }

        public void Add(AccountModel entity)
        {
        }

        public void AddRange(IEnumerable<AccountModel> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AccountModel> Find(Expression<Func<AccountModel, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Remove(AccountModel entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<AccountModel> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<AccountModel> IGenericContract<AccountModel>.GetAll()
        {
            throw new NotImplementedException();
        }

        AccountModel IGenericContract<AccountModel>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}

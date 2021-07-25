using ERP.HRM.Data.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.HRM.Data.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        IStaffRepository Staffs { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}

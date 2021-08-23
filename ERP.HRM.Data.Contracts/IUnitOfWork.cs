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
        IDependantRepository Dependants { get; }
        ILeaveRepository Leaves { get; }

        int SaveChanges();
        Task<int> SaveChangesAsync();
    }
}

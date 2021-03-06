using ERP.Models.HMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.HRM.Data.Contracts.Repositories
{
    public interface ILeaveRepository : IRepository<Leave>
    {
        Task<IList<Leave>> GetByDateAsync(DateTime date);
    }
}

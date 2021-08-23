using ERP.HRM.Data.Contracts.Repositories;
using ERP.Models.HMS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.HRM.Data.Repositories
{
    public class LeaveRepository : GenericRepository<Leave>, ILeaveRepository
    {
        public LeaveRepository(DbContext context) : base(context)
        {
        }

        public async Task<IList<Leave>> GetByDateAsync(DateTime date)
        {
            return await DbSet.Where(x=>x.From.Date == date.Date).ToListAsync();
        }
    }
}

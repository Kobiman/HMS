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
    public class StaffRepository : GenericRepository<Staff>, IStaffRepository
    {
        public StaffRepository(DbContext context) : base(context)
        {
        }

        public Task<Staff> GetStaffAsync(string staffId)
        {
            return DbSet.Include(x => x.Dependants.Where(x => x.StaffId == staffId)).FirstOrDefaultAsync(x => x.StaffId == staffId);;
        }
    }
}

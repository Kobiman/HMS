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
    public class DependantRepository : GenericRepository<Dependant>, IDependantRepository
    {
        public DependantRepository(DbContext context) : base(context)
        {
        }
    }
}

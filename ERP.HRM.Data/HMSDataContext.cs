using ERP.Models.HMS;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.HRM.Data
{
    public class HMSDataContext : DbContext
    {
        public HMSDataContext(DbContextOptions<HMSDataContext> options) : base(options)
        {
        }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Dependant> Dependants { get; set; }
    }
}

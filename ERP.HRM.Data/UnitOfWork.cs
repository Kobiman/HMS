using ERP.HRM.Data.Contracts;
using ERP.HRM.Data.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.HRM.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IStaffRepository Staffs => throw new NotImplementedException();

        private HMSDataContext _context { get; set; }

        public UnitOfWork(HMSDataContext context)
        {
            _context = context;
        }
        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                }
            }
        }
    }
}

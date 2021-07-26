using ERP.HRM.Data.Contracts;
using ERP.HRM.Data.Contracts.Repositories;
using ERP.HRM.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.HRM.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private IStaffRepository _staffs;
        public IStaffRepository Staffs => _staffs ??= new StaffRepository(_context);

        private HMSDataContext _context { get; set; }

        public UnitOfWork(HMSDataContext context)
        {
            _context = context;
        }
        public int SaveChanges()
        {
          return  _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
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

using ERP.HRM.Data.Contracts;
using ERP.HRM.Services.Contracts;
using ERP.Models.HMS;
using ERP.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ERP.HRM.Services
{
    public class StaffService : IStaffService
    {
        private IUnitOfWork _unitOfWork;
        public StaffService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddStaff(Staff staff)
        {
           if (staff is null) return new Result(false, MessageSource.OperationFailed);
           _unitOfWork.Staffs.Add(staff);
           await _unitOfWork.SaveChangesAsync();
           return new Result(true, MessageSource.AddedSuccessfully(nameof(Staff)));
        }

        public async ValueTask<IResult> GetStaff(string staffId)
        {
            var staff = await _unitOfWork.Staffs.GetByIdAsync(staffId);
            if (staff is null) return new Result(false, MessageSource.OperationFailed);
            return new Result<Staff>(true, staff, MessageSource.OperationCompletedSuccesfully);
        }

        public async ValueTask<IResult> GetStaffs()
        {
            var staffs = await _unitOfWork.Staffs.GetAllAsync();
            if (staffs is null) return new Result(false, MessageSource.OperationFailed);
            return new Result<IList<Staff>>(true, staffs, MessageSource.OperationCompletedSuccesfully);
        }

        public async Task<IResult> UpdateStaff(Staff staff)
        {
            if (staff is null) return new Result(false, MessageSource.OperationFailed);
            _unitOfWork.Staffs.Update(staff);
            await _unitOfWork.SaveChangesAsync();
            return new Result(true, MessageSource.AddedSuccessfully(nameof(Staff)));
        }
    }
}

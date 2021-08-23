using ERP.HRM.Data.Contracts;
using ERP.HRM.Services.Contracts;
using ERP.Models.HMS;
using ERP.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.HRM.Services
{
    public class LeaveService : ILeaveService
    {
        private IUnitOfWork _unitOfWork;
        public LeaveService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> Apply(Leave leave)
        {
            if (leave is null) return new Result(false, MessageSource.OperationFailed);
            _unitOfWork.Leaves.Add(leave);
            await _unitOfWork.SaveChangesAsync();
            return new Result(true, MessageSource.AddedSuccessfully(nameof(Leave)));
        }

        public async ValueTask<IResult> GetLeavesByDate(DateTime date)
        {
            var leaves = await _unitOfWork.Leaves.GetByDateAsync(date);
            if (leaves is null) return new Result(false, MessageSource.OperationFailed);
            return new Result<IList<Leave>>(true, leaves, MessageSource.OperationCompletedSuccesfully);
        }
    }
}

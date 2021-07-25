using ERP.Models.HMS;
using ERP.Shared;
using System;
using System.Threading.Tasks;

namespace ERP.HRM.Services.Contracts
{
    public interface IStaffService
    {
        Task<IResult> AddStaff(Staff staff);
        Task<IResult> UpdateStaff(Staff staff);
        ValueTask<IResult> GetStaffs();
        ValueTask<IResult> GetStaff(string staffId);
    }
}

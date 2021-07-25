using ERP.Models.HMS;
using ERP.Shared;
using System;

namespace ERP.HRM.Services.Contracts
{
    public interface IStaffService
    {
        IResult AddStaff(Staff staff);
        IResult UpdateStaff(Staff staff);
        IResult GetStaffs();
        IResult GetStaff(string staffId);
    }
}

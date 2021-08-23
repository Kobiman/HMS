using ERP.Models.HMS;
using ERP.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.HRM.Services.Contracts
{
    public interface ILeaveService
    {
        Task<IResult> Apply(Leave leave);
        ValueTask<IResult> GetLeavesByDate(DateTime date);
    }
}

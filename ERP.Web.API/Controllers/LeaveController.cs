using ERP.HRM.Services.Contracts;
using ERP.Models.HMS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.HRM.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveController : ControllerBase
    {
        private readonly ILeaveService _leaveService;
        public LeaveController(ILeaveService leaveService)
        {
            _leaveService = leaveService;
        }

        [HttpPost]
        [Route("Apply")]
        public async Task<IActionResult> AddStaff([FromBody] Leave leave)
        {
            var result = await _leaveService.Apply(leave);
            if (result.IsSucessful) return Ok(result);
            return BadRequest(result);
        }

        //[HttpGet]
        //[Route("GetStaffs")]
        //public async Task<IActionResult> GetStaffs()
        //{
        //    var result = await _leaveService.GetStaffs();
        //    if (result.IsSucessful) return Ok(result);
        //    return BadRequest(result);
        //}

    }
}

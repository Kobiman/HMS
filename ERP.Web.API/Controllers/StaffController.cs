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
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _staffService;
        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpPost]
        [Route("AddStaff")]
        public async Task<IActionResult> AddStaff([FromBody] Staff staff)
        {
            var result = await _staffService.AddStaff(staff);
            if (result.IsSucessful) return Ok(result);
            return BadRequest(result);
        }

        [HttpPost]
        [Route("UpdateStaff")]
        public async Task<IActionResult> UpdateStaff([FromBody] Staff staff)
        {
            var result = await _staffService.UpdateStaff(staff);
            if (result.IsSucessful) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet]
        [Route("GetStaffs")]
        public async Task<IActionResult> GetStaffs()
        {
            var result = await _staffService.GetStaffs();
            if (result.IsSucessful) return Ok(result);
            return BadRequest(result);
        }

        [HttpGet]
        [Route("GetStaff/{stffId}")]
        public async Task<IActionResult> GetStaff(string stffId)
        {
            var result = await _staffService.GetStaff(stffId);
            if (result.IsSucessful) return Ok(result);
            return BadRequest(result);
        }
    }
}

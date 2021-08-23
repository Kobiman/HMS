using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models.HMS
{
    public class Leave
    {
        public string LeaveId { get; set; } = Guid.NewGuid().ToString();
        public string StaffId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

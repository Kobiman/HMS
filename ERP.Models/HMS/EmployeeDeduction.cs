using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models.HMS
{
    public class EmployeeDeduction
    {
        public int Id { get; set; }
        public string Deductions { get; set; }
        public double Rate { get; set; }
        public string Code { get; set; }
    }
}

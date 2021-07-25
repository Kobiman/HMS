using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models.HMS
{
    public class EmployeeBenefit
    {
        public int Id { get; set; }
        public string Benefits { get; set; }
        public string Category { get; set; }
        public double Rate { get; set; }
        public string Code { get; set; }
    }
}

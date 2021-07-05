using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Shared.Models
{
   public class EmployeeBenefit
    {
        public int Id { get; set; }
        public String Benefits { get; set; }
        public String Category { get; set; }
        public double Rate { get; set; }
        public String  Code { get; set; }
    }
}

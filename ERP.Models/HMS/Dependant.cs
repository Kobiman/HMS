using System;

namespace ERP.Models.HMS
{
    public class Dependant
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string StaffId { get; set; }
    }
}

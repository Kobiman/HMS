using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Models.HMS
{
    public class Staff
    {
        //Personal
        public string Photo { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public string DateofBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Hometown { get; set; }
        public string PlaceofBirth { get; set; }
        public string ResidentialAddress { get; set; }

        //Adminstrative
        public string Department { get; set; }
        public string Designation { get; set; }
        public string AccountNumber { get; set; }
        public string TinNumber { get; set; }
        public string SocialSecurityNumber { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime RetirementDate { get; set; }

        //Spous
        public string NameofSpouse { get; set; }
        public string Address { get; set; }
        public string SpousPhone { get; set; }

        public IList<Dependant> Dependants { get; set; }
    }
}

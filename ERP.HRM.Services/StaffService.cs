using ERP.HRM.Data.Contracts;
using ERP.HRM.Services.Contracts;
using ERP.Models.HMS;
using ERP.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.HRM.Services
{
    public class StaffService : IStaffService
    {
        private IUnitOfWork _unitOfWork;
        public StaffService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddStaff(Staff staff)
        {
           if (staff is null) return new Result(false, MessageSource.OperationFailed);
           _unitOfWork.Staffs.Add(staff);
           await _unitOfWork.SaveChangesAsync();
           return new Result(true, MessageSource.AddedSuccessfully(nameof(Staff)));
        }

        public async ValueTask<IResult> GetStaff(string staffId)
        {
            var staff = await _unitOfWork.Staffs.GetStaffAsync(staffId);
            if (staff is null) return new Result(false, MessageSource.OperationFailed);
            return new Result<Staff>(true, staff, MessageSource.OperationCompletedSuccesfully);
        }

        public async ValueTask<IResult> GetStaffs()
        {
            var staffs = await _unitOfWork.Staffs.GetAllAsync();
            if (staffs is null) return new Result(false, MessageSource.OperationFailed);
            return new Result<IList<Staff>>(true, staffs, MessageSource.OperationCompletedSuccesfully);
        }

        public async Task<IResult> UpdateStaff(Staff staff)
        {
            try
            {
                if (staff is null) return new Result(false, MessageSource.OperationFailed);
                var originalStaff = await _unitOfWork.Staffs.GetStaffAsync(staff.StaffId);
                if (originalStaff == null) return new Result(false, MessageSource.OperationFailed);
                originalStaff.AccountNumber = staff.AccountNumber;
                originalStaff.AppointmentDate = staff.AppointmentDate;
                originalStaff.DateofBirth = staff.DateofBirth;
                originalStaff.Department = staff.Department;
                originalStaff.Designation = staff.Designation;
                originalStaff.Email = staff.Email;
                originalStaff.Hometown = staff.Hometown;
                originalStaff.NameofSpouse = staff.NameofSpouse;
                originalStaff.Othernames = staff.Othernames;
                originalStaff.Phone = staff.Phone;
                originalStaff.Photo = staff.Photo;
                originalStaff.PlaceofBirth = staff.PlaceofBirth;
                originalStaff.ResidentialAddress = staff.ResidentialAddress;
                originalStaff.RetirementDate = staff.RetirementDate;
                originalStaff.SocialSecurityNumber = staff.SocialSecurityNumber;
                originalStaff.SpouseAddress = staff.SpouseAddress;
                originalStaff.SpousPhone = staff.SpousPhone;
                originalStaff.StaffId = staff.StaffId;
                originalStaff.Surname = staff.Surname;
                originalStaff.TinNumber = staff.TinNumber;

                originalStaff.Dependants = SetValuesForDependant(originalStaff.Dependants,staff.Dependants);

                _unitOfWork.Staffs.Update(originalStaff);
                await _unitOfWork.SaveChangesAsync();
                return new Result(true, MessageSource.AddedSuccessfully(nameof(Staff)));
            }
            catch(Exception ex)
            {
                return new Result(false, MessageSource.OperationFailed);
            }
        }


        private IList<Dependant> SetValuesForDependant(
            IList<Dependant> originalDependant,
            IList<Dependant> edittedDependant)
        {
            foreach (var e in edittedDependant)
            {
                foreach (var o in originalDependant)
                {
                    if (e.Id.Equals(o.Id))
                    {
                        o.Name = e.Name;
                        o.Address = e.Address;
                        o.Phone = e.Phone;
                    }
                    if (e.Id.Equals(o.Id) ||
                        edittedDependant.IndexOf(e) + 1 <= originalDependant.Count) continue;
                    originalDependant.Add(e);
                    break;
                }
            }

            if (originalDependant.Count <= edittedDependant.Count) return originalDependant;
            {
                foreach (var o in originalDependant
                    .Where(o => !edittedDependant.Any(e => e.Id.Equals(o.Id))))
                {
                    _unitOfWork.Dependants.Delete(o);
                    break;
                }
            }
            return originalDependant;
        }
    }
}

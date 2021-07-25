using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Shared
{
    public class MessageSource
    {
        public static string AddedSuccessfully(string name) => $"{name} added successfully";
        public static string UpdatedSuccessfully(string name) => $"{name} updated successfully";
        public static string AlreadyExist(string name) => $"{name} already exist";
        public static string CannotBeNull(string name) => $"{name} cannot be null";
        public const string OperationFailed = "Operation failed";
        public const string OperationCompletedSuccesfully = "Operation completed succesfully";
    }
}

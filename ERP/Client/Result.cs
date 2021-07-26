using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.Client
{
    public class Result<T>
    {
        public bool IsSucessful { get; set; }
        public T Value { get; set; }
        public string Message { get; set; }
    }

    public class Result
    {
        public bool IsSucessful { get; set; }
        public string Message { get; set; }
    }
}

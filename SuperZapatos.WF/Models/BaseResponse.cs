using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperZapatos.WF.Models
{
    public class BaseResponse<T>
    {
        public bool Success { get; set; }
        public T? Data { get; set; }
        public string? Message { get; set; }
        public int? TotalElements { get; set; }
        public int? errorCode { get; set; }
    }
}

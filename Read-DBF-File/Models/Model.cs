using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Read_DBF_File.Models
{
    public class Model
    {
        public decimal? CuserId { get; set; }
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime? ChkTime { get; set; }
    }
}
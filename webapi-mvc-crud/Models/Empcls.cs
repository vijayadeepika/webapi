using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapi_mvc_crud.Models
{
    public class Empcls
    {
        public int Empid { get; set; }
        public string Empname { get; set; }
        public string empmail { get; set; }
        public string emplocation { get; set; }
        public string empdesignation { get; set; }
    }
}
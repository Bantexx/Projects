using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParaBoLicFunc.Models
{

    public class UserData
    {
        [Key]
        public int Id_UD{get; set;}

        public int A { get; set; }

        public int B { get; set; }

        public int C { get; set; }

        public int RangeFrom { get; set; }
   
        public int RangeTo { get; set; }

        public float Step { get; set; }
        public UserData()
        {

        }
  
    }
    
}
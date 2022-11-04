using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ApiPlatformKPI.Models
{
    public class Login
    {



        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(50)]
        public string Password { get; set; }
    }
}
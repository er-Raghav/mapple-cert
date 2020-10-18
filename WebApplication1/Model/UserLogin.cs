using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    public class UserLogin
    {
        [Required]
        [DisplayName("User Name")]
        public string UserID { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
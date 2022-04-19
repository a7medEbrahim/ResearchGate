using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication39.Models
{

    public partial class User
    {
        [Required(ErrorMessage = "This feild is requierd")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "This feild is requierd")]
        public string LastName { get; set; }
        [DisplayName("User Name")]
        [Required(ErrorMessage = "This feild is requierd")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "This feild is requierd")]
        public string University { get; set; }
        [Required(ErrorMessage = "This feild is requierd")]
        public string Depatrment { get; set; }
        [Required(ErrorMessage = "This feild is requierd")]
        public string Email { get; set; }
        [Required(ErrorMessage = "This feild is requierd")]
        public int PhoneNumper { get; set; }
        [Required(ErrorMessage = "This feild is requierd")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "This feild is requierd")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword {get;set;}
        public byte[] picture { get; set; }
        public Nullable<int> PaperID { get; set; }
        public virtual Paper Paper { get; set; }
        public string LoginErorrMessage { get; set; }
    }
}

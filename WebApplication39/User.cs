//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication39
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string University { get; set; }
        public string Depatrment { get; set; }
        public string Email { get; set; }
        public int PhoneNumper { get; set; }
        public string Password { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<int> PaperID { get; set; }
    
        public virtual Paper Paper { get; set; }
    }
}

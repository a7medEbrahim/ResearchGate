//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication39.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Paper
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paper()
        {
            this.Users = new HashSet<User>();
        }
    
        public int ID { get; set; }
        public string Name { get; set; }
        public string Descripition { get; set; }
        public System.DateTime Time { get; set; }
        public Nullable<int> Likes { get; set; }
        public Nullable<int> DisLikes { get; set; }
        public byte[] Paper1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}
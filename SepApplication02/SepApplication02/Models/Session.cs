//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SepApplication02.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Session
    {
        public Session()
        {
            this.Attendances = new HashSet<Attendance>();
        }
    
        public int id { get; set; }
        public System.DateTime Date { get; set; }
        public string Info { get; set; }
        public int Course_id { get; set; }
    
        public virtual ICollection<Attendance> Attendances { get; set; }
        public virtual Course Course { get; set; }
    }
}

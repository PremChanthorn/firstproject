//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstProjectGit.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> modified_date { get; set; }
        public Nullable<int> modified_by { get; set; }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TMS1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Offence_Details
    {
        public string veh_no { get; set; }
        public System.DateTime time { get; set; }
        public string place { get; set; }
        public Nullable<int> offence_id { get; set; }
        public string reported_by { get; set; }
    
        public virtual TM_Offence TM_Offence { get; set; }
    }
}
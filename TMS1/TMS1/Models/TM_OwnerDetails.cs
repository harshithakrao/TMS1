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
    
    public partial class TM_OwnerDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TM_OwnerDetails()
        {
            this.TM_RegDetails = new HashSet<TM_RegDetails>();
        }
    
        public string owner_id { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string date_of_birth { get; set; }
        public Nullable<long> landline_number { get; set; }
        public Nullable<long> mobile_no { get; set; }
        public string gender { get; set; }
        public string temp_address { get; set; }
        public string permanent_address { get; set; }
        public long pincode { get; set; }
        public string occupation { get; set; }
        public string pancard_no { get; set; }
        public string addressproof_name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_RegDetails> TM_RegDetails { get; set; }
    }
}

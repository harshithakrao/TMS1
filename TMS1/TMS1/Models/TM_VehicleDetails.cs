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
    
    public partial class TM_VehicleDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TM_VehicleDetails()
        {
            this.TM_RegDetails = new HashSet<TM_RegDetails>();
        }
    
        public int veh_id { get; set; }
        public string veh_type { get; set; }
        public string engine_no { get; set; }
        public string model_no { get; set; }
        public string veh_name { get; set; }
        public string veh_color { get; set; }
        public string manufacturer_name { get; set; }
        public System.DateTime date_of_manufacture { get; set; }
        public Nullable<int> no_of_cylinders { get; set; }
        public Nullable<int> cubic_capacity { get; set; }
        public string fuel_used { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TM_RegDetails> TM_RegDetails { get; set; }
    }
}

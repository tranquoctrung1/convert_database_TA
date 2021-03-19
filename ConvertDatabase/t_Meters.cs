//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConvertDatabase
{
    using System;
    using System.Collections.Generic;
    
    public partial class t_Meters
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Meters()
        {
            this.t_Accreditations = new HashSet<t_Accreditations>();
            this.t_Meter_Files = new HashSet<t_Meter_Files>();
            this.t_Meter_Histories = new HashSet<t_Meter_Histories>();
            this.t_Sites = new HashSet<t_Sites>();
        }
    
        public string Serial { get; set; }
        public Nullable<System.DateTime> ReceiptDate { get; set; }
        public string Provider { get; set; }
        public string Marks { get; set; }
        public Nullable<short> Size { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Installed { get; set; }
        public string AccreditationDocument { get; set; }
        public string ApprovalDecision { get; set; }
        public Nullable<System.DateTime> ApprovedDate { get; set; }
        public Nullable<bool> Approved { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Accreditations> t_Accreditations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Meter_Files> t_Meter_Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Meter_Histories> t_Meter_Histories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Sites> t_Sites { get; set; }
    }
}

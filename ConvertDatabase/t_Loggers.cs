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
    
    public partial class t_Loggers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Loggers()
        {
            this.t_Logger_Files = new HashSet<t_Logger_Files>();
            this.t_Logger_Histories = new HashSet<t_Logger_Histories>();
            this.t_Sites = new HashSet<t_Sites>();
        }
    
        public string Serial { get; set; }
        public Nullable<System.DateTime> ReceiptDate { get; set; }
        public string Provider { get; set; }
        public string Marks { get; set; }
        public string Model { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Installed { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Logger_Files> t_Logger_Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Logger_Histories> t_Logger_Histories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Sites> t_Sites { get; set; }
    }
}
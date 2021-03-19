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
    
    public partial class t_Sites
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t_Sites()
        {
            this.t_Data_Raw_Indexes = new HashSet<t_Data_Raw_Indexes>();
            this.t_Logger_Histories = new HashSet<t_Logger_Histories>();
            this.t_Site_Files = new HashSet<t_Site_Files>();
        }
    
        public string SiteId { get; set; }
        public string SiteAliasName { get; set; }
        public string Location { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public string DisplayGroup { get; set; }
        public Nullable<byte> Zoom { get; set; }
        public string ConsumerId { get; set; }
        public string LoggerId { get; set; }
        public Nullable<byte> StartDay { get; set; }
        public string Description { get; set; }
        public string MeterSerial { get; set; }
        public string TransmitterSerial { get; set; }
        public string LoggerSerial { get; set; }
        public Nullable<System.DateTime> MeterDateChanged { get; set; }
        public Nullable<System.DateTime> TransmitterDateChanged { get; set; }
        public Nullable<System.DateTime> LoggerDateChanged { get; set; }
        public string Availability { get; set; }
        public string Status { get; set; }
        public string Staffs { get; set; }
        public Nullable<int> LabelAnchorX { get; set; }
        public Nullable<int> LabelAnchorY { get; set; }
        public Nullable<double> LabelLat { get; set; }
        public Nullable<double> LabelLng { get; set; }
        public string PipeSize { get; set; }
        public Nullable<int> SetDelayTime { get; set; }
        public Nullable<double> SetDiffValue { get; set; }
        public Nullable<double> Baseline { get; set; }
    
        public virtual t_Consumers t_Consumers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Data_Raw_Indexes> t_Data_Raw_Indexes { get; set; }
        public virtual t_DisplayGroups t_DisplayGroups { get; set; }
        public virtual t_Logger_Configurations t_Logger_Configurations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Logger_Histories> t_Logger_Histories { get; set; }
        public virtual t_Loggers t_Loggers { get; set; }
        public virtual t_Meters t_Meters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t_Site_Files> t_Site_Files { get; set; }
        public virtual t_Transmitters t_Transmitters { get; set; }
    }
}

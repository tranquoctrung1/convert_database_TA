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
    
    public partial class t_Devices_SitesConfigs
    {
        public string Id { get; set; }
        public string SiteId { get; set; }
        public string Tel { get; set; }
        public Nullable<byte> Pressure { get; set; }
        public Nullable<byte> Forward { get; set; }
        public Nullable<byte> Reverse { get; set; }
        public Nullable<short> Interval { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<byte> ZoomInit { get; set; }
        public Nullable<byte> ZoomOn { get; set; }
        public Nullable<byte> Pressure1 { get; set; }
        public Nullable<int> DelayTime { get; set; }
    }
}

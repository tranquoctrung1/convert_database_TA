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
    
    public partial class t_Alarms
    {
        public int Id { get; set; }
        public string SiteId { get; set; }
        public string SiteName { get; set; }
        public string ChannelId { get; set; }
        public string ChannelName { get; set; }
        public System.DateTime Timestamp { get; set; }
        public string Msg1 { get; set; }
        public string Msg2 { get; set; }
        public string Msg3 { get; set; }
        public string Msg4 { get; set; }
        public Nullable<bool> Trigger { get; set; }
    }
}

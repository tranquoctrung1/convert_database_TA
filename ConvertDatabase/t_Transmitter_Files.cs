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
    
    public partial class t_Transmitter_Files
    {
        public int FileID { get; set; }
        public string FileName { get; set; }
        public string TransmitterSerial { get; set; }
        public string MIMEType { get; set; }
        public Nullable<int> Size { get; set; }
        public string Path { get; set; }
        public Nullable<System.DateTime> UploadDate { get; set; }
    
        public virtual t_Transmitters t_Transmitters { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chmoky.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Message
    {
        public long id { get; set; }
        public string author { get; set; }
        public string from_dispname { get; set; }
        public Nullable<System.DateTime> timestamp { get; set; }
        public string edited_by { get; set; }
        public Nullable<System.DateTime> edited_timestamp { get; set; }
        public Nullable<int> type { get; set; }
        public string body_xml { get; set; }
        public string identities { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace U413.Domain.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChannelStatus
    {
        public string Channel { get; set; }
        public string Username { get; set; }
        public System.DateTime LastActive { get; set; }
        public System.DateTime LastSeen { get; set; }
        public string PositionTop { get; set; }
        public string PositionLeft { get; set; }
        public int ElementHeight { get; set; }
        public int ElementWidth { get; set; }
        public bool Minimized { get; set; }
        public int ZIndex { get; set; }
        public long LastID { get; set; }
    
        public virtual User User { get; set; }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CW2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int Id { get; set; }
        public string EventType { get; set; }
        public string OccurenceType { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
    
        public virtual User User { get; set; }
    }
}

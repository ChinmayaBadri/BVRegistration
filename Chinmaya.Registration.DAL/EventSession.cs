//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chinmaya.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventSession
    {
        public int Id { get; set; }
        public string EventId { get; set; }
        public int SessionId { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public string Location { get; set; }
        public string Instructor { get; set; }
        public string Contact { get; set; }
        public string Other { get; set; }
    }
}

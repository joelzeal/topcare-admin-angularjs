//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.WebApplication_TOP_SPA
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScheduleDetail
    {
        public int ScheduleDetailID { get; set; }
        public string Item { get; set; }
        public Nullable<int> ScheduleID { get; set; }
        public Nullable<System.TimeSpan> StartTime { get; set; }
        public Nullable<System.TimeSpan> EndTime { get; set; }
    
        public virtual Schedule Schedule { get; set; }
    }
}
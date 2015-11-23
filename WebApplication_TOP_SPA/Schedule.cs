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
    
    public partial class Schedule
    {
        public Schedule()
        {
            this.MemberAttendances = new HashSet<MemberAttendance>();
            this.ScheduleDetails = new HashSet<ScheduleDetail>();
        }
    
        public int ScheduleID { get; set; }
        public Nullable<System.DateTime> DateOfEvent { get; set; }
        public string MealsToBeServed { get; set; }
        public string ProgramTitle { get; set; }
        public Nullable<decimal> PaymentExpected { get; set; }
        public string Team { get; set; }
        public string Notes { get; set; }
        public string NotesNew { get; set; }
        public string MealsToBeServed_New { get; set; }
    
        public virtual ICollection<MemberAttendance> MemberAttendances { get; set; }
        public virtual ICollection<ScheduleDetail> ScheduleDetails { get; set; }
    }
}

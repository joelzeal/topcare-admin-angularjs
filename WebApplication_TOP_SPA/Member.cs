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
    
    public partial class Member
    {
        public Member()
        {
            this.AddonServices = new HashSet<AddonService>();
            this.MemberAttendances = new HashSet<MemberAttendance>();
            this.MemberSubscriptionsPaids = new HashSet<MemberSubscriptionsPaid>();
        }
    
        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address { get; set; }
        public string Postcode { get; set; }
        public Nullable<int> NationalityID { get; set; }
        public string DietaryRequirements { get; set; }
        public string NextOfKin_Name { get; set; }
        public string NextOfKin_Address { get; set; }
        public string NextOfKin_Postcode { get; set; }
        public string NextOfKin_PhoneNumber { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string PhoneNumber3 { get; set; }
        public string EmailAddress { get; set; }
        public string MemberTransportationID { get; set; }
        public Nullable<int> TransportationOptionID { get; set; }
        public string Remarks { get; set; }
    
        public virtual ICollection<AddonService> AddonServices { get; set; }
        public virtual ICollection<MemberAttendance> MemberAttendances { get; set; }
        public virtual ICollection<MemberSubscriptionsPaid> MemberSubscriptionsPaids { get; set; }
    }
}

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
    
    public partial class MemberSubscriptionsPaid
    {
        public int MemberSubscriptionPaidID { get; set; }
        public Nullable<int> MemberID { get; set; }
        public Nullable<decimal> AmountPaid { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public string PaymentRecievedBy { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public Nullable<bool> IsOpen { get; set; }
        public Nullable<System.DateTime> ExpiryDate { get; set; }
        public Nullable<bool> IsWaived { get; set; }
    
        public virtual Member Member { get; set; }
    }
}

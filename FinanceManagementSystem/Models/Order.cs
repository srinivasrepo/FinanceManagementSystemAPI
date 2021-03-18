//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int OrderID { get; set; }
        public System.DateTime OrderDate { get; set; }
        public double AmountPayable { get; set; }
        public int EMI_Tenure_In_Months { get; set; }
        public double BillAmountperMonth { get; set; }
        public long CardNumber { get; set; }
        public Nullable<int> Remaining_EMI_Tenures { get; set; }
        public Nullable<System.DateTime> LastPaymentDate { get; set; }
    
        public virtual CardTable CardTable { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
    }
}

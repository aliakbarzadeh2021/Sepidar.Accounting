using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InsurancePolicy : BaseEntity
    {
          
 
		public Int32 InsurancePolicyID { get; set; }  
 
		public Int32 PurchaseOrderRef { get; set; }  
 
		public Int32 AgencyDLRef { get; set; }  
 
		public Int32 CoverType { get; set; }  
 
		public Nullable<Int32> SLAccountRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<DateTime> ValidityDate { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal CurrencyRate { get; set; }  
 
		public String Description { get; set; }  
 
		public Nullable<Int32> InputCustomsRef { get; set; }  
 
		public Nullable<Int32> TransportSourceRef { get; set; }  
 
		public Nullable<Int32> TransportDestinationRef { get; set; }  
 
		public Decimal TotalPrice { get; set; }  
 
		public Nullable<Decimal> TotalPriceInBaseCurrency { get; set; }  
 
		public Decimal TotalNetPrice { get; set; }  
 
		public Nullable<Decimal> TotalNetPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalTax { get; set; }  
 
		public Nullable<Decimal> TotalTaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalDuty { get; set; }  
 
		public Nullable<Decimal> TotalDutyInBaseCurrency { get; set; }  
 
		public Int32 AllotmentType { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



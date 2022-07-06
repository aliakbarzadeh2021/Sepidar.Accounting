using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommercialOrder : BaseEntity
    {
          
 
		public Int32 CommercialOrderID { get; set; }  
 
		public Int32 PurchaseOrderRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<DateTime> ValidityDate { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public Nullable<Int32> SLRef { get; set; }  
 
		public Nullable<Decimal> RegisterFee { get; set; }  
 
		public Nullable<Int32> SharingMethod { get; set; }  
 
		public String LoadingPlace { get; set; }  
 
		public Nullable<Int32> InCustomsRef { get; set; }  
 
		public Nullable<Int32> OutCustomsRef { get; set; }  
 
		public Nullable<Int32> OriginCountryRef { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



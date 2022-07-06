using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PriceNoteItem : BaseEntity
    {
          
 
		public Int32 PriceNoteItemID { get; set; }  
 
		public Int32 PriceNoteRef { get; set; }  
 
		public Int32 SaleTypeRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Int32 UnitRef { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Nullable<Int32> CurrencyRef { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Boolean CanChangeInvoiceFee { get; set; }  
 
		public Boolean CanChangeInvoiceDiscount { get; set; }  
 
		public Decimal AdditionRate { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Nullable<Int32> CustomerGroupingRef { get; set; }  
 
		public Nullable<Decimal> LowerMargin { get; set; }  
 
		public Nullable<Decimal> UpperMargin { get; set; } 
    }
}



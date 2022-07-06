using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CostStatementItem : BaseEntity
    {
          
 
		public Int32 CostStatementItemID { get; set; }  
 
		public Int32 CostStatementRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Nullable<Int32> ItemRef { get; set; }  
 
		public Int32 CostTypeRef { get; set; }  
 
		public Nullable<Decimal> Quantity { get; set; }  
 
		public Nullable<Decimal> Fee { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<Int32> InvoiceNumber { get; set; }  
 
		public Nullable<DateTime> InvoiceDate { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Nullable<Int32> SlRef { get; set; }  
 
		public Nullable<Int32> PartyRef { get; set; }  
 
		public Nullable<Decimal> InitialSettledValue { get; set; }  
 
		public Nullable<Int32> CostSLRef { get; set; } 
    }
}



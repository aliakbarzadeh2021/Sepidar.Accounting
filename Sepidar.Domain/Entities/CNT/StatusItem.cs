using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class StatusItem : BaseEntity
    {
          
 
		public Int32 StatusItemID { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Nullable<Int32> ItemRef { get; set; }  
 
		public Nullable<Int32> ContractAgreementItemRef { get; set; }  
 
		public String ItemTitle { get; set; }  
 
		public String ItemTitle_En { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Decimal Fee { get; set; }  
 
		public Decimal ConfirmedFee { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Decimal ConfirmedQuantity { get; set; }  
 
		public Decimal ConfirmedPrice { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}



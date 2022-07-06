using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class MarketingDisketteItem : BaseEntity
    {
          
 
		public Int32 MarketingDisketteItemID { get; set; }  
 
		public Int32 MarketingDisketteRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Nullable<Int32> InventoryReceiptRef { get; set; }  
 
		public Nullable<Int32> ReturnedInventoryReceiptRef { get; set; }  
 
		public Nullable<Int32> ServiceInventoryPurchaseInvoiceRef { get; set; }  
 
		public Nullable<Int32> StatusRef { get; set; }  
 
		public Boolean UsedInDiskette { get; set; }  
 
		public String EntityFullName { get; set; }  
 
		public Nullable<Boolean> ISDealTypeLowerThanTenPercent { get; set; }  
 
		public Nullable<Boolean> IsRefusal { get; set; }  
 
		public Nullable<Boolean> IsTransport { get; set; } 
    }
}



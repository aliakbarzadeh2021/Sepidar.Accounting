using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class InventoryDeliveryItem : BaseEntity
    {
          
 
		public Int32 InventoryDeliveryItemID { get; set; }  
 
		public Int32 InventoryDeliveryRef { get; set; }  
 
		public Boolean IsReturn { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Nullable<Int32> BaseInvoiceItem { get; set; }  
 
		public Nullable<Int32> BaseInventoryDeliveryItem { get; set; }  
 
		public Nullable<Int32> BaseReturnedInvoiceItem { get; set; }  
 
		public Nullable<Int32> QuotationItemRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public Decimal RemainingQuantity { get; set; }  
 
		public Nullable<Decimal> RemainingSecondaryQuantity { get; set; }  
 
		public Nullable<Int32> SLAccountRef { get; set; }  
 
		public Nullable<Decimal> Price { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> ProductOrderRef { get; set; }  
 
		public String ParityCheck { get; set; }  
 
		public Nullable<Int32> WeighingRef { get; set; }  
 
		public Nullable<Decimal> Fee { get; set; } 
    }
}



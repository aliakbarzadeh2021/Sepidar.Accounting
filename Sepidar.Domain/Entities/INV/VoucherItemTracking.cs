using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class VoucherItemTracking : BaseEntity
    {
          
 
		public Int32 VoucherItemTrackingID { get; set; }  
 
		public String Serial { get; set; }  
 
		public Nullable<Int32> InvoiceItemRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> InventoryReceiptItemRef { get; set; }  
 
		public Nullable<Int32> InventoryDeliveryItemRef { get; set; } 
    }
}



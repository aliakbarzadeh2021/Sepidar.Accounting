using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class AssetRelatedPurchaseInvoice : BaseEntity
    {
          
 
		public Int32 AssetRelatedPurchaseInvoiceId { get; set; }  
 
		public Nullable<Int32> AssetPurchaseInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> AcquisitionReceiptItemRef { get; set; }  
 
		public Nullable<Int32> RepairItemRef { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Decimal PriceInBaseCurrency { get; set; }  
 
		public Nullable<Int32> PurchaseInvoiceItemRef { get; set; } 
    }
}



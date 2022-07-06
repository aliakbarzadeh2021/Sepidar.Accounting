using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class AssetRelatedPurchaseInvoiceDto
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



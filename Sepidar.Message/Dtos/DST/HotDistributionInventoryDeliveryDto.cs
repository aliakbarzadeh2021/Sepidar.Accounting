using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class HotDistributionInventoryDeliveryDto
    {
          
 
		public Int32 HotDistributionInventoryDeliveryId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Int32 InventoryDeliveryRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; } 
    }
}



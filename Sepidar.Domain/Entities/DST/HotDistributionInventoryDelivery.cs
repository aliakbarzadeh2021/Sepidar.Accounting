using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class HotDistributionInventoryDelivery : BaseEntity
    {
          
 
		public Int32 HotDistributionInventoryDeliveryId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Int32 InventoryDeliveryRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ProductOrderBOMItem : BaseEntity
    {
          
 
		public Int32 ProductOrderBOMItemID { get; set; }  
 
		public Int32 ProductOrderRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> FormulaBOMItemRef { get; set; }  
 
		public Nullable<Decimal> StandardConsumptionQuantity { get; set; }  
 
		public Nullable<Decimal> RemainingConsumptionQuantity { get; set; }  
 
		public String Description { get; set; }  
 
		public Nullable<Decimal> TransferedQuantity { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class TaxTableItem : BaseEntity
    {
          
 
		public Int32 TaxTableItemId { get; set; }  
 
		public Decimal FromAmount { get; set; }  
 
		public Decimal ToAmount { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Int32 TaxTableRef { get; set; }  
 
		public Decimal InLineAmount { get; set; }  
 
		public Nullable<Decimal> PartialAmount { get; set; } 
    }
}



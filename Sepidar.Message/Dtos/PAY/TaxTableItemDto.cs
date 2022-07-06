using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class TaxTableItemDto
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



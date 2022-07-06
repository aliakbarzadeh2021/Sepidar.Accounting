using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class SalesLimitItemPartyDto
    {
          
 
		public Int32 SalesLimitItemPartyId { get; set; }  
 
		public Int32 SalesLimitItemRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Nullable<Decimal> Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class SalesLimitItemParty : BaseEntity
    {
          
 
		public Int32 SalesLimitItemPartyId { get; set; }  
 
		public Int32 SalesLimitItemRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Nullable<Decimal> Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; } 
    }
}



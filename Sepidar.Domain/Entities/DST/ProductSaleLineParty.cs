using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ProductSaleLineParty : BaseEntity
    {
          
 
		public Int32 ProductSaleLinePartyId { get; set; }  
 
		public Int32 ProductSaleLineRef { get; set; }  
 
		public Int32 PartyRef { get; set; } 
    }
}



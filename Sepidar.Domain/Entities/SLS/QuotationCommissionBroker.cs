using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class QuotationCommissionBroker : BaseEntity
    {
          
 
		public Int32 QuotationCommissionBrokerID { get; set; }  
 
		public Int32 QuotationRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal SalePortionPercent { get; set; } 
    }
}



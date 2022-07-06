using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class QuotationCommissionBrokerDto
    {
          
 
		public Int32 QuotationCommissionBrokerID { get; set; }  
 
		public Int32 QuotationRef { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Decimal SalePortionPercent { get; set; } 
    }
}



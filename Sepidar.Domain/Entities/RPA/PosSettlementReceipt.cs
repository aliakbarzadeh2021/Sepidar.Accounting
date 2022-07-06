using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PosSettlementReceipt : BaseEntity
    {
          
 
		public Int32 PosSettlementReceiptID { get; set; }  
 
		public Int32 PosSettlementRef { get; set; }  
 
		public Int32 ReceiptPosRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



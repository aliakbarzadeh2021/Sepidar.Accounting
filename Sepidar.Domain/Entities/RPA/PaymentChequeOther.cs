using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PaymentChequeOther : BaseEntity
    {
          
 
		public Int32 PaymentChequeOtherId { get; set; }  
 
		public Int32 ReceiptChequeRef { get; set; }  
 
		public Int32 PaymentHeaderRef { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public DateTime HeaderDate { get; set; } 
    }
}



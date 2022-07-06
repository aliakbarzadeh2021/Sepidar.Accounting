using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReceiptPos : BaseEntity
    {
          
 
		public Int32 ReceiptPosId { get; set; }  
 
		public Int32 PosRef { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Int32 state { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 ReceiptHeaderRef { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public String TrackingCode { get; set; } 
    }
}



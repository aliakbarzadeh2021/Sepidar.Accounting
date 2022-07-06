using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class BankBillItem : BaseEntity
    {
          
 
		public Int32 BankBillItemId { get; set; }  
 
		public Int32 BankBillRef { get; set; }  
 
		public String VoucherNumber { get; set; }  
 
		public DateTime VoucherDate { get; set; }  
 
		public Decimal Debit { get; set; }  
 
		public Decimal Credit { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



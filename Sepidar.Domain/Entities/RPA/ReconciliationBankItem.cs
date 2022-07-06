using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ReconciliationBankItem : BaseEntity
    {
          
 
		public Int32 ReconciliationBankItemId { get; set; }  
 
		public Nullable<Int32> BankBillItemRef { get; set; }  
 
		public Nullable<Int32> RelationNo { get; set; }  
 
		public String Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Decimal Debit { get; set; }  
 
		public Decimal Credit { get; set; }  
 
		public Int32 ReconciliationRef { get; set; }  
 
		public Nullable<Int32> ReconciliationBankItemRef { get; set; } 
    }
}



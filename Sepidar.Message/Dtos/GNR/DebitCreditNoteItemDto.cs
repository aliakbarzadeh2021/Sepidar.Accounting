using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class DebitCreditNoteItemDto
    {
          
 
		public Int32 DebitCreditNoteItemID { get; set; }  
 
		public Int32 DebitCreditNoteRef { get; set; }  
 
		public Int32 RowID { get; set; }  
 
		public Int32 DebitSLRef { get; set; }  
 
		public Int32 CreditSLRef { get; set; }  
 
		public Nullable<Int32> DebitDLRef { get; set; }  
 
		public Nullable<Int32> CreditDLRef { get; set; }  
 
		public Nullable<Int32> DebitType { get; set; }  
 
		public Nullable<Int32> CreditType { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Decimal> Rate { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



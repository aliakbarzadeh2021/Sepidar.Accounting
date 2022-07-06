using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ReceiptChequeDto
    {
          
 
		public Int32 ReceiptChequeId { get; set; }  
 
		public String Number { get; set; }  
 
		public String SecondNumber { get; set; }  
 
		public Boolean IsGuarantee { get; set; }  
 
		public String AccountNo { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<DateTime> Date { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Nullable<Int32> CashRef { get; set; }  
 
		public Int32 ReceiptHeaderRef { get; set; }  
 
		public Nullable<Int32> BankRef { get; set; }  
 
		public String BranchCode { get; set; }  
 
		public String BranchTitle { get; set; }  
 
		public Nullable<Int32> LocationRef { get; set; }  
 
		public Int32 HeaderNumber { get; set; }  
 
		public DateTime HeaderDate { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public Nullable<Int32> BankBranchRef { get; set; }  
 
		public Int32 DlRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> InitState { get; set; } 
    }
}



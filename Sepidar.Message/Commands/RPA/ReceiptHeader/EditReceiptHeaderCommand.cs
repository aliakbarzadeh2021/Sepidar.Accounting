using Sepidar.Message.Base;
using Sepidar.Message.Extentions;
using Sepidar.Message.Validators;
using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class EditReceiptHeaderCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ReceiptHeaderId { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Int32> AccountSlRef { get; set; }  
 
		public Int32 DlRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Decimal Discount { get; set; }  
 
		public Decimal TotalAmount { get; set; }  
 
		public Int32 ItemType { get; set; }  
 
		public Int32 State { get; set; }  
 
		public String CreatorForm { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Nullable<Int32> CashRef { get; set; }  
 
		public Nullable<Decimal> Amount { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Nullable<Decimal> DiscountRate { get; set; }  
 
		public Nullable<Decimal> DiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalAmountInBaseCurrency { get; set; }  
 
		public String Guid { get; set; }  
 
		public Nullable<Decimal> ReceiptAmount { get; set; } 

        public void Validate()
        {
            new EditReceiptHeaderCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

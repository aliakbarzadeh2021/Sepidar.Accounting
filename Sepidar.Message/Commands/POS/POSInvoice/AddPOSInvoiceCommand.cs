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
    public class AddPOSInvoiceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 InvoiceId { get; set; }  
 
		public String CustomerRealName { get; set; }  
 
		public String CustomerRealName_En { get; set; }  
 
		public Int32 CashierRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 SaleTypeRef { get; set; }  
 
		public Nullable<Int32> StockRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> InvoiceDiscount { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> Duty { get; set; }  
 
		public Decimal NetPrice { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Decimal> CashAmount { get; set; }  
 
		public Nullable<Decimal> CardReaderAmount { get; set; }  
 
		public Nullable<Int32> PosRef { get; set; }  
 
		public String TransactionNumber { get; set; }  
 
		public Nullable<Decimal> ChequeAmount { get; set; }  
 
		public String ChequeSecondaryNumber { get; set; }  
 
		public Nullable<Decimal> OtherAmount { get; set; }  
 
		public String OtherDescription { get; set; }  
 
		public Nullable<Decimal> CashPaidAmount { get; set; } 

        public void Validate()
        {
            new AddPOSInvoiceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

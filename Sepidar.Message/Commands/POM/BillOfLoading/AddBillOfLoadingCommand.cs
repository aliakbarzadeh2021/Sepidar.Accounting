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
    public class AddBillOfLoadingCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 BillOfLoadingID { get; set; }  
 
		public Int32 TransporterDLRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal CurrencyRate { get; set; }  
 
		public Int32 AllotmentType { get; set; }  
 
		public String Description { get; set; }  
 
		public Nullable<Int32> TransportSourceRef { get; set; }  
 
		public Nullable<Int32> TransportDestinationRef { get; set; }  
 
		public String TransportType { get; set; }  
 
		public Nullable<Decimal> TotalPrice { get; set; }  
 
		public Nullable<Decimal> TotalPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalDiscount { get; set; }  
 
		public Nullable<Decimal> TotalDiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalAddition { get; set; }  
 
		public Nullable<Decimal> TotalAdditionInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalTax { get; set; }  
 
		public Nullable<Decimal> TotalTaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalDuty { get; set; }  
 
		public Nullable<Decimal> TotalDutyInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> TotalNetPrice { get; set; }  
 
		public Nullable<Decimal> TotalNetPriceInBaseCurrency { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Nullable<Int32> SLAccountRef { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddBillOfLoadingCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

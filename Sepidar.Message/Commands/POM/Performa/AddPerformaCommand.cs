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
    public class AddPerformaCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PerformaID { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 VendorDLRef { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public String PerformaNumber { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<DateTime> ValidityDate { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal CurrencyRate { get; set; }  
 
		public Nullable<Int32> ContractType { get; set; }  
 
		public String TransportType { get; set; }  
 
		public String PaymentMethod { get; set; }  
 
		public String Description { get; set; }  
 
		public Nullable<Decimal> Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; }  
 
		public Nullable<Decimal> NetPriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> TaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> DiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> AdditionInBaseCurrency { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddPerformaCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

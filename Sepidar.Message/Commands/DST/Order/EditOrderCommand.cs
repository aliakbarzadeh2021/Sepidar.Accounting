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
    public class EditOrderCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OrderID { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Nullable<Int32> BrokerPartyRef { get; set; }  
 
		public Int32 CustomerPartyRef { get; set; }  
 
		public Int32 CustomerPartyAddressRef { get; set; }  
 
		public Int32 SaleTypeRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<DateTime> DeliveryDate { get; set; }  
 
		public Nullable<Decimal> Price { get; set; }  
 
		public Nullable<Decimal> PriceInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Discount { get; set; }  
 
		public Nullable<Decimal> DiscountInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Addition { get; set; }  
 
		public Nullable<Decimal> AdditionInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Tax { get; set; }  
 
		public Nullable<Decimal> TaxInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> Duty { get; set; }  
 
		public Nullable<Decimal> DutyInBaseCurrency { get; set; }  
 
		public Nullable<Decimal> NetPriceInBaseCurrency { get; set; }  
 
		public String Agreements { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public String Guid { get; set; }  
 
		public Decimal AdditionFactor_VatEffective { get; set; }  
 
		public Decimal AdditionFactorInBaseCurrency_VatEffective { get; set; }  
 
		public Decimal AdditionFactor_VatIneffective { get; set; }  
 
		public Decimal AdditionFactorInBaseCurrency_VatIneffective { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; } 

        public void Validate()
        {
            new EditOrderCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

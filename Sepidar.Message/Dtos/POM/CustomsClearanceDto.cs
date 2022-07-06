using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CustomsClearanceDto
    {
          
 
		public Int32 CustomsClearanceID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public Nullable<Int32> SLRef { get; set; }  
 
		public Nullable<Int32> InCustomsRef { get; set; }  
 
		public Nullable<Int32> AssessCustomsRef { get; set; }  
 
		public Nullable<Int32> OriginCountryRef { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Decimal Currencyrate { get; set; }  
 
		public String Description { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public Decimal CustomsCost { get; set; }  
 
		public Decimal Tax { get; set; }  
 
		public Decimal Duty { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Nullable<Int32> PaymentHeaderRef { get; set; }  
 
		public Nullable<Decimal> NetPrice { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



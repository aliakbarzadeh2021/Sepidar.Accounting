using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CurrencyExchangeRateDto
    {
          
 
		public Int32 CurrencyExchangeRateId { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public DateTime EffectiveDate { get; set; }  
 
		public Decimal ExchangeRate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; } 
    }
}



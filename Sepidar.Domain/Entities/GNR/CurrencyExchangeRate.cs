using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CurrencyExchangeRate : BaseEntity
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



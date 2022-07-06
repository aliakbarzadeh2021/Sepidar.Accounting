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
    public class AddCurrencyExchangeRateCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
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

        public void Validate()
        {
            new AddCurrencyExchangeRateCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

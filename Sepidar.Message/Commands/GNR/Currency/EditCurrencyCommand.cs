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
    public class EditCurrencyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CurrencyID { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 ExchangeUnit { get; set; }  
 
		public Int32 PrecisionCount { get; set; }  
 
		public String PrecisionName { get; set; }  
 
		public String PrecisionName_En { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditCurrencyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

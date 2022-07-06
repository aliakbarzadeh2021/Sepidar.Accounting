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
    public class AddProducedItemPriceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ProducedItemPriceID { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Decimal> Price { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddProducedItemPriceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

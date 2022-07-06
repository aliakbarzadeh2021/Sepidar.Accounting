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
    public class AddItemStockCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ItemStockID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Int32 StockRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddItemStockCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

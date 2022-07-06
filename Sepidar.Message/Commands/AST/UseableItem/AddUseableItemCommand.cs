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
    public class AddUseableItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UseableItemId { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 UseableRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 

        public void Validate()
        {
            new AddUseableItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

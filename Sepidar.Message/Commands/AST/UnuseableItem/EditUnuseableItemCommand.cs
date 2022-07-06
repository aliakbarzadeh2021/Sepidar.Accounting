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
    public class EditUnuseableItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UnuseableItemId { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 UnuseableRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 

        public void Validate()
        {
            new EditUnuseableItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

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
    public class EditOpeningOperationItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 OpeningOperationItemId { get; set; }  
 
		public Int32 OpeningOperationRef { get; set; }  
 
		public String RecordType { get; set; }  
 
		public Int32 RecordId { get; set; }  
 
		public Nullable<Boolean> Checked { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditOpeningOperationItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

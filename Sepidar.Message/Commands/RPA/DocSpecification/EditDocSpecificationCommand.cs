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
    public class EditDocSpecificationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DocSpecificationId { get; set; }  
 
		public String TableName { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 

        public void Validate()
        {
            new EditDocSpecificationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

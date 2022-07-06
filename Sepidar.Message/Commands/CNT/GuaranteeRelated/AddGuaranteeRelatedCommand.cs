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
    public class AddGuaranteeRelatedCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GuaranteeRelatedID { get; set; }  
 
		public Int32 ParentGuaranteeRef { get; set; }  
 
		public Int32 ChildGuaranteeRef { get; set; } 

        public void Validate()
        {
            new AddGuaranteeRelatedCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

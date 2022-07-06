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
    public class EditGLVoucherItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 GLVoucherItemId { get; set; }  
 
		public Int32 GLVoucherRef { get; set; }  
 
		public Int32 VoucherRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditGLVoucherItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

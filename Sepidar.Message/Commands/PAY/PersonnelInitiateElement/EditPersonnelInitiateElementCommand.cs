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
    public class EditPersonnelInitiateElementCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PersonnelInitiateElementId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Int32 PersonnelInitiateRef { get; set; } 

        public void Validate()
        {
            new EditPersonnelInitiateElementCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

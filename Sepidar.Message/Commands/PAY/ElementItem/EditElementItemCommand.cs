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
    public class EditElementItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ElementItemId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Int32 RelatedElementRef { get; set; }  
 
		public Nullable<Decimal> Coefficient { get; set; }  
 
		public Int32 Type { get; set; } 

        public void Validate()
        {
            new EditElementItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

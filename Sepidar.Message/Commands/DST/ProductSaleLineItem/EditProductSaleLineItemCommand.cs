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
    public class EditProductSaleLineItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ProductSaleLineItemId { get; set; }  
 
		public Int32 ProductSaleLineRef { get; set; }  
 
		public Int32 ItemRef { get; set; } 

        public void Validate()
        {
            new EditProductSaleLineItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

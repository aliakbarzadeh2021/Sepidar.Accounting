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
    public class AddProductPackDiscountCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ProductPackDiscountID { get; set; }  
 
		public Int32 DiscountRef { get; set; }  
 
		public Nullable<Int32> ProductPackRef { get; set; } 

        public void Validate()
        {
            new AddProductPackDiscountCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

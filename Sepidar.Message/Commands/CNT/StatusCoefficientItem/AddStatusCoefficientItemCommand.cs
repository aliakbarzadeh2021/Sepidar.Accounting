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
    public class AddStatusCoefficientItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 StatusCoefficientItemID { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Nullable<Int32> ContractCoefficientItemRef { get; set; }  
 
		public Nullable<Int32> CoefficientRef { get; set; }  
 
		public Decimal Price { get; set; } 

        public void Validate()
        {
            new AddStatusCoefficientItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

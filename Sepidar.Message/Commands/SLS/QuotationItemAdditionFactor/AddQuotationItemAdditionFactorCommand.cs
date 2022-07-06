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
    public class AddQuotationItemAdditionFactorCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 QuotationItemAdditionFactorID { get; set; }  
 
		public Int32 QuotationItemRef { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Decimal Value { get; set; }  
 
		public Decimal ValueInBaseCurrency { get; set; } 

        public void Validate()
        {
            new AddQuotationItemAdditionFactorCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

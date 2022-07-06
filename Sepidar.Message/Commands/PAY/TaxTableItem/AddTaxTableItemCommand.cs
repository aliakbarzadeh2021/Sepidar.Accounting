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
    public class AddTaxTableItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TaxTableItemId { get; set; }  
 
		public Decimal FromAmount { get; set; }  
 
		public Decimal ToAmount { get; set; }  
 
		public Decimal Rate { get; set; }  
 
		public Int32 TaxTableRef { get; set; }  
 
		public Decimal InLineAmount { get; set; }  
 
		public Nullable<Decimal> PartialAmount { get; set; } 

        public void Validate()
        {
            new AddTaxTableItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

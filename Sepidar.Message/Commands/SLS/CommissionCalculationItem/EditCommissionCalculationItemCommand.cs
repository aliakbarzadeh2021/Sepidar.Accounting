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
    public class EditCommissionCalculationItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommissionCalculationItemID { get; set; }  
 
		public Int32 CommissionCalculationRef { get; set; }  
 
		public Nullable<Int32> ItemRef { get; set; }  
 
		public Nullable<Int32> InvoiceRef { get; set; }  
 
		public Nullable<Int32> ReturnedInvoiceRef { get; set; }  
 
		public Decimal Amount { get; set; } 

        public void Validate()
        {
            new EditCommissionCalculationItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

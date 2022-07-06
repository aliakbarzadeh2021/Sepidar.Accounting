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
    public class AddCommercialOrderItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 CommercialOrderItemID { get; set; }  
 
		public Int32 CommercialOrderRef { get; set; }  
 
		public Int32 PurchaseOrderItemRef { get; set; }  
 
		public Nullable<Decimal> RegisterFee { get; set; }  
 
		public Int32 RowNumber { get; set; } 

        public void Validate()
        {
            new AddCommercialOrderItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

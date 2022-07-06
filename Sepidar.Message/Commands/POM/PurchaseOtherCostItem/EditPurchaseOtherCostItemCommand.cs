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
    public class EditPurchaseOtherCostItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PurchaseOtherCostItemID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 PurchaseCostRef { get; set; }  
 
		public Int32 ServiceInventoryPurchaseInvoiceItemRef { get; set; }  
 
		public Nullable<Int32> CostServiceAccountSLRef { get; set; }  
 
		public Decimal AmountInBaseCurrency { get; set; }  
 
		public Decimal EffectiveAmountInBaseCurrency { get; set; }  
 
		public Int32 AllotmentType { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new EditPurchaseOtherCostItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

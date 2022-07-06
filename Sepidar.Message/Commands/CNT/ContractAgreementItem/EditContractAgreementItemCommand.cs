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
    public class EditContractAgreementItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ContractAgreementItemID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public String ContractPriceListFieldTitle { get; set; }  
 
		public String ContractPriceListChapterTitle { get; set; }  
 
		public String ContractPriceListClassTitle { get; set; }  
 
		public String OperationalYear { get; set; }  
 
		public String OperationCode { get; set; }  
 
		public String OperationDescription { get; set; }  
 
		public String OperationUnit { get; set; }  
 
		public Decimal OperationFee { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Decimal Price { get; set; }  
 
		public Decimal PrvOperationFee { get; set; }  
 
		public Decimal PrvQuantity { get; set; }  
 
		public Decimal PrvPrice { get; set; }  
 
		public Nullable<Int32> ContractAgreementItemRef { get; set; } 

        public void Validate()
        {
            new EditContractAgreementItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

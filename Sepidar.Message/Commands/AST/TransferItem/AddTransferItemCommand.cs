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
    public class AddTransferItemCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 TransferItemID { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 TransferRef { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; }  
 
		public Nullable<Int32> PreCostCenterDlRef { get; set; }  
 
		public Nullable<Int32> PreEmplacementRef { get; set; }  
 
		public Nullable<Int32> PreReceiverPartyRef { get; set; }  
 
		public Int32 CostCenterDlRef { get; set; }  
 
		public Nullable<Int32> EmplacementRef { get; set; }  
 
		public Nullable<Int32> ReceiverPartyRef { get; set; } 

        public void Validate()
        {
            new AddTransferItemCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

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
    public class EditAssetTransactionCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AssetTransactionID { get; set; }  
 
		public Int32 TransactionType { get; set; }  
 
		public Nullable<Int32> AssetTransactionRef { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 AssetState { get; set; }  
 
		public Nullable<Int32> CostCenterDlRef { get; set; }  
 
		public Int32 AssetGroupRef { get; set; }  
 
		public Nullable<Int32> EmplacementRef { get; set; }  
 
		public Nullable<Int32> ReceiverPartyRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public DateTime ActivityDate { get; set; }  
 
		public Nullable<Int32> ActivityNumber { get; set; }  
 
		public Int32 ActivityRef { get; set; } 

        public void Validate()
        {
            new EditAssetTransactionCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

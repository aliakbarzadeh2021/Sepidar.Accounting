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
    public class AddDepreciationCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DepreciationID { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; }  
 
		public Int32 LastAssetTransactionRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddDepreciationCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

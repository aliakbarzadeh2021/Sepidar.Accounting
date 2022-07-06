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
    public class AddAssetGroupCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AssetGroupID { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Decimal DepreciationRate { get; set; }  
 
		public Decimal UsefulLife { get; set; }  
 
		public Int32 DepreciationMethod { get; set; }  
 
		public Decimal MaxDepreciableBookValue { get; set; }  
 
		public Decimal SalvageValue { get; set; }  
 
		public Int32 AssetClassRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddAssetGroupCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

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
    public class AddAssetClassCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AssetClassID { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Nullable<Int32> AssetSLRef { get; set; }  
 
		public Nullable<Int32> DepreciationSLRef { get; set; }  
 
		public Nullable<Int32> AccumulatedDepreciationSLRef { get; set; }  
 
		public Nullable<Int32> AssetClassRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddAssetClassCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

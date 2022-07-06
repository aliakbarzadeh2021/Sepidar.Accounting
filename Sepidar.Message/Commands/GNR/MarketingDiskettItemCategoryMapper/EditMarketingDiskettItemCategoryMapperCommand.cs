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
    public class EditMarketingDiskettItemCategoryMapperCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MarketingDiskettItemCategoryMapperID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> ItemCategory95Ref { get; set; }  
 
		public Int32 ItemCategory96 { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditMarketingDiskettItemCategoryMapperCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

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
    public class EditMarketingDisketteCurrencyMapperCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MarketingDisketteCurrencyMapperID { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Nullable<Int32> MarketingDisketteCurrencyRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditMarketingDisketteCurrencyMapperCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

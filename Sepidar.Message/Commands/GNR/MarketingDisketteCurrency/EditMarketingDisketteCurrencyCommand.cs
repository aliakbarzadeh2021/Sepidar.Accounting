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
    public class EditMarketingDisketteCurrencyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MarketingDisketteCurrencyID { get; set; }  
 
		public String Code { get; set; }  
 
		public String Ttile { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditMarketingDisketteCurrencyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

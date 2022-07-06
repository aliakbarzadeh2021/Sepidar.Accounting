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
    public class EditMarketingDiskette1396Command : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 MarketingDisketteID { get; set; }  
 
		public Int32 year { get; set; }  
 
		public Int32 Season { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditMarketingDiskette1396CommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

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
    public class EditPartyOpeningBalanceCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PartyOpeningBalanceID { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Decimal OpeningBalance { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 OpeningBalanceType { get; set; }  
 
		public Boolean FeedFromClosingOperation { get; set; } 

        public void Validate()
        {
            new EditPartyOpeningBalanceCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

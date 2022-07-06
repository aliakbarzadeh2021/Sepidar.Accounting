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
    public class EditPathPartyAddressCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 PathPartyAddressId { get; set; }  
 
		public Int32 RowOrder { get; set; }  
 
		public Int32 AreaAndPathRef { get; set; }  
 
		public Int32 PartyAddressRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new EditPathPartyAddressCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

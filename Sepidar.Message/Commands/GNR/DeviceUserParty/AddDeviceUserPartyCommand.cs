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
    public class AddDeviceUserPartyCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 DeviceUserPartyId { get; set; }  
 
		public Int32 DeviceRef { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public Nullable<Int32> PartyRef { get; set; }  
 
		public Int32 Version { get; set; } 

        public void Validate()
        {
            new AddDeviceUserPartyCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

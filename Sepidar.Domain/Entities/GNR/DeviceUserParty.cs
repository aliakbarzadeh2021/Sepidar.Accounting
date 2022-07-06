using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class DeviceUserParty : BaseEntity
    {
          
 
		public Int32 DeviceUserPartyId { get; set; }  
 
		public Int32 DeviceRef { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public Nullable<Int32> PartyRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



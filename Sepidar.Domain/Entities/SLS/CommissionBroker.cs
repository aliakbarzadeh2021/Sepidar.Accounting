using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommissionBroker : BaseEntity
    {
          
 
		public Int32 CommissionBrokerId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Int32 PartyRef { get; set; } 
    }
}



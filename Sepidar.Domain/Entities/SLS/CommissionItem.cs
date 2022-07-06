using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommissionItem : BaseEntity
    {
          
 
		public Int32 CommissionItemId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Int32 ItemRef { get; set; } 
    }
}



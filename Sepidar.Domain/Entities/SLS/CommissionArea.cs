using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommissionArea : BaseEntity
    {
          
 
		public Int32 CommissionAreaId { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Int32 AreaRef { get; set; } 
    }
}



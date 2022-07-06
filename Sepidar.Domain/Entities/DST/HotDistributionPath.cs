using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class HotDistributionPath : BaseEntity
    {
          
 
		public Int32 HotDistributionPathId { get; set; }  
 
		public Int32 HotDistributionRef { get; set; }  
 
		public Int32 PathRef { get; set; } 
    }
}



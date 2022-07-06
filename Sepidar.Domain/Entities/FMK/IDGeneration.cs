using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class IDGeneration : BaseEntity
    {
          
 
		public String TableName { get; set; }  
 
		public Int32 LastId { get; set; } 
    }
}



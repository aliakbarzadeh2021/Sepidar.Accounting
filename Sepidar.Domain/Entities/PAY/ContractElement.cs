using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ContractElement : BaseEntity
    {
          
 
		public Int32 ContractElementId { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Decimal Value { get; set; } 
    }
}



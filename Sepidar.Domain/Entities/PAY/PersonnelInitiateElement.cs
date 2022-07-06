using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PersonnelInitiateElement : BaseEntity
    {
          
 
		public Int32 PersonnelInitiateElementId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Int32 PersonnelInitiateRef { get; set; } 
    }
}



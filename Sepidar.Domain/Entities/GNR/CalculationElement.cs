using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CalculationElement : BaseEntity
    {
          
 
		public Int32 CalculationElementID { get; set; }  
 
		public String Symbol { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



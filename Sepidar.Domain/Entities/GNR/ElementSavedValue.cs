using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ElementSavedValue : BaseEntity
    {
          
 
		public Int32 ElementSavedValueID { get; set; }  
 
		public Int32 CalculationFormulaRef { get; set; }  
 
		public String Key { get; set; }  
 
		public String Values { get; set; } 
    }
}



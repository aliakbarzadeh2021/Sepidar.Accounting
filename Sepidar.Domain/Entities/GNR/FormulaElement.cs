using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class FormulaElement : BaseEntity
    {
          
 
		public Int32 FormulaElementID { get; set; }  
 
		public Int32 CalculationFormulaRef { get; set; }  
 
		public Int32 CalculationElementRef { get; set; } 
    }
}



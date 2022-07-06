using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommissionCalculationXMLResult : BaseEntity
    {
          
 
		public Int32 CommissionCalculationXMLResultID { get; set; }  
 
		public Int32 CommissionCalculationRef { get; set; }  
 
		public String Content { get; set; } 
    }
}



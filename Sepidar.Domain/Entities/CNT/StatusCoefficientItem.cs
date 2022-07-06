using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class StatusCoefficientItem : BaseEntity
    {
          
 
		public Int32 StatusCoefficientItemID { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Nullable<Int32> ContractCoefficientItemRef { get; set; }  
 
		public Nullable<Int32> CoefficientRef { get; set; }  
 
		public Decimal Price { get; set; } 
    }
}



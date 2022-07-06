using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ContractCoefficientItem : BaseEntity
    {
          
 
		public Int32 ContractCoefficientID { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 CoefficientRef { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Single Percent { get; set; } 
    }
}



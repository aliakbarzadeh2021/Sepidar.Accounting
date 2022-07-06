using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class SaleTypeConstraintItem : BaseEntity
    {
          
 
		public Int32 SaleTypeConstraintItemID { get; set; }  
 
		public Int32 SaleTypeConstraintRef { get; set; }  
 
		public Int32 SaleTypeRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



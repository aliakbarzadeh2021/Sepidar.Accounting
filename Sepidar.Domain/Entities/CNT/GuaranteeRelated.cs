using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class GuaranteeRelated : BaseEntity
    {
          
 
		public Int32 GuaranteeRelatedID { get; set; }  
 
		public Int32 ParentGuaranteeRef { get; set; }  
 
		public Int32 ChildGuaranteeRef { get; set; } 
    }
}



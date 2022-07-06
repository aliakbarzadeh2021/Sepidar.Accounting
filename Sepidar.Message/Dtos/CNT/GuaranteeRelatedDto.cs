using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class GuaranteeRelatedDto
    {
          
 
		public Int32 GuaranteeRelatedID { get; set; }  
 
		public Int32 ParentGuaranteeRef { get; set; }  
 
		public Int32 ChildGuaranteeRef { get; set; } 
    }
}



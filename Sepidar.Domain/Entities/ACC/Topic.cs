using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Topic : BaseEntity
    {
          
 
		public Int32 TopicId { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Topic1 { get; set; }  
 
		public String Topic_En { get; set; }  
 
		public String Category { get; set; }  
 
		public String Category_En { get; set; } 
    }
}



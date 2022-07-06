using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class TracingCategory : BaseEntity
    {
          
 
		public Int32 TracingCategoryID { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Boolean IsFixed { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



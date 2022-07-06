using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Lookup : BaseEntity
    {
          
 
		public Int32 LookupID { get; set; }  
 
		public String Type { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 DisplayOrder { get; set; }  
 
		public String Extra { get; set; }  
 
		public String System { get; set; } 
    }
}



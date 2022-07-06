using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class LookupLocale : BaseEntity
    {
          
 
		public Int32 LookupRef { get; set; }  
 
		public String LocaleName { get; set; }  
 
		public String Title { get; set; } 
    }
}



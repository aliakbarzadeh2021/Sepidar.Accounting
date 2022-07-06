using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class KeywordLocale : BaseEntity
    {
          
 
		public Int32 KeywordRef { get; set; }  
 
		public String LocaleName { get; set; }  
 
		public String Value { get; set; } 
    }
}



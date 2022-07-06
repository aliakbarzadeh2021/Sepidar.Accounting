using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Keyword : BaseEntity
    {
          
 
		public Int32 KeywordID { get; set; }  
 
		public String ActionKey { get; set; } 
    }
}



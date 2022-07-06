using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Currency : BaseEntity
    {
          
 
		public Int32 CurrencyID { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 ExchangeUnit { get; set; }  
 
		public Int32 PrecisionCount { get; set; }  
 
		public String PrecisionName { get; set; }  
 
		public String PrecisionName_En { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



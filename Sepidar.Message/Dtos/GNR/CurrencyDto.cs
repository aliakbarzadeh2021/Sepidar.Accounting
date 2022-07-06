using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CurrencyDto
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



using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class StatusCoefficientItemDto
    {
          
 
		public Int32 StatusCoefficientItemID { get; set; }  
 
		public Int32 StatusRef { get; set; }  
 
		public Nullable<Int32> ContractCoefficientItemRef { get; set; }  
 
		public Nullable<Int32> CoefficientRef { get; set; }  
 
		public Decimal Price { get; set; } 
    }
}



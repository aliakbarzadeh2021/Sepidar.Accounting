using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ItemAdditionFactorDto
    {
          
 
		public Int32 ItemAdditionFactorID { get; set; }  
 
		public Int32 AdditionFactorRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Nullable<Int32> TracingRef { get; set; } 
    }
}



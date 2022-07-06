using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class UserAccessDto
    {
          
 
		public Int32 UserAccessID { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public String LogicalResource { get; set; }  
 
		public Boolean HasAccess { get; set; } 
    }
}



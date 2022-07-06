using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class UserPhoneDto
    {
          
 
		public Int32 UserPhoneId { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Phone { get; set; }  
 
		public Boolean IsMain { get; set; } 
    }
}



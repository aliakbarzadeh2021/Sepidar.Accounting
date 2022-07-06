using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class UserConfigurationDto
    {
          
 
		public Int32 UserConfigurationID { get; set; }  
 
		public String Key { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



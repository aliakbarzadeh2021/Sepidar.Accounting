using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CommunicationConfigurationDto
    {
          
 
		public Int32 CommunicationConfigurationID { get; set; }  
 
		public Int32 System { get; set; }  
 
		public String Key { get; set; }  
 
		public String Value { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



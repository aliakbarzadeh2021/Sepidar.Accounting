using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class FAQDto
    {
          
 
		public Int32 FAQID { get; set; }  
 
		public Int32 ClubFAQRef { get; set; }  
 
		public Int32 ClubVersion { get; set; }  
 
		public String Question { get; set; }  
 
		public String Answer { get; set; }  
 
		public String Location { get; set; }  
 
		public String Key { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class FAQ : BaseEntity
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



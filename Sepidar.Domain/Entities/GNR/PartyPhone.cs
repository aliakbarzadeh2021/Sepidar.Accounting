using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PartyPhone : BaseEntity
    {
          
 
		public Int32 PartyPhoneId { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 IsMain { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Phone { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



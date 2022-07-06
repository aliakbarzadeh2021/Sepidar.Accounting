using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Job : BaseEntity
    {
          
 
		public Int32 JobId { get; set; }  
 
		public String Title_En { get; set; }  
 
		public String HardCode { get; set; }  
 
		public String Title { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Nullable<Int32> GuildType { get; set; } 
    }
}



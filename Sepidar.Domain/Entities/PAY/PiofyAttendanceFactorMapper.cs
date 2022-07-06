using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PiofyAttendanceFactorMapper : BaseEntity
    {
          
 
		public Int32 PiofyAttendanceFactorMapperId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Int32 PiofyAttendanceFactorRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



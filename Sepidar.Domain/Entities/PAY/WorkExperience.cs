using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class WorkExperience : BaseEntity
    {
          
 
		public Int32 WorkExperienceId { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public DateTime EndDate { get; set; }  
 
		public Int32 Duration { get; set; }  
 
		public String Company { get; set; }  
 
		public String Career { get; set; }  
 
		public String QuitReason { get; set; }  
 
		public Int32 PersonnelRef { get; set; } 
    }
}



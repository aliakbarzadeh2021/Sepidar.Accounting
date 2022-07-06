using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Workshop : BaseEntity
    {
          
 
		public Int32 WorkshopID { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 SupervisorRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



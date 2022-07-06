using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Message1 : BaseEntity
    {
          
 
		public Int32 MessageID { get; set; }  
 
		public String Body { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Boolean IsDraft { get; set; }  
 
		public Nullable<Int32> TemplateRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



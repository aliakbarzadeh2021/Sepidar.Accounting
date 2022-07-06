using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Leave : BaseEntity
    {
          
 
		public Int32 LeaveId { get; set; }  
 
		public Int32 PersonnelRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 SystemRemainder { get; set; }  
 
		public Nullable<Int32> UserRemainder { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Solaryear { get; set; }  
 
		public Int32 Month { get; set; } 
    }
}



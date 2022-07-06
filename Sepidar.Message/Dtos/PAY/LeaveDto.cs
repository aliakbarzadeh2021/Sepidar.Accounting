using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class LeaveDto
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



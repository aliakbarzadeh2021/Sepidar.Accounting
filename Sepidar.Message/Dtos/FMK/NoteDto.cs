using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class NoteDto
    {
          
 
		public Int32 NoteID { get; set; }  
 
		public String EntityType { get; set; }  
 
		public Int32 EntityRef { get; set; }  
 
		public String Note1 { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



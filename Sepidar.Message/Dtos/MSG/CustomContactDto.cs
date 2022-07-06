using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CustomContactDto
    {
          
 
		public Int32 CustomContactId { get; set; }  
 
		public String FullName { get; set; }  
 
		public Nullable<DateTime> MarriageDate { get; set; }  
 
		public Nullable<DateTime> BirthDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



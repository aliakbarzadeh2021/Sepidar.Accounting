using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class MessageContactDto
    {
          
 
		public Int32 MessageContactID { get; set; }  
 
		public Int32 MessageRef { get; set; }  
 
		public String Phone { get; set; }  
 
		public Nullable<Int32> ContactPhoneRef { get; set; }  
 
		public Nullable<Int32> ContactType { get; set; } 
    }
}



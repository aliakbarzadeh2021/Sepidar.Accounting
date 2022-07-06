using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class OutgoingMessageDto
    {
          
 
		public Int32 OutgoingMessageID { get; set; }  
 
		public String Text { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String SenderNumber { get; set; }  
 
		public String ReceiverNumber { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Nullable<Int64> TrackingID { get; set; }  
 
		public Nullable<Int32> MessageContactRef { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



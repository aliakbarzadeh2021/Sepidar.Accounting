using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class OutgoingMessage : BaseEntity
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



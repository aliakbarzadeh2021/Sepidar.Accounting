using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CommunicationDto
    {
          
 
		public Int32 CommunicationId { get; set; }  
 
		public Int32 System { get; set; }  
 
		public String Method { get; set; }  
 
		public String RequestHttpMethod { get; set; }  
 
		public String RequestUrl { get; set; }  
 
		public String RequestBody { get; set; }  
 
		public Int32 SendingState { get; set; }  
 
		public Int32 NumberOfAttempts { get; set; }  
 
		public Nullable<DateTime> LastAttemptTime { get; set; }  
 
		public String UniqueId { get; set; }  
 
		public String ResponseStatusCode { get; set; }  
 
		public String ResponseRawText { get; set; }  
 
		public String ErrorMessage { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



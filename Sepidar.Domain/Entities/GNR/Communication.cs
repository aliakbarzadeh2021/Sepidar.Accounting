using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Communication : BaseEntity
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



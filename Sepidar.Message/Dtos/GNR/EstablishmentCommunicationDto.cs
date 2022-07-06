using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class EstablishmentCommunicationDto
    {
          
 
		public Int32 EstablishmentCommunicationId { get; set; }  
 
		public String EntityName { get; set; }  
 
		public Int32 EntityCode { get; set; }  
 
		public Boolean IsSynchronized { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class OpeningOperationItemDto
    {
          
 
		public Int32 OpeningOperationItemId { get; set; }  
 
		public Int32 OpeningOperationRef { get; set; }  
 
		public String RecordType { get; set; }  
 
		public Int32 RecordId { get; set; }  
 
		public Nullable<Boolean> Checked { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



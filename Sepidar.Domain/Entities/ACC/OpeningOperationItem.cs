using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class OpeningOperationItem : BaseEntity
    {
          
 
		public Int32 OpeningOperationItemId { get; set; }  
 
		public Int32 OpeningOperationRef { get; set; }  
 
		public String RecordType { get; set; }  
 
		public Int32 RecordId { get; set; }  
 
		public Nullable<Boolean> Checked { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



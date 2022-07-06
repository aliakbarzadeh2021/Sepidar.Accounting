using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class OpeningOperation : BaseEntity
    {
          
 
		public Int32 OpeningOperationId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Nullable<Int32> AccountSLRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



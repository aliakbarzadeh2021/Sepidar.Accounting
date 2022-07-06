using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CustomContact : BaseEntity
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



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class NumberedEntity : BaseEntity
    {
          
 
		public Int32 NumberedEntityID { get; set; }  
 
		public String EntityFullName { get; set; }  
 
		public Int32 Method { get; set; }  
 
		public Int64 StartValue { get; set; }  
 
		public Nullable<Int64> FinishValue { get; set; }  
 
		public Boolean ApplyProperty1 { get; set; }  
 
		public Boolean ApplyProperty2 { get; set; }  
 
		public Boolean ApplyProperty3 { get; set; }  
 
		public Boolean ApplyPorperty4 { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



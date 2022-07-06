using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PiofyEmployeeMapper : BaseEntity
    {
          
 
		public Int32 PiofyEmployeeMapperID { get; set; }  
 
		public Int32 PersonnelRef { get; set; }  
 
		public Nullable<Int32> PiofyEmployeeID { get; set; }  
 
		public Int32 PiofyEmploymentType { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



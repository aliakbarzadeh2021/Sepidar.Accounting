using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Version1 : BaseEntity
    {
          
 
		public Int32 VersionID { get; set; }  
 
		public Int32 Major { get; set; }  
 
		public Int32 Minor { get; set; }  
 
		public Int32 Build { get; set; }  
 
		public Int32 Revision { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version2 { get; set; } 
    }
}



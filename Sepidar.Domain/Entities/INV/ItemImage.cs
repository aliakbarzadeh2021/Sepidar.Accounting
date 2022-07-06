using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ItemImage : BaseEntity
    {
          
 
		public Int32 ItemImageID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Byte[] Image { get; set; }  
 
		public Byte[] Thumbnail { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



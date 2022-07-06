using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ItemImageDto
    {
          
 
		public Int32 ItemImageID { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Byte[] Image { get; set; }  
 
		public Byte[] Thumbnail { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



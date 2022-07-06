using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class CostCenterDto
    {
          
 
		public Int32 CostCenterId { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public Int32 Type { get; set; } 
    }
}



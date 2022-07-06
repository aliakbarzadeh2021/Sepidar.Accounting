using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class DeviceDto
    {
          
 
		public Int32 DeviceId { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Key { get; set; }  
 
		public Nullable<Int32> TempKey { get; set; }  
 
		public Int32 IntegrationId { get; set; }  
 
		public Boolean IsRegistered { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 DeviceType { get; set; } 
    }
}


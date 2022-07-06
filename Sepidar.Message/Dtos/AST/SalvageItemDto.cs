using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class SalvageItemDto
    {
          
 
		public Int32 SalvageItemID { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 SalvageRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 
    }
}



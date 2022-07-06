using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class EliminationItemDto
    {
          
 
		public Int32 EliminationItemID { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 EliminationRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 
    }
}



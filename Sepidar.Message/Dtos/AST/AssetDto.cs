using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class AssetDto
    {
          
 
		public Int32 AssetId { get; set; }  
 
		public String PlaqueNumber { get; set; }  
 
		public String OldPlaqueNumber { get; set; }  
 
		public Nullable<Int32> PlaqueSerial { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 State { get; set; }  
 
		public Int32 AssetGroupRef { get; set; }  
 
		public Int32 CostCenterDlRef { get; set; }  
 
		public Nullable<Int32> EmplacementRef { get; set; }  
 
		public Nullable<Int32> ReceiverPartyRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Details { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Boolean IsInitial { get; set; } 
    }
}



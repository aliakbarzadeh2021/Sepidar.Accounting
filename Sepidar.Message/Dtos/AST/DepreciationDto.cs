using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class DepreciationDto
    {
          
 
		public Int32 DepreciationID { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; }  
 
		public Int32 LastAssetTransactionRef { get; set; }  
 
		public Nullable<Int32> VoucherRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



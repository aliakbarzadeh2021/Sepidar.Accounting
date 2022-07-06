using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ChangeDepreciationMethodDto
    {
          
 
		public Int32 ChangeDepreciationMethodId { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ProductFormulaDto
    {
          
 
		public Int32 ProductFormulaID { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Int32 ItemUnitRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Nullable<Decimal> EstimatedLabour { get; set; }  
 
		public Nullable<Decimal> EstimatedOverhead { get; set; }  
 
		public Nullable<Int32> BaseProductFormula { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



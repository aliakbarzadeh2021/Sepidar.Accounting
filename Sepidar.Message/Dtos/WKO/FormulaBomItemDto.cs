using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class FormulaBomItemDto
    {
          
 
		public Int32 FormulaBomItemID { get; set; }  
 
		public Int32 ProductFormulaRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public String Description { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class FormulaBomItem : BaseEntity
    {
          
 
		public Int32 FormulaBomItemID { get; set; }  
 
		public Int32 ProductFormulaRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Decimal Quantity { get; set; }  
 
		public Nullable<Decimal> SecondaryQuantity { get; set; }  
 
		public String Description { get; set; } 
    }
}



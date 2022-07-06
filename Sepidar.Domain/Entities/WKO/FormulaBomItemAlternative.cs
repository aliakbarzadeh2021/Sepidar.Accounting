using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class FormulaBomItemAlternative : BaseEntity
    {
          
 
		public Int32 FormulaBomItemAlternativeID { get; set; }  
 
		public Int32 FormulaBomItemRef { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Double AlternativeRatio { get; set; } 
    }
}



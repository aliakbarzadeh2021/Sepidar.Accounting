using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PayrollConfigurationElementDto
    {
          
 
		public Int32 PayrollConfigurationElementId { get; set; }  
 
		public Int32 ElementRef { get; set; }  
 
		public Nullable<Decimal> Coefficient { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 PayrollConfigurationRef { get; set; } 
    }
}



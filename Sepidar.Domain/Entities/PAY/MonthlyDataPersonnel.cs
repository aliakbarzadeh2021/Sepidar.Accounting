using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class MonthlyDataPersonnel : BaseEntity
    {
          
 
		public Int32 MonthlyDataPersonnelId { get; set; }  
 
		public Int32 MonthlyDataRef { get; set; }  
 
		public Int32 PersonnelRef { get; set; } 
    }
}



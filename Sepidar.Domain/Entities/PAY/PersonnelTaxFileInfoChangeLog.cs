using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PersonnelTaxFileInfoChangeLog : BaseEntity
    {
          
 
		public Int32 PersonnelTaxFileInfoChangeLogId { get; set; }  
 
		public Int32 PersonnelRef { get; set; }  
 
		public DateTime ChangeInfoDate { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ContractCompromiseItem : BaseEntity
    {
          
 
		public Int32 ContractCompromiseItemID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PartyRelated : BaseEntity
    {
          
 
		public Int32 PartyRelatedId { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Nullable<Boolean> IsMain { get; set; }  
 
		public String Name { get; set; }  
 
		public String Post { get; set; }  
 
		public String Name_En { get; set; }  
 
		public String Post_En { get; set; }  
 
		public String Phone { get; set; }  
 
		public String Email { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



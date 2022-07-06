using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class User : BaseEntity
    {
          
 
		public Int32 UserID { get; set; }  
 
		public String Name { get; set; }  
 
		public String Name_En { get; set; }  
 
		public String UserName { get; set; }  
 
		public String Password { get; set; }  
 
		public Nullable<Boolean> Status { get; set; }  
 
		public Boolean IsDeleted { get; set; }  
 
		public Boolean CanChangeAdminConfiguration { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



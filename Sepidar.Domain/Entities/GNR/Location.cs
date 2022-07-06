using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Location : BaseEntity
    {
          
 
		public Int32 LocationId { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public String Code { get; set; }  
 
		public Nullable<Int32> Parent { get; set; }  
 
		public String Type { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; }  
 
		public String MinistryofFinanceCode { get; set; }  
 
		public String TaxFileCode { get; set; } 
    }
}



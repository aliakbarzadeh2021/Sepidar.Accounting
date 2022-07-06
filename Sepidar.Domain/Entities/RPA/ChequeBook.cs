using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ChequeBook : BaseEntity
    {
          
 
		public Int32 ChequeBookId { get; set; }  
 
		public Int32 BankAccountRef { get; set; }  
 
		public String beginNumber { get; set; }  
 
		public Int32 Count { get; set; }  
 
		public String PrintFormat { get; set; }  
 
		public String Series { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> Creator { get; set; }  
 
		public Nullable<DateTime> CreationDate { get; set; }  
 
		public Nullable<Int32> LastModifier { get; set; }  
 
		public Nullable<DateTime> LastModificationDate { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Grouping : BaseEntity
    {
          
 
		public Int32 GroupingID { get; set; }  
 
		public String EntityType { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Nullable<Int32> CalculationFormulaRef { get; set; }  
 
		public Nullable<Int32> ParentGroupRef { get; set; }  
 
		public Nullable<Decimal> MaximumCredit { get; set; }  
 
		public Boolean HasCredit { get; set; }  
 
		public Int32 CreditCheckingType { get; set; }  
 
		public String FullCode { get; set; } 
    }
}



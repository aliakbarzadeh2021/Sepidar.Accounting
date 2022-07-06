using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Shred : BaseEntity
    {
          
 
		public Int32 ShredID { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public Int32 Key { get; set; }  
 
		public Int32 TargetRef { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Decimal Amount { get; set; }  
 
		public Nullable<Decimal> InterestAmount { get; set; }  
 
		public Decimal TotalAmount { get; set; }  
 
		public Decimal RemainedAmount { get; set; }  
 
		public Nullable<Decimal> PenaltyRate { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 CurrencyRef { get; set; }  
 
		public Nullable<Int32> InterestAccountSLRef { get; set; }  
 
		public Nullable<Int32> PenaltyAccountSLRef { get; set; }  
 
		public Int32 RPType { get; set; } 
    }
}



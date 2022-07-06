using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Element : BaseEntity
    {
          
 
		public Int32 ElementId { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 Class { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 NormalType { get; set; }  
 
		public Nullable<Int32> AccountRef { get; set; }  
 
		public Int32 DlType { get; set; }  
 
		public Nullable<Boolean> InsuranceCoverage { get; set; }  
 
		public Nullable<Boolean> Taxable { get; set; }  
 
		public Nullable<Boolean> UnrelatedToWorkingTime { get; set; }  
 
		public Nullable<Boolean> CalculateForMinWorkingTime { get; set; }  
 
		public Nullable<Int32> CalculateForMinBase { get; set; }  
 
		public Nullable<Decimal> Coefficient { get; set; }  
 
		public Nullable<Decimal> FixPoint { get; set; }  
 
		public Nullable<Int32> DenominatorsType { get; set; }  
 
		public Nullable<Decimal> Denominators { get; set; }  
 
		public Nullable<Boolean> SavingRemainder { get; set; }  
 
		//public bool IsActive { get; set; }  
 
		public Int32 DisplayOrder { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Nullable<Int32> PaymentAccountRef { get; set; }  
 
		public Nullable<Int32> PaymentDlType { get; set; } 
    }
}



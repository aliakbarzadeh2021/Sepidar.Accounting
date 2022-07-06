using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class CommissionCalculation : BaseEntity
    {
          
 
		public Int32 CommissionCalculationID { get; set; }  
 
		public Int32 CommissionRef { get; set; }  
 
		public Int32 BrokerPartyRef_ { get; set; }  
 
		public DateTime FromDate { get; set; }  
 
		public DateTime ToDate { get; set; }  
 
		public Nullable<Int32> SLRef { get; set; }  
 
		public Nullable<Int32> DLRef { get; set; }  
 
		public Nullable<Int32> AccountingVoucherRef { get; set; }  
 
		public Int32 FiscalYearRef { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Account : BaseEntity
    {
          
 
		public Int32 AccountId { get; set; }  
 
		public Nullable<Int32> ParentAccountRef { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Nullable<Int32> CashFlowCategory { get; set; }  
 
		public Nullable<Decimal> OpeningBalance { get; set; }  
 
		public Int32 BalanceType { get; set; }  
 
		public Boolean HasBalanceTypeCheck { get; set; }  
 
		public Boolean HasDL { get; set; }  
 
		public Boolean HasCurrency { get; set; }  
 
		public Boolean HasCurrencyConversion { get; set; }  
 
		public Boolean HasTracking { get; set; }  
 
		public Boolean HasTrackingCheck { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



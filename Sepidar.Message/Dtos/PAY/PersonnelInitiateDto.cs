using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PersonnelInitiateDto
    {
          
 
		public Int32 PersonnelInitiateId { get; set; }  
 
		public Int32 PersonnelRef { get; set; }  
 
		public Nullable<DateTime> Date { get; set; }  
 
		public Nullable<Int32> SumYearlyWorkingTimeDay { get; set; }  
 
		public Nullable<Decimal> SumYearlyTaxableIncome { get; set; }  
 
		public Nullable<Decimal> SumYearlyTax { get; set; }  
 
		public Nullable<Int32> WorkHistoryDay { get; set; }  
 
		public Nullable<Decimal> WorkHistorySaving { get; set; }  
 
		public Nullable<Int32> LeaveRemain { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Nullable<Decimal> PaymentRound { get; set; }  
 
		public Nullable<DateTime> BaseDate { get; set; }  
 
		public Nullable<Int32> NewyearBonusWorkingTime { get; set; }  
 
		public Nullable<Decimal> NewyearBonusSaving { get; set; } 
    }
}



using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class PayrollConfiguration : BaseEntity
    {
          
 
		public Int32 PayrollConfigurationId { get; set; }  
 
		public Nullable<Decimal> TopDailyInsurance { get; set; }  
 
		public Nullable<Decimal> EmployeeInsurancePercent { get; set; }  
 
		public Nullable<Decimal> EmployerInsurancePercent { get; set; }  
 
		public Nullable<Decimal> UnemploymentInsurancePercent { get; set; }  
 
		public Nullable<Decimal> HardWorkInsurance { get; set; }  
 
		public Nullable<Int32> SocialSecurityAccountRef { get; set; }  
 
		public Nullable<Int32> UnemploymentAccountRef { get; set; }  
 
		public Nullable<Int32> PaymentSocialSecurityAccountRef { get; set; }  
 
		public Nullable<Decimal> NonTaxableSocialSecurityPercent { get; set; }  
 
		public Nullable<Decimal> SupportingInsurancePercent { get; set; }  
 
		public Nullable<Int32> PaymentInsuranceAccountRef { get; set; }  
 
		public Nullable<Int32> SupportingInsuranceEmployeeElementRef { get; set; }  
 
		public Nullable<Int32> SupportingInsuranceEmployerElementRef { get; set; }  
 
		public Nullable<Int32> SupportingInsuranceCostAccountRef { get; set; }  
 
		public Nullable<Int32> PaymentSupportingInsuranceAccountRef { get; set; }  
 
		public Nullable<Int32> TopMonthlyLeave { get; set; }  
 
		public Nullable<Int32> TransferYearlyLeave { get; set; }  
 
		public Nullable<Int32> LeaveCostAccountRef { get; set; }  
 
		public Nullable<Int32> LeaveSavingAccountRef { get; set; }  
 
		public Nullable<Decimal> TopNewYearBonus { get; set; }  
 
		public Nullable<Decimal> NewYearBonusBaseFactor { get; set; }  
 
		public Nullable<Decimal> NonTaxableNewYearBonus { get; set; }  
 
		public Nullable<Boolean> NonTaxbleBonusRelatedToWorkTime { get; set; }  
 
		public Nullable<Int32> NewYearBonuCostAccountRef { get; set; }  
 
		public Nullable<Int32> WorkingHistoryYearlyDay { get; set; }  
 
		public Nullable<Int32> WorkingHistorySavingAccountRef { get; set; }  
 
		public Nullable<Int32> WorkingHistoryCostAccountRef { get; set; }  
 
		public Nullable<Int32> PaymentRound { get; set; }  
 
		public Nullable<Int32> PaymentAccountRef { get; set; }  
 
		public Nullable<Int32> PaymentRoundAccountRef { get; set; }  
 
		public Nullable<Int32> EmployeesCurrentAccountRef { get; set; }  
 
		public Boolean CalculateNegativeTax { get; set; }  
 
		public Boolean ShowAvailableLeaveInFish { get; set; }  
 
		public Nullable<Int32> LoanAccountRef { get; set; }  
 
		public Boolean ShowAvailableLeaveInPayFish { get; set; } 
    }
}



using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PayContractDto
    {
          
 
		public Int32 ContractId { get; set; }  
 
		public Int32 PersonnelRef { get; set; }  
 
		public Int32 WorkSiteRef { get; set; }  
 
		public Nullable<Int32> CostCenterRef { get; set; }  
 
		public Nullable<Int32> CostCenterDlRef { get; set; }  
 
		public Int32 JobRef { get; set; }  
 
		public Int32 TaxGroupRef { get; set; }  
 
		public Int32 TaxBranchRef { get; set; }  
 
		public Nullable<Int32> InsuranceBranchRef { get; set; }  
 
		public Nullable<Int32> SupportingInsuranceBranchRef { get; set; }  
 
		public Int32 ContractType { get; set; }  
 
		public Int32 Number { get; set; }  
 
		public DateTime IssueDate { get; set; }  
 
		public DateTime ExpireDate { get; set; }  
 
		public Nullable<DateTime> EndDate { get; set; }  
 
		public DateTime EmploymentDate { get; set; }  
 
		public Int32 EmploymentType { get; set; }  
 
		public Nullable<Decimal> NonTaxableAmount { get; set; }  
 
		public Boolean HasInsurance { get; set; }  
 
		public Boolean HasSupportingInsurance { get; set; }  
 
		public Boolean HasHardJob { get; set; }  
 
		public String Description { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Boolean HasUnemploymentException { get; set; }  
 
		public Int32 EmployerInsuranceExceptionPercent { get; set; }  
 
		public String SupportingInsuranceName { get; set; }  
 
		public Nullable<Int32> PiofyEmploymentType { get; set; }  
 
		public Boolean IsEmployer { get; set; }  
 
		public Boolean HasEmployerInsuranceException { get; set; } 
    }
}



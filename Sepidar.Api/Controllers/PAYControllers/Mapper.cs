using Sepidar.Domain.Entities;
using Sepidar.Message.Commands;
using Sepidar.Message.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sepidar.Api.Controllers
{
    public partial class Mapper
    {
                
        
        public static Branch Map(AddBranchCommand inputItem)
        {
            var entity = new Branch() {
                  
  
		BranchId = inputItem.BranchId,  
  
		Type = inputItem.Type,  
  
		BranchPartyRef = inputItem.BranchPartyRef,  
  
		Code = inputItem.Code,  
  
		ContractNumber = inputItem.ContractNumber,  
  
		NoInsurancePersonsCount = inputItem.NoInsurancePersonsCount,  
  
		AdjustmentType = inputItem.AdjustmentType,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Branch Map(Branch entity ,EditBranchCommand inputItem)
        {
              
  
		entity.BranchId = inputItem.BranchId;  
  
		entity.Type = inputItem.Type;  
  
		entity.BranchPartyRef = inputItem.BranchPartyRef;  
  
		entity.Code = inputItem.Code;  
  
		entity.ContractNumber = inputItem.ContractNumber;  
  
		entity.NoInsurancePersonsCount = inputItem.NoInsurancePersonsCount;  
  
		entity.AdjustmentType = inputItem.AdjustmentType;  
  
		entity.CostCenterRef = inputItem.CostCenterRef;  
  
		entity.CostCenterDlRef = inputItem.CostCenterDlRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static BranchDto Map(Branch inputItem)
        {
            var dto = new BranchDto()
            {
                  
  
		BranchId = inputItem.BranchId,  
  
		Type = inputItem.Type,  
  
		BranchPartyRef = inputItem.BranchPartyRef,  
  
		Code = inputItem.Code,  
  
		ContractNumber = inputItem.ContractNumber,  
  
		NoInsurancePersonsCount = inputItem.NoInsurancePersonsCount,  
  
		AdjustmentType = inputItem.AdjustmentType,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<BranchDto> Map(ICollection<Branch> entities)
        {
            var dtos = new List<BranchDto>();
            foreach (var inputItem in entities)
            {
                var dto = new BranchDto()
                {
                      
  
		BranchId = inputItem.BranchId,  
  
		Type = inputItem.Type,  
  
		BranchPartyRef = inputItem.BranchPartyRef,  
  
		Code = inputItem.Code,  
  
		ContractNumber = inputItem.ContractNumber,  
  
		NoInsurancePersonsCount = inputItem.NoInsurancePersonsCount,  
  
		AdjustmentType = inputItem.AdjustmentType,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Calculation Map(AddCalculationCommand inputItem)
        {
            var entity = new Calculation() {
                  
  
		CalculationId = inputItem.CalculationId,  
  
		ElementRef = inputItem.ElementRef,  
  
		BranchRef = inputItem.BranchRef,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		Value = inputItem.Value,  
  
		Type = inputItem.Type,  
  
		Year = inputItem.Year,  
  
		Month = inputItem.Month,  
  
		ContractRef = inputItem.ContractRef,  
  
		VoucherRef = inputItem.VoucherRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Calculation Map(Calculation entity ,EditCalculationCommand inputItem)
        {
              
  
		entity.CalculationId = inputItem.CalculationId;  
  
		entity.ElementRef = inputItem.ElementRef;  
  
		entity.BranchRef = inputItem.BranchRef;  
  
		entity.PersonnelRef = inputItem.PersonnelRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.Value = inputItem.Value;  
  
		entity.Type = inputItem.Type;  
  
		entity.Year = inputItem.Year;  
  
		entity.Month = inputItem.Month;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.VoucherRef = inputItem.VoucherRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CalculationDto Map(Calculation inputItem)
        {
            var dto = new CalculationDto()
            {
                  
  
		CalculationId = inputItem.CalculationId,  
  
		ElementRef = inputItem.ElementRef,  
  
		BranchRef = inputItem.BranchRef,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		Value = inputItem.Value,  
  
		Type = inputItem.Type,  
  
		Year = inputItem.Year,  
  
		Month = inputItem.Month,  
  
		ContractRef = inputItem.ContractRef,  
  
		VoucherRef = inputItem.VoucherRef, 
            };
            return dto;
        }

        public static List<CalculationDto> Map(ICollection<Calculation> entities)
        {
            var dtos = new List<CalculationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CalculationDto()
                {
                      
  
		CalculationId = inputItem.CalculationId,  
  
		ElementRef = inputItem.ElementRef,  
  
		BranchRef = inputItem.BranchRef,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		Value = inputItem.Value,  
  
		Type = inputItem.Type,  
  
		Year = inputItem.Year,  
  
		Month = inputItem.Month,  
  
		ContractRef = inputItem.ContractRef,  
  
		VoucherRef = inputItem.VoucherRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayContract Map(AddPayContractCommand inputItem)
        {
            var entity = new PayContract() {
                  
  
		ContractId = inputItem.ContractId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		WorkSiteRef = inputItem.WorkSiteRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		JobRef = inputItem.JobRef,  
  
		TaxGroupRef = inputItem.TaxGroupRef,  
  
		TaxBranchRef = inputItem.TaxBranchRef,  
  
		InsuranceBranchRef = inputItem.InsuranceBranchRef,  
  
		SupportingInsuranceBranchRef = inputItem.SupportingInsuranceBranchRef,  
  
		ContractType = inputItem.ContractType,  
  
		Number = inputItem.Number,  
  
		IssueDate = inputItem.IssueDate,  
  
		ExpireDate = inputItem.ExpireDate,  
  
		EndDate = inputItem.EndDate,  
  
		EmploymentDate = inputItem.EmploymentDate,  
  
		EmploymentType = inputItem.EmploymentType,  
  
		NonTaxableAmount = inputItem.NonTaxableAmount,  
  
		HasInsurance = inputItem.HasInsurance,  
  
		HasSupportingInsurance = inputItem.HasSupportingInsurance,  
  
		HasHardJob = inputItem.HasHardJob,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		HasUnemploymentException = inputItem.HasUnemploymentException,  
  
		EmployerInsuranceExceptionPercent = inputItem.EmployerInsuranceExceptionPercent,  
  
		SupportingInsuranceName = inputItem.SupportingInsuranceName,  
  
		PiofyEmploymentType = inputItem.PiofyEmploymentType,  
  
		IsEmployer = inputItem.IsEmployer,  
  
		HasEmployerInsuranceException = inputItem.HasEmployerInsuranceException, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayContract Map(PayContract entity ,EditPayContractCommand inputItem)
        {
              
  
		entity.ContractId = inputItem.ContractId;  
  
		entity.PersonnelRef = inputItem.PersonnelRef;  
  
		entity.WorkSiteRef = inputItem.WorkSiteRef;  
  
		entity.CostCenterRef = inputItem.CostCenterRef;  
  
		entity.CostCenterDlRef = inputItem.CostCenterDlRef;  
  
		entity.JobRef = inputItem.JobRef;  
  
		entity.TaxGroupRef = inputItem.TaxGroupRef;  
  
		entity.TaxBranchRef = inputItem.TaxBranchRef;  
  
		entity.InsuranceBranchRef = inputItem.InsuranceBranchRef;  
  
		entity.SupportingInsuranceBranchRef = inputItem.SupportingInsuranceBranchRef;  
  
		entity.ContractType = inputItem.ContractType;  
  
		entity.Number = inputItem.Number;  
  
		entity.IssueDate = inputItem.IssueDate;  
  
		entity.ExpireDate = inputItem.ExpireDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.EmploymentDate = inputItem.EmploymentDate;  
  
		entity.EmploymentType = inputItem.EmploymentType;  
  
		entity.NonTaxableAmount = inputItem.NonTaxableAmount;  
  
		entity.HasInsurance = inputItem.HasInsurance;  
  
		entity.HasSupportingInsurance = inputItem.HasSupportingInsurance;  
  
		entity.HasHardJob = inputItem.HasHardJob;  
  
		entity.Description = inputItem.Description;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.HasUnemploymentException = inputItem.HasUnemploymentException;  
  
		entity.EmployerInsuranceExceptionPercent = inputItem.EmployerInsuranceExceptionPercent;  
  
		entity.SupportingInsuranceName = inputItem.SupportingInsuranceName;  
  
		entity.PiofyEmploymentType = inputItem.PiofyEmploymentType;  
  
		entity.IsEmployer = inputItem.IsEmployer;  
  
		entity.HasEmployerInsuranceException = inputItem.HasEmployerInsuranceException; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayContractDto Map(PayContract inputItem)
        {
            var dto = new PayContractDto()
            {
                  
  
		ContractId = inputItem.ContractId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		WorkSiteRef = inputItem.WorkSiteRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		JobRef = inputItem.JobRef,  
  
		TaxGroupRef = inputItem.TaxGroupRef,  
  
		TaxBranchRef = inputItem.TaxBranchRef,  
  
		InsuranceBranchRef = inputItem.InsuranceBranchRef,  
  
		SupportingInsuranceBranchRef = inputItem.SupportingInsuranceBranchRef,  
  
		ContractType = inputItem.ContractType,  
  
		Number = inputItem.Number,  
  
		IssueDate = inputItem.IssueDate,  
  
		ExpireDate = inputItem.ExpireDate,  
  
		EndDate = inputItem.EndDate,  
  
		EmploymentDate = inputItem.EmploymentDate,  
  
		EmploymentType = inputItem.EmploymentType,  
  
		NonTaxableAmount = inputItem.NonTaxableAmount,  
  
		HasInsurance = inputItem.HasInsurance,  
  
		HasSupportingInsurance = inputItem.HasSupportingInsurance,  
  
		HasHardJob = inputItem.HasHardJob,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		HasUnemploymentException = inputItem.HasUnemploymentException,  
  
		EmployerInsuranceExceptionPercent = inputItem.EmployerInsuranceExceptionPercent,  
  
		SupportingInsuranceName = inputItem.SupportingInsuranceName,  
  
		PiofyEmploymentType = inputItem.PiofyEmploymentType,  
  
		IsEmployer = inputItem.IsEmployer,  
  
		HasEmployerInsuranceException = inputItem.HasEmployerInsuranceException, 
            };
            return dto;
        }

        public static List<PayContractDto> Map(ICollection<PayContract> entities)
        {
            var dtos = new List<PayContractDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayContractDto()
                {
                      
  
		ContractId = inputItem.ContractId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		WorkSiteRef = inputItem.WorkSiteRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		CostCenterDlRef = inputItem.CostCenterDlRef,  
  
		JobRef = inputItem.JobRef,  
  
		TaxGroupRef = inputItem.TaxGroupRef,  
  
		TaxBranchRef = inputItem.TaxBranchRef,  
  
		InsuranceBranchRef = inputItem.InsuranceBranchRef,  
  
		SupportingInsuranceBranchRef = inputItem.SupportingInsuranceBranchRef,  
  
		ContractType = inputItem.ContractType,  
  
		Number = inputItem.Number,  
  
		IssueDate = inputItem.IssueDate,  
  
		ExpireDate = inputItem.ExpireDate,  
  
		EndDate = inputItem.EndDate,  
  
		EmploymentDate = inputItem.EmploymentDate,  
  
		EmploymentType = inputItem.EmploymentType,  
  
		NonTaxableAmount = inputItem.NonTaxableAmount,  
  
		HasInsurance = inputItem.HasInsurance,  
  
		HasSupportingInsurance = inputItem.HasSupportingInsurance,  
  
		HasHardJob = inputItem.HasHardJob,  
  
		Description = inputItem.Description,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		HasUnemploymentException = inputItem.HasUnemploymentException,  
  
		EmployerInsuranceExceptionPercent = inputItem.EmployerInsuranceExceptionPercent,  
  
		SupportingInsuranceName = inputItem.SupportingInsuranceName,  
  
		PiofyEmploymentType = inputItem.PiofyEmploymentType,  
  
		IsEmployer = inputItem.IsEmployer,  
  
		HasEmployerInsuranceException = inputItem.HasEmployerInsuranceException, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractElement Map(AddContractElementCommand inputItem)
        {
            var entity = new ContractElement() {
                  
  
		ContractElementId = inputItem.ContractElementId,  
  
		ContractRef = inputItem.ContractRef,  
  
		ElementRef = inputItem.ElementRef,  
  
		Value = inputItem.Value, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractElement Map(ContractElement entity ,EditContractElementCommand inputItem)
        {
              
  
		entity.ContractElementId = inputItem.ContractElementId;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.ElementRef = inputItem.ElementRef;  
  
		entity.Value = inputItem.Value; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractElementDto Map(ContractElement inputItem)
        {
            var dto = new ContractElementDto()
            {
                  
  
		ContractElementId = inputItem.ContractElementId,  
  
		ContractRef = inputItem.ContractRef,  
  
		ElementRef = inputItem.ElementRef,  
  
		Value = inputItem.Value, 
            };
            return dto;
        }

        public static List<ContractElementDto> Map(ICollection<ContractElement> entities)
        {
            var dtos = new List<ContractElementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractElementDto()
                {
                      
  
		ContractElementId = inputItem.ContractElementId,  
  
		ContractRef = inputItem.ContractRef,  
  
		ElementRef = inputItem.ElementRef,  
  
		Value = inputItem.Value, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static DailyHourMinute Map(AddDailyHourMinuteCommand inputItem)
        {
            var entity = new DailyHourMinute() {
                  
  
		DailyHourMinuteId = inputItem.DailyHourMinuteId,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef,  
  
		Year = inputItem.Year,  
  
		DailyHourMinute1 = inputItem.DailyHourMinute1, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DailyHourMinute Map(DailyHourMinute entity ,EditDailyHourMinuteCommand inputItem)
        {
              
  
		entity.DailyHourMinuteId = inputItem.DailyHourMinuteId;  
  
		entity.PayrollConfigurationRef = inputItem.PayrollConfigurationRef;  
  
		entity.Year = inputItem.Year;  
  
		entity.DailyHourMinute1 = inputItem.DailyHourMinute1; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DailyHourMinuteDto Map(DailyHourMinute inputItem)
        {
            var dto = new DailyHourMinuteDto()
            {
                  
  
		DailyHourMinuteId = inputItem.DailyHourMinuteId,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef,  
  
		Year = inputItem.Year,  
  
		DailyHourMinute1 = inputItem.DailyHourMinute1, 
            };
            return dto;
        }

        public static List<DailyHourMinuteDto> Map(ICollection<DailyHourMinute> entities)
        {
            var dtos = new List<DailyHourMinuteDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DailyHourMinuteDto()
                {
                      
  
		DailyHourMinuteId = inputItem.DailyHourMinuteId,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef,  
  
		Year = inputItem.Year,  
  
		DailyHourMinute1 = inputItem.DailyHourMinute1, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Element Map(AddElementCommand inputItem)
        {
            var entity = new Element() {
                  
  
		ElementId = inputItem.ElementId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Class = inputItem.Class,  
  
		Type = inputItem.Type,  
  
		NormalType = inputItem.NormalType,  
  
		AccountRef = inputItem.AccountRef,  
  
		DlType = inputItem.DlType,  
  
		InsuranceCoverage = inputItem.InsuranceCoverage,  
  
		Taxable = inputItem.Taxable,  
  
		UnrelatedToWorkingTime = inputItem.UnrelatedToWorkingTime,  
  
		CalculateForMinWorkingTime = inputItem.CalculateForMinWorkingTime,  
  
		CalculateForMinBase = inputItem.CalculateForMinBase,  
  
		Coefficient = inputItem.Coefficient,  
  
		FixPoint = inputItem.FixPoint,  
  
		DenominatorsType = inputItem.DenominatorsType,  
  
		Denominators = inputItem.Denominators,  
  
		SavingRemainder = inputItem.SavingRemainder,  
  
		//IsActive = inputItem.IsActive,  
  
		DisplayOrder = inputItem.DisplayOrder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		PaymentAccountRef = inputItem.PaymentAccountRef,  
  
		PaymentDlType = inputItem.PaymentDlType, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Element Map(Element entity ,EditElementCommand inputItem)
        {
              
  
		entity.ElementId = inputItem.ElementId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Class = inputItem.Class;  
  
		entity.Type = inputItem.Type;  
  
		entity.NormalType = inputItem.NormalType;  
  
		entity.AccountRef = inputItem.AccountRef;  
  
		entity.DlType = inputItem.DlType;  
  
		entity.InsuranceCoverage = inputItem.InsuranceCoverage;  
  
		entity.Taxable = inputItem.Taxable;  
  
		entity.UnrelatedToWorkingTime = inputItem.UnrelatedToWorkingTime;  
  
		entity.CalculateForMinWorkingTime = inputItem.CalculateForMinWorkingTime;  
  
		entity.CalculateForMinBase = inputItem.CalculateForMinBase;  
  
		entity.Coefficient = inputItem.Coefficient;  
  
		entity.FixPoint = inputItem.FixPoint;  
  
		entity.DenominatorsType = inputItem.DenominatorsType;  
  
		entity.Denominators = inputItem.Denominators;  
  
		entity.SavingRemainder = inputItem.SavingRemainder;  
  
		//entity.IsActive = inputItem.IsActive;  
  
		entity.DisplayOrder = inputItem.DisplayOrder;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.PaymentAccountRef = inputItem.PaymentAccountRef;  
  
		entity.PaymentDlType = inputItem.PaymentDlType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ElementDto Map(Element inputItem)
        {
            var dto = new ElementDto()
            {
                  
  
		ElementId = inputItem.ElementId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Class = inputItem.Class,  
  
		Type = inputItem.Type,  
  
		NormalType = inputItem.NormalType,  
  
		AccountRef = inputItem.AccountRef,  
  
		DlType = inputItem.DlType,  
  
		InsuranceCoverage = inputItem.InsuranceCoverage,  
  
		Taxable = inputItem.Taxable,  
  
		UnrelatedToWorkingTime = inputItem.UnrelatedToWorkingTime,  
  
		CalculateForMinWorkingTime = inputItem.CalculateForMinWorkingTime,  
  
		CalculateForMinBase = inputItem.CalculateForMinBase,  
  
		Coefficient = inputItem.Coefficient,  
  
		FixPoint = inputItem.FixPoint,  
  
		DenominatorsType = inputItem.DenominatorsType,  
  
		Denominators = inputItem.Denominators,  
  
		SavingRemainder = inputItem.SavingRemainder,  
  
		IsActive = inputItem.IsActive,  
  
		DisplayOrder = inputItem.DisplayOrder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		PaymentAccountRef = inputItem.PaymentAccountRef,  
  
		PaymentDlType = inputItem.PaymentDlType, 
            };
            return dto;
        }

        public static List<ElementDto> Map(ICollection<Element> entities)
        {
            var dtos = new List<ElementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ElementDto()
                {
                      
  
		ElementId = inputItem.ElementId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Class = inputItem.Class,  
  
		Type = inputItem.Type,  
  
		NormalType = inputItem.NormalType,  
  
		AccountRef = inputItem.AccountRef,  
  
		DlType = inputItem.DlType,  
  
		InsuranceCoverage = inputItem.InsuranceCoverage,  
  
		Taxable = inputItem.Taxable,  
  
		UnrelatedToWorkingTime = inputItem.UnrelatedToWorkingTime,  
  
		CalculateForMinWorkingTime = inputItem.CalculateForMinWorkingTime,  
  
		CalculateForMinBase = inputItem.CalculateForMinBase,  
  
		Coefficient = inputItem.Coefficient,  
  
		FixPoint = inputItem.FixPoint,  
  
		DenominatorsType = inputItem.DenominatorsType,  
  
		Denominators = inputItem.Denominators,  
  
		SavingRemainder = inputItem.SavingRemainder,  
  
		IsActive = inputItem.IsActive,  
  
		DisplayOrder = inputItem.DisplayOrder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		PaymentAccountRef = inputItem.PaymentAccountRef,  
  
		PaymentDlType = inputItem.PaymentDlType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ElementItem Map(AddElementItemCommand inputItem)
        {
            var entity = new ElementItem() {
                  
  
		ElementItemId = inputItem.ElementItemId,  
  
		ElementRef = inputItem.ElementRef,  
  
		RelatedElementRef = inputItem.RelatedElementRef,  
  
		Coefficient = inputItem.Coefficient,  
  
		Type = inputItem.Type, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ElementItem Map(ElementItem entity ,EditElementItemCommand inputItem)
        {
              
  
		entity.ElementItemId = inputItem.ElementItemId;  
  
		entity.ElementRef = inputItem.ElementRef;  
  
		entity.RelatedElementRef = inputItem.RelatedElementRef;  
  
		entity.Coefficient = inputItem.Coefficient;  
  
		entity.Type = inputItem.Type; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ElementItemDto Map(ElementItem inputItem)
        {
            var dto = new ElementItemDto()
            {
                  
  
		ElementItemId = inputItem.ElementItemId,  
  
		ElementRef = inputItem.ElementRef,  
  
		RelatedElementRef = inputItem.RelatedElementRef,  
  
		Coefficient = inputItem.Coefficient,  
  
		Type = inputItem.Type, 
            };
            return dto;
        }

        public static List<ElementItemDto> Map(ICollection<ElementItem> entities)
        {
            var dtos = new List<ElementItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ElementItemDto()
                {
                      
  
		ElementItemId = inputItem.ElementItemId,  
  
		ElementRef = inputItem.ElementRef,  
  
		RelatedElementRef = inputItem.RelatedElementRef,  
  
		Coefficient = inputItem.Coefficient,  
  
		Type = inputItem.Type, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Job Map(AddJobCommand inputItem)
        {
            var entity = new Job() {
                  
  
		JobId = inputItem.JobId,  
  
		Title_En = inputItem.Title_En,  
  
		HardCode = inputItem.HardCode,  
  
		Title = inputItem.Title,  
  
		Code = inputItem.Code,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		GuildType = inputItem.GuildType, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Job Map(Job entity ,EditJobCommand inputItem)
        {
              
  
		entity.JobId = inputItem.JobId;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.HardCode = inputItem.HardCode;  
  
		entity.Title = inputItem.Title;  
  
		entity.Code = inputItem.Code;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.GuildType = inputItem.GuildType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static JobDto Map(Job inputItem)
        {
            var dto = new JobDto()
            {
                  
  
		JobId = inputItem.JobId,  
  
		Title_En = inputItem.Title_En,  
  
		HardCode = inputItem.HardCode,  
  
		Title = inputItem.Title,  
  
		Code = inputItem.Code,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		GuildType = inputItem.GuildType, 
            };
            return dto;
        }

        public static List<JobDto> Map(ICollection<Job> entities)
        {
            var dtos = new List<JobDto>();
            foreach (var inputItem in entities)
            {
                var dto = new JobDto()
                {
                      
  
		JobId = inputItem.JobId,  
  
		Title_En = inputItem.Title_En,  
  
		HardCode = inputItem.HardCode,  
  
		Title = inputItem.Title,  
  
		Code = inputItem.Code,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		GuildType = inputItem.GuildType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Leave Map(AddLeaveCommand inputItem)
        {
            var entity = new Leave() {
                  
  
		LeaveId = inputItem.LeaveId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		SystemRemainder = inputItem.SystemRemainder,  
  
		UserRemainder = inputItem.UserRemainder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Solaryear = inputItem.Solaryear,  
  
		Month = inputItem.Month, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Leave Map(Leave entity ,EditLeaveCommand inputItem)
        {
              
  
		entity.LeaveId = inputItem.LeaveId;  
  
		entity.PersonnelRef = inputItem.PersonnelRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.SystemRemainder = inputItem.SystemRemainder;  
  
		entity.UserRemainder = inputItem.UserRemainder;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Solaryear = inputItem.Solaryear;  
  
		entity.Month = inputItem.Month; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static LeaveDto Map(Leave inputItem)
        {
            var dto = new LeaveDto()
            {
                  
  
		LeaveId = inputItem.LeaveId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		SystemRemainder = inputItem.SystemRemainder,  
  
		UserRemainder = inputItem.UserRemainder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Solaryear = inputItem.Solaryear,  
  
		Month = inputItem.Month, 
            };
            return dto;
        }

        public static List<LeaveDto> Map(ICollection<Leave> entities)
        {
            var dtos = new List<LeaveDto>();
            foreach (var inputItem in entities)
            {
                var dto = new LeaveDto()
                {
                      
  
		LeaveId = inputItem.LeaveId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		SystemRemainder = inputItem.SystemRemainder,  
  
		UserRemainder = inputItem.UserRemainder,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Solaryear = inputItem.Solaryear,  
  
		Month = inputItem.Month, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Loan Map(AddLoanCommand inputItem)
        {
            var entity = new Loan() {
                  
  
		LoanID = inputItem.LoanID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Loan Map(Loan entity ,EditLoanCommand inputItem)
        {
              
  
		entity.LoanID = inputItem.LoanID;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static LoanDto Map(Loan inputItem)
        {
            var dto = new LoanDto()
            {
                  
  
		LoanID = inputItem.LoanID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<LoanDto> Map(ICollection<Loan> entities)
        {
            var dtos = new List<LoanDto>();
            foreach (var inputItem in entities)
            {
                var dto = new LoanDto()
                {
                      
  
		LoanID = inputItem.LoanID,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MonthlyData Map(AddMonthlyDataCommand inputItem)
        {
            var entity = new MonthlyData() {
                  
  
		MonthlyDataId = inputItem.MonthlyDataId,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MonthlyData Map(MonthlyData entity ,EditMonthlyDataCommand inputItem)
        {
              
  
		entity.MonthlyDataId = inputItem.MonthlyDataId;  
  
		entity.Date = inputItem.Date;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MonthlyDataDto Map(MonthlyData inputItem)
        {
            var dto = new MonthlyDataDto()
            {
                  
  
		MonthlyDataId = inputItem.MonthlyDataId,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<MonthlyDataDto> Map(ICollection<MonthlyData> entities)
        {
            var dtos = new List<MonthlyDataDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MonthlyDataDto()
                {
                      
  
		MonthlyDataId = inputItem.MonthlyDataId,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MonthlyDataPersonnel Map(AddMonthlyDataPersonnelCommand inputItem)
        {
            var entity = new MonthlyDataPersonnel() {
                  
  
		MonthlyDataPersonnelId = inputItem.MonthlyDataPersonnelId,  
  
		MonthlyDataRef = inputItem.MonthlyDataRef,  
  
		PersonnelRef = inputItem.PersonnelRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MonthlyDataPersonnel Map(MonthlyDataPersonnel entity ,EditMonthlyDataPersonnelCommand inputItem)
        {
              
  
		entity.MonthlyDataPersonnelId = inputItem.MonthlyDataPersonnelId;  
  
		entity.MonthlyDataRef = inputItem.MonthlyDataRef;  
  
		entity.PersonnelRef = inputItem.PersonnelRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MonthlyDataPersonnelDto Map(MonthlyDataPersonnel inputItem)
        {
            var dto = new MonthlyDataPersonnelDto()
            {
                  
  
		MonthlyDataPersonnelId = inputItem.MonthlyDataPersonnelId,  
  
		MonthlyDataRef = inputItem.MonthlyDataRef,  
  
		PersonnelRef = inputItem.PersonnelRef, 
            };
            return dto;
        }

        public static List<MonthlyDataPersonnelDto> Map(ICollection<MonthlyDataPersonnel> entities)
        {
            var dtos = new List<MonthlyDataPersonnelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MonthlyDataPersonnelDto()
                {
                      
  
		MonthlyDataPersonnelId = inputItem.MonthlyDataPersonnelId,  
  
		MonthlyDataRef = inputItem.MonthlyDataRef,  
  
		PersonnelRef = inputItem.PersonnelRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static MonthlyDataPersonnelElement Map(AddMonthlyDataPersonnelElementCommand inputItem)
        {
            var entity = new MonthlyDataPersonnelElement() {
                  
  
		MonthlyDataPersonnelElementlId = inputItem.MonthlyDataPersonnelElementlId,  
  
		MonthlyDataPersonnelRef = inputItem.MonthlyDataPersonnelRef,  
  
		Type = inputItem.Type,  
  
		ElementRef = inputItem.ElementRef,  
  
		Value = inputItem.Value, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static MonthlyDataPersonnelElement Map(MonthlyDataPersonnelElement entity ,EditMonthlyDataPersonnelElementCommand inputItem)
        {
              
  
		entity.MonthlyDataPersonnelElementlId = inputItem.MonthlyDataPersonnelElementlId;  
  
		entity.MonthlyDataPersonnelRef = inputItem.MonthlyDataPersonnelRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.ElementRef = inputItem.ElementRef;  
  
		entity.Value = inputItem.Value; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static MonthlyDataPersonnelElementDto Map(MonthlyDataPersonnelElement inputItem)
        {
            var dto = new MonthlyDataPersonnelElementDto()
            {
                  
  
		MonthlyDataPersonnelElementlId = inputItem.MonthlyDataPersonnelElementlId,  
  
		MonthlyDataPersonnelRef = inputItem.MonthlyDataPersonnelRef,  
  
		Type = inputItem.Type,  
  
		ElementRef = inputItem.ElementRef,  
  
		Value = inputItem.Value, 
            };
            return dto;
        }

        public static List<MonthlyDataPersonnelElementDto> Map(ICollection<MonthlyDataPersonnelElement> entities)
        {
            var dtos = new List<MonthlyDataPersonnelElementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new MonthlyDataPersonnelElementDto()
                {
                      
  
		MonthlyDataPersonnelElementlId = inputItem.MonthlyDataPersonnelElementlId,  
  
		MonthlyDataPersonnelRef = inputItem.MonthlyDataPersonnelRef,  
  
		Type = inputItem.Type,  
  
		ElementRef = inputItem.ElementRef,  
  
		Value = inputItem.Value, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayrollCalendar Map(AddPayrollCalendarCommand inputItem)
        {
            var entity = new PayrollCalendar() {
                  
  
		PayrollCalendarId = inputItem.PayrollCalendarId,  
  
		Year = inputItem.Year,  
  
		Month = inputItem.Month,  
  
		Day = inputItem.Day,  
  
		HourMinute = inputItem.HourMinute,  
  
		TotalHourMinute = inputItem.TotalHourMinute,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayrollCalendar Map(PayrollCalendar entity ,EditPayrollCalendarCommand inputItem)
        {
              
  
		entity.PayrollCalendarId = inputItem.PayrollCalendarId;  
  
		entity.Year = inputItem.Year;  
  
		entity.Month = inputItem.Month;  
  
		entity.Day = inputItem.Day;  
  
		entity.HourMinute = inputItem.HourMinute;  
  
		entity.TotalHourMinute = inputItem.TotalHourMinute;  
  
		entity.PayrollConfigurationRef = inputItem.PayrollConfigurationRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayrollCalendarDto Map(PayrollCalendar inputItem)
        {
            var dto = new PayrollCalendarDto()
            {
                  
  
		PayrollCalendarId = inputItem.PayrollCalendarId,  
  
		Year = inputItem.Year,  
  
		Month = inputItem.Month,  
  
		Day = inputItem.Day,  
  
		HourMinute = inputItem.HourMinute,  
  
		TotalHourMinute = inputItem.TotalHourMinute,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef, 
            };
            return dto;
        }

        public static List<PayrollCalendarDto> Map(ICollection<PayrollCalendar> entities)
        {
            var dtos = new List<PayrollCalendarDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayrollCalendarDto()
                {
                      
  
		PayrollCalendarId = inputItem.PayrollCalendarId,  
  
		Year = inputItem.Year,  
  
		Month = inputItem.Month,  
  
		Day = inputItem.Day,  
  
		HourMinute = inputItem.HourMinute,  
  
		TotalHourMinute = inputItem.TotalHourMinute,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayrollConfiguration Map(AddPayrollConfigurationCommand inputItem)
        {
            var entity = new PayrollConfiguration() {
                  
  
		PayrollConfigurationId = inputItem.PayrollConfigurationId,  
  
		TopDailyInsurance = inputItem.TopDailyInsurance,  
  
		EmployeeInsurancePercent = inputItem.EmployeeInsurancePercent,  
  
		EmployerInsurancePercent = inputItem.EmployerInsurancePercent,  
  
		UnemploymentInsurancePercent = inputItem.UnemploymentInsurancePercent,  
  
		HardWorkInsurance = inputItem.HardWorkInsurance,  
  
		SocialSecurityAccountRef = inputItem.SocialSecurityAccountRef,  
  
		UnemploymentAccountRef = inputItem.UnemploymentAccountRef,  
  
		PaymentSocialSecurityAccountRef = inputItem.PaymentSocialSecurityAccountRef,  
  
		NonTaxableSocialSecurityPercent = inputItem.NonTaxableSocialSecurityPercent,  
  
		SupportingInsurancePercent = inputItem.SupportingInsurancePercent,  
  
		PaymentInsuranceAccountRef = inputItem.PaymentInsuranceAccountRef,  
  
		SupportingInsuranceEmployeeElementRef = inputItem.SupportingInsuranceEmployeeElementRef,  
  
		SupportingInsuranceEmployerElementRef = inputItem.SupportingInsuranceEmployerElementRef,  
  
		SupportingInsuranceCostAccountRef = inputItem.SupportingInsuranceCostAccountRef,  
  
		PaymentSupportingInsuranceAccountRef = inputItem.PaymentSupportingInsuranceAccountRef,  
  
		TopMonthlyLeave = inputItem.TopMonthlyLeave,  
  
		TransferYearlyLeave = inputItem.TransferYearlyLeave,  
  
		LeaveCostAccountRef = inputItem.LeaveCostAccountRef,  
  
		LeaveSavingAccountRef = inputItem.LeaveSavingAccountRef,  
  
		TopNewYearBonus = inputItem.TopNewYearBonus,  
  
		NewYearBonusBaseFactor = inputItem.NewYearBonusBaseFactor,  
  
		NonTaxableNewYearBonus = inputItem.NonTaxableNewYearBonus,  
  
		NonTaxbleBonusRelatedToWorkTime = inputItem.NonTaxbleBonusRelatedToWorkTime,  
  
		NewYearBonuCostAccountRef = inputItem.NewYearBonuCostAccountRef,  
  
		WorkingHistoryYearlyDay = inputItem.WorkingHistoryYearlyDay,  
  
		WorkingHistorySavingAccountRef = inputItem.WorkingHistorySavingAccountRef,  
  
		WorkingHistoryCostAccountRef = inputItem.WorkingHistoryCostAccountRef,  
  
		PaymentRound = inputItem.PaymentRound,  
  
		PaymentAccountRef = inputItem.PaymentAccountRef,  
  
		PaymentRoundAccountRef = inputItem.PaymentRoundAccountRef,  
  
		EmployeesCurrentAccountRef = inputItem.EmployeesCurrentAccountRef,  
  
		CalculateNegativeTax = inputItem.CalculateNegativeTax,  
  
		ShowAvailableLeaveInFish = inputItem.ShowAvailableLeaveInFish,  
  
		LoanAccountRef = inputItem.LoanAccountRef,  
  
		ShowAvailableLeaveInPayFish = inputItem.ShowAvailableLeaveInPayFish, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayrollConfiguration Map(PayrollConfiguration entity ,EditPayrollConfigurationCommand inputItem)
        {
              
  
		entity.PayrollConfigurationId = inputItem.PayrollConfigurationId;  
  
		entity.TopDailyInsurance = inputItem.TopDailyInsurance;  
  
		entity.EmployeeInsurancePercent = inputItem.EmployeeInsurancePercent;  
  
		entity.EmployerInsurancePercent = inputItem.EmployerInsurancePercent;  
  
		entity.UnemploymentInsurancePercent = inputItem.UnemploymentInsurancePercent;  
  
		entity.HardWorkInsurance = inputItem.HardWorkInsurance;  
  
		entity.SocialSecurityAccountRef = inputItem.SocialSecurityAccountRef;  
  
		entity.UnemploymentAccountRef = inputItem.UnemploymentAccountRef;  
  
		entity.PaymentSocialSecurityAccountRef = inputItem.PaymentSocialSecurityAccountRef;  
  
		entity.NonTaxableSocialSecurityPercent = inputItem.NonTaxableSocialSecurityPercent;  
  
		entity.SupportingInsurancePercent = inputItem.SupportingInsurancePercent;  
  
		entity.PaymentInsuranceAccountRef = inputItem.PaymentInsuranceAccountRef;  
  
		entity.SupportingInsuranceEmployeeElementRef = inputItem.SupportingInsuranceEmployeeElementRef;  
  
		entity.SupportingInsuranceEmployerElementRef = inputItem.SupportingInsuranceEmployerElementRef;  
  
		entity.SupportingInsuranceCostAccountRef = inputItem.SupportingInsuranceCostAccountRef;  
  
		entity.PaymentSupportingInsuranceAccountRef = inputItem.PaymentSupportingInsuranceAccountRef;  
  
		entity.TopMonthlyLeave = inputItem.TopMonthlyLeave;  
  
		entity.TransferYearlyLeave = inputItem.TransferYearlyLeave;  
  
		entity.LeaveCostAccountRef = inputItem.LeaveCostAccountRef;  
  
		entity.LeaveSavingAccountRef = inputItem.LeaveSavingAccountRef;  
  
		entity.TopNewYearBonus = inputItem.TopNewYearBonus;  
  
		entity.NewYearBonusBaseFactor = inputItem.NewYearBonusBaseFactor;  
  
		entity.NonTaxableNewYearBonus = inputItem.NonTaxableNewYearBonus;  
  
		entity.NonTaxbleBonusRelatedToWorkTime = inputItem.NonTaxbleBonusRelatedToWorkTime;  
  
		entity.NewYearBonuCostAccountRef = inputItem.NewYearBonuCostAccountRef;  
  
		entity.WorkingHistoryYearlyDay = inputItem.WorkingHistoryYearlyDay;  
  
		entity.WorkingHistorySavingAccountRef = inputItem.WorkingHistorySavingAccountRef;  
  
		entity.WorkingHistoryCostAccountRef = inputItem.WorkingHistoryCostAccountRef;  
  
		entity.PaymentRound = inputItem.PaymentRound;  
  
		entity.PaymentAccountRef = inputItem.PaymentAccountRef;  
  
		entity.PaymentRoundAccountRef = inputItem.PaymentRoundAccountRef;  
  
		entity.EmployeesCurrentAccountRef = inputItem.EmployeesCurrentAccountRef;  
  
		entity.CalculateNegativeTax = inputItem.CalculateNegativeTax;  
  
		entity.ShowAvailableLeaveInFish = inputItem.ShowAvailableLeaveInFish;  
  
		entity.LoanAccountRef = inputItem.LoanAccountRef;  
  
		entity.ShowAvailableLeaveInPayFish = inputItem.ShowAvailableLeaveInPayFish; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayrollConfigurationDto Map(PayrollConfiguration inputItem)
        {
            var dto = new PayrollConfigurationDto()
            {
                  
  
		PayrollConfigurationId = inputItem.PayrollConfigurationId,  
  
		TopDailyInsurance = inputItem.TopDailyInsurance,  
  
		EmployeeInsurancePercent = inputItem.EmployeeInsurancePercent,  
  
		EmployerInsurancePercent = inputItem.EmployerInsurancePercent,  
  
		UnemploymentInsurancePercent = inputItem.UnemploymentInsurancePercent,  
  
		HardWorkInsurance = inputItem.HardWorkInsurance,  
  
		SocialSecurityAccountRef = inputItem.SocialSecurityAccountRef,  
  
		UnemploymentAccountRef = inputItem.UnemploymentAccountRef,  
  
		PaymentSocialSecurityAccountRef = inputItem.PaymentSocialSecurityAccountRef,  
  
		NonTaxableSocialSecurityPercent = inputItem.NonTaxableSocialSecurityPercent,  
  
		SupportingInsurancePercent = inputItem.SupportingInsurancePercent,  
  
		PaymentInsuranceAccountRef = inputItem.PaymentInsuranceAccountRef,  
  
		SupportingInsuranceEmployeeElementRef = inputItem.SupportingInsuranceEmployeeElementRef,  
  
		SupportingInsuranceEmployerElementRef = inputItem.SupportingInsuranceEmployerElementRef,  
  
		SupportingInsuranceCostAccountRef = inputItem.SupportingInsuranceCostAccountRef,  
  
		PaymentSupportingInsuranceAccountRef = inputItem.PaymentSupportingInsuranceAccountRef,  
  
		TopMonthlyLeave = inputItem.TopMonthlyLeave,  
  
		TransferYearlyLeave = inputItem.TransferYearlyLeave,  
  
		LeaveCostAccountRef = inputItem.LeaveCostAccountRef,  
  
		LeaveSavingAccountRef = inputItem.LeaveSavingAccountRef,  
  
		TopNewYearBonus = inputItem.TopNewYearBonus,  
  
		NewYearBonusBaseFactor = inputItem.NewYearBonusBaseFactor,  
  
		NonTaxableNewYearBonus = inputItem.NonTaxableNewYearBonus,  
  
		NonTaxbleBonusRelatedToWorkTime = inputItem.NonTaxbleBonusRelatedToWorkTime,  
  
		NewYearBonuCostAccountRef = inputItem.NewYearBonuCostAccountRef,  
  
		WorkingHistoryYearlyDay = inputItem.WorkingHistoryYearlyDay,  
  
		WorkingHistorySavingAccountRef = inputItem.WorkingHistorySavingAccountRef,  
  
		WorkingHistoryCostAccountRef = inputItem.WorkingHistoryCostAccountRef,  
  
		PaymentRound = inputItem.PaymentRound,  
  
		PaymentAccountRef = inputItem.PaymentAccountRef,  
  
		PaymentRoundAccountRef = inputItem.PaymentRoundAccountRef,  
  
		EmployeesCurrentAccountRef = inputItem.EmployeesCurrentAccountRef,  
  
		CalculateNegativeTax = inputItem.CalculateNegativeTax,  
  
		ShowAvailableLeaveInFish = inputItem.ShowAvailableLeaveInFish,  
  
		LoanAccountRef = inputItem.LoanAccountRef,  
  
		ShowAvailableLeaveInPayFish = inputItem.ShowAvailableLeaveInPayFish, 
            };
            return dto;
        }

        public static List<PayrollConfigurationDto> Map(ICollection<PayrollConfiguration> entities)
        {
            var dtos = new List<PayrollConfigurationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayrollConfigurationDto()
                {
                      
  
		PayrollConfigurationId = inputItem.PayrollConfigurationId,  
  
		TopDailyInsurance = inputItem.TopDailyInsurance,  
  
		EmployeeInsurancePercent = inputItem.EmployeeInsurancePercent,  
  
		EmployerInsurancePercent = inputItem.EmployerInsurancePercent,  
  
		UnemploymentInsurancePercent = inputItem.UnemploymentInsurancePercent,  
  
		HardWorkInsurance = inputItem.HardWorkInsurance,  
  
		SocialSecurityAccountRef = inputItem.SocialSecurityAccountRef,  
  
		UnemploymentAccountRef = inputItem.UnemploymentAccountRef,  
  
		PaymentSocialSecurityAccountRef = inputItem.PaymentSocialSecurityAccountRef,  
  
		NonTaxableSocialSecurityPercent = inputItem.NonTaxableSocialSecurityPercent,  
  
		SupportingInsurancePercent = inputItem.SupportingInsurancePercent,  
  
		PaymentInsuranceAccountRef = inputItem.PaymentInsuranceAccountRef,  
  
		SupportingInsuranceEmployeeElementRef = inputItem.SupportingInsuranceEmployeeElementRef,  
  
		SupportingInsuranceEmployerElementRef = inputItem.SupportingInsuranceEmployerElementRef,  
  
		SupportingInsuranceCostAccountRef = inputItem.SupportingInsuranceCostAccountRef,  
  
		PaymentSupportingInsuranceAccountRef = inputItem.PaymentSupportingInsuranceAccountRef,  
  
		TopMonthlyLeave = inputItem.TopMonthlyLeave,  
  
		TransferYearlyLeave = inputItem.TransferYearlyLeave,  
  
		LeaveCostAccountRef = inputItem.LeaveCostAccountRef,  
  
		LeaveSavingAccountRef = inputItem.LeaveSavingAccountRef,  
  
		TopNewYearBonus = inputItem.TopNewYearBonus,  
  
		NewYearBonusBaseFactor = inputItem.NewYearBonusBaseFactor,  
  
		NonTaxableNewYearBonus = inputItem.NonTaxableNewYearBonus,  
  
		NonTaxbleBonusRelatedToWorkTime = inputItem.NonTaxbleBonusRelatedToWorkTime,  
  
		NewYearBonuCostAccountRef = inputItem.NewYearBonuCostAccountRef,  
  
		WorkingHistoryYearlyDay = inputItem.WorkingHistoryYearlyDay,  
  
		WorkingHistorySavingAccountRef = inputItem.WorkingHistorySavingAccountRef,  
  
		WorkingHistoryCostAccountRef = inputItem.WorkingHistoryCostAccountRef,  
  
		PaymentRound = inputItem.PaymentRound,  
  
		PaymentAccountRef = inputItem.PaymentAccountRef,  
  
		PaymentRoundAccountRef = inputItem.PaymentRoundAccountRef,  
  
		EmployeesCurrentAccountRef = inputItem.EmployeesCurrentAccountRef,  
  
		CalculateNegativeTax = inputItem.CalculateNegativeTax,  
  
		ShowAvailableLeaveInFish = inputItem.ShowAvailableLeaveInFish,  
  
		LoanAccountRef = inputItem.LoanAccountRef,  
  
		ShowAvailableLeaveInPayFish = inputItem.ShowAvailableLeaveInPayFish, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PayrollConfigurationElement Map(AddPayrollConfigurationElementCommand inputItem)
        {
            var entity = new PayrollConfigurationElement() {
                  
  
		PayrollConfigurationElementId = inputItem.PayrollConfigurationElementId,  
  
		ElementRef = inputItem.ElementRef,  
  
		Coefficient = inputItem.Coefficient,  
  
		Type = inputItem.Type,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PayrollConfigurationElement Map(PayrollConfigurationElement entity ,EditPayrollConfigurationElementCommand inputItem)
        {
              
  
		entity.PayrollConfigurationElementId = inputItem.PayrollConfigurationElementId;  
  
		entity.ElementRef = inputItem.ElementRef;  
  
		entity.Coefficient = inputItem.Coefficient;  
  
		entity.Type = inputItem.Type;  
  
		entity.PayrollConfigurationRef = inputItem.PayrollConfigurationRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PayrollConfigurationElementDto Map(PayrollConfigurationElement inputItem)
        {
            var dto = new PayrollConfigurationElementDto()
            {
                  
  
		PayrollConfigurationElementId = inputItem.PayrollConfigurationElementId,  
  
		ElementRef = inputItem.ElementRef,  
  
		Coefficient = inputItem.Coefficient,  
  
		Type = inputItem.Type,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef, 
            };
            return dto;
        }

        public static List<PayrollConfigurationElementDto> Map(ICollection<PayrollConfigurationElement> entities)
        {
            var dtos = new List<PayrollConfigurationElementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PayrollConfigurationElementDto()
                {
                      
  
		PayrollConfigurationElementId = inputItem.PayrollConfigurationElementId,  
  
		ElementRef = inputItem.ElementRef,  
  
		Coefficient = inputItem.Coefficient,  
  
		Type = inputItem.Type,  
  
		PayrollConfigurationRef = inputItem.PayrollConfigurationRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Personnel Map(AddPersonnelCommand inputItem)
        {
            var entity = new Personnel() {
                  
  
		PersonnelId = inputItem.PersonnelId,  
  
		PartyRef = inputItem.PartyRef,  
  
		BirthIdentity = inputItem.BirthIdentity,  
  
		BirthSerial = inputItem.BirthSerial,  
  
		BirthLocationRef = inputItem.BirthLocationRef,  
  
		FatherName = inputItem.FatherName,  
  
		Nationality = inputItem.Nationality,  
  
		MarriageStatus = inputItem.MarriageStatus,  
  
		StatusDate = inputItem.StatusDate,  
  
		Children = inputItem.Children,  
  
		FamilyCount = inputItem.FamilyCount,  
  
		EducationDegree = inputItem.EducationDegree,  
  
		EducationField = inputItem.EducationField,  
  
		InsuranceNumber = inputItem.InsuranceNumber,  
  
		SupportInsuranceNumber = inputItem.SupportInsuranceNumber,  
  
		InsuranceDay = inputItem.InsuranceDay,  
  
		MilitaryStatus = inputItem.MilitaryStatus,  
  
		BankRef = inputItem.BankRef,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		AccountTypeRef = inputItem.AccountTypeRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		Sex = inputItem.Sex,  
  
		EmployeeStatus = inputItem.EmployeeStatus, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Personnel Map(Personnel entity ,EditPersonnelCommand inputItem)
        {
              
  
		entity.PersonnelId = inputItem.PersonnelId;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.BirthIdentity = inputItem.BirthIdentity;  
  
		entity.BirthSerial = inputItem.BirthSerial;  
  
		entity.BirthLocationRef = inputItem.BirthLocationRef;  
  
		entity.FatherName = inputItem.FatherName;  
  
		entity.Nationality = inputItem.Nationality;  
  
		entity.MarriageStatus = inputItem.MarriageStatus;  
  
		entity.StatusDate = inputItem.StatusDate;  
  
		entity.Children = inputItem.Children;  
  
		entity.FamilyCount = inputItem.FamilyCount;  
  
		entity.EducationDegree = inputItem.EducationDegree;  
  
		entity.EducationField = inputItem.EducationField;  
  
		entity.InsuranceNumber = inputItem.InsuranceNumber;  
  
		entity.SupportInsuranceNumber = inputItem.SupportInsuranceNumber;  
  
		entity.InsuranceDay = inputItem.InsuranceDay;  
  
		entity.MilitaryStatus = inputItem.MilitaryStatus;  
  
		entity.BankRef = inputItem.BankRef;  
  
		entity.BankBranchRef = inputItem.BankBranchRef;  
  
		entity.AccountTypeRef = inputItem.AccountTypeRef;  
  
		entity.AccountNo = inputItem.AccountNo;  
  
		entity.Sex = inputItem.Sex;  
  
		entity.EmployeeStatus = inputItem.EmployeeStatus; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PersonnelDto Map(Personnel inputItem)
        {
            var dto = new PersonnelDto()
            {
                  
  
		PersonnelId = inputItem.PersonnelId,  
  
		PartyRef = inputItem.PartyRef,  
  
		BirthIdentity = inputItem.BirthIdentity,  
  
		BirthSerial = inputItem.BirthSerial,  
  
		BirthLocationRef = inputItem.BirthLocationRef,  
  
		FatherName = inputItem.FatherName,  
  
		Nationality = inputItem.Nationality,  
  
		MarriageStatus = inputItem.MarriageStatus,  
  
		StatusDate = inputItem.StatusDate,  
  
		Children = inputItem.Children,  
  
		FamilyCount = inputItem.FamilyCount,  
  
		EducationDegree = inputItem.EducationDegree,  
  
		EducationField = inputItem.EducationField,  
  
		InsuranceNumber = inputItem.InsuranceNumber,  
  
		SupportInsuranceNumber = inputItem.SupportInsuranceNumber,  
  
		InsuranceDay = inputItem.InsuranceDay,  
  
		MilitaryStatus = inputItem.MilitaryStatus,  
  
		BankRef = inputItem.BankRef,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		AccountTypeRef = inputItem.AccountTypeRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		Sex = inputItem.Sex,  
  
		EmployeeStatus = inputItem.EmployeeStatus, 
            };
            return dto;
        }

        public static List<PersonnelDto> Map(ICollection<Personnel> entities)
        {
            var dtos = new List<PersonnelDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PersonnelDto()
                {
                      
  
		PersonnelId = inputItem.PersonnelId,  
  
		PartyRef = inputItem.PartyRef,  
  
		BirthIdentity = inputItem.BirthIdentity,  
  
		BirthSerial = inputItem.BirthSerial,  
  
		BirthLocationRef = inputItem.BirthLocationRef,  
  
		FatherName = inputItem.FatherName,  
  
		Nationality = inputItem.Nationality,  
  
		MarriageStatus = inputItem.MarriageStatus,  
  
		StatusDate = inputItem.StatusDate,  
  
		Children = inputItem.Children,  
  
		FamilyCount = inputItem.FamilyCount,  
  
		EducationDegree = inputItem.EducationDegree,  
  
		EducationField = inputItem.EducationField,  
  
		InsuranceNumber = inputItem.InsuranceNumber,  
  
		SupportInsuranceNumber = inputItem.SupportInsuranceNumber,  
  
		InsuranceDay = inputItem.InsuranceDay,  
  
		MilitaryStatus = inputItem.MilitaryStatus,  
  
		BankRef = inputItem.BankRef,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		AccountTypeRef = inputItem.AccountTypeRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		Sex = inputItem.Sex,  
  
		EmployeeStatus = inputItem.EmployeeStatus, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PersonnelInitiate Map(AddPersonnelInitiateCommand inputItem)
        {
            var entity = new PersonnelInitiate() {
                  
  
		PersonnelInitiateId = inputItem.PersonnelInitiateId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		SumYearlyWorkingTimeDay = inputItem.SumYearlyWorkingTimeDay,  
  
		SumYearlyTaxableIncome = inputItem.SumYearlyTaxableIncome,  
  
		SumYearlyTax = inputItem.SumYearlyTax,  
  
		WorkHistoryDay = inputItem.WorkHistoryDay,  
  
		WorkHistorySaving = inputItem.WorkHistorySaving,  
  
		LeaveRemain = inputItem.LeaveRemain,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Type = inputItem.Type,  
  
		PaymentRound = inputItem.PaymentRound,  
  
		BaseDate = inputItem.BaseDate,  
  
		NewyearBonusWorkingTime = inputItem.NewyearBonusWorkingTime,  
  
		NewyearBonusSaving = inputItem.NewyearBonusSaving, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PersonnelInitiate Map(PersonnelInitiate entity ,EditPersonnelInitiateCommand inputItem)
        {
              
  
		entity.PersonnelInitiateId = inputItem.PersonnelInitiateId;  
  
		entity.PersonnelRef = inputItem.PersonnelRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.SumYearlyWorkingTimeDay = inputItem.SumYearlyWorkingTimeDay;  
  
		entity.SumYearlyTaxableIncome = inputItem.SumYearlyTaxableIncome;  
  
		entity.SumYearlyTax = inputItem.SumYearlyTax;  
  
		entity.WorkHistoryDay = inputItem.WorkHistoryDay;  
  
		entity.WorkHistorySaving = inputItem.WorkHistorySaving;  
  
		entity.LeaveRemain = inputItem.LeaveRemain;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Type = inputItem.Type;  
  
		entity.PaymentRound = inputItem.PaymentRound;  
  
		entity.BaseDate = inputItem.BaseDate;  
  
		entity.NewyearBonusWorkingTime = inputItem.NewyearBonusWorkingTime;  
  
		entity.NewyearBonusSaving = inputItem.NewyearBonusSaving; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PersonnelInitiateDto Map(PersonnelInitiate inputItem)
        {
            var dto = new PersonnelInitiateDto()
            {
                  
  
		PersonnelInitiateId = inputItem.PersonnelInitiateId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		SumYearlyWorkingTimeDay = inputItem.SumYearlyWorkingTimeDay,  
  
		SumYearlyTaxableIncome = inputItem.SumYearlyTaxableIncome,  
  
		SumYearlyTax = inputItem.SumYearlyTax,  
  
		WorkHistoryDay = inputItem.WorkHistoryDay,  
  
		WorkHistorySaving = inputItem.WorkHistorySaving,  
  
		LeaveRemain = inputItem.LeaveRemain,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Type = inputItem.Type,  
  
		PaymentRound = inputItem.PaymentRound,  
  
		BaseDate = inputItem.BaseDate,  
  
		NewyearBonusWorkingTime = inputItem.NewyearBonusWorkingTime,  
  
		NewyearBonusSaving = inputItem.NewyearBonusSaving, 
            };
            return dto;
        }

        public static List<PersonnelInitiateDto> Map(ICollection<PersonnelInitiate> entities)
        {
            var dtos = new List<PersonnelInitiateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PersonnelInitiateDto()
                {
                      
  
		PersonnelInitiateId = inputItem.PersonnelInitiateId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		Date = inputItem.Date,  
  
		SumYearlyWorkingTimeDay = inputItem.SumYearlyWorkingTimeDay,  
  
		SumYearlyTaxableIncome = inputItem.SumYearlyTaxableIncome,  
  
		SumYearlyTax = inputItem.SumYearlyTax,  
  
		WorkHistoryDay = inputItem.WorkHistoryDay,  
  
		WorkHistorySaving = inputItem.WorkHistorySaving,  
  
		LeaveRemain = inputItem.LeaveRemain,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Type = inputItem.Type,  
  
		PaymentRound = inputItem.PaymentRound,  
  
		BaseDate = inputItem.BaseDate,  
  
		NewyearBonusWorkingTime = inputItem.NewyearBonusWorkingTime,  
  
		NewyearBonusSaving = inputItem.NewyearBonusSaving, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PersonnelInitiateElement Map(AddPersonnelInitiateElementCommand inputItem)
        {
            var entity = new PersonnelInitiateElement() {
                  
  
		PersonnelInitiateElementId = inputItem.PersonnelInitiateElementId,  
  
		ElementRef = inputItem.ElementRef,  
  
		Amount = inputItem.Amount,  
  
		PersonnelInitiateRef = inputItem.PersonnelInitiateRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PersonnelInitiateElement Map(PersonnelInitiateElement entity ,EditPersonnelInitiateElementCommand inputItem)
        {
              
  
		entity.PersonnelInitiateElementId = inputItem.PersonnelInitiateElementId;  
  
		entity.ElementRef = inputItem.ElementRef;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.PersonnelInitiateRef = inputItem.PersonnelInitiateRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PersonnelInitiateElementDto Map(PersonnelInitiateElement inputItem)
        {
            var dto = new PersonnelInitiateElementDto()
            {
                  
  
		PersonnelInitiateElementId = inputItem.PersonnelInitiateElementId,  
  
		ElementRef = inputItem.ElementRef,  
  
		Amount = inputItem.Amount,  
  
		PersonnelInitiateRef = inputItem.PersonnelInitiateRef, 
            };
            return dto;
        }

        public static List<PersonnelInitiateElementDto> Map(ICollection<PersonnelInitiateElement> entities)
        {
            var dtos = new List<PersonnelInitiateElementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PersonnelInitiateElementDto()
                {
                      
  
		PersonnelInitiateElementId = inputItem.PersonnelInitiateElementId,  
  
		ElementRef = inputItem.ElementRef,  
  
		Amount = inputItem.Amount,  
  
		PersonnelInitiateRef = inputItem.PersonnelInitiateRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PersonnelTaxFileInfoChangeLog Map(AddPersonnelTaxFileInfoChangeLogCommand inputItem)
        {
            var entity = new PersonnelTaxFileInfoChangeLog() {
                  
  
		PersonnelTaxFileInfoChangeLogId = inputItem.PersonnelTaxFileInfoChangeLogId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		ChangeInfoDate = inputItem.ChangeInfoDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PersonnelTaxFileInfoChangeLog Map(PersonnelTaxFileInfoChangeLog entity ,EditPersonnelTaxFileInfoChangeLogCommand inputItem)
        {
              
  
		entity.PersonnelTaxFileInfoChangeLogId = inputItem.PersonnelTaxFileInfoChangeLogId;  
  
		entity.PersonnelRef = inputItem.PersonnelRef;  
  
		entity.ChangeInfoDate = inputItem.ChangeInfoDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PersonnelTaxFileInfoChangeLogDto Map(PersonnelTaxFileInfoChangeLog inputItem)
        {
            var dto = new PersonnelTaxFileInfoChangeLogDto()
            {
                  
  
		PersonnelTaxFileInfoChangeLogId = inputItem.PersonnelTaxFileInfoChangeLogId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		ChangeInfoDate = inputItem.ChangeInfoDate, 
            };
            return dto;
        }

        public static List<PersonnelTaxFileInfoChangeLogDto> Map(ICollection<PersonnelTaxFileInfoChangeLog> entities)
        {
            var dtos = new List<PersonnelTaxFileInfoChangeLogDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PersonnelTaxFileInfoChangeLogDto()
                {
                      
  
		PersonnelTaxFileInfoChangeLogId = inputItem.PersonnelTaxFileInfoChangeLogId,  
  
		PersonnelRef = inputItem.PersonnelRef,  
  
		ChangeInfoDate = inputItem.ChangeInfoDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PiofyAttendanceFactor Map(AddPiofyAttendanceFactorCommand inputItem)
        {
            var entity = new PiofyAttendanceFactor() {
                  
  
		PiofyAttendanceFactorId = inputItem.PiofyAttendanceFactorId,  
  
		Code = inputItem.Code,  
  
		MeasurementUnit = inputItem.MeasurementUnit,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PiofyAttendanceFactor Map(PiofyAttendanceFactor entity ,EditPiofyAttendanceFactorCommand inputItem)
        {
              
  
		entity.PiofyAttendanceFactorId = inputItem.PiofyAttendanceFactorId;  
  
		entity.Code = inputItem.Code;  
  
		entity.MeasurementUnit = inputItem.MeasurementUnit;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PiofyAttendanceFactorDto Map(PiofyAttendanceFactor inputItem)
        {
            var dto = new PiofyAttendanceFactorDto()
            {
                  
  
		PiofyAttendanceFactorId = inputItem.PiofyAttendanceFactorId,  
  
		Code = inputItem.Code,  
  
		MeasurementUnit = inputItem.MeasurementUnit,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<PiofyAttendanceFactorDto> Map(ICollection<PiofyAttendanceFactor> entities)
        {
            var dtos = new List<PiofyAttendanceFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PiofyAttendanceFactorDto()
                {
                      
  
		PiofyAttendanceFactorId = inputItem.PiofyAttendanceFactorId,  
  
		Code = inputItem.Code,  
  
		MeasurementUnit = inputItem.MeasurementUnit,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PiofyAttendanceFactorMapper Map(AddPiofyAttendanceFactorMapperCommand inputItem)
        {
            var entity = new PiofyAttendanceFactorMapper() {
                  
  
		PiofyAttendanceFactorMapperId = inputItem.PiofyAttendanceFactorMapperId,  
  
		ElementRef = inputItem.ElementRef,  
  
		PiofyAttendanceFactorRef = inputItem.PiofyAttendanceFactorRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PiofyAttendanceFactorMapper Map(PiofyAttendanceFactorMapper entity ,EditPiofyAttendanceFactorMapperCommand inputItem)
        {
              
  
		entity.PiofyAttendanceFactorMapperId = inputItem.PiofyAttendanceFactorMapperId;  
  
		entity.ElementRef = inputItem.ElementRef;  
  
		entity.PiofyAttendanceFactorRef = inputItem.PiofyAttendanceFactorRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PiofyAttendanceFactorMapperDto Map(PiofyAttendanceFactorMapper inputItem)
        {
            var dto = new PiofyAttendanceFactorMapperDto()
            {
                  
  
		PiofyAttendanceFactorMapperId = inputItem.PiofyAttendanceFactorMapperId,  
  
		ElementRef = inputItem.ElementRef,  
  
		PiofyAttendanceFactorRef = inputItem.PiofyAttendanceFactorRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<PiofyAttendanceFactorMapperDto> Map(ICollection<PiofyAttendanceFactorMapper> entities)
        {
            var dtos = new List<PiofyAttendanceFactorMapperDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PiofyAttendanceFactorMapperDto()
                {
                      
  
		PiofyAttendanceFactorMapperId = inputItem.PiofyAttendanceFactorMapperId,  
  
		ElementRef = inputItem.ElementRef,  
  
		PiofyAttendanceFactorRef = inputItem.PiofyAttendanceFactorRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PiofyMonthlyCalculation Map(AddPiofyMonthlyCalculationCommand inputItem)
        {
            var entity = new PiofyMonthlyCalculation() {
                  
  
		PiofyMonthlyCalculationId = inputItem.PiofyMonthlyCalculationId,  
  
		YMCode = inputItem.YMCode,  
  
		EmployeeID = inputItem.EmployeeID,  
  
		FactorCode = inputItem.FactorCode,  
  
		DayValue = inputItem.DayValue,  
  
		HourValue = inputItem.HourValue,  
  
		MinuteValue = inputItem.MinuteValue,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		State = inputItem.State, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PiofyMonthlyCalculation Map(PiofyMonthlyCalculation entity ,EditPiofyMonthlyCalculationCommand inputItem)
        {
              
  
		entity.PiofyMonthlyCalculationId = inputItem.PiofyMonthlyCalculationId;  
  
		entity.YMCode = inputItem.YMCode;  
  
		entity.EmployeeID = inputItem.EmployeeID;  
  
		entity.FactorCode = inputItem.FactorCode;  
  
		entity.DayValue = inputItem.DayValue;  
  
		entity.HourValue = inputItem.HourValue;  
  
		entity.MinuteValue = inputItem.MinuteValue;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.State = inputItem.State; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PiofyMonthlyCalculationDto Map(PiofyMonthlyCalculation inputItem)
        {
            var dto = new PiofyMonthlyCalculationDto()
            {
                  
  
		PiofyMonthlyCalculationId = inputItem.PiofyMonthlyCalculationId,  
  
		YMCode = inputItem.YMCode,  
  
		EmployeeID = inputItem.EmployeeID,  
  
		FactorCode = inputItem.FactorCode,  
  
		DayValue = inputItem.DayValue,  
  
		HourValue = inputItem.HourValue,  
  
		MinuteValue = inputItem.MinuteValue,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		State = inputItem.State, 
            };
            return dto;
        }

        public static List<PiofyMonthlyCalculationDto> Map(ICollection<PiofyMonthlyCalculation> entities)
        {
            var dtos = new List<PiofyMonthlyCalculationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PiofyMonthlyCalculationDto()
                {
                      
  
		PiofyMonthlyCalculationId = inputItem.PiofyMonthlyCalculationId,  
  
		YMCode = inputItem.YMCode,  
  
		EmployeeID = inputItem.EmployeeID,  
  
		FactorCode = inputItem.FactorCode,  
  
		DayValue = inputItem.DayValue,  
  
		HourValue = inputItem.HourValue,  
  
		MinuteValue = inputItem.MinuteValue,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		State = inputItem.State, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaySettlement Map(AddPaySettlementCommand inputItem)
        {
            var entity = new PaySettlement() {
                  
  
		SettlementID = inputItem.SettlementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		NetPay = inputItem.NetPay,  
  
		NewYearBonusNet = inputItem.NewYearBonusNet,  
  
		LeaveRepayment = inputItem.LeaveRepayment,  
  
		WorkingHistoryRepayment = inputItem.WorkingHistoryRepayment,  
  
		NotsettledShredAmount = inputItem.NotsettledShredAmount,  
  
		Total = inputItem.Total,  
  
		Description = inputItem.Description,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaySettlement Map(PaySettlement entity ,EditPaySettlementCommand inputItem)
        {
              
  
		entity.SettlementID = inputItem.SettlementID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.AccountingVoucherRef = inputItem.AccountingVoucherRef;  
  
		entity.NetPay = inputItem.NetPay;  
  
		entity.NewYearBonusNet = inputItem.NewYearBonusNet;  
  
		entity.LeaveRepayment = inputItem.LeaveRepayment;  
  
		entity.WorkingHistoryRepayment = inputItem.WorkingHistoryRepayment;  
  
		entity.NotsettledShredAmount = inputItem.NotsettledShredAmount;  
  
		entity.Total = inputItem.Total;  
  
		entity.Description = inputItem.Description;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaySettlementDto Map(PaySettlement inputItem)
        {
            var dto = new PaySettlementDto()
            {
                  
  
		SettlementID = inputItem.SettlementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		NetPay = inputItem.NetPay,  
  
		NewYearBonusNet = inputItem.NewYearBonusNet,  
  
		LeaveRepayment = inputItem.LeaveRepayment,  
  
		WorkingHistoryRepayment = inputItem.WorkingHistoryRepayment,  
  
		NotsettledShredAmount = inputItem.NotsettledShredAmount,  
  
		Total = inputItem.Total,  
  
		Description = inputItem.Description,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PaySettlementDto> Map(ICollection<PaySettlement> entities)
        {
            var dtos = new List<PaySettlementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaySettlementDto()
                {
                      
  
		SettlementID = inputItem.SettlementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		NetPay = inputItem.NetPay,  
  
		NewYearBonusNet = inputItem.NewYearBonusNet,  
  
		LeaveRepayment = inputItem.LeaveRepayment,  
  
		WorkingHistoryRepayment = inputItem.WorkingHistoryRepayment,  
  
		NotsettledShredAmount = inputItem.NotsettledShredAmount,  
  
		Total = inputItem.Total,  
  
		Description = inputItem.Description,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PaySettlementItem Map(AddPaySettlementItemCommand inputItem)
        {
            var entity = new PaySettlementItem() {
                  
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Amount = inputItem.Amount,  
  
		AccoungSLRef = inputItem.AccoungSLRef,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PaySettlementItem Map(PaySettlementItem entity ,EditPaySettlementItemCommand inputItem)
        {
              
  
		entity.SettlementItemID = inputItem.SettlementItemID;  
  
		entity.SettlementRef = inputItem.SettlementRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.AccoungSLRef = inputItem.AccoungSLRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PaySettlementItemDto Map(PaySettlementItem inputItem)
        {
            var dto = new PaySettlementItemDto()
            {
                  
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Amount = inputItem.Amount,  
  
		AccoungSLRef = inputItem.AccoungSLRef,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<PaySettlementItemDto> Map(ICollection<PaySettlementItem> entities)
        {
            var dtos = new List<PaySettlementItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PaySettlementItemDto()
                {
                      
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Amount = inputItem.Amount,  
  
		AccoungSLRef = inputItem.AccoungSLRef,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TaxGroup Map(AddTaxGroupCommand inputItem)
        {
            var entity = new TaxGroup() {
                  
  
		TaxGroupId = inputItem.TaxGroupId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TaxGroup Map(TaxGroup entity ,EditTaxGroupCommand inputItem)
        {
              
  
		entity.TaxGroupId = inputItem.TaxGroupId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Type = inputItem.Type;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TaxGroupDto Map(TaxGroup inputItem)
        {
            var dto = new TaxGroupDto()
            {
                  
  
		TaxGroupId = inputItem.TaxGroupId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<TaxGroupDto> Map(ICollection<TaxGroup> entities)
        {
            var dtos = new List<TaxGroupDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TaxGroupDto()
                {
                      
  
		TaxGroupId = inputItem.TaxGroupId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TaxTable Map(AddTaxTableCommand inputItem)
        {
            var entity = new TaxTable() {
                  
  
		TaxTableId = inputItem.TaxTableId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		TaxGroupRef = inputItem.TaxGroupRef,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TaxTable Map(TaxTable entity ,EditTaxTableCommand inputItem)
        {
              
  
		entity.TaxTableId = inputItem.TaxTableId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.TaxGroupRef = inputItem.TaxGroupRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TaxTableDto Map(TaxTable inputItem)
        {
            var dto = new TaxTableDto()
            {
                  
  
		TaxTableId = inputItem.TaxTableId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		TaxGroupRef = inputItem.TaxGroupRef,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<TaxTableDto> Map(ICollection<TaxTable> entities)
        {
            var dtos = new List<TaxTableDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TaxTableDto()
                {
                      
  
		TaxTableId = inputItem.TaxTableId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		TaxGroupRef = inputItem.TaxGroupRef,  
  
		Date = inputItem.Date,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static TaxTableItem Map(AddTaxTableItemCommand inputItem)
        {
            var entity = new TaxTableItem() {
                  
  
		TaxTableItemId = inputItem.TaxTableItemId,  
  
		FromAmount = inputItem.FromAmount,  
  
		ToAmount = inputItem.ToAmount,  
  
		Rate = inputItem.Rate,  
  
		TaxTableRef = inputItem.TaxTableRef,  
  
		InLineAmount = inputItem.InLineAmount,  
  
		PartialAmount = inputItem.PartialAmount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static TaxTableItem Map(TaxTableItem entity ,EditTaxTableItemCommand inputItem)
        {
              
  
		entity.TaxTableItemId = inputItem.TaxTableItemId;  
  
		entity.FromAmount = inputItem.FromAmount;  
  
		entity.ToAmount = inputItem.ToAmount;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.TaxTableRef = inputItem.TaxTableRef;  
  
		entity.InLineAmount = inputItem.InLineAmount;  
  
		entity.PartialAmount = inputItem.PartialAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TaxTableItemDto Map(TaxTableItem inputItem)
        {
            var dto = new TaxTableItemDto()
            {
                  
  
		TaxTableItemId = inputItem.TaxTableItemId,  
  
		FromAmount = inputItem.FromAmount,  
  
		ToAmount = inputItem.ToAmount,  
  
		Rate = inputItem.Rate,  
  
		TaxTableRef = inputItem.TaxTableRef,  
  
		InLineAmount = inputItem.InLineAmount,  
  
		PartialAmount = inputItem.PartialAmount, 
            };
            return dto;
        }

        public static List<TaxTableItemDto> Map(ICollection<TaxTableItem> entities)
        {
            var dtos = new List<TaxTableItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TaxTableItemDto()
                {
                      
  
		TaxTableItemId = inputItem.TaxTableItemId,  
  
		FromAmount = inputItem.FromAmount,  
  
		ToAmount = inputItem.ToAmount,  
  
		Rate = inputItem.Rate,  
  
		TaxTableRef = inputItem.TaxTableRef,  
  
		InLineAmount = inputItem.InLineAmount,  
  
		PartialAmount = inputItem.PartialAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static WorkExperience Map(AddWorkExperienceCommand inputItem)
        {
            var entity = new WorkExperience() {
                  
  
		WorkExperienceId = inputItem.WorkExperienceId,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Duration = inputItem.Duration,  
  
		Company = inputItem.Company,  
  
		Career = inputItem.Career,  
  
		QuitReason = inputItem.QuitReason,  
  
		PersonnelRef = inputItem.PersonnelRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static WorkExperience Map(WorkExperience entity ,EditWorkExperienceCommand inputItem)
        {
              
  
		entity.WorkExperienceId = inputItem.WorkExperienceId;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.Duration = inputItem.Duration;  
  
		entity.Company = inputItem.Company;  
  
		entity.Career = inputItem.Career;  
  
		entity.QuitReason = inputItem.QuitReason;  
  
		entity.PersonnelRef = inputItem.PersonnelRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WorkExperienceDto Map(WorkExperience inputItem)
        {
            var dto = new WorkExperienceDto()
            {
                  
  
		WorkExperienceId = inputItem.WorkExperienceId,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Duration = inputItem.Duration,  
  
		Company = inputItem.Company,  
  
		Career = inputItem.Career,  
  
		QuitReason = inputItem.QuitReason,  
  
		PersonnelRef = inputItem.PersonnelRef, 
            };
            return dto;
        }

        public static List<WorkExperienceDto> Map(ICollection<WorkExperience> entities)
        {
            var dtos = new List<WorkExperienceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WorkExperienceDto()
                {
                      
  
		WorkExperienceId = inputItem.WorkExperienceId,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Duration = inputItem.Duration,  
  
		Company = inputItem.Company,  
  
		Career = inputItem.Career,  
  
		QuitReason = inputItem.QuitReason,  
  
		PersonnelRef = inputItem.PersonnelRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Worksite Map(AddWorksiteCommand inputItem)
        {
            var entity = new Worksite() {
                  
  
		WorksiteId = inputItem.WorksiteId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Worksite Map(Worksite entity ,EditWorksiteCommand inputItem)
        {
              
  
		entity.WorksiteId = inputItem.WorksiteId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Code = inputItem.Code;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WorksiteDto Map(Worksite inputItem)
        {
            var dto = new WorksiteDto()
            {
                  
  
		WorksiteId = inputItem.WorksiteId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<WorksiteDto> Map(ICollection<Worksite> entities)
        {
            var dtos = new List<WorksiteDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WorksiteDto()
                {
                      
  
		WorksiteId = inputItem.WorksiteId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Code = inputItem.Code,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}

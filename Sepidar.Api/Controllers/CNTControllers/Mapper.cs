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
                
        
        public static ChangeItem Map(AddChangeItemCommand inputItem)
        {
            var entity = new ChangeItem() {
                  
  
		ChangeID = inputItem.ChangeID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		PrimaryFee = inputItem.PrimaryFee,  
  
		ChangeAmount = inputItem.ChangeAmount,  
  
		ChangeAmountType = inputItem.ChangeAmountType,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ChangeItem Map(ChangeItem entity ,EditChangeItemCommand inputItem)
        {
              
  
		entity.ChangeID = inputItem.ChangeID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.Date = inputItem.Date;  
  
		entity.Type = inputItem.Type;  
  
		entity.PrimaryFee = inputItem.PrimaryFee;  
  
		entity.ChangeAmount = inputItem.ChangeAmount;  
  
		entity.ChangeAmountType = inputItem.ChangeAmountType;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ChangeItemDto Map(ChangeItem inputItem)
        {
            var dto = new ChangeItemDto()
            {
                  
  
		ChangeID = inputItem.ChangeID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		PrimaryFee = inputItem.PrimaryFee,  
  
		ChangeAmount = inputItem.ChangeAmount,  
  
		ChangeAmountType = inputItem.ChangeAmountType,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<ChangeItemDto> Map(ICollection<ChangeItem> entities)
        {
            var dtos = new List<ChangeItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ChangeItemDto()
                {
                      
  
		ChangeID = inputItem.ChangeID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		PrimaryFee = inputItem.PrimaryFee,  
  
		ChangeAmount = inputItem.ChangeAmount,  
  
		ChangeAmountType = inputItem.ChangeAmountType,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Coefficient Map(AddCoefficientCommand inputItem)
        {
            var entity = new Coefficient() {
                  
  
		CoefficientID = inputItem.CoefficientID,  
  
		Nature = inputItem.Nature,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Percent = inputItem.Percent,  
  
		Type = inputItem.Type,  
  
		SLRef = inputItem.SLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Coefficient Map(Coefficient entity ,EditCoefficientCommand inputItem)
        {
              
  
		entity.CoefficientID = inputItem.CoefficientID;  
  
		entity.Nature = inputItem.Nature;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.Percent = inputItem.Percent;  
  
		entity.Type = inputItem.Type;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CoefficientDto Map(Coefficient inputItem)
        {
            var dto = new CoefficientDto()
            {
                  
  
		CoefficientID = inputItem.CoefficientID,  
  
		Nature = inputItem.Nature,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Percent = inputItem.Percent,  
  
		Type = inputItem.Type,  
  
		SLRef = inputItem.SLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<CoefficientDto> Map(ICollection<Coefficient> entities)
        {
            var dtos = new List<CoefficientDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CoefficientDto()
                {
                      
  
		CoefficientID = inputItem.CoefficientID,  
  
		Nature = inputItem.Nature,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		Percent = inputItem.Percent,  
  
		Type = inputItem.Type,  
  
		SLRef = inputItem.SLRef,  
  
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
        
        public static Contract Map(AddContractCommand inputItem)
        {
            var entity = new Contract() {
                  
  
		ContractID = inputItem.ContractID,  
  
		ProjectRef = inputItem.ProjectRef,  
  
		Date = inputItem.Date,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ContractorPartyRef = inputItem.ContractorPartyRef,  
  
		Location = inputItem.Location,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Cost = inputItem.Cost,  
  
		DLRef = inputItem.DLRef,  
  
		ContractTypeRef = inputItem.ContractTypeRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AllowedChangePercent = inputItem.AllowedChangePercent,  
  
		Established = inputItem.Established,  
  
		EstimatedCost = inputItem.EstimatedCost,  
  
		DepositSum = inputItem.DepositSum,  
  
		MaterialSum = inputItem.MaterialSum,  
  
		DepositDepreciationPercent = inputItem.DepositDepreciationPercent,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		TenderRef = inputItem.TenderRef,  
  
		CancelDate = inputItem.CancelDate,  
  
		ContractRef = inputItem.ContractRef,  
  
		Type = inputItem.Type,  
  
		AffectedChange = inputItem.AffectedChange,  
  
		PrimaryFee = inputItem.PrimaryFee,  
  
		ChangeAmount = inputItem.ChangeAmount,  
  
		ChangeAmountType = inputItem.ChangeAmountType,  
  
		RowNumber = inputItem.RowNumber,  
  
		AnnexDocumentNumber = inputItem.AnnexDocumentNumber,  
  
		AnnexDate = inputItem.AnnexDate,  
  
		OldChangeID = inputItem.OldChangeID,  
  
		Nature = inputItem.Nature,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ContractRowNumber = inputItem.ContractRowNumber,  
  
		ContractDLType = inputItem.ContractDLType,  
  
		ParentContractRef = inputItem.ParentContractRef,  
  
		IsActive = inputItem.IsActive,  
  
		OnAccountSum = inputItem.OnAccountSum,  
  
		OnAccountDepreciationPercent = inputItem.OnAccountDepreciationPercent,  
  
		NeedsBillSerial = inputItem.NeedsBillSerial, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Contract Map(Contract entity ,EditContractCommand inputItem)
        {
              
  
		entity.ContractID = inputItem.ContractID;  
  
		entity.ProjectRef = inputItem.ProjectRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.ContractorPartyRef = inputItem.ContractorPartyRef;  
  
		entity.Location = inputItem.Location;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.Cost = inputItem.Cost;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.ContractTypeRef = inputItem.ContractTypeRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.AllowedChangePercent = inputItem.AllowedChangePercent;  
  
		entity.Established = inputItem.Established;  
  
		entity.EstimatedCost = inputItem.EstimatedCost;  
  
		entity.DepositSum = inputItem.DepositSum;  
  
		entity.MaterialSum = inputItem.MaterialSum;  
  
		entity.DepositDepreciationPercent = inputItem.DepositDepreciationPercent;  
  
		entity.DocumentNumber = inputItem.DocumentNumber;  
  
		entity.TenderRef = inputItem.TenderRef;  
  
		entity.CancelDate = inputItem.CancelDate;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.AffectedChange = inputItem.AffectedChange;  
  
		entity.PrimaryFee = inputItem.PrimaryFee;  
  
		entity.ChangeAmount = inputItem.ChangeAmount;  
  
		entity.ChangeAmountType = inputItem.ChangeAmountType;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.AnnexDocumentNumber = inputItem.AnnexDocumentNumber;  
  
		entity.AnnexDate = inputItem.AnnexDate;  
  
		entity.OldChangeID = inputItem.OldChangeID;  
  
		entity.Nature = inputItem.Nature;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.ContractRowNumber = inputItem.ContractRowNumber;  
  
		entity.ContractDLType = inputItem.ContractDLType;  
  
		entity.ParentContractRef = inputItem.ParentContractRef;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.OnAccountSum = inputItem.OnAccountSum;  
  
		entity.OnAccountDepreciationPercent = inputItem.OnAccountDepreciationPercent;  
  
		entity.NeedsBillSerial = inputItem.NeedsBillSerial; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractDto Map(Contract inputItem)
        {
            var dto = new ContractDto()
            {
                  
  
		ContractID = inputItem.ContractID,  
  
		ProjectRef = inputItem.ProjectRef,  
  
		Date = inputItem.Date,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ContractorPartyRef = inputItem.ContractorPartyRef,  
  
		Location = inputItem.Location,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Cost = inputItem.Cost,  
  
		DLRef = inputItem.DLRef,  
  
		ContractTypeRef = inputItem.ContractTypeRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AllowedChangePercent = inputItem.AllowedChangePercent,  
  
		Established = inputItem.Established,  
  
		EstimatedCost = inputItem.EstimatedCost,  
  
		DepositSum = inputItem.DepositSum,  
  
		MaterialSum = inputItem.MaterialSum,  
  
		DepositDepreciationPercent = inputItem.DepositDepreciationPercent,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		TenderRef = inputItem.TenderRef,  
  
		CancelDate = inputItem.CancelDate,  
  
		ContractRef = inputItem.ContractRef,  
  
		Type = inputItem.Type,  
  
		AffectedChange = inputItem.AffectedChange,  
  
		PrimaryFee = inputItem.PrimaryFee,  
  
		ChangeAmount = inputItem.ChangeAmount,  
  
		ChangeAmountType = inputItem.ChangeAmountType,  
  
		RowNumber = inputItem.RowNumber,  
  
		AnnexDocumentNumber = inputItem.AnnexDocumentNumber,  
  
		AnnexDate = inputItem.AnnexDate,  
  
		OldChangeID = inputItem.OldChangeID,  
  
		Nature = inputItem.Nature,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ContractRowNumber = inputItem.ContractRowNumber,  
  
		ContractDLType = inputItem.ContractDLType,  
  
		ParentContractRef = inputItem.ParentContractRef,  
  
		IsActive = inputItem.IsActive,  
  
		OnAccountSum = inputItem.OnAccountSum,  
  
		OnAccountDepreciationPercent = inputItem.OnAccountDepreciationPercent,  
  
		NeedsBillSerial = inputItem.NeedsBillSerial, 
            };
            return dto;
        }

        public static List<ContractDto> Map(ICollection<Contract> entities)
        {
            var dtos = new List<ContractDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractDto()
                {
                      
  
		ContractID = inputItem.ContractID,  
  
		ProjectRef = inputItem.ProjectRef,  
  
		Date = inputItem.Date,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ContractorPartyRef = inputItem.ContractorPartyRef,  
  
		Location = inputItem.Location,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Cost = inputItem.Cost,  
  
		DLRef = inputItem.DLRef,  
  
		ContractTypeRef = inputItem.ContractTypeRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		AllowedChangePercent = inputItem.AllowedChangePercent,  
  
		Established = inputItem.Established,  
  
		EstimatedCost = inputItem.EstimatedCost,  
  
		DepositSum = inputItem.DepositSum,  
  
		MaterialSum = inputItem.MaterialSum,  
  
		DepositDepreciationPercent = inputItem.DepositDepreciationPercent,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		TenderRef = inputItem.TenderRef,  
  
		CancelDate = inputItem.CancelDate,  
  
		ContractRef = inputItem.ContractRef,  
  
		Type = inputItem.Type,  
  
		AffectedChange = inputItem.AffectedChange,  
  
		PrimaryFee = inputItem.PrimaryFee,  
  
		ChangeAmount = inputItem.ChangeAmount,  
  
		ChangeAmountType = inputItem.ChangeAmountType,  
  
		RowNumber = inputItem.RowNumber,  
  
		AnnexDocumentNumber = inputItem.AnnexDocumentNumber,  
  
		AnnexDate = inputItem.AnnexDate,  
  
		OldChangeID = inputItem.OldChangeID,  
  
		Nature = inputItem.Nature,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ContractRowNumber = inputItem.ContractRowNumber,  
  
		ContractDLType = inputItem.ContractDLType,  
  
		ParentContractRef = inputItem.ParentContractRef,  
  
		IsActive = inputItem.IsActive,  
  
		OnAccountSum = inputItem.OnAccountSum,  
  
		OnAccountDepreciationPercent = inputItem.OnAccountDepreciationPercent,  
  
		NeedsBillSerial = inputItem.NeedsBillSerial, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractAgreementItem Map(AddContractAgreementItemCommand inputItem)
        {
            var entity = new ContractAgreementItem() {
                  
  
		ContractAgreementItemID = inputItem.ContractAgreementItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		ContractPriceListFieldTitle = inputItem.ContractPriceListFieldTitle,  
  
		ContractPriceListChapterTitle = inputItem.ContractPriceListChapterTitle,  
  
		ContractPriceListClassTitle = inputItem.ContractPriceListClassTitle,  
  
		OperationalYear = inputItem.OperationalYear,  
  
		OperationCode = inputItem.OperationCode,  
  
		OperationDescription = inputItem.OperationDescription,  
  
		OperationUnit = inputItem.OperationUnit,  
  
		OperationFee = inputItem.OperationFee,  
  
		Quantity = inputItem.Quantity,  
  
		Price = inputItem.Price,  
  
		PrvOperationFee = inputItem.PrvOperationFee,  
  
		PrvQuantity = inputItem.PrvQuantity,  
  
		PrvPrice = inputItem.PrvPrice,  
  
		ContractAgreementItemRef = inputItem.ContractAgreementItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractAgreementItem Map(ContractAgreementItem entity ,EditContractAgreementItemCommand inputItem)
        {
              
  
		entity.ContractAgreementItemID = inputItem.ContractAgreementItemID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.ContractPriceListFieldTitle = inputItem.ContractPriceListFieldTitle;  
  
		entity.ContractPriceListChapterTitle = inputItem.ContractPriceListChapterTitle;  
  
		entity.ContractPriceListClassTitle = inputItem.ContractPriceListClassTitle;  
  
		entity.OperationalYear = inputItem.OperationalYear;  
  
		entity.OperationCode = inputItem.OperationCode;  
  
		entity.OperationDescription = inputItem.OperationDescription;  
  
		entity.OperationUnit = inputItem.OperationUnit;  
  
		entity.OperationFee = inputItem.OperationFee;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.Price = inputItem.Price;  
  
		entity.PrvOperationFee = inputItem.PrvOperationFee;  
  
		entity.PrvQuantity = inputItem.PrvQuantity;  
  
		entity.PrvPrice = inputItem.PrvPrice;  
  
		entity.ContractAgreementItemRef = inputItem.ContractAgreementItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractAgreementItemDto Map(ContractAgreementItem inputItem)
        {
            var dto = new ContractAgreementItemDto()
            {
                  
  
		ContractAgreementItemID = inputItem.ContractAgreementItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		ContractPriceListFieldTitle = inputItem.ContractPriceListFieldTitle,  
  
		ContractPriceListChapterTitle = inputItem.ContractPriceListChapterTitle,  
  
		ContractPriceListClassTitle = inputItem.ContractPriceListClassTitle,  
  
		OperationalYear = inputItem.OperationalYear,  
  
		OperationCode = inputItem.OperationCode,  
  
		OperationDescription = inputItem.OperationDescription,  
  
		OperationUnit = inputItem.OperationUnit,  
  
		OperationFee = inputItem.OperationFee,  
  
		Quantity = inputItem.Quantity,  
  
		Price = inputItem.Price,  
  
		PrvOperationFee = inputItem.PrvOperationFee,  
  
		PrvQuantity = inputItem.PrvQuantity,  
  
		PrvPrice = inputItem.PrvPrice,  
  
		ContractAgreementItemRef = inputItem.ContractAgreementItemRef, 
            };
            return dto;
        }

        public static List<ContractAgreementItemDto> Map(ICollection<ContractAgreementItem> entities)
        {
            var dtos = new List<ContractAgreementItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractAgreementItemDto()
                {
                      
  
		ContractAgreementItemID = inputItem.ContractAgreementItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		ContractPriceListFieldTitle = inputItem.ContractPriceListFieldTitle,  
  
		ContractPriceListChapterTitle = inputItem.ContractPriceListChapterTitle,  
  
		ContractPriceListClassTitle = inputItem.ContractPriceListClassTitle,  
  
		OperationalYear = inputItem.OperationalYear,  
  
		OperationCode = inputItem.OperationCode,  
  
		OperationDescription = inputItem.OperationDescription,  
  
		OperationUnit = inputItem.OperationUnit,  
  
		OperationFee = inputItem.OperationFee,  
  
		Quantity = inputItem.Quantity,  
  
		Price = inputItem.Price,  
  
		PrvOperationFee = inputItem.PrvOperationFee,  
  
		PrvQuantity = inputItem.PrvQuantity,  
  
		PrvPrice = inputItem.PrvPrice,  
  
		ContractAgreementItemRef = inputItem.ContractAgreementItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractCoefficientItem Map(AddContractCoefficientItemCommand inputItem)
        {
            var entity = new ContractCoefficientItem() {
                  
  
		ContractCoefficientID = inputItem.ContractCoefficientID,  
  
		RowNumber = inputItem.RowNumber,  
  
		CoefficientRef = inputItem.CoefficientRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		Percent = inputItem.Percent, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractCoefficientItem Map(ContractCoefficientItem entity ,EditContractCoefficientItemCommand inputItem)
        {
              
  
		entity.ContractCoefficientID = inputItem.ContractCoefficientID;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.CoefficientRef = inputItem.CoefficientRef;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.Percent = inputItem.Percent; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractCoefficientItemDto Map(ContractCoefficientItem inputItem)
        {
            var dto = new ContractCoefficientItemDto()
            {
                  
  
		ContractCoefficientID = inputItem.ContractCoefficientID,  
  
		RowNumber = inputItem.RowNumber,  
  
		CoefficientRef = inputItem.CoefficientRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		Percent = inputItem.Percent, 
            };
            return dto;
        }

        public static List<ContractCoefficientItemDto> Map(ICollection<ContractCoefficientItem> entities)
        {
            var dtos = new List<ContractCoefficientItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractCoefficientItemDto()
                {
                      
  
		ContractCoefficientID = inputItem.ContractCoefficientID,  
  
		RowNumber = inputItem.RowNumber,  
  
		CoefficientRef = inputItem.CoefficientRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		Percent = inputItem.Percent, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractCompromiseItem Map(AddContractCompromiseItemCommand inputItem)
        {
            var entity = new ContractCompromiseItem() {
                  
  
		ContractCompromiseItemID = inputItem.ContractCompromiseItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractCompromiseItem Map(ContractCompromiseItem entity ,EditContractCompromiseItemCommand inputItem)
        {
              
  
		entity.ContractCompromiseItemID = inputItem.ContractCompromiseItemID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractCompromiseItemDto Map(ContractCompromiseItem inputItem)
        {
            var dto = new ContractCompromiseItemDto()
            {
                  
  
		ContractCompromiseItemID = inputItem.ContractCompromiseItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<ContractCompromiseItemDto> Map(ICollection<ContractCompromiseItem> entities)
        {
            var dtos = new List<ContractCompromiseItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractCompromiseItemDto()
                {
                      
  
		ContractCompromiseItemID = inputItem.ContractCompromiseItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		Date = inputItem.Date,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractEmployerMaterialsItem Map(AddContractEmployerMaterialsItemCommand inputItem)
        {
            var entity = new ContractEmployerMaterialsItem() {
                  
  
		EmployerMaterialsID = inputItem.EmployerMaterialsID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		ReceiptNumber = inputItem.ReceiptNumber,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		TracingRef = inputItem.TracingRef,  
  
		TotalPrice = inputItem.TotalPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractEmployerMaterialsItem Map(ContractEmployerMaterialsItem entity ,EditContractEmployerMaterialsItemCommand inputItem)
        {
              
  
		entity.EmployerMaterialsID = inputItem.EmployerMaterialsID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.Date = inputItem.Date;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.ReceiptRef = inputItem.ReceiptRef;  
  
		entity.ReceiptNumber = inputItem.ReceiptNumber;  
  
		entity.InventoryDeliveryRef = inputItem.InventoryDeliveryRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.TotalPrice = inputItem.TotalPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractEmployerMaterialsItemDto Map(ContractEmployerMaterialsItem inputItem)
        {
            var dto = new ContractEmployerMaterialsItemDto()
            {
                  
  
		EmployerMaterialsID = inputItem.EmployerMaterialsID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		ReceiptNumber = inputItem.ReceiptNumber,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		TracingRef = inputItem.TracingRef,  
  
		TotalPrice = inputItem.TotalPrice, 
            };
            return dto;
        }

        public static List<ContractEmployerMaterialsItemDto> Map(ICollection<ContractEmployerMaterialsItem> entities)
        {
            var dtos = new List<ContractEmployerMaterialsItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractEmployerMaterialsItemDto()
                {
                      
  
		EmployerMaterialsID = inputItem.EmployerMaterialsID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		StockRef = inputItem.StockRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		ReceiptNumber = inputItem.ReceiptNumber,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		TracingRef = inputItem.TracingRef,  
  
		TotalPrice = inputItem.TotalPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractPreReceiptItem Map(AddContractPreReceiptItemCommand inputItem)
        {
            var entity = new ContractPreReceiptItem() {
                  
  
		PreReceiptID = inputItem.PreReceiptID,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		ReceiptNumber = inputItem.ReceiptNumber,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		Price = inputItem.Price,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractPreReceiptItem Map(ContractPreReceiptItem entity ,EditContractPreReceiptItemCommand inputItem)
        {
              
  
		entity.PreReceiptID = inputItem.PreReceiptID;  
  
		entity.ReceiptRef = inputItem.ReceiptRef;  
  
		entity.ReceiptNumber = inputItem.ReceiptNumber;  
  
		entity.PaymentRef = inputItem.PaymentRef;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.Date = inputItem.Date;  
  
		entity.Price = inputItem.Price;  
  
		entity.Type = inputItem.Type;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractPreReceiptItemDto Map(ContractPreReceiptItem inputItem)
        {
            var dto = new ContractPreReceiptItemDto()
            {
                  
  
		PreReceiptID = inputItem.PreReceiptID,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		ReceiptNumber = inputItem.ReceiptNumber,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		Price = inputItem.Price,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<ContractPreReceiptItemDto> Map(ICollection<ContractPreReceiptItem> entities)
        {
            var dtos = new List<ContractPreReceiptItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractPreReceiptItemDto()
                {
                      
  
		PreReceiptID = inputItem.PreReceiptID,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		ReceiptNumber = inputItem.ReceiptNumber,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Date = inputItem.Date,  
  
		Price = inputItem.Price,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractPriceList Map(AddContractPriceListCommand inputItem)
        {
            var entity = new ContractPriceList() {
                  
  
		ContractPriceListID = inputItem.ContractPriceListID,  
  
		ContractPriceListChapterTitle = inputItem.ContractPriceListChapterTitle,  
  
		ContractPriceListClassTitle = inputItem.ContractPriceListClassTitle,  
  
		ContractPriceListFieldTitle = inputItem.ContractPriceListFieldTitle,  
  
		OperationalYear = inputItem.OperationalYear,  
  
		OperationCode = inputItem.OperationCode,  
  
		OperationDescription = inputItem.OperationDescription,  
  
		OperationUnit = inputItem.OperationUnit,  
  
		OperationFee = inputItem.OperationFee,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractPriceList Map(ContractPriceList entity ,EditContractPriceListCommand inputItem)
        {
              
  
		entity.ContractPriceListID = inputItem.ContractPriceListID;  
  
		entity.ContractPriceListChapterTitle = inputItem.ContractPriceListChapterTitle;  
  
		entity.ContractPriceListClassTitle = inputItem.ContractPriceListClassTitle;  
  
		entity.ContractPriceListFieldTitle = inputItem.ContractPriceListFieldTitle;  
  
		entity.OperationalYear = inputItem.OperationalYear;  
  
		entity.OperationCode = inputItem.OperationCode;  
  
		entity.OperationDescription = inputItem.OperationDescription;  
  
		entity.OperationUnit = inputItem.OperationUnit;  
  
		entity.OperationFee = inputItem.OperationFee;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractPriceListDto Map(ContractPriceList inputItem)
        {
            var dto = new ContractPriceListDto()
            {
                  
  
		ContractPriceListID = inputItem.ContractPriceListID,  
  
		ContractPriceListChapterTitle = inputItem.ContractPriceListChapterTitle,  
  
		ContractPriceListClassTitle = inputItem.ContractPriceListClassTitle,  
  
		ContractPriceListFieldTitle = inputItem.ContractPriceListFieldTitle,  
  
		OperationalYear = inputItem.OperationalYear,  
  
		OperationCode = inputItem.OperationCode,  
  
		OperationDescription = inputItem.OperationDescription,  
  
		OperationUnit = inputItem.OperationUnit,  
  
		OperationFee = inputItem.OperationFee,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<ContractPriceListDto> Map(ICollection<ContractPriceList> entities)
        {
            var dtos = new List<ContractPriceListDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractPriceListDto()
                {
                      
  
		ContractPriceListID = inputItem.ContractPriceListID,  
  
		ContractPriceListChapterTitle = inputItem.ContractPriceListChapterTitle,  
  
		ContractPriceListClassTitle = inputItem.ContractPriceListClassTitle,  
  
		ContractPriceListFieldTitle = inputItem.ContractPriceListFieldTitle,  
  
		OperationalYear = inputItem.OperationalYear,  
  
		OperationCode = inputItem.OperationCode,  
  
		OperationDescription = inputItem.OperationDescription,  
  
		OperationUnit = inputItem.OperationUnit,  
  
		OperationFee = inputItem.OperationFee,  
  
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
        
        public static ContractRelatedPurchaseInvoice Map(AddContractRelatedPurchaseInvoiceCommand inputItem)
        {
            var entity = new ContractRelatedPurchaseInvoice() {
                  
  
		ContractRelatedPurchaseInvoiceId = inputItem.ContractRelatedPurchaseInvoiceId,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		TenderRef = inputItem.TenderRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractRelatedPurchaseInvoice Map(ContractRelatedPurchaseInvoice entity ,EditContractRelatedPurchaseInvoiceCommand inputItem)
        {
              
  
		entity.ContractRelatedPurchaseInvoiceId = inputItem.ContractRelatedPurchaseInvoiceId;  
  
		entity.PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef;  
  
		entity.TenderRef = inputItem.TenderRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractRelatedPurchaseInvoiceDto Map(ContractRelatedPurchaseInvoice inputItem)
        {
            var dto = new ContractRelatedPurchaseInvoiceDto()
            {
                  
  
		ContractRelatedPurchaseInvoiceId = inputItem.ContractRelatedPurchaseInvoiceId,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		TenderRef = inputItem.TenderRef, 
            };
            return dto;
        }

        public static List<ContractRelatedPurchaseInvoiceDto> Map(ICollection<ContractRelatedPurchaseInvoice> entities)
        {
            var dtos = new List<ContractRelatedPurchaseInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractRelatedPurchaseInvoiceDto()
                {
                      
  
		ContractRelatedPurchaseInvoiceId = inputItem.ContractRelatedPurchaseInvoiceId,  
  
		PurchaseInvoiceRef = inputItem.PurchaseInvoiceRef,  
  
		TenderRef = inputItem.TenderRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractSupportingInsurance Map(AddContractSupportingInsuranceCommand inputItem)
        {
            var entity = new ContractSupportingInsurance() {
                  
  
		ContractSupportingInsuranceID = inputItem.ContractSupportingInsuranceID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BranchCode = inputItem.BranchCode,  
  
		BranchTitle = inputItem.BranchTitle,  
  
		BranchTitle_En = inputItem.BranchTitle_En,  
  
		WorkshopCode = inputItem.WorkshopCode,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractSupportingInsurance Map(ContractSupportingInsurance entity ,EditContractSupportingInsuranceCommand inputItem)
        {
              
  
		entity.ContractSupportingInsuranceID = inputItem.ContractSupportingInsuranceID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.BranchCode = inputItem.BranchCode;  
  
		entity.BranchTitle = inputItem.BranchTitle;  
  
		entity.BranchTitle_En = inputItem.BranchTitle_En;  
  
		entity.WorkshopCode = inputItem.WorkshopCode;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractSupportingInsuranceDto Map(ContractSupportingInsurance inputItem)
        {
            var dto = new ContractSupportingInsuranceDto()
            {
                  
  
		ContractSupportingInsuranceID = inputItem.ContractSupportingInsuranceID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BranchCode = inputItem.BranchCode,  
  
		BranchTitle = inputItem.BranchTitle,  
  
		BranchTitle_En = inputItem.BranchTitle_En,  
  
		WorkshopCode = inputItem.WorkshopCode,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<ContractSupportingInsuranceDto> Map(ICollection<ContractSupportingInsurance> entities)
        {
            var dtos = new List<ContractSupportingInsuranceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractSupportingInsuranceDto()
                {
                      
  
		ContractSupportingInsuranceID = inputItem.ContractSupportingInsuranceID,  
  
		ContractRef = inputItem.ContractRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		BranchCode = inputItem.BranchCode,  
  
		BranchTitle = inputItem.BranchTitle,  
  
		BranchTitle_En = inputItem.BranchTitle_En,  
  
		WorkshopCode = inputItem.WorkshopCode,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractType Map(AddContractTypeCommand inputItem)
        {
            var entity = new ContractType() {
                  
  
		ContractTypeID = inputItem.ContractTypeID,  
  
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

        public static ContractType Map(ContractType entity ,EditContractTypeCommand inputItem)
        {
              
  
		entity.ContractTypeID = inputItem.ContractTypeID;  
  
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

        
        public static ContractTypeDto Map(ContractType inputItem)
        {
            var dto = new ContractTypeDto()
            {
                  
  
		ContractTypeID = inputItem.ContractTypeID,  
  
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

        public static List<ContractTypeDto> Map(ICollection<ContractType> entities)
        {
            var dtos = new List<ContractTypeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractTypeDto()
                {
                      
  
		ContractTypeID = inputItem.ContractTypeID,  
  
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
        
        public static ContractWarrantyItem Map(AddContractWarrantyItemCommand inputItem)
        {
            var entity = new ContractWarrantyItem() {
                  
  
		ContractWarrantyItemID = inputItem.ContractWarrantyItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		WarrantyRef = inputItem.WarrantyRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Regard = inputItem.Regard,  
  
		DueDate = inputItem.DueDate,  
  
		Price = inputItem.Price,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
		FurtherInfo = inputItem.FurtherInfo,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractWarrantyItem Map(ContractWarrantyItem entity ,EditContractWarrantyItemCommand inputItem)
        {
              
  
		entity.ContractWarrantyItemID = inputItem.ContractWarrantyItemID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.WarrantyRef = inputItem.WarrantyRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.Regard = inputItem.Regard;  
  
		entity.DueDate = inputItem.DueDate;  
  
		entity.Price = inputItem.Price;  
  
		entity.DeliveryDate = inputItem.DeliveryDate;  
  
		entity.FurtherInfo = inputItem.FurtherInfo;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractWarrantyItemDto Map(ContractWarrantyItem inputItem)
        {
            var dto = new ContractWarrantyItemDto()
            {
                  
  
		ContractWarrantyItemID = inputItem.ContractWarrantyItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		WarrantyRef = inputItem.WarrantyRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Regard = inputItem.Regard,  
  
		DueDate = inputItem.DueDate,  
  
		Price = inputItem.Price,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
		FurtherInfo = inputItem.FurtherInfo,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<ContractWarrantyItemDto> Map(ICollection<ContractWarrantyItem> entities)
        {
            var dtos = new List<ContractWarrantyItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractWarrantyItemDto()
                {
                      
  
		ContractWarrantyItemID = inputItem.ContractWarrantyItemID,  
  
		ContractRef = inputItem.ContractRef,  
  
		WarrantyRef = inputItem.WarrantyRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		Regard = inputItem.Regard,  
  
		DueDate = inputItem.DueDate,  
  
		Price = inputItem.Price,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
		FurtherInfo = inputItem.FurtherInfo,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ContractWorkshopItem Map(AddContractWorkshopItemCommand inputItem)
        {
            var entity = new ContractWorkshopItem() {
                  
  
		ContractWorkshopItemID = inputItem.ContractWorkshopItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		ContractRef = inputItem.ContractRef,  
  
		WorkshopRef = inputItem.WorkshopRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractWorkshopItem Map(ContractWorkshopItem entity ,EditContractWorkshopItemCommand inputItem)
        {
              
  
		entity.ContractWorkshopItemID = inputItem.ContractWorkshopItemID;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.WorkshopRef = inputItem.WorkshopRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractWorkshopItemDto Map(ContractWorkshopItem inputItem)
        {
            var dto = new ContractWorkshopItemDto()
            {
                  
  
		ContractWorkshopItemID = inputItem.ContractWorkshopItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		ContractRef = inputItem.ContractRef,  
  
		WorkshopRef = inputItem.WorkshopRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<ContractWorkshopItemDto> Map(ICollection<ContractWorkshopItem> entities)
        {
            var dtos = new List<ContractWorkshopItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractWorkshopItemDto()
                {
                      
  
		ContractWorkshopItemID = inputItem.ContractWorkshopItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		ContractRef = inputItem.ContractRef,  
  
		WorkshopRef = inputItem.WorkshopRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Cost Map(AddCostCommand inputItem)
        {
            var entity = new Cost() {
                  
  
		CostID = inputItem.CostID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SLRef = inputItem.SLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Cost Map(Cost entity ,EditCostCommand inputItem)
        {
              
  
		entity.CostID = inputItem.CostID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CostDto Map(Cost inputItem)
        {
            var dto = new CostDto()
            {
                  
  
		CostID = inputItem.CostID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SLRef = inputItem.SLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<CostDto> Map(ICollection<Cost> entities)
        {
            var dtos = new List<CostDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CostDto()
                {
                      
  
		CostID = inputItem.CostID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SLRef = inputItem.SLRef,  
  
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
        
        public static CostStatement Map(AddCostStatementCommand inputItem)
        {
            var entity = new CostStatement() {
                  
  
		CostStatementID = inputItem.CostStatementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		WorkshopRef = inputItem.WorkshopRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		VoucherType = inputItem.VoucherType,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FundResponderDLRef = inputItem.FundResponderDLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Established = inputItem.Established, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CostStatement Map(CostStatement entity ,EditCostStatementCommand inputItem)
        {
              
  
		entity.CostStatementID = inputItem.CostStatementID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.WorkshopRef = inputItem.WorkshopRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.Type = inputItem.Type;  
  
		entity.VoucherType = inputItem.VoucherType;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.FundResponderDLRef = inputItem.FundResponderDLRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Established = inputItem.Established; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CostStatementDto Map(CostStatement inputItem)
        {
            var dto = new CostStatementDto()
            {
                  
  
		CostStatementID = inputItem.CostStatementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		WorkshopRef = inputItem.WorkshopRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		VoucherType = inputItem.VoucherType,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FundResponderDLRef = inputItem.FundResponderDLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Established = inputItem.Established, 
            };
            return dto;
        }

        public static List<CostStatementDto> Map(ICollection<CostStatement> entities)
        {
            var dtos = new List<CostStatementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CostStatementDto()
                {
                      
  
		CostStatementID = inputItem.CostStatementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		WorkshopRef = inputItem.WorkshopRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		VoucherType = inputItem.VoucherType,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		FundResponderDLRef = inputItem.FundResponderDLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Established = inputItem.Established, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CostStatementItem Map(AddCostStatementItemCommand inputItem)
        {
            var entity = new CostStatementItem() {
                  
  
		CostStatementItemID = inputItem.CostStatementItemID,  
  
		CostStatementRef = inputItem.CostStatementRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		CostTypeRef = inputItem.CostTypeRef,  
  
		Quantity = inputItem.Quantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		InvoiceNumber = inputItem.InvoiceNumber,  
  
		InvoiceDate = inputItem.InvoiceDate,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SlRef = inputItem.SlRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		InitialSettledValue = inputItem.InitialSettledValue,  
  
		CostSLRef = inputItem.CostSLRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CostStatementItem Map(CostStatementItem entity ,EditCostStatementItemCommand inputItem)
        {
              
  
		entity.CostStatementItemID = inputItem.CostStatementItemID;  
  
		entity.CostStatementRef = inputItem.CostStatementRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.CostTypeRef = inputItem.CostTypeRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.Price = inputItem.Price;  
  
		entity.InvoiceNumber = inputItem.InvoiceNumber;  
  
		entity.InvoiceDate = inputItem.InvoiceDate;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.SlRef = inputItem.SlRef;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.InitialSettledValue = inputItem.InitialSettledValue;  
  
		entity.CostSLRef = inputItem.CostSLRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CostStatementItemDto Map(CostStatementItem inputItem)
        {
            var dto = new CostStatementItemDto()
            {
                  
  
		CostStatementItemID = inputItem.CostStatementItemID,  
  
		CostStatementRef = inputItem.CostStatementRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		CostTypeRef = inputItem.CostTypeRef,  
  
		Quantity = inputItem.Quantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		InvoiceNumber = inputItem.InvoiceNumber,  
  
		InvoiceDate = inputItem.InvoiceDate,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SlRef = inputItem.SlRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		InitialSettledValue = inputItem.InitialSettledValue,  
  
		CostSLRef = inputItem.CostSLRef, 
            };
            return dto;
        }

        public static List<CostStatementItemDto> Map(ICollection<CostStatementItem> entities)
        {
            var dtos = new List<CostStatementItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CostStatementItemDto()
                {
                      
  
		CostStatementItemID = inputItem.CostStatementItemID,  
  
		CostStatementRef = inputItem.CostStatementRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		CostTypeRef = inputItem.CostTypeRef,  
  
		Quantity = inputItem.Quantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		InvoiceNumber = inputItem.InvoiceNumber,  
  
		InvoiceDate = inputItem.InvoiceDate,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		SlRef = inputItem.SlRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		InitialSettledValue = inputItem.InitialSettledValue,  
  
		CostSLRef = inputItem.CostSLRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Guarantee Map(AddGuaranteeCommand inputItem)
        {
            var entity = new Guarantee() {
                  
  
		GuaranteeID = inputItem.GuaranteeID,  
  
		Date = inputItem.Date,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		TenderRef = inputItem.TenderRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		WarrantyRef = inputItem.WarrantyRef,  
  
		Regard = inputItem.Regard,  
  
		DlRef = inputItem.DlRef,  
  
		Price = inputItem.Price,  
  
		DueDate = inputItem.DueDate,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
		FurtherInfo = inputItem.FurtherInfo,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		State = inputItem.State,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Nature = inputItem.Nature,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		BankRef = inputItem.BankRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		SLref = inputItem.SLref,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		OldContractWarrantyItemId = inputItem.OldContractWarrantyItemId, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Guarantee Map(Guarantee entity ,EditGuaranteeCommand inputItem)
        {
              
  
		entity.GuaranteeID = inputItem.GuaranteeID;  
  
		entity.Date = inputItem.Date;  
  
		entity.DocumentNumber = inputItem.DocumentNumber;  
  
		entity.TenderRef = inputItem.TenderRef;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.WarrantyRef = inputItem.WarrantyRef;  
  
		entity.Regard = inputItem.Regard;  
  
		entity.DlRef = inputItem.DlRef;  
  
		entity.Price = inputItem.Price;  
  
		entity.DueDate = inputItem.DueDate;  
  
		entity.DeliveryDate = inputItem.DeliveryDate;  
  
		entity.FurtherInfo = inputItem.FurtherInfo;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.BankAccountRef = inputItem.BankAccountRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.BankBranchRef = inputItem.BankBranchRef;  
  
		entity.State = inputItem.State;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.PaymentRef = inputItem.PaymentRef;  
  
		entity.Nature = inputItem.Nature;  
  
		entity.ReceiptRef = inputItem.ReceiptRef;  
  
		entity.BankRef = inputItem.BankRef;  
  
		entity.AccountNo = inputItem.AccountNo;  
  
		entity.SLref = inputItem.SLref;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.OldContractWarrantyItemId = inputItem.OldContractWarrantyItemId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GuaranteeDto Map(Guarantee inputItem)
        {
            var dto = new GuaranteeDto()
            {
                  
  
		GuaranteeID = inputItem.GuaranteeID,  
  
		Date = inputItem.Date,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		TenderRef = inputItem.TenderRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		WarrantyRef = inputItem.WarrantyRef,  
  
		Regard = inputItem.Regard,  
  
		DlRef = inputItem.DlRef,  
  
		Price = inputItem.Price,  
  
		DueDate = inputItem.DueDate,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
		FurtherInfo = inputItem.FurtherInfo,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		State = inputItem.State,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Nature = inputItem.Nature,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		BankRef = inputItem.BankRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		SLref = inputItem.SLref,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		OldContractWarrantyItemId = inputItem.OldContractWarrantyItemId, 
            };
            return dto;
        }

        public static List<GuaranteeDto> Map(ICollection<Guarantee> entities)
        {
            var dtos = new List<GuaranteeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GuaranteeDto()
                {
                      
  
		GuaranteeID = inputItem.GuaranteeID,  
  
		Date = inputItem.Date,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		TenderRef = inputItem.TenderRef,  
  
		ContractRef = inputItem.ContractRef,  
  
		WarrantyRef = inputItem.WarrantyRef,  
  
		Regard = inputItem.Regard,  
  
		DlRef = inputItem.DlRef,  
  
		Price = inputItem.Price,  
  
		DueDate = inputItem.DueDate,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
		FurtherInfo = inputItem.FurtherInfo,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		BankAccountRef = inputItem.BankAccountRef,  
  
		Number = inputItem.Number,  
  
		BankBranchRef = inputItem.BankBranchRef,  
  
		State = inputItem.State,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Nature = inputItem.Nature,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		BankRef = inputItem.BankRef,  
  
		AccountNo = inputItem.AccountNo,  
  
		SLref = inputItem.SLref,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		OldContractWarrantyItemId = inputItem.OldContractWarrantyItemId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GuaranteeOperation Map(AddGuaranteeOperationCommand inputItem)
        {
            var entity = new GuaranteeOperation() {
                  
  
		GuaranteeOperationID = inputItem.GuaranteeOperationID,  
  
		GuaranteeRef = inputItem.GuaranteeRef,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		Price = inputItem.Price,  
  
		ExtensionDate = inputItem.ExtensionDate,  
  
		State = inputItem.State,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GuaranteeOperation Map(GuaranteeOperation entity ,EditGuaranteeOperationCommand inputItem)
        {
              
  
		entity.GuaranteeOperationID = inputItem.GuaranteeOperationID;  
  
		entity.GuaranteeRef = inputItem.GuaranteeRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.Type = inputItem.Type;  
  
		entity.Price = inputItem.Price;  
  
		entity.ExtensionDate = inputItem.ExtensionDate;  
  
		entity.State = inputItem.State;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.PaymentRef = inputItem.PaymentRef;  
  
		entity.ReceiptRef = inputItem.ReceiptRef;  
  
		entity.RefundChequeRef = inputItem.RefundChequeRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GuaranteeOperationDto Map(GuaranteeOperation inputItem)
        {
            var dto = new GuaranteeOperationDto()
            {
                  
  
		GuaranteeOperationID = inputItem.GuaranteeOperationID,  
  
		GuaranteeRef = inputItem.GuaranteeRef,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		Price = inputItem.Price,  
  
		ExtensionDate = inputItem.ExtensionDate,  
  
		State = inputItem.State,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
            };
            return dto;
        }

        public static List<GuaranteeOperationDto> Map(ICollection<GuaranteeOperation> entities)
        {
            var dtos = new List<GuaranteeOperationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GuaranteeOperationDto()
                {
                      
  
		GuaranteeOperationID = inputItem.GuaranteeOperationID,  
  
		GuaranteeRef = inputItem.GuaranteeRef,  
  
		Date = inputItem.Date,  
  
		Type = inputItem.Type,  
  
		Price = inputItem.Price,  
  
		ExtensionDate = inputItem.ExtensionDate,  
  
		State = inputItem.State,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		RefundChequeRef = inputItem.RefundChequeRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static GuaranteeRelated Map(AddGuaranteeRelatedCommand inputItem)
        {
            var entity = new GuaranteeRelated() {
                  
  
		GuaranteeRelatedID = inputItem.GuaranteeRelatedID,  
  
		ParentGuaranteeRef = inputItem.ParentGuaranteeRef,  
  
		ChildGuaranteeRef = inputItem.ChildGuaranteeRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static GuaranteeRelated Map(GuaranteeRelated entity ,EditGuaranteeRelatedCommand inputItem)
        {
              
  
		entity.GuaranteeRelatedID = inputItem.GuaranteeRelatedID;  
  
		entity.ParentGuaranteeRef = inputItem.ParentGuaranteeRef;  
  
		entity.ChildGuaranteeRef = inputItem.ChildGuaranteeRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static GuaranteeRelatedDto Map(GuaranteeRelated inputItem)
        {
            var dto = new GuaranteeRelatedDto()
            {
                  
  
		GuaranteeRelatedID = inputItem.GuaranteeRelatedID,  
  
		ParentGuaranteeRef = inputItem.ParentGuaranteeRef,  
  
		ChildGuaranteeRef = inputItem.ChildGuaranteeRef, 
            };
            return dto;
        }

        public static List<GuaranteeRelatedDto> Map(ICollection<GuaranteeRelated> entities)
        {
            var dtos = new List<GuaranteeRelatedDto>();
            foreach (var inputItem in entities)
            {
                var dto = new GuaranteeRelatedDto()
                {
                      
  
		GuaranteeRelatedID = inputItem.GuaranteeRelatedID,  
  
		ParentGuaranteeRef = inputItem.ParentGuaranteeRef,  
  
		ChildGuaranteeRef = inputItem.ChildGuaranteeRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Project Map(AddProjectCommand inputItem)
        {
            var entity = new Project() {
                  
  
		ProjectID = inputItem.ProjectID,  
  
		Code = inputItem.Code,  
  
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

        public static Project Map(Project entity ,EditProjectCommand inputItem)
        {
              
  
		entity.ProjectID = inputItem.ProjectID;  
  
		entity.Code = inputItem.Code;  
  
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

        
        public static ProjectDto Map(Project inputItem)
        {
            var dto = new ProjectDto()
            {
                  
  
		ProjectID = inputItem.ProjectID,  
  
		Code = inputItem.Code,  
  
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

        public static List<ProjectDto> Map(ICollection<Project> entities)
        {
            var dtos = new List<ProjectDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProjectDto()
                {
                      
  
		ProjectID = inputItem.ProjectID,  
  
		Code = inputItem.Code,  
  
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
        
        public static ContractSettlement Map(AddContractSettlementCommand inputItem)
        {
            var entity = new ContractSettlement() {
                  
  
		SettlementID = inputItem.SettlementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ContractSettlement Map(ContractSettlement entity ,EditContractSettlementCommand inputItem)
        {
              
  
		entity.SettlementID = inputItem.SettlementID;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.ReceiptRef = inputItem.ReceiptRef;  
  
		entity.PaymentRef = inputItem.PaymentRef;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ContractSettlementDto Map(ContractSettlement inputItem)
        {
            var dto = new ContractSettlementDto()
            {
                  
  
		SettlementID = inputItem.SettlementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<ContractSettlementDto> Map(ICollection<ContractSettlement> entities)
        {
            var dtos = new List<ContractSettlementDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ContractSettlementDto()
                {
                      
  
		SettlementID = inputItem.SettlementID,  
  
		ContractRef = inputItem.ContractRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Type = inputItem.Type,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SettlementDebtItem Map(AddSettlementDebtItemCommand inputItem)
        {
            var entity = new SettlementDebtItem() {
                  
  
		SettlementDebtItemID = inputItem.SettlementDebtItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		CostStatementItemRef = inputItem.CostStatementItemRef,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		Remain = inputItem.Remain,  
  
		Amount = inputItem.Amount,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SettlementDebtItem Map(SettlementDebtItem entity ,EditSettlementDebtItemCommand inputItem)
        {
              
  
		entity.SettlementDebtItemID = inputItem.SettlementDebtItemID;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.CostStatementItemRef = inputItem.CostStatementItemRef;  
  
		entity.SettlementRef = inputItem.SettlementRef;  
  
		entity.Remain = inputItem.Remain;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SettlementDebtItemDto Map(SettlementDebtItem inputItem)
        {
            var dto = new SettlementDebtItemDto()
            {
                  
  
		SettlementDebtItemID = inputItem.SettlementDebtItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		CostStatementItemRef = inputItem.CostStatementItemRef,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		Remain = inputItem.Remain,  
  
		Amount = inputItem.Amount,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<SettlementDebtItemDto> Map(ICollection<SettlementDebtItem> entities)
        {
            var dtos = new List<SettlementDebtItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SettlementDebtItemDto()
                {
                      
  
		SettlementDebtItemID = inputItem.SettlementDebtItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		CostStatementItemRef = inputItem.CostStatementItemRef,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		Remain = inputItem.Remain,  
  
		Amount = inputItem.Amount,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SettlementItem Map(AddSettlementItemCommand inputItem)
        {
            var entity = new SettlementItem() {
                  
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		StatusRef = inputItem.StatusRef,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		Remain = inputItem.Remain,  
  
		Amount = inputItem.Amount,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SettlementItem Map(SettlementItem entity ,EditSettlementItemCommand inputItem)
        {
              
  
		entity.SettlementItemID = inputItem.SettlementItemID;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.SettlementRef = inputItem.SettlementRef;  
  
		entity.Remain = inputItem.Remain;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SettlementItemDto Map(SettlementItem inputItem)
        {
            var dto = new SettlementItemDto()
            {
                  
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		StatusRef = inputItem.StatusRef,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		Remain = inputItem.Remain,  
  
		Amount = inputItem.Amount,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<SettlementItemDto> Map(ICollection<SettlementItem> entities)
        {
            var dtos = new List<SettlementItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SettlementItemDto()
                {
                      
  
		SettlementItemID = inputItem.SettlementItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		StatusRef = inputItem.StatusRef,  
  
		SettlementRef = inputItem.SettlementRef,  
  
		Remain = inputItem.Remain,  
  
		Amount = inputItem.Amount,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Status Map(AddStatusCommand inputItem)
        {
            var entity = new Status() {
                  
  
		StatusID = inputItem.StatusID,  
  
		Nature = inputItem.Nature,  
  
		Established = inputItem.Established,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		InitialSettledValue = inputItem.InitialSettledValue,  
  
		ContractRef = inputItem.ContractRef,  
  
		Type = inputItem.Type,  
  
		StatusRef = inputItem.StatusRef,  
  
		StatusRefType = inputItem.StatusRefType,  
  
		ConfirmedCost = inputItem.ConfirmedCost,  
  
		CurrentCost = inputItem.CurrentCost,  
  
		Material = inputItem.Material,  
  
		PreReceipt = inputItem.PreReceipt,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SLRef = inputItem.SLRef,  
  
		ConfirmationState = inputItem.ConfirmationState,  
  
		ConfirmationDate = inputItem.ConfirmationDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BillSerial = inputItem.BillSerial,  
  
		Duty = inputItem.Duty, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Status Map(Status entity ,EditStatusCommand inputItem)
        {
              
  
		entity.StatusID = inputItem.StatusID;  
  
		entity.Nature = inputItem.Nature;  
  
		entity.Established = inputItem.Established;  
  
		entity.Date = inputItem.Date;  
  
		entity.Number = inputItem.Number;  
  
		entity.InitialSettledValue = inputItem.InitialSettledValue;  
  
		entity.ContractRef = inputItem.ContractRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.StatusRefType = inputItem.StatusRefType;  
  
		entity.ConfirmedCost = inputItem.ConfirmedCost;  
  
		entity.CurrentCost = inputItem.CurrentCost;  
  
		entity.Material = inputItem.Material;  
  
		entity.PreReceipt = inputItem.PreReceipt;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.ConfirmationState = inputItem.ConfirmationState;  
  
		entity.ConfirmationDate = inputItem.ConfirmationDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.BillSerial = inputItem.BillSerial;  
  
		entity.Duty = inputItem.Duty; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StatusDto Map(Status inputItem)
        {
            var dto = new StatusDto()
            {
                  
  
		StatusID = inputItem.StatusID,  
  
		Nature = inputItem.Nature,  
  
		Established = inputItem.Established,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		InitialSettledValue = inputItem.InitialSettledValue,  
  
		ContractRef = inputItem.ContractRef,  
  
		Type = inputItem.Type,  
  
		StatusRef = inputItem.StatusRef,  
  
		StatusRefType = inputItem.StatusRefType,  
  
		ConfirmedCost = inputItem.ConfirmedCost,  
  
		CurrentCost = inputItem.CurrentCost,  
  
		Material = inputItem.Material,  
  
		PreReceipt = inputItem.PreReceipt,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SLRef = inputItem.SLRef,  
  
		ConfirmationState = inputItem.ConfirmationState,  
  
		ConfirmationDate = inputItem.ConfirmationDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BillSerial = inputItem.BillSerial,  
  
		Duty = inputItem.Duty, 
            };
            return dto;
        }

        public static List<StatusDto> Map(ICollection<Status> entities)
        {
            var dtos = new List<StatusDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StatusDto()
                {
                      
  
		StatusID = inputItem.StatusID,  
  
		Nature = inputItem.Nature,  
  
		Established = inputItem.Established,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		InitialSettledValue = inputItem.InitialSettledValue,  
  
		ContractRef = inputItem.ContractRef,  
  
		Type = inputItem.Type,  
  
		StatusRef = inputItem.StatusRef,  
  
		StatusRefType = inputItem.StatusRefType,  
  
		ConfirmedCost = inputItem.ConfirmedCost,  
  
		CurrentCost = inputItem.CurrentCost,  
  
		Material = inputItem.Material,  
  
		PreReceipt = inputItem.PreReceipt,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		SLRef = inputItem.SLRef,  
  
		ConfirmationState = inputItem.ConfirmationState,  
  
		ConfirmationDate = inputItem.ConfirmationDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		BillSerial = inputItem.BillSerial,  
  
		Duty = inputItem.Duty, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static StatusCoefficientItem Map(AddStatusCoefficientItemCommand inputItem)
        {
            var entity = new StatusCoefficientItem() {
                  
  
		StatusCoefficientItemID = inputItem.StatusCoefficientItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		ContractCoefficientItemRef = inputItem.ContractCoefficientItemRef,  
  
		CoefficientRef = inputItem.CoefficientRef,  
  
		Price = inputItem.Price, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StatusCoefficientItem Map(StatusCoefficientItem entity ,EditStatusCoefficientItemCommand inputItem)
        {
              
  
		entity.StatusCoefficientItemID = inputItem.StatusCoefficientItemID;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.ContractCoefficientItemRef = inputItem.ContractCoefficientItemRef;  
  
		entity.CoefficientRef = inputItem.CoefficientRef;  
  
		entity.Price = inputItem.Price; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StatusCoefficientItemDto Map(StatusCoefficientItem inputItem)
        {
            var dto = new StatusCoefficientItemDto()
            {
                  
  
		StatusCoefficientItemID = inputItem.StatusCoefficientItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		ContractCoefficientItemRef = inputItem.ContractCoefficientItemRef,  
  
		CoefficientRef = inputItem.CoefficientRef,  
  
		Price = inputItem.Price, 
            };
            return dto;
        }

        public static List<StatusCoefficientItemDto> Map(ICollection<StatusCoefficientItem> entities)
        {
            var dtos = new List<StatusCoefficientItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StatusCoefficientItemDto()
                {
                      
  
		StatusCoefficientItemID = inputItem.StatusCoefficientItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		ContractCoefficientItemRef = inputItem.ContractCoefficientItemRef,  
  
		CoefficientRef = inputItem.CoefficientRef,  
  
		Price = inputItem.Price, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static StatusItem Map(AddStatusItemCommand inputItem)
        {
            var entity = new StatusItem() {
                  
  
		StatusItemID = inputItem.StatusItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		ContractAgreementItemRef = inputItem.ContractAgreementItemRef,  
  
		ItemTitle = inputItem.ItemTitle,  
  
		ItemTitle_En = inputItem.ItemTitle_En,  
  
		Quantity = inputItem.Quantity,  
  
		Fee = inputItem.Fee,  
  
		ConfirmedFee = inputItem.ConfirmedFee,  
  
		Price = inputItem.Price,  
  
		ConfirmedQuantity = inputItem.ConfirmedQuantity,  
  
		ConfirmedPrice = inputItem.ConfirmedPrice,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StatusItem Map(StatusItem entity ,EditStatusItemCommand inputItem)
        {
              
  
		entity.StatusItemID = inputItem.StatusItemID;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.ContractAgreementItemRef = inputItem.ContractAgreementItemRef;  
  
		entity.ItemTitle = inputItem.ItemTitle;  
  
		entity.ItemTitle_En = inputItem.ItemTitle_En;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.ConfirmedFee = inputItem.ConfirmedFee;  
  
		entity.Price = inputItem.Price;  
  
		entity.ConfirmedQuantity = inputItem.ConfirmedQuantity;  
  
		entity.ConfirmedPrice = inputItem.ConfirmedPrice;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StatusItemDto Map(StatusItem inputItem)
        {
            var dto = new StatusItemDto()
            {
                  
  
		StatusItemID = inputItem.StatusItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		ContractAgreementItemRef = inputItem.ContractAgreementItemRef,  
  
		ItemTitle = inputItem.ItemTitle,  
  
		ItemTitle_En = inputItem.ItemTitle_En,  
  
		Quantity = inputItem.Quantity,  
  
		Fee = inputItem.Fee,  
  
		ConfirmedFee = inputItem.ConfirmedFee,  
  
		Price = inputItem.Price,  
  
		ConfirmedQuantity = inputItem.ConfirmedQuantity,  
  
		ConfirmedPrice = inputItem.ConfirmedPrice,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<StatusItemDto> Map(ICollection<StatusItem> entities)
        {
            var dtos = new List<StatusItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StatusItemDto()
                {
                      
  
		StatusItemID = inputItem.StatusItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ItemRef = inputItem.ItemRef,  
  
		ContractAgreementItemRef = inputItem.ContractAgreementItemRef,  
  
		ItemTitle = inputItem.ItemTitle,  
  
		ItemTitle_En = inputItem.ItemTitle_En,  
  
		Quantity = inputItem.Quantity,  
  
		Fee = inputItem.Fee,  
  
		ConfirmedFee = inputItem.ConfirmedFee,  
  
		Price = inputItem.Price,  
  
		ConfirmedQuantity = inputItem.ConfirmedQuantity,  
  
		ConfirmedPrice = inputItem.ConfirmedPrice,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static StatusOnAccountItem Map(AddStatusOnAccountItemCommand inputItem)
        {
            var entity = new StatusOnAccountItem() {
                  
  
		StatusOnAccountItemID = inputItem.StatusOnAccountItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Date = inputItem.Date,  
  
		Price = inputItem.Price,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StatusOnAccountItem Map(StatusOnAccountItem entity ,EditStatusOnAccountItemCommand inputItem)
        {
              
  
		entity.StatusOnAccountItemID = inputItem.StatusOnAccountItemID;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.ReceiptRef = inputItem.ReceiptRef;  
  
		entity.PaymentRef = inputItem.PaymentRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.Price = inputItem.Price;  
  
		entity.Type = inputItem.Type;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StatusOnAccountItemDto Map(StatusOnAccountItem inputItem)
        {
            var dto = new StatusOnAccountItemDto()
            {
                  
  
		StatusOnAccountItemID = inputItem.StatusOnAccountItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Date = inputItem.Date,  
  
		Price = inputItem.Price,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
            };
            return dto;
        }

        public static List<StatusOnAccountItemDto> Map(ICollection<StatusOnAccountItem> entities)
        {
            var dtos = new List<StatusOnAccountItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StatusOnAccountItemDto()
                {
                      
  
		StatusOnAccountItemID = inputItem.StatusOnAccountItemID,  
  
		StatusRef = inputItem.StatusRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Date = inputItem.Date,  
  
		Price = inputItem.Price,  
  
		Type = inputItem.Type,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static StatusReceiptItem Map(AddStatusReceiptItemCommand inputItem)
        {
            var entity = new StatusReceiptItem() {
                  
  
		StatusReceiptItemID = inputItem.StatusReceiptItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		StatusRef = inputItem.StatusRef,  
  
		Type = inputItem.Type,  
  
		Fee = inputItem.Fee,  
  
		ReceiptRef = inputItem.ReceiptRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StatusReceiptItem Map(StatusReceiptItem entity ,EditStatusReceiptItemCommand inputItem)
        {
              
  
		entity.StatusReceiptItemID = inputItem.StatusReceiptItemID;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.StatusRef = inputItem.StatusRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.ReceiptRef = inputItem.ReceiptRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StatusReceiptItemDto Map(StatusReceiptItem inputItem)
        {
            var dto = new StatusReceiptItemDto()
            {
                  
  
		StatusReceiptItemID = inputItem.StatusReceiptItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		StatusRef = inputItem.StatusRef,  
  
		Type = inputItem.Type,  
  
		Fee = inputItem.Fee,  
  
		ReceiptRef = inputItem.ReceiptRef, 
            };
            return dto;
        }

        public static List<StatusReceiptItemDto> Map(ICollection<StatusReceiptItem> entities)
        {
            var dtos = new List<StatusReceiptItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StatusReceiptItemDto()
                {
                      
  
		StatusReceiptItemID = inputItem.StatusReceiptItemID,  
  
		RowNumber = inputItem.RowNumber,  
  
		StatusRef = inputItem.StatusRef,  
  
		Type = inputItem.Type,  
  
		Fee = inputItem.Fee,  
  
		ReceiptRef = inputItem.ReceiptRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Tender Map(AddTenderCommand inputItem)
        {
            var entity = new Tender() {
                  
  
		TenderID = inputItem.TenderID,  
  
		Date = inputItem.Date,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		TenderPartyRef = inputItem.TenderPartyRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		DLRef = inputItem.DLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Tender Map(Tender entity ,EditTenderCommand inputItem)
        {
              
  
		entity.TenderID = inputItem.TenderID;  
  
		entity.Date = inputItem.Date;  
  
		entity.DocumentNumber = inputItem.DocumentNumber;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.TenderPartyRef = inputItem.TenderPartyRef;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static TenderDto Map(Tender inputItem)
        {
            var dto = new TenderDto()
            {
                  
  
		TenderID = inputItem.TenderID,  
  
		Date = inputItem.Date,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		TenderPartyRef = inputItem.TenderPartyRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		DLRef = inputItem.DLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
            };
            return dto;
        }

        public static List<TenderDto> Map(ICollection<Tender> entities)
        {
            var dtos = new List<TenderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new TenderDto()
                {
                      
  
		TenderID = inputItem.TenderID,  
  
		Date = inputItem.Date,  
  
		DocumentNumber = inputItem.DocumentNumber,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		TenderPartyRef = inputItem.TenderPartyRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		DLRef = inputItem.DLRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Warranty Map(AddWarrantyCommand inputItem)
        {
            var entity = new Warranty() {
                  
  
		warrantyID = inputItem.warrantyID,  
  
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

        public static Warranty Map(Warranty entity ,EditWarrantyCommand inputItem)
        {
              
  
		entity.warrantyID = inputItem.warrantyID;  
  
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

        
        public static WarrantyDto Map(Warranty inputItem)
        {
            var dto = new WarrantyDto()
            {
                  
  
		warrantyID = inputItem.warrantyID,  
  
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

        public static List<WarrantyDto> Map(ICollection<Warranty> entities)
        {
            var dtos = new List<WarrantyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WarrantyDto()
                {
                      
  
		warrantyID = inputItem.warrantyID,  
  
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
        
        public static Workshop Map(AddWorkshopCommand inputItem)
        {
            var entity = new Workshop() {
                  
  
		WorkshopID = inputItem.WorkshopID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SupervisorRef = inputItem.SupervisorRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Workshop Map(Workshop entity ,EditWorkshopCommand inputItem)
        {
              
  
		entity.WorkshopID = inputItem.WorkshopID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.SupervisorRef = inputItem.SupervisorRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static WorkshopDto Map(Workshop inputItem)
        {
            var dto = new WorkshopDto()
            {
                  
  
		WorkshopID = inputItem.WorkshopID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SupervisorRef = inputItem.SupervisorRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<WorkshopDto> Map(ICollection<Workshop> entities)
        {
            var dtos = new List<WorkshopDto>();
            foreach (var inputItem in entities)
            {
                var dto = new WorkshopDto()
                {
                      
  
		WorkshopID = inputItem.WorkshopID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SupervisorRef = inputItem.SupervisorRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
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

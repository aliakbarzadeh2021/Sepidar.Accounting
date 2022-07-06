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
                
        
        public static AdditionFactor Map(AddAdditionFactorCommand inputItem)
        {
            var entity = new AdditionFactor() {
                  
  
		AdditionFactorID = inputItem.AdditionFactorID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleVolumeType = inputItem.SaleVolumeType,  
  
		Basis = inputItem.Basis,  
  
		IsActive = inputItem.IsActive,  
  
		IsEffectiveOnVat = inputItem.IsEffectiveOnVat,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
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

        public static AdditionFactor Map(AdditionFactor entity ,EditAdditionFactorCommand inputItem)
        {
              
  
		entity.AdditionFactorID = inputItem.AdditionFactorID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.SaleVolumeType = inputItem.SaleVolumeType;  
  
		entity.Basis = inputItem.Basis;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.IsEffectiveOnVat = inputItem.IsEffectiveOnVat;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CustomerGroupingRef = inputItem.CustomerGroupingRef;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AdditionFactorDto Map(AdditionFactor inputItem)
        {
            var dto = new AdditionFactorDto()
            {
                  
  
		AdditionFactorID = inputItem.AdditionFactorID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleVolumeType = inputItem.SaleVolumeType,  
  
		Basis = inputItem.Basis,  
  
		IsActive = inputItem.IsActive,  
  
		IsEffectiveOnVat = inputItem.IsEffectiveOnVat,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
		SLRef = inputItem.SLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AdditionFactorDto> Map(ICollection<AdditionFactor> entities)
        {
            var dtos = new List<AdditionFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AdditionFactorDto()
                {
                      
  
		AdditionFactorID = inputItem.AdditionFactorID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleVolumeType = inputItem.SaleVolumeType,  
  
		Basis = inputItem.Basis,  
  
		IsActive = inputItem.IsActive,  
  
		IsEffectiveOnVat = inputItem.IsEffectiveOnVat,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
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
        
        public static AdditionFactorItem Map(AddAdditionFactorItemCommand inputItem)
        {
            var entity = new AdditionFactorItem() {
                  
  
		AdditionFactorItemID = inputItem.AdditionFactorItemID,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		AdditionType = inputItem.AdditionType,  
  
		Amount = inputItem.Amount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AdditionFactorItem Map(AdditionFactorItem entity ,EditAdditionFactorItemCommand inputItem)
        {
              
  
		entity.AdditionFactorItemID = inputItem.AdditionFactorItemID;  
  
		entity.AdditionFactorRef = inputItem.AdditionFactorRef;  
  
		entity.FromValue = inputItem.FromValue;  
  
		entity.ToValue = inputItem.ToValue;  
  
		entity.AdditionType = inputItem.AdditionType;  
  
		entity.Amount = inputItem.Amount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AdditionFactorItemDto Map(AdditionFactorItem inputItem)
        {
            var dto = new AdditionFactorItemDto()
            {
                  
  
		AdditionFactorItemID = inputItem.AdditionFactorItemID,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		AdditionType = inputItem.AdditionType,  
  
		Amount = inputItem.Amount, 
            };
            return dto;
        }

        public static List<AdditionFactorItemDto> Map(ICollection<AdditionFactorItem> entities)
        {
            var dtos = new List<AdditionFactorItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AdditionFactorItemDto()
                {
                      
  
		AdditionFactorItemID = inputItem.AdditionFactorItemID,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		AdditionType = inputItem.AdditionType,  
  
		Amount = inputItem.Amount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Commission Map(AddCommissionCommand inputItem)
        {
            var entity = new Commission() {
                  
  
		CommissionId = inputItem.CommissionId,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		CalculationBase = inputItem.CalculationBase,  
  
		InvoiceSettlementState = inputItem.InvoiceSettlementState,  
  
		SaleVolumeCalculationBase = inputItem.SaleVolumeCalculationBase,  
  
		CalculationType = inputItem.CalculationType,  
  
		Type = inputItem.Type,  
  
		ItemFilterType = inputItem.ItemFilterType,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Commission Map(Commission entity ,EditCommissionCommand inputItem)
        {
              
  
		entity.CommissionId = inputItem.CommissionId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.FromDate = inputItem.FromDate;  
  
		entity.ToDate = inputItem.ToDate;  
  
		entity.CalculationBase = inputItem.CalculationBase;  
  
		entity.InvoiceSettlementState = inputItem.InvoiceSettlementState;  
  
		entity.SaleVolumeCalculationBase = inputItem.SaleVolumeCalculationBase;  
  
		entity.CalculationType = inputItem.CalculationType;  
  
		entity.Type = inputItem.Type;  
  
		entity.ItemFilterType = inputItem.ItemFilterType;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionDto Map(Commission inputItem)
        {
            var dto = new CommissionDto()
            {
                  
  
		CommissionId = inputItem.CommissionId,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		CalculationBase = inputItem.CalculationBase,  
  
		InvoiceSettlementState = inputItem.InvoiceSettlementState,  
  
		SaleVolumeCalculationBase = inputItem.SaleVolumeCalculationBase,  
  
		CalculationType = inputItem.CalculationType,  
  
		Type = inputItem.Type,  
  
		ItemFilterType = inputItem.ItemFilterType,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<CommissionDto> Map(ICollection<Commission> entities)
        {
            var dtos = new List<CommissionDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionDto()
                {
                      
  
		CommissionId = inputItem.CommissionId,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		CalculationBase = inputItem.CalculationBase,  
  
		InvoiceSettlementState = inputItem.InvoiceSettlementState,  
  
		SaleVolumeCalculationBase = inputItem.SaleVolumeCalculationBase,  
  
		CalculationType = inputItem.CalculationType,  
  
		Type = inputItem.Type,  
  
		ItemFilterType = inputItem.ItemFilterType,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
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
        
        public static CommissionArea Map(AddCommissionAreaCommand inputItem)
        {
            var entity = new CommissionArea() {
                  
  
		CommissionAreaId = inputItem.CommissionAreaId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		AreaRef = inputItem.AreaRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommissionArea Map(CommissionArea entity ,EditCommissionAreaCommand inputItem)
        {
              
  
		entity.CommissionAreaId = inputItem.CommissionAreaId;  
  
		entity.CommissionRef = inputItem.CommissionRef;  
  
		entity.AreaRef = inputItem.AreaRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionAreaDto Map(CommissionArea inputItem)
        {
            var dto = new CommissionAreaDto()
            {
                  
  
		CommissionAreaId = inputItem.CommissionAreaId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		AreaRef = inputItem.AreaRef, 
            };
            return dto;
        }

        public static List<CommissionAreaDto> Map(ICollection<CommissionArea> entities)
        {
            var dtos = new List<CommissionAreaDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionAreaDto()
                {
                      
  
		CommissionAreaId = inputItem.CommissionAreaId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		AreaRef = inputItem.AreaRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CommissionBroker Map(AddCommissionBrokerCommand inputItem)
        {
            var entity = new CommissionBroker() {
                  
  
		CommissionBrokerId = inputItem.CommissionBrokerId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		PartyRef = inputItem.PartyRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommissionBroker Map(CommissionBroker entity ,EditCommissionBrokerCommand inputItem)
        {
              
  
		entity.CommissionBrokerId = inputItem.CommissionBrokerId;  
  
		entity.CommissionRef = inputItem.CommissionRef;  
  
		entity.PartyRef = inputItem.PartyRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionBrokerDto Map(CommissionBroker inputItem)
        {
            var dto = new CommissionBrokerDto()
            {
                  
  
		CommissionBrokerId = inputItem.CommissionBrokerId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		PartyRef = inputItem.PartyRef, 
            };
            return dto;
        }

        public static List<CommissionBrokerDto> Map(ICollection<CommissionBroker> entities)
        {
            var dtos = new List<CommissionBrokerDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionBrokerDto()
                {
                      
  
		CommissionBrokerId = inputItem.CommissionBrokerId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		PartyRef = inputItem.PartyRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CommissionCalculation Map(AddCommissionCalculationCommand inputItem)
        {
            var entity = new CommissionCalculation() {
                  
  
		CommissionCalculationID = inputItem.CommissionCalculationID,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		BrokerPartyRef_ = inputItem.BrokerPartyRef_,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		SLRef = inputItem.SLRef,  
  
		DLRef = inputItem.DLRef,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommissionCalculation Map(CommissionCalculation entity ,EditCommissionCalculationCommand inputItem)
        {
              
  
		entity.CommissionCalculationID = inputItem.CommissionCalculationID;  
  
		entity.CommissionRef = inputItem.CommissionRef;  
  
		entity.BrokerPartyRef_ = inputItem.BrokerPartyRef_;  
  
		entity.FromDate = inputItem.FromDate;  
  
		entity.ToDate = inputItem.ToDate;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.DLRef = inputItem.DLRef;  
  
		entity.AccountingVoucherRef = inputItem.AccountingVoucherRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionCalculationDto Map(CommissionCalculation inputItem)
        {
            var dto = new CommissionCalculationDto()
            {
                  
  
		CommissionCalculationID = inputItem.CommissionCalculationID,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		BrokerPartyRef_ = inputItem.BrokerPartyRef_,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		SLRef = inputItem.SLRef,  
  
		DLRef = inputItem.DLRef,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<CommissionCalculationDto> Map(ICollection<CommissionCalculation> entities)
        {
            var dtos = new List<CommissionCalculationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionCalculationDto()
                {
                      
  
		CommissionCalculationID = inputItem.CommissionCalculationID,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		BrokerPartyRef_ = inputItem.BrokerPartyRef_,  
  
		FromDate = inputItem.FromDate,  
  
		ToDate = inputItem.ToDate,  
  
		SLRef = inputItem.SLRef,  
  
		DLRef = inputItem.DLRef,  
  
		AccountingVoucherRef = inputItem.AccountingVoucherRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
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
        
        public static CommissionCalculationInvoice Map(AddCommissionCalculationInvoiceCommand inputItem)
        {
            var entity = new CommissionCalculationInvoice() {
                  
  
		CommissionCalculationInvoiceID = inputItem.CommissionCalculationInvoiceID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommissionCalculationInvoice Map(CommissionCalculationInvoice entity ,EditCommissionCalculationInvoiceCommand inputItem)
        {
              
  
		entity.CommissionCalculationInvoiceID = inputItem.CommissionCalculationInvoiceID;  
  
		entity.CommissionCalculationRef = inputItem.CommissionCalculationRef;  
  
		entity.InvoiceItemRef = inputItem.InvoiceItemRef;  
  
		entity.ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionCalculationInvoiceDto Map(CommissionCalculationInvoice inputItem)
        {
            var dto = new CommissionCalculationInvoiceDto()
            {
                  
  
		CommissionCalculationInvoiceID = inputItem.CommissionCalculationInvoiceID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef, 
            };
            return dto;
        }

        public static List<CommissionCalculationInvoiceDto> Map(ICollection<CommissionCalculationInvoice> entities)
        {
            var dtos = new List<CommissionCalculationInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionCalculationInvoiceDto()
                {
                      
  
		CommissionCalculationInvoiceID = inputItem.CommissionCalculationInvoiceID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CommissionCalculationItem Map(AddCommissionCalculationItemCommand inputItem)
        {
            var entity = new CommissionCalculationItem() {
                  
  
		CommissionCalculationItemID = inputItem.CommissionCalculationItemID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		Amount = inputItem.Amount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommissionCalculationItem Map(CommissionCalculationItem entity ,EditCommissionCalculationItemCommand inputItem)
        {
              
  
		entity.CommissionCalculationItemID = inputItem.CommissionCalculationItemID;  
  
		entity.CommissionCalculationRef = inputItem.CommissionCalculationRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.Amount = inputItem.Amount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionCalculationItemDto Map(CommissionCalculationItem inputItem)
        {
            var dto = new CommissionCalculationItemDto()
            {
                  
  
		CommissionCalculationItemID = inputItem.CommissionCalculationItemID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		Amount = inputItem.Amount, 
            };
            return dto;
        }

        public static List<CommissionCalculationItemDto> Map(ICollection<CommissionCalculationItem> entities)
        {
            var dtos = new List<CommissionCalculationItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionCalculationItemDto()
                {
                      
  
		CommissionCalculationItemID = inputItem.CommissionCalculationItemID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		Amount = inputItem.Amount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CommissionCalculationXMLResult Map(AddCommissionCalculationXMLResultCommand inputItem)
        {
            var entity = new CommissionCalculationXMLResult() {
                  
  
		CommissionCalculationXMLResultID = inputItem.CommissionCalculationXMLResultID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		Content = inputItem.Content, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommissionCalculationXMLResult Map(CommissionCalculationXMLResult entity ,EditCommissionCalculationXMLResultCommand inputItem)
        {
              
  
		entity.CommissionCalculationXMLResultID = inputItem.CommissionCalculationXMLResultID;  
  
		entity.CommissionCalculationRef = inputItem.CommissionCalculationRef;  
  
		entity.Content = inputItem.Content; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionCalculationXMLResultDto Map(CommissionCalculationXMLResult inputItem)
        {
            var dto = new CommissionCalculationXMLResultDto()
            {
                  
  
		CommissionCalculationXMLResultID = inputItem.CommissionCalculationXMLResultID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		Content = inputItem.Content, 
            };
            return dto;
        }

        public static List<CommissionCalculationXMLResultDto> Map(ICollection<CommissionCalculationXMLResult> entities)
        {
            var dtos = new List<CommissionCalculationXMLResultDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionCalculationXMLResultDto()
                {
                      
  
		CommissionCalculationXMLResultID = inputItem.CommissionCalculationXMLResultID,  
  
		CommissionCalculationRef = inputItem.CommissionCalculationRef,  
  
		Content = inputItem.Content, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CommissionItem Map(AddCommissionItemCommand inputItem)
        {
            var entity = new CommissionItem() {
                  
  
		CommissionItemId = inputItem.CommissionItemId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		ItemRef = inputItem.ItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommissionItem Map(CommissionItem entity ,EditCommissionItemCommand inputItem)
        {
              
  
		entity.CommissionItemId = inputItem.CommissionItemId;  
  
		entity.CommissionRef = inputItem.CommissionRef;  
  
		entity.ItemRef = inputItem.ItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionItemDto Map(CommissionItem inputItem)
        {
            var dto = new CommissionItemDto()
            {
                  
  
		CommissionItemId = inputItem.CommissionItemId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		ItemRef = inputItem.ItemRef, 
            };
            return dto;
        }

        public static List<CommissionItemDto> Map(ICollection<CommissionItem> entities)
        {
            var dtos = new List<CommissionItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionItemDto()
                {
                      
  
		CommissionItemId = inputItem.CommissionItemId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		ItemRef = inputItem.ItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CommissionStep Map(AddCommissionStepCommand inputItem)
        {
            var entity = new CommissionStep() {
                  
  
		CommissionStepId = inputItem.CommissionStepId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		Amount = inputItem.Amount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CommissionStep Map(CommissionStep entity ,EditCommissionStepCommand inputItem)
        {
              
  
		entity.CommissionStepId = inputItem.CommissionStepId;  
  
		entity.CommissionRef = inputItem.CommissionRef;  
  
		entity.FromValue = inputItem.FromValue;  
  
		entity.ToValue = inputItem.ToValue;  
  
		entity.Amount = inputItem.Amount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CommissionStepDto Map(CommissionStep inputItem)
        {
            var dto = new CommissionStepDto()
            {
                  
  
		CommissionStepId = inputItem.CommissionStepId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		Amount = inputItem.Amount, 
            };
            return dto;
        }

        public static List<CommissionStepDto> Map(ICollection<CommissionStep> entities)
        {
            var dtos = new List<CommissionStepDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CommissionStepDto()
                {
                      
  
		CommissionStepId = inputItem.CommissionStepId,  
  
		CommissionRef = inputItem.CommissionRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		Amount = inputItem.Amount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Discount Map(AddDiscountCommand inputItem)
        {
            var entity = new Discount() {
                  
  
		DiscountID = inputItem.DiscountID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleVolumeType = inputItem.SaleVolumeType,  
  
		DiscountCalcType = inputItem.DiscountCalcType,  
  
		DiscountCalculationBasis = inputItem.DiscountCalculationBasis,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Discount Map(Discount entity ,EditDiscountCommand inputItem)
        {
              
  
		entity.DiscountID = inputItem.DiscountID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.SaleVolumeType = inputItem.SaleVolumeType;  
  
		entity.DiscountCalcType = inputItem.DiscountCalcType;  
  
		entity.DiscountCalculationBasis = inputItem.DiscountCalculationBasis;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.CustomerGroupingRef = inputItem.CustomerGroupingRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DiscountDto Map(Discount inputItem)
        {
            var dto = new DiscountDto()
            {
                  
  
		DiscountID = inputItem.DiscountID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleVolumeType = inputItem.SaleVolumeType,  
  
		DiscountCalcType = inputItem.DiscountCalcType,  
  
		DiscountCalculationBasis = inputItem.DiscountCalculationBasis,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef, 
            };
            return dto;
        }

        public static List<DiscountDto> Map(ICollection<Discount> entities)
        {
            var dtos = new List<DiscountDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DiscountDto()
                {
                      
  
		DiscountID = inputItem.DiscountID,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleVolumeType = inputItem.SaleVolumeType,  
  
		DiscountCalcType = inputItem.DiscountCalcType,  
  
		DiscountCalculationBasis = inputItem.DiscountCalculationBasis,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static DiscountItem Map(AddDiscountItemCommand inputItem)
        {
            var entity = new DiscountItem() {
                  
  
		DiscountItemID = inputItem.DiscountItemID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		DiscountType = inputItem.DiscountType,  
  
		Amount = inputItem.Amount,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		ProductPackRef = inputItem.ProductPackRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DiscountItem Map(DiscountItem entity ,EditDiscountItemCommand inputItem)
        {
              
  
		entity.DiscountItemID = inputItem.DiscountItemID;  
  
		entity.DiscountRef = inputItem.DiscountRef;  
  
		entity.FromValue = inputItem.FromValue;  
  
		entity.ToValue = inputItem.ToValue;  
  
		entity.DiscountType = inputItem.DiscountType;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.ProductPackRef = inputItem.ProductPackRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DiscountItemDto Map(DiscountItem inputItem)
        {
            var dto = new DiscountItemDto()
            {
                  
  
		DiscountItemID = inputItem.DiscountItemID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		DiscountType = inputItem.DiscountType,  
  
		Amount = inputItem.Amount,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		ProductPackRef = inputItem.ProductPackRef, 
            };
            return dto;
        }

        public static List<DiscountItemDto> Map(ICollection<DiscountItem> entities)
        {
            var dtos = new List<DiscountItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DiscountItemDto()
                {
                      
  
		DiscountItemID = inputItem.DiscountItemID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		FromValue = inputItem.FromValue,  
  
		ToValue = inputItem.ToValue,  
  
		DiscountType = inputItem.DiscountType,  
  
		Amount = inputItem.Amount,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		ProductPackRef = inputItem.ProductPackRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Invoice Map(AddInvoiceCommand inputItem)
        {
            var entity = new Invoice() {
                  
  
		InvoiceId = inputItem.InvoiceId,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		OrderRef = inputItem.OrderRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		SLRef = inputItem.SLRef,  
  
		DeliveryLocationRef = inputItem.DeliveryLocationRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		Agreements = inputItem.Agreements,  
  
		ShouldControlCustomerCredit = inputItem.ShouldControlCustomerCredit,  
  
		BaseOnInventoryDelivery = inputItem.BaseOnInventoryDelivery,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Invoice Map(Invoice entity ,EditInvoiceCommand inputItem)
        {
              
  
		entity.InvoiceId = inputItem.InvoiceId;  
  
		entity.QuotationRef = inputItem.QuotationRef;  
  
		entity.OrderRef = inputItem.OrderRef;  
  
		entity.CustomerPartyRef = inputItem.CustomerPartyRef;  
  
		entity.CustomerRealName = inputItem.CustomerRealName;  
  
		entity.CustomerRealName_En = inputItem.CustomerRealName_En;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.PartyAddressRef = inputItem.PartyAddressRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.DeliveryLocationRef = inputItem.DeliveryLocationRef;  
  
		entity.State = inputItem.State;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.Agreements = inputItem.Agreements;  
  
		entity.ShouldControlCustomerCredit = inputItem.ShouldControlCustomerCredit;  
  
		entity.BaseOnInventoryDelivery = inputItem.BaseOnInventoryDelivery;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvoiceDto Map(Invoice inputItem)
        {
            var dto = new InvoiceDto()
            {
                  
  
		InvoiceId = inputItem.InvoiceId,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		OrderRef = inputItem.OrderRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		SLRef = inputItem.SLRef,  
  
		DeliveryLocationRef = inputItem.DeliveryLocationRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		Agreements = inputItem.Agreements,  
  
		ShouldControlCustomerCredit = inputItem.ShouldControlCustomerCredit,  
  
		BaseOnInventoryDelivery = inputItem.BaseOnInventoryDelivery,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<InvoiceDto> Map(ICollection<Invoice> entities)
        {
            var dtos = new List<InvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvoiceDto()
                {
                      
  
		InvoiceId = inputItem.InvoiceId,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		OrderRef = inputItem.OrderRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		SLRef = inputItem.SLRef,  
  
		DeliveryLocationRef = inputItem.DeliveryLocationRef,  
  
		State = inputItem.State,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		Agreements = inputItem.Agreements,  
  
		ShouldControlCustomerCredit = inputItem.ShouldControlCustomerCredit,  
  
		BaseOnInventoryDelivery = inputItem.BaseOnInventoryDelivery,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvoiceBroker Map(AddInvoiceBrokerCommand inputItem)
        {
            var entity = new InvoiceBroker() {
                  
  
		BrokerID = inputItem.BrokerID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Commission = inputItem.Commission,  
  
		Rate = inputItem.Rate,  
  
		CommissionInBaseCurrency = inputItem.CommissionInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvoiceBroker Map(InvoiceBroker entity ,EditInvoiceBrokerCommand inputItem)
        {
              
  
		entity.BrokerID = inputItem.BrokerID;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.Commission = inputItem.Commission;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.CommissionInBaseCurrency = inputItem.CommissionInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvoiceBrokerDto Map(InvoiceBroker inputItem)
        {
            var dto = new InvoiceBrokerDto()
            {
                  
  
		BrokerID = inputItem.BrokerID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Commission = inputItem.Commission,  
  
		Rate = inputItem.Rate,  
  
		CommissionInBaseCurrency = inputItem.CommissionInBaseCurrency, 
            };
            return dto;
        }

        public static List<InvoiceBrokerDto> Map(ICollection<InvoiceBroker> entities)
        {
            var dtos = new List<InvoiceBrokerDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvoiceBrokerDto()
                {
                      
  
		BrokerID = inputItem.BrokerID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Commission = inputItem.Commission,  
  
		Rate = inputItem.Rate,  
  
		CommissionInBaseCurrency = inputItem.CommissionInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvoiceCommissionBroker Map(AddInvoiceCommissionBrokerCommand inputItem)
        {
            var entity = new InvoiceCommissionBroker() {
                  
  
		InvoiceCommissionBrokerID = inputItem.InvoiceCommissionBrokerID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent,  
  
		ManualCommissionAmount = inputItem.ManualCommissionAmount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvoiceCommissionBroker Map(InvoiceCommissionBroker entity ,EditInvoiceCommissionBrokerCommand inputItem)
        {
              
  
		entity.InvoiceCommissionBrokerID = inputItem.InvoiceCommissionBrokerID;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.SalePortionPercent = inputItem.SalePortionPercent;  
  
		entity.ManualCommissionAmount = inputItem.ManualCommissionAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvoiceCommissionBrokerDto Map(InvoiceCommissionBroker inputItem)
        {
            var dto = new InvoiceCommissionBrokerDto()
            {
                  
  
		InvoiceCommissionBrokerID = inputItem.InvoiceCommissionBrokerID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent,  
  
		ManualCommissionAmount = inputItem.ManualCommissionAmount, 
            };
            return dto;
        }

        public static List<InvoiceCommissionBrokerDto> Map(ICollection<InvoiceCommissionBroker> entities)
        {
            var dtos = new List<InvoiceCommissionBrokerDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvoiceCommissionBrokerDto()
                {
                      
  
		InvoiceCommissionBrokerID = inputItem.InvoiceCommissionBrokerID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent,  
  
		ManualCommissionAmount = inputItem.ManualCommissionAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvoiceItem Map(AddInvoiceItemCommand inputItem)
        {
            var entity = new InvoiceItem() {
                  
  
		InvoiceItemID = inputItem.InvoiceItemID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		OrderItemRef = inputItem.OrderItemRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountInvoiceItemRef = inputItem.DiscountInvoiceItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvoiceItem Map(InvoiceItem entity ,EditInvoiceItemCommand inputItem)
        {
              
  
		entity.InvoiceItemID = inputItem.InvoiceItemID;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate;  
  
		entity.PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount;  
  
		entity.PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount;  
  
		entity.CustomerDiscount = inputItem.CustomerDiscount;  
  
		entity.CustomerDiscountRate = inputItem.CustomerDiscountRate;  
  
		entity.AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate;  
  
		entity.AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount;  
  
		entity.AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.QuotationItemRef = inputItem.QuotationItemRef;  
  
		entity.OrderItemRef = inputItem.OrderItemRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.DiscountInvoiceItemRef = inputItem.DiscountInvoiceItemRef;  
  
		entity.ProductPackRef = inputItem.ProductPackRef;  
  
		entity.ProductPackQuantity = inputItem.ProductPackQuantity;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvoiceItemDto Map(InvoiceItem inputItem)
        {
            var dto = new InvoiceItemDto()
            {
                  
  
		InvoiceItemID = inputItem.InvoiceItemID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		OrderItemRef = inputItem.OrderItemRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountInvoiceItemRef = inputItem.DiscountInvoiceItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<InvoiceItemDto> Map(ICollection<InvoiceItem> entities)
        {
            var dtos = new List<InvoiceItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvoiceItemDto()
                {
                      
  
		InvoiceItemID = inputItem.InvoiceItemID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		OrderItemRef = inputItem.OrderItemRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountInvoiceItemRef = inputItem.DiscountInvoiceItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvoiceItemAdditionFactor Map(AddInvoiceItemAdditionFactorCommand inputItem)
        {
            var entity = new InvoiceItemAdditionFactor() {
                  
  
		InvoiceItemAdditionFactorID = inputItem.InvoiceItemAdditionFactorID,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvoiceItemAdditionFactor Map(InvoiceItemAdditionFactor entity ,EditInvoiceItemAdditionFactorCommand inputItem)
        {
              
  
		entity.InvoiceItemAdditionFactorID = inputItem.InvoiceItemAdditionFactorID;  
  
		entity.InvoiceItemRef = inputItem.InvoiceItemRef;  
  
		entity.AdditionFactorRef = inputItem.AdditionFactorRef;  
  
		entity.Value = inputItem.Value;  
  
		entity.ValueInBaseCurrency = inputItem.ValueInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvoiceItemAdditionFactorDto Map(InvoiceItemAdditionFactor inputItem)
        {
            var dto = new InvoiceItemAdditionFactorDto()
            {
                  
  
		InvoiceItemAdditionFactorID = inputItem.InvoiceItemAdditionFactorID,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
            };
            return dto;
        }

        public static List<InvoiceItemAdditionFactorDto> Map(ICollection<InvoiceItemAdditionFactor> entities)
        {
            var dtos = new List<InvoiceItemAdditionFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvoiceItemAdditionFactorDto()
                {
                      
  
		InvoiceItemAdditionFactorID = inputItem.InvoiceItemAdditionFactorID,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvoiceReceiptChequeInfo Map(AddInvoiceReceiptChequeInfoCommand inputItem)
        {
            var entity = new InvoiceReceiptChequeInfo() {
                  
  
		InvoiceReceiptChequeInfoId = inputItem.InvoiceReceiptChequeInfoId,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Number = inputItem.Number,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		AccountNo = inputItem.AccountNo,  
  
		BankRef = inputItem.BankRef,  
  
		PartyAccountSettlementItemRef = inputItem.PartyAccountSettlementItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvoiceReceiptChequeInfo Map(InvoiceReceiptChequeInfo entity ,EditInvoiceReceiptChequeInfoCommand inputItem)
        {
              
  
		entity.InvoiceReceiptChequeInfoId = inputItem.InvoiceReceiptChequeInfoId;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.Date = inputItem.Date;  
  
		entity.AccountNo = inputItem.AccountNo;  
  
		entity.BankRef = inputItem.BankRef;  
  
		entity.PartyAccountSettlementItemRef = inputItem.PartyAccountSettlementItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvoiceReceiptChequeInfoDto Map(InvoiceReceiptChequeInfo inputItem)
        {
            var dto = new InvoiceReceiptChequeInfoDto()
            {
                  
  
		InvoiceReceiptChequeInfoId = inputItem.InvoiceReceiptChequeInfoId,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Number = inputItem.Number,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		AccountNo = inputItem.AccountNo,  
  
		BankRef = inputItem.BankRef,  
  
		PartyAccountSettlementItemRef = inputItem.PartyAccountSettlementItemRef, 
            };
            return dto;
        }

        public static List<InvoiceReceiptChequeInfoDto> Map(ICollection<InvoiceReceiptChequeInfo> entities)
        {
            var dtos = new List<InvoiceReceiptChequeInfoDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvoiceReceiptChequeInfoDto()
                {
                      
  
		InvoiceReceiptChequeInfoId = inputItem.InvoiceReceiptChequeInfoId,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Number = inputItem.Number,  
  
		Amount = inputItem.Amount,  
  
		Date = inputItem.Date,  
  
		AccountNo = inputItem.AccountNo,  
  
		BankRef = inputItem.BankRef,  
  
		PartyAccountSettlementItemRef = inputItem.PartyAccountSettlementItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static InvoiceReceiptInfo Map(AddInvoiceReceiptInfoCommand inputItem)
        {
            var entity = new InvoiceReceiptInfo() {
                  
  
		InvoiceReceiptInfoID = inputItem.InvoiceReceiptInfoID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Discount = inputItem.Discount,  
  
		Amount = inputItem.Amount,  
  
		PosAmount = inputItem.PosAmount,  
  
		DraftAmount = inputItem.DraftAmount,  
  
		PartyAccountSettlementItemRef = inputItem.PartyAccountSettlementItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static InvoiceReceiptInfo Map(InvoiceReceiptInfo entity ,EditInvoiceReceiptInfoCommand inputItem)
        {
              
  
		entity.InvoiceReceiptInfoID = inputItem.InvoiceReceiptInfoID;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.PosAmount = inputItem.PosAmount;  
  
		entity.DraftAmount = inputItem.DraftAmount;  
  
		entity.PartyAccountSettlementItemRef = inputItem.PartyAccountSettlementItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static InvoiceReceiptInfoDto Map(InvoiceReceiptInfo inputItem)
        {
            var dto = new InvoiceReceiptInfoDto()
            {
                  
  
		InvoiceReceiptInfoID = inputItem.InvoiceReceiptInfoID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Discount = inputItem.Discount,  
  
		Amount = inputItem.Amount,  
  
		PosAmount = inputItem.PosAmount,  
  
		DraftAmount = inputItem.DraftAmount,  
  
		PartyAccountSettlementItemRef = inputItem.PartyAccountSettlementItemRef, 
            };
            return dto;
        }

        public static List<InvoiceReceiptInfoDto> Map(ICollection<InvoiceReceiptInfo> entities)
        {
            var dtos = new List<InvoiceReceiptInfoDto>();
            foreach (var inputItem in entities)
            {
                var dto = new InvoiceReceiptInfoDto()
                {
                      
  
		InvoiceReceiptInfoID = inputItem.InvoiceReceiptInfoID,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Discount = inputItem.Discount,  
  
		Amount = inputItem.Amount,  
  
		PosAmount = inputItem.PosAmount,  
  
		DraftAmount = inputItem.DraftAmount,  
  
		PartyAccountSettlementItemRef = inputItem.PartyAccountSettlementItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ItemAdditionFactor Map(AddItemAdditionFactorCommand inputItem)
        {
            var entity = new ItemAdditionFactor() {
                  
  
		ItemAdditionFactorID = inputItem.ItemAdditionFactorID,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ItemAdditionFactor Map(ItemAdditionFactor entity ,EditItemAdditionFactorCommand inputItem)
        {
              
  
		entity.ItemAdditionFactorID = inputItem.ItemAdditionFactorID;  
  
		entity.AdditionFactorRef = inputItem.AdditionFactorRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ItemAdditionFactorDto Map(ItemAdditionFactor inputItem)
        {
            var dto = new ItemAdditionFactorDto()
            {
                  
  
		ItemAdditionFactorID = inputItem.ItemAdditionFactorID,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
            };
            return dto;
        }

        public static List<ItemAdditionFactorDto> Map(ICollection<ItemAdditionFactor> entities)
        {
            var dtos = new List<ItemAdditionFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ItemAdditionFactorDto()
                {
                      
  
		ItemAdditionFactorID = inputItem.ItemAdditionFactorID,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ItemDiscount Map(AddItemDiscountCommand inputItem)
        {
            var entity = new ItemDiscount() {
                  
  
		ItemDiscountID = inputItem.ItemDiscountID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ItemDiscount Map(ItemDiscount entity ,EditItemDiscountCommand inputItem)
        {
              
  
		entity.ItemDiscountID = inputItem.ItemDiscountID;  
  
		entity.DiscountRef = inputItem.DiscountRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ItemDiscountDto Map(ItemDiscount inputItem)
        {
            var dto = new ItemDiscountDto()
            {
                  
  
		ItemDiscountID = inputItem.ItemDiscountID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
            };
            return dto;
        }

        public static List<ItemDiscountDto> Map(ICollection<ItemDiscount> entities)
        {
            var dtos = new List<ItemDiscountDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ItemDiscountDto()
                {
                      
  
		ItemDiscountID = inputItem.ItemDiscountID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PriceNote Map(AddPriceNoteCommand inputItem)
        {
            var entity = new PriceNote() {
                  
  
		PriceNoteID = inputItem.PriceNoteID,  
  
		Date = inputItem.Date,  
  
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

        public static PriceNote Map(PriceNote entity ,EditPriceNoteCommand inputItem)
        {
              
  
		entity.PriceNoteID = inputItem.PriceNoteID;  
  
		entity.Date = inputItem.Date;  
  
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

        
        public static PriceNoteDto Map(PriceNote inputItem)
        {
            var dto = new PriceNoteDto()
            {
                  
  
		PriceNoteID = inputItem.PriceNoteID,  
  
		Date = inputItem.Date,  
  
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

        public static List<PriceNoteDto> Map(ICollection<PriceNote> entities)
        {
            var dtos = new List<PriceNoteDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PriceNoteDto()
                {
                      
  
		PriceNoteID = inputItem.PriceNoteID,  
  
		Date = inputItem.Date,  
  
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
        
        public static PriceNoteItem Map(AddPriceNoteItemCommand inputItem)
        {
            var entity = new PriceNoteItem() {
                  
  
		PriceNoteItemID = inputItem.PriceNoteItemID,  
  
		PriceNoteRef = inputItem.PriceNoteRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		UnitRef = inputItem.UnitRef,  
  
		Fee = inputItem.Fee,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Discount = inputItem.Discount,  
  
		CanChangeInvoiceFee = inputItem.CanChangeInvoiceFee,  
  
		CanChangeInvoiceDiscount = inputItem.CanChangeInvoiceDiscount,  
  
		AdditionRate = inputItem.AdditionRate,  
  
		TracingRef = inputItem.TracingRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
		LowerMargin = inputItem.LowerMargin,  
  
		UpperMargin = inputItem.UpperMargin, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PriceNoteItem Map(PriceNoteItem entity ,EditPriceNoteItemCommand inputItem)
        {
              
  
		entity.PriceNoteItemID = inputItem.PriceNoteItemID;  
  
		entity.PriceNoteRef = inputItem.PriceNoteRef;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.UnitRef = inputItem.UnitRef;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.CanChangeInvoiceFee = inputItem.CanChangeInvoiceFee;  
  
		entity.CanChangeInvoiceDiscount = inputItem.CanChangeInvoiceDiscount;  
  
		entity.AdditionRate = inputItem.AdditionRate;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.CustomerGroupingRef = inputItem.CustomerGroupingRef;  
  
		entity.LowerMargin = inputItem.LowerMargin;  
  
		entity.UpperMargin = inputItem.UpperMargin; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PriceNoteItemDto Map(PriceNoteItem inputItem)
        {
            var dto = new PriceNoteItemDto()
            {
                  
  
		PriceNoteItemID = inputItem.PriceNoteItemID,  
  
		PriceNoteRef = inputItem.PriceNoteRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		UnitRef = inputItem.UnitRef,  
  
		Fee = inputItem.Fee,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Discount = inputItem.Discount,  
  
		CanChangeInvoiceFee = inputItem.CanChangeInvoiceFee,  
  
		CanChangeInvoiceDiscount = inputItem.CanChangeInvoiceDiscount,  
  
		AdditionRate = inputItem.AdditionRate,  
  
		TracingRef = inputItem.TracingRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
		LowerMargin = inputItem.LowerMargin,  
  
		UpperMargin = inputItem.UpperMargin, 
            };
            return dto;
        }

        public static List<PriceNoteItemDto> Map(ICollection<PriceNoteItem> entities)
        {
            var dtos = new List<PriceNoteItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PriceNoteItemDto()
                {
                      
  
		PriceNoteItemID = inputItem.PriceNoteItemID,  
  
		PriceNoteRef = inputItem.PriceNoteRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		UnitRef = inputItem.UnitRef,  
  
		Fee = inputItem.Fee,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Discount = inputItem.Discount,  
  
		CanChangeInvoiceFee = inputItem.CanChangeInvoiceFee,  
  
		CanChangeInvoiceDiscount = inputItem.CanChangeInvoiceDiscount,  
  
		AdditionRate = inputItem.AdditionRate,  
  
		TracingRef = inputItem.TracingRef,  
  
		CustomerGroupingRef = inputItem.CustomerGroupingRef,  
  
		LowerMargin = inputItem.LowerMargin,  
  
		UpperMargin = inputItem.UpperMargin, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PriceNoteItemDiscount Map(AddPriceNoteItemDiscountCommand inputItem)
        {
            var entity = new PriceNoteItemDiscount() {
                  
  
		PriceNoteItemDiscountID = inputItem.PriceNoteItemDiscountID,  
  
		PriceNoteItemRef = inputItem.PriceNoteItemRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		Converted = inputItem.Converted, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PriceNoteItemDiscount Map(PriceNoteItemDiscount entity ,EditPriceNoteItemDiscountCommand inputItem)
        {
              
  
		entity.PriceNoteItemDiscountID = inputItem.PriceNoteItemDiscountID;  
  
		entity.PriceNoteItemRef = inputItem.PriceNoteItemRef;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.DiscountRef = inputItem.DiscountRef;  
  
		entity.Converted = inputItem.Converted; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PriceNoteItemDiscountDto Map(PriceNoteItemDiscount inputItem)
        {
            var dto = new PriceNoteItemDiscountDto()
            {
                  
  
		PriceNoteItemDiscountID = inputItem.PriceNoteItemDiscountID,  
  
		PriceNoteItemRef = inputItem.PriceNoteItemRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		Converted = inputItem.Converted, 
            };
            return dto;
        }

        public static List<PriceNoteItemDiscountDto> Map(ICollection<PriceNoteItemDiscount> entities)
        {
            var dtos = new List<PriceNoteItemDiscountDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PriceNoteItemDiscountDto()
                {
                      
  
		PriceNoteItemDiscountID = inputItem.PriceNoteItemDiscountID,  
  
		PriceNoteItemRef = inputItem.PriceNoteItemRef,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		Converted = inputItem.Converted, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ProductPack Map(AddProductPackCommand inputItem)
        {
            var entity = new ProductPack() {
                  
  
		ProductPackID = inputItem.ProductPackID,  
  
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

        public static ProductPack Map(ProductPack entity ,EditProductPackCommand inputItem)
        {
              
  
		entity.ProductPackID = inputItem.ProductPackID;  
  
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

        
        public static ProductPackDto Map(ProductPack inputItem)
        {
            var dto = new ProductPackDto()
            {
                  
  
		ProductPackID = inputItem.ProductPackID,  
  
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

        public static List<ProductPackDto> Map(ICollection<ProductPack> entities)
        {
            var dtos = new List<ProductPackDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductPackDto()
                {
                      
  
		ProductPackID = inputItem.ProductPackID,  
  
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
        
        public static ProductPackDiscount Map(AddProductPackDiscountCommand inputItem)
        {
            var entity = new ProductPackDiscount() {
                  
  
		ProductPackDiscountID = inputItem.ProductPackDiscountID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		ProductPackRef = inputItem.ProductPackRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ProductPackDiscount Map(ProductPackDiscount entity ,EditProductPackDiscountCommand inputItem)
        {
              
  
		entity.ProductPackDiscountID = inputItem.ProductPackDiscountID;  
  
		entity.DiscountRef = inputItem.DiscountRef;  
  
		entity.ProductPackRef = inputItem.ProductPackRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProductPackDiscountDto Map(ProductPackDiscount inputItem)
        {
            var dto = new ProductPackDiscountDto()
            {
                  
  
		ProductPackDiscountID = inputItem.ProductPackDiscountID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		ProductPackRef = inputItem.ProductPackRef, 
            };
            return dto;
        }

        public static List<ProductPackDiscountDto> Map(ICollection<ProductPackDiscount> entities)
        {
            var dtos = new List<ProductPackDiscountDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductPackDiscountDto()
                {
                      
  
		ProductPackDiscountID = inputItem.ProductPackDiscountID,  
  
		DiscountRef = inputItem.DiscountRef,  
  
		ProductPackRef = inputItem.ProductPackRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ProductPackItem Map(AddProductPackItemCommand inputItem)
        {
            var entity = new ProductPackItem() {
                  
  
		ProductPackItemID = inputItem.ProductPackItemID,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ProductPackItem Map(ProductPackItem entity ,EditProductPackItemCommand inputItem)
        {
              
  
		entity.ProductPackItemID = inputItem.ProductPackItemID;  
  
		entity.ProductPackRef = inputItem.ProductPackRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProductPackItemDto Map(ProductPackItem inputItem)
        {
            var dto = new ProductPackItemDto()
            {
                  
  
		ProductPackItemID = inputItem.ProductPackItemID,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
            };
            return dto;
        }

        public static List<ProductPackItemDto> Map(ICollection<ProductPackItem> entities)
        {
            var dtos = new List<ProductPackItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductPackItemDto()
                {
                      
  
		ProductPackItemID = inputItem.ProductPackItemID,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Quotation Map(AddQuotationCommand inputItem)
        {
            var entity = new Quotation() {
                  
  
		QuotationId = inputItem.QuotationId,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ExpirationDate = inputItem.ExpirationDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		DeliveryLocationRef = inputItem.DeliveryLocationRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Closed = inputItem.Closed,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Quotation Map(Quotation entity ,EditQuotationCommand inputItem)
        {
              
  
		entity.QuotationId = inputItem.QuotationId;  
  
		entity.CustomerPartyRef = inputItem.CustomerPartyRef;  
  
		entity.CustomerRealName = inputItem.CustomerRealName;  
  
		entity.CustomerRealName_En = inputItem.CustomerRealName_En;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.PartyAddressRef = inputItem.PartyAddressRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.ExpirationDate = inputItem.ExpirationDate;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.DeliveryLocationRef = inputItem.DeliveryLocationRef;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Closed = inputItem.Closed;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.ReceiptRef = inputItem.ReceiptRef;  
  
		entity.PaymentRef = inputItem.PaymentRef;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QuotationDto Map(Quotation inputItem)
        {
            var dto = new QuotationDto()
            {
                  
  
		QuotationId = inputItem.QuotationId,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ExpirationDate = inputItem.ExpirationDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		DeliveryLocationRef = inputItem.DeliveryLocationRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Closed = inputItem.Closed,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<QuotationDto> Map(ICollection<Quotation> entities)
        {
            var dtos = new List<QuotationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QuotationDto()
                {
                      
  
		QuotationId = inputItem.QuotationId,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		ExpirationDate = inputItem.ExpirationDate,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		DeliveryLocationRef = inputItem.DeliveryLocationRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Closed = inputItem.Closed,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		ReceiptRef = inputItem.ReceiptRef,  
  
		PaymentRef = inputItem.PaymentRef,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QuotationCommissionBroker Map(AddQuotationCommissionBrokerCommand inputItem)
        {
            var entity = new QuotationCommissionBroker() {
                  
  
		QuotationCommissionBrokerID = inputItem.QuotationCommissionBrokerID,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QuotationCommissionBroker Map(QuotationCommissionBroker entity ,EditQuotationCommissionBrokerCommand inputItem)
        {
              
  
		entity.QuotationCommissionBrokerID = inputItem.QuotationCommissionBrokerID;  
  
		entity.QuotationRef = inputItem.QuotationRef;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.SalePortionPercent = inputItem.SalePortionPercent; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QuotationCommissionBrokerDto Map(QuotationCommissionBroker inputItem)
        {
            var dto = new QuotationCommissionBrokerDto()
            {
                  
  
		QuotationCommissionBrokerID = inputItem.QuotationCommissionBrokerID,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent, 
            };
            return dto;
        }

        public static List<QuotationCommissionBrokerDto> Map(ICollection<QuotationCommissionBroker> entities)
        {
            var dtos = new List<QuotationCommissionBrokerDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QuotationCommissionBrokerDto()
                {
                      
  
		QuotationCommissionBrokerID = inputItem.QuotationCommissionBrokerID,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QuotationItem Map(AddQuotationItemCommand inputItem)
        {
            var entity = new QuotationItem() {
                  
  
		QuotationItemID = inputItem.QuotationItemID,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		UsedQuantity = inputItem.UsedQuantity,  
  
		Description = inputItem.Description,  
  
		DiscountQuotationItemRef = inputItem.DiscountQuotationItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		Description_En = inputItem.Description_En,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QuotationItem Map(QuotationItem entity ,EditQuotationItemCommand inputItem)
        {
              
  
		entity.QuotationItemID = inputItem.QuotationItemID;  
  
		entity.QuotationRef = inputItem.QuotationRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate;  
  
		entity.PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount;  
  
		entity.PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount;  
  
		entity.AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate;  
  
		entity.AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount;  
  
		entity.AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount;  
  
		entity.CustomerDiscount = inputItem.CustomerDiscount;  
  
		entity.CustomerDiscountRate = inputItem.CustomerDiscountRate;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.UsedQuantity = inputItem.UsedQuantity;  
  
		entity.Description = inputItem.Description;  
  
		entity.DiscountQuotationItemRef = inputItem.DiscountQuotationItemRef;  
  
		entity.ProductPackRef = inputItem.ProductPackRef;  
  
		entity.ProductPackQuantity = inputItem.ProductPackQuantity;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QuotationItemDto Map(QuotationItem inputItem)
        {
            var dto = new QuotationItemDto()
            {
                  
  
		QuotationItemID = inputItem.QuotationItemID,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		UsedQuantity = inputItem.UsedQuantity,  
  
		Description = inputItem.Description,  
  
		DiscountQuotationItemRef = inputItem.DiscountQuotationItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		Description_En = inputItem.Description_En,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<QuotationItemDto> Map(ICollection<QuotationItem> entities)
        {
            var dtos = new List<QuotationItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QuotationItemDto()
                {
                      
  
		QuotationItemID = inputItem.QuotationItemID,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		UsedQuantity = inputItem.UsedQuantity,  
  
		Description = inputItem.Description,  
  
		DiscountQuotationItemRef = inputItem.DiscountQuotationItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		Description_En = inputItem.Description_En,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static QuotationItemAdditionFactor Map(AddQuotationItemAdditionFactorCommand inputItem)
        {
            var entity = new QuotationItemAdditionFactor() {
                  
  
		QuotationItemAdditionFactorID = inputItem.QuotationItemAdditionFactorID,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static QuotationItemAdditionFactor Map(QuotationItemAdditionFactor entity ,EditQuotationItemAdditionFactorCommand inputItem)
        {
              
  
		entity.QuotationItemAdditionFactorID = inputItem.QuotationItemAdditionFactorID;  
  
		entity.QuotationItemRef = inputItem.QuotationItemRef;  
  
		entity.AdditionFactorRef = inputItem.AdditionFactorRef;  
  
		entity.Value = inputItem.Value;  
  
		entity.ValueInBaseCurrency = inputItem.ValueInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static QuotationItemAdditionFactorDto Map(QuotationItemAdditionFactor inputItem)
        {
            var dto = new QuotationItemAdditionFactorDto()
            {
                  
  
		QuotationItemAdditionFactorID = inputItem.QuotationItemAdditionFactorID,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
            };
            return dto;
        }

        public static List<QuotationItemAdditionFactorDto> Map(ICollection<QuotationItemAdditionFactor> entities)
        {
            var dtos = new List<QuotationItemAdditionFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new QuotationItemAdditionFactorDto()
                {
                      
  
		QuotationItemAdditionFactorID = inputItem.QuotationItemAdditionFactorID,  
  
		QuotationItemRef = inputItem.QuotationItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReturnedInvoice Map(AddReturnedInvoiceCommand inputItem)
        {
            var entity = new ReturnedInvoice() {
                  
  
		ReturnedInvoiceId = inputItem.ReturnedInvoiceId,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		SLRef = inputItem.SLRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReturnedInvoice Map(ReturnedInvoice entity ,EditReturnedInvoiceCommand inputItem)
        {
              
  
		entity.ReturnedInvoiceId = inputItem.ReturnedInvoiceId;  
  
		entity.QuotationRef = inputItem.QuotationRef;  
  
		entity.CustomerPartyRef = inputItem.CustomerPartyRef;  
  
		entity.CustomerRealName = inputItem.CustomerRealName;  
  
		entity.CustomerRealName_En = inputItem.CustomerRealName_En;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.PartyAddressRef = inputItem.PartyAddressRef;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.SLRef = inputItem.SLRef;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.VoucherRef = inputItem.VoucherRef;  
  
		entity.PaymentHeaderRef = inputItem.PaymentHeaderRef;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReturnedInvoiceDto Map(ReturnedInvoice inputItem)
        {
            var dto = new ReturnedInvoiceDto()
            {
                  
  
		ReturnedInvoiceId = inputItem.ReturnedInvoiceId,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		SLRef = inputItem.SLRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<ReturnedInvoiceDto> Map(ICollection<ReturnedInvoice> entities)
        {
            var dtos = new List<ReturnedInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnedInvoiceDto()
                {
                      
  
		ReturnedInvoiceId = inputItem.ReturnedInvoiceId,  
  
		QuotationRef = inputItem.QuotationRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerRealName = inputItem.CustomerRealName,  
  
		CustomerRealName_En = inputItem.CustomerRealName_En,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		SLRef = inputItem.SLRef,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		VoucherRef = inputItem.VoucherRef,  
  
		PaymentHeaderRef = inputItem.PaymentHeaderRef,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReturnedInvoiceBroker Map(AddReturnedInvoiceBrokerCommand inputItem)
        {
            var entity = new ReturnedInvoiceBroker() {
                  
  
		ReturnedInvoiceBrokerID = inputItem.ReturnedInvoiceBrokerID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		Commission = inputItem.Commission,  
  
		Rate = inputItem.Rate,  
  
		CommissionInBaseCurrency = inputItem.CommissionInBaseCurrency,  
  
		PartyRef = inputItem.PartyRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReturnedInvoiceBroker Map(ReturnedInvoiceBroker entity ,EditReturnedInvoiceBrokerCommand inputItem)
        {
              
  
		entity.ReturnedInvoiceBrokerID = inputItem.ReturnedInvoiceBrokerID;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.Commission = inputItem.Commission;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.CommissionInBaseCurrency = inputItem.CommissionInBaseCurrency;  
  
		entity.PartyRef = inputItem.PartyRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReturnedInvoiceBrokerDto Map(ReturnedInvoiceBroker inputItem)
        {
            var dto = new ReturnedInvoiceBrokerDto()
            {
                  
  
		ReturnedInvoiceBrokerID = inputItem.ReturnedInvoiceBrokerID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		Commission = inputItem.Commission,  
  
		Rate = inputItem.Rate,  
  
		CommissionInBaseCurrency = inputItem.CommissionInBaseCurrency,  
  
		PartyRef = inputItem.PartyRef, 
            };
            return dto;
        }

        public static List<ReturnedInvoiceBrokerDto> Map(ICollection<ReturnedInvoiceBroker> entities)
        {
            var dtos = new List<ReturnedInvoiceBrokerDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnedInvoiceBrokerDto()
                {
                      
  
		ReturnedInvoiceBrokerID = inputItem.ReturnedInvoiceBrokerID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		Commission = inputItem.Commission,  
  
		Rate = inputItem.Rate,  
  
		CommissionInBaseCurrency = inputItem.CommissionInBaseCurrency,  
  
		PartyRef = inputItem.PartyRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReturnedInvoiceCommissionBroker Map(AddReturnedInvoiceCommissionBrokerCommand inputItem)
        {
            var entity = new ReturnedInvoiceCommissionBroker() {
                  
  
		ReturnedInvoiceCommissionBrokerID = inputItem.ReturnedInvoiceCommissionBrokerID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent,  
  
		ManualCommissionAmount = inputItem.ManualCommissionAmount, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReturnedInvoiceCommissionBroker Map(ReturnedInvoiceCommissionBroker entity ,EditReturnedInvoiceCommissionBrokerCommand inputItem)
        {
              
  
		entity.ReturnedInvoiceCommissionBrokerID = inputItem.ReturnedInvoiceCommissionBrokerID;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.SalePortionPercent = inputItem.SalePortionPercent;  
  
		entity.ManualCommissionAmount = inputItem.ManualCommissionAmount; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReturnedInvoiceCommissionBrokerDto Map(ReturnedInvoiceCommissionBroker inputItem)
        {
            var dto = new ReturnedInvoiceCommissionBrokerDto()
            {
                  
  
		ReturnedInvoiceCommissionBrokerID = inputItem.ReturnedInvoiceCommissionBrokerID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent,  
  
		ManualCommissionAmount = inputItem.ManualCommissionAmount, 
            };
            return dto;
        }

        public static List<ReturnedInvoiceCommissionBrokerDto> Map(ICollection<ReturnedInvoiceCommissionBroker> entities)
        {
            var dtos = new List<ReturnedInvoiceCommissionBrokerDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnedInvoiceCommissionBrokerDto()
                {
                      
  
		ReturnedInvoiceCommissionBrokerID = inputItem.ReturnedInvoiceCommissionBrokerID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		SalePortionPercent = inputItem.SalePortionPercent,  
  
		ManualCommissionAmount = inputItem.ManualCommissionAmount, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReturnedInvoiceItem Map(AddReturnedInvoiceItemCommand inputItem)
        {
            var entity = new ReturnedInvoiceItem() {
                  
  
		ReturnedInvoiceItemID = inputItem.ReturnedInvoiceItemID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnOrderItemRef = inputItem.ReturnOrderItemRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountReturnedInvoiceItemRef = inputItem.DiscountReturnedInvoiceItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		ReturnReasonRef = inputItem.ReturnReasonRef,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReturnedInvoiceItem Map(ReturnedInvoiceItem entity ,EditReturnedInvoiceItemCommand inputItem)
        {
              
  
		entity.ReturnedInvoiceItemID = inputItem.ReturnedInvoiceItemID;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Fee = inputItem.Fee;  
  
		entity.Price = inputItem.Price;  
  
		entity.PriceInBaseCurrency = inputItem.PriceInBaseCurrency;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency;  
  
		entity.PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate;  
  
		entity.CustomerDiscount = inputItem.CustomerDiscount;  
  
		entity.CustomerDiscountRate = inputItem.CustomerDiscountRate;  
  
		entity.PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount;  
  
		entity.PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount;  
  
		entity.AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate;  
  
		entity.AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount;  
  
		entity.AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount;  
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.InvoiceItemRef = inputItem.InvoiceItemRef;  
  
		entity.ReturnOrderItemRef = inputItem.ReturnOrderItemRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.DiscountReturnedInvoiceItemRef = inputItem.DiscountReturnedInvoiceItemRef;  
  
		entity.ProductPackRef = inputItem.ProductPackRef;  
  
		entity.ProductPackQuantity = inputItem.ProductPackQuantity;  
  
		entity.ReturnReasonRef = inputItem.ReturnReasonRef;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReturnedInvoiceItemDto Map(ReturnedInvoiceItem inputItem)
        {
            var dto = new ReturnedInvoiceItemDto()
            {
                  
  
		ReturnedInvoiceItemID = inputItem.ReturnedInvoiceItemID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnOrderItemRef = inputItem.ReturnOrderItemRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountReturnedInvoiceItemRef = inputItem.DiscountReturnedInvoiceItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		ReturnReasonRef = inputItem.ReturnReasonRef,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<ReturnedInvoiceItemDto> Map(ICollection<ReturnedInvoiceItem> entities)
        {
            var dtos = new List<ReturnedInvoiceItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnedInvoiceItemDto()
                {
                      
  
		ReturnedInvoiceItemID = inputItem.ReturnedInvoiceItemID,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Fee = inputItem.Fee,  
  
		Price = inputItem.Price,  
  
		PriceInBaseCurrency = inputItem.PriceInBaseCurrency,  
  
		Discount = inputItem.Discount,  
  
		DiscountInBaseCurrency = inputItem.DiscountInBaseCurrency,  
  
		PriceInfoDiscountRate = inputItem.PriceInfoDiscountRate,  
  
		CustomerDiscount = inputItem.CustomerDiscount,  
  
		CustomerDiscountRate = inputItem.CustomerDiscountRate,  
  
		PriceInfoPriceDiscount = inputItem.PriceInfoPriceDiscount,  
  
		PriceInfoPercentDiscount = inputItem.PriceInfoPercentDiscount,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Rate = inputItem.Rate,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
		ReturnOrderItemRef = inputItem.ReturnOrderItemRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountReturnedInvoiceItemRef = inputItem.DiscountReturnedInvoiceItemRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		ReturnReasonRef = inputItem.ReturnReasonRef,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReturnedInvoiceItemAdditionFactor Map(AddReturnedInvoiceItemAdditionFactorCommand inputItem)
        {
            var entity = new ReturnedInvoiceItemAdditionFactor() {
                  
  
		ReturnedInvoiceItemAdditionFactorID = inputItem.ReturnedInvoiceItemAdditionFactorID,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReturnedInvoiceItemAdditionFactor Map(ReturnedInvoiceItemAdditionFactor entity ,EditReturnedInvoiceItemAdditionFactorCommand inputItem)
        {
              
  
		entity.ReturnedInvoiceItemAdditionFactorID = inputItem.ReturnedInvoiceItemAdditionFactorID;  
  
		entity.ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef;  
  
		entity.AdditionFactorRef = inputItem.AdditionFactorRef;  
  
		entity.Value = inputItem.Value;  
  
		entity.ValueInBaseCurrency = inputItem.ValueInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReturnedInvoiceItemAdditionFactorDto Map(ReturnedInvoiceItemAdditionFactor inputItem)
        {
            var dto = new ReturnedInvoiceItemAdditionFactorDto()
            {
                  
  
		ReturnedInvoiceItemAdditionFactorID = inputItem.ReturnedInvoiceItemAdditionFactorID,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
            };
            return dto;
        }

        public static List<ReturnedInvoiceItemAdditionFactorDto> Map(ICollection<ReturnedInvoiceItemAdditionFactor> entities)
        {
            var dtos = new List<ReturnedInvoiceItemAdditionFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnedInvoiceItemAdditionFactorDto()
                {
                      
  
		ReturnedInvoiceItemAdditionFactorID = inputItem.ReturnedInvoiceItemAdditionFactorID,  
  
		ReturnedInvoiceItemRef = inputItem.ReturnedInvoiceItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SaleType Map(AddSaleTypeCommand inputItem)
        {
            var entity = new SaleType() {
                  
  
		SaleTypeId = inputItem.SaleTypeId,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleTypeMarket = inputItem.SaleTypeMarket,  
  
		PartSalesSLRef = inputItem.PartSalesSLRef,  
  
		ServiceSalesSLRef = inputItem.ServiceSalesSLRef,  
  
		PartSalesReturnSLRef = inputItem.PartSalesReturnSLRef,  
  
		ServiceSalesReturnSLRef = inputItem.ServiceSalesReturnSLRef,  
  
		PartSalesDiscountSLRef = inputItem.PartSalesDiscountSLRef,  
  
		ServiceSalesDiscountSLRef = inputItem.ServiceSalesDiscountSLRef,  
  
		SalesAdditionSLRef = inputItem.SalesAdditionSLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SaleType Map(SaleType entity ,EditSaleTypeCommand inputItem)
        {
              
  
		entity.SaleTypeId = inputItem.SaleTypeId;  
  
		entity.Number = inputItem.Number;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.SaleTypeMarket = inputItem.SaleTypeMarket;  
  
		entity.PartSalesSLRef = inputItem.PartSalesSLRef;  
  
		entity.ServiceSalesSLRef = inputItem.ServiceSalesSLRef;  
  
		entity.PartSalesReturnSLRef = inputItem.PartSalesReturnSLRef;  
  
		entity.ServiceSalesReturnSLRef = inputItem.ServiceSalesReturnSLRef;  
  
		entity.PartSalesDiscountSLRef = inputItem.PartSalesDiscountSLRef;  
  
		entity.ServiceSalesDiscountSLRef = inputItem.ServiceSalesDiscountSLRef;  
  
		entity.SalesAdditionSLRef = inputItem.SalesAdditionSLRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SaleTypeDto Map(SaleType inputItem)
        {
            var dto = new SaleTypeDto()
            {
                  
  
		SaleTypeId = inputItem.SaleTypeId,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleTypeMarket = inputItem.SaleTypeMarket,  
  
		PartSalesSLRef = inputItem.PartSalesSLRef,  
  
		ServiceSalesSLRef = inputItem.ServiceSalesSLRef,  
  
		PartSalesReturnSLRef = inputItem.PartSalesReturnSLRef,  
  
		ServiceSalesReturnSLRef = inputItem.ServiceSalesReturnSLRef,  
  
		PartSalesDiscountSLRef = inputItem.PartSalesDiscountSLRef,  
  
		ServiceSalesDiscountSLRef = inputItem.ServiceSalesDiscountSLRef,  
  
		SalesAdditionSLRef = inputItem.SalesAdditionSLRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<SaleTypeDto> Map(ICollection<SaleType> entities)
        {
            var dtos = new List<SaleTypeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SaleTypeDto()
                {
                      
  
		SaleTypeId = inputItem.SaleTypeId,  
  
		Number = inputItem.Number,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		SaleTypeMarket = inputItem.SaleTypeMarket,  
  
		PartSalesSLRef = inputItem.PartSalesSLRef,  
  
		ServiceSalesSLRef = inputItem.ServiceSalesSLRef,  
  
		PartSalesReturnSLRef = inputItem.PartSalesReturnSLRef,  
  
		ServiceSalesReturnSLRef = inputItem.ServiceSalesReturnSLRef,  
  
		PartSalesDiscountSLRef = inputItem.PartSalesDiscountSLRef,  
  
		ServiceSalesDiscountSLRef = inputItem.ServiceSalesDiscountSLRef,  
  
		SalesAdditionSLRef = inputItem.SalesAdditionSLRef,  
  
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

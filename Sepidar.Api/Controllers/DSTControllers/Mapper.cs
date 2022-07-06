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
                
        
        public static AreaAndPath Map(AddAreaAndPathCommand inputItem)
        {
            var entity = new AreaAndPath() {
                  
  
		AreaAndPathId = inputItem.AreaAndPathId,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		ParentAreaAndPathRef = inputItem.ParentAreaAndPathRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static AreaAndPath Map(AreaAndPath entity ,EditAreaAndPathCommand inputItem)
        {
              
  
		entity.AreaAndPathId = inputItem.AreaAndPathId;  
  
		entity.Type = inputItem.Type;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.ParentAreaAndPathRef = inputItem.ParentAreaAndPathRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static AreaAndPathDto Map(AreaAndPath inputItem)
        {
            var dto = new AreaAndPathDto()
            {
                  
  
		AreaAndPathId = inputItem.AreaAndPathId,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		ParentAreaAndPathRef = inputItem.ParentAreaAndPathRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<AreaAndPathDto> Map(ICollection<AreaAndPath> entities)
        {
            var dtos = new List<AreaAndPathDto>();
            foreach (var inputItem in entities)
            {
                var dto = new AreaAndPathDto()
                {
                      
  
		AreaAndPathId = inputItem.AreaAndPathId,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		IsActive = inputItem.IsActive,  
  
		ParentAreaAndPathRef = inputItem.ParentAreaAndPathRef,  
  
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
        
        public static ColdDistribution Map(AddColdDistributionCommand inputItem)
        {
            var entity = new ColdDistribution() {
                  
  
		ColdDistributionId = inputItem.ColdDistributionId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DistributorPartyRef = inputItem.DistributorPartyRef,  
  
		TruckRef = inputItem.TruckRef,  
  
		DriverPartyRef = inputItem.DriverPartyRef,  
  
		State = inputItem.State,  
  
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

        public static ColdDistribution Map(ColdDistribution entity ,EditColdDistributionCommand inputItem)
        {
              
  
		entity.ColdDistributionId = inputItem.ColdDistributionId;  
  
		entity.Date = inputItem.Date;  
  
		entity.Number = inputItem.Number;  
  
		entity.DistributorPartyRef = inputItem.DistributorPartyRef;  
  
		entity.TruckRef = inputItem.TruckRef;  
  
		entity.DriverPartyRef = inputItem.DriverPartyRef;  
  
		entity.State = inputItem.State;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ColdDistributionDto Map(ColdDistribution inputItem)
        {
            var dto = new ColdDistributionDto()
            {
                  
  
		ColdDistributionId = inputItem.ColdDistributionId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DistributorPartyRef = inputItem.DistributorPartyRef,  
  
		TruckRef = inputItem.TruckRef,  
  
		DriverPartyRef = inputItem.DriverPartyRef,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<ColdDistributionDto> Map(ICollection<ColdDistribution> entities)
        {
            var dtos = new List<ColdDistributionDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ColdDistributionDto()
                {
                      
  
		ColdDistributionId = inputItem.ColdDistributionId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DistributorPartyRef = inputItem.DistributorPartyRef,  
  
		TruckRef = inputItem.TruckRef,  
  
		DriverPartyRef = inputItem.DriverPartyRef,  
  
		State = inputItem.State,  
  
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
        
        public static ColdDistributionInvoice Map(AddColdDistributionInvoiceCommand inputItem)
        {
            var entity = new ColdDistributionInvoice() {
                  
  
		ColdDistributionInvoiceId = inputItem.ColdDistributionInvoiceId,  
  
		ColdDistributionRef = inputItem.ColdDistributionRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ColdDistributionInvoice Map(ColdDistributionInvoice entity ,EditColdDistributionInvoiceCommand inputItem)
        {
              
  
		entity.ColdDistributionInvoiceId = inputItem.ColdDistributionInvoiceId;  
  
		entity.ColdDistributionRef = inputItem.ColdDistributionRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ColdDistributionInvoiceDto Map(ColdDistributionInvoice inputItem)
        {
            var dto = new ColdDistributionInvoiceDto()
            {
                  
  
		ColdDistributionInvoiceId = inputItem.ColdDistributionInvoiceId,  
  
		ColdDistributionRef = inputItem.ColdDistributionRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef, 
            };
            return dto;
        }

        public static List<ColdDistributionInvoiceDto> Map(ICollection<ColdDistributionInvoice> entities)
        {
            var dtos = new List<ColdDistributionInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ColdDistributionInvoiceDto()
                {
                      
  
		ColdDistributionInvoiceId = inputItem.ColdDistributionInvoiceId,  
  
		ColdDistributionRef = inputItem.ColdDistributionRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ColdDistributionReturnedInvoice Map(AddColdDistributionReturnedInvoiceCommand inputItem)
        {
            var entity = new ColdDistributionReturnedInvoice() {
                  
  
		ColdDistributionReturnedInvoiceId = inputItem.ColdDistributionReturnedInvoiceId,  
  
		ColdDistributionRef = inputItem.ColdDistributionRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ColdDistributionReturnedInvoice Map(ColdDistributionReturnedInvoice entity ,EditColdDistributionReturnedInvoiceCommand inputItem)
        {
              
  
		entity.ColdDistributionReturnedInvoiceId = inputItem.ColdDistributionReturnedInvoiceId;  
  
		entity.ColdDistributionRef = inputItem.ColdDistributionRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ColdDistributionReturnedInvoiceDto Map(ColdDistributionReturnedInvoice inputItem)
        {
            var dto = new ColdDistributionReturnedInvoiceDto()
            {
                  
  
		ColdDistributionReturnedInvoiceId = inputItem.ColdDistributionReturnedInvoiceId,  
  
		ColdDistributionRef = inputItem.ColdDistributionRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef, 
            };
            return dto;
        }

        public static List<ColdDistributionReturnedInvoiceDto> Map(ICollection<ColdDistributionReturnedInvoice> entities)
        {
            var dtos = new List<ColdDistributionReturnedInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ColdDistributionReturnedInvoiceDto()
                {
                      
  
		ColdDistributionReturnedInvoiceId = inputItem.ColdDistributionReturnedInvoiceId,  
  
		ColdDistributionRef = inputItem.ColdDistributionRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static DebtCollectionList Map(AddDebtCollectionListCommand inputItem)
        {
            var entity = new DebtCollectionList() {
                  
  
		DebtCollectionListId = inputItem.DebtCollectionListId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DebtCollectorPartyRef = inputItem.DebtCollectorPartyRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		State = inputItem.State,  
  
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

        public static DebtCollectionList Map(DebtCollectionList entity ,EditDebtCollectionListCommand inputItem)
        {
              
  
		entity.DebtCollectionListId = inputItem.DebtCollectionListId;  
  
		entity.Date = inputItem.Date;  
  
		entity.Number = inputItem.Number;  
  
		entity.DebtCollectorPartyRef = inputItem.DebtCollectorPartyRef;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.State = inputItem.State;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DebtCollectionListDto Map(DebtCollectionList inputItem)
        {
            var dto = new DebtCollectionListDto()
            {
                  
  
		DebtCollectionListId = inputItem.DebtCollectionListId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DebtCollectorPartyRef = inputItem.DebtCollectorPartyRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<DebtCollectionListDto> Map(ICollection<DebtCollectionList> entities)
        {
            var dtos = new List<DebtCollectionListDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DebtCollectionListDto()
                {
                      
  
		DebtCollectionListId = inputItem.DebtCollectionListId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DebtCollectorPartyRef = inputItem.DebtCollectorPartyRef,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		State = inputItem.State,  
  
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
        
        public static DebtCollectionListInvoice Map(AddDebtCollectionListInvoiceCommand inputItem)
        {
            var entity = new DebtCollectionListInvoice() {
                  
  
		DebtCollectionListInvoiceId = inputItem.DebtCollectionListInvoiceId,  
  
		DebtCollectionListRef = inputItem.DebtCollectionListRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Amount = inputItem.Amount,  
  
		Discount = inputItem.Discount,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		PartyAccountSettlementRef = inputItem.PartyAccountSettlementRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static DebtCollectionListInvoice Map(DebtCollectionListInvoice entity ,EditDebtCollectionListInvoiceCommand inputItem)
        {
              
  
		entity.DebtCollectionListInvoiceId = inputItem.DebtCollectionListInvoiceId;  
  
		entity.DebtCollectionListRef = inputItem.DebtCollectionListRef;  
  
		entity.RowNumber = inputItem.RowNumber;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.Amount = inputItem.Amount;  
  
		entity.Discount = inputItem.Discount;  
  
		entity.UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef;  
  
		entity.PartyAccountSettlementRef = inputItem.PartyAccountSettlementRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static DebtCollectionListInvoiceDto Map(DebtCollectionListInvoice inputItem)
        {
            var dto = new DebtCollectionListInvoiceDto()
            {
                  
  
		DebtCollectionListInvoiceId = inputItem.DebtCollectionListInvoiceId,  
  
		DebtCollectionListRef = inputItem.DebtCollectionListRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Amount = inputItem.Amount,  
  
		Discount = inputItem.Discount,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		PartyAccountSettlementRef = inputItem.PartyAccountSettlementRef, 
            };
            return dto;
        }

        public static List<DebtCollectionListInvoiceDto> Map(ICollection<DebtCollectionListInvoice> entities)
        {
            var dtos = new List<DebtCollectionListInvoiceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new DebtCollectionListInvoiceDto()
                {
                      
  
		DebtCollectionListInvoiceId = inputItem.DebtCollectionListInvoiceId,  
  
		DebtCollectionListRef = inputItem.DebtCollectionListRef,  
  
		RowNumber = inputItem.RowNumber,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		Amount = inputItem.Amount,  
  
		Discount = inputItem.Discount,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		PartyAccountSettlementRef = inputItem.PartyAccountSettlementRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HotDistribution Map(AddHotDistributionCommand inputItem)
        {
            var entity = new HotDistribution() {
                  
  
		HotDistributionId = inputItem.HotDistributionId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DistributorPartyRef = inputItem.DistributorPartyRef,  
  
		TruckRef = inputItem.TruckRef,  
  
		DriverPartyRef = inputItem.DriverPartyRef,  
  
		StockRef = inputItem.StockRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsModifiedByDevice = inputItem.IsModifiedByDevice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HotDistribution Map(HotDistribution entity ,EditHotDistributionCommand inputItem)
        {
              
  
		entity.HotDistributionId = inputItem.HotDistributionId;  
  
		entity.Date = inputItem.Date;  
  
		entity.Number = inputItem.Number;  
  
		entity.DistributorPartyRef = inputItem.DistributorPartyRef;  
  
		entity.TruckRef = inputItem.TruckRef;  
  
		entity.DriverPartyRef = inputItem.DriverPartyRef;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.InventoryDeliveryRef = inputItem.InventoryDeliveryRef;  
  
		entity.State = inputItem.State;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.IsModifiedByDevice = inputItem.IsModifiedByDevice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HotDistributionDto Map(HotDistribution inputItem)
        {
            var dto = new HotDistributionDto()
            {
                  
  
		HotDistributionId = inputItem.HotDistributionId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DistributorPartyRef = inputItem.DistributorPartyRef,  
  
		TruckRef = inputItem.TruckRef,  
  
		DriverPartyRef = inputItem.DriverPartyRef,  
  
		StockRef = inputItem.StockRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsModifiedByDevice = inputItem.IsModifiedByDevice, 
            };
            return dto;
        }

        public static List<HotDistributionDto> Map(ICollection<HotDistribution> entities)
        {
            var dtos = new List<HotDistributionDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HotDistributionDto()
                {
                      
  
		HotDistributionId = inputItem.HotDistributionId,  
  
		Date = inputItem.Date,  
  
		Number = inputItem.Number,  
  
		DistributorPartyRef = inputItem.DistributorPartyRef,  
  
		TruckRef = inputItem.TruckRef,  
  
		DriverPartyRef = inputItem.DriverPartyRef,  
  
		StockRef = inputItem.StockRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		State = inputItem.State,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		IsModifiedByDevice = inputItem.IsModifiedByDevice, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HotDistributionInventoryDelivery Map(AddHotDistributionInventoryDeliveryCommand inputItem)
        {
            var entity = new HotDistributionInventoryDelivery() {
                  
  
		HotDistributionInventoryDeliveryId = inputItem.HotDistributionInventoryDeliveryId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HotDistributionInventoryDelivery Map(HotDistributionInventoryDelivery entity ,EditHotDistributionInventoryDeliveryCommand inputItem)
        {
              
  
		entity.HotDistributionInventoryDeliveryId = inputItem.HotDistributionInventoryDeliveryId;  
  
		entity.HotDistributionRef = inputItem.HotDistributionRef;  
  
		entity.InventoryDeliveryRef = inputItem.InventoryDeliveryRef;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HotDistributionInventoryDeliveryDto Map(HotDistributionInventoryDelivery inputItem)
        {
            var dto = new HotDistributionInventoryDeliveryDto()
            {
                  
  
		HotDistributionInventoryDeliveryId = inputItem.HotDistributionInventoryDeliveryId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef, 
            };
            return dto;
        }

        public static List<HotDistributionInventoryDeliveryDto> Map(ICollection<HotDistributionInventoryDelivery> entities)
        {
            var dtos = new List<HotDistributionInventoryDeliveryDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HotDistributionInventoryDeliveryDto()
                {
                      
  
		HotDistributionInventoryDeliveryId = inputItem.HotDistributionInventoryDeliveryId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		InventoryDeliveryRef = inputItem.InventoryDeliveryRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HotDistributionItem Map(AddHotDistributionItemCommand inputItem)
        {
            var entity = new HotDistributionItem() {
                  
  
		HotDistributionItemId = inputItem.HotDistributionItemId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HotDistributionItem Map(HotDistributionItem entity ,EditHotDistributionItemCommand inputItem)
        {
              
  
		entity.HotDistributionItemId = inputItem.HotDistributionItemId;  
  
		entity.HotDistributionRef = inputItem.HotDistributionRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HotDistributionItemDto Map(HotDistributionItem inputItem)
        {
            var dto = new HotDistributionItemDto()
            {
                  
  
		HotDistributionItemId = inputItem.HotDistributionItemId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
            };
            return dto;
        }

        public static List<HotDistributionItemDto> Map(ICollection<HotDistributionItem> entities)
        {
            var dtos = new List<HotDistributionItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HotDistributionItemDto()
                {
                      
  
		HotDistributionItemId = inputItem.HotDistributionItemId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HotDistributionPath Map(AddHotDistributionPathCommand inputItem)
        {
            var entity = new HotDistributionPath() {
                  
  
		HotDistributionPathId = inputItem.HotDistributionPathId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		PathRef = inputItem.PathRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HotDistributionPath Map(HotDistributionPath entity ,EditHotDistributionPathCommand inputItem)
        {
              
  
		entity.HotDistributionPathId = inputItem.HotDistributionPathId;  
  
		entity.HotDistributionRef = inputItem.HotDistributionRef;  
  
		entity.PathRef = inputItem.PathRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HotDistributionPathDto Map(HotDistributionPath inputItem)
        {
            var dto = new HotDistributionPathDto()
            {
                  
  
		HotDistributionPathId = inputItem.HotDistributionPathId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		PathRef = inputItem.PathRef, 
            };
            return dto;
        }

        public static List<HotDistributionPathDto> Map(ICollection<HotDistributionPath> entities)
        {
            var dtos = new List<HotDistributionPathDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HotDistributionPathDto()
                {
                      
  
		HotDistributionPathId = inputItem.HotDistributionPathId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		PathRef = inputItem.PathRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HotDistributionSaleDocument Map(AddHotDistributionSaleDocumentCommand inputItem)
        {
            var entity = new HotDistributionSaleDocument() {
                  
  
		HotDistributionSaleDocumentId = inputItem.HotDistributionSaleDocumentId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		IsDocCreatedByHotDistribution = inputItem.IsDocCreatedByHotDistribution, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HotDistributionSaleDocument Map(HotDistributionSaleDocument entity ,EditHotDistributionSaleDocumentCommand inputItem)
        {
              
  
		entity.HotDistributionSaleDocumentId = inputItem.HotDistributionSaleDocumentId;  
  
		entity.HotDistributionRef = inputItem.HotDistributionRef;  
  
		entity.InvoiceRef = inputItem.InvoiceRef;  
  
		entity.ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef;  
  
		entity.IsDocCreatedByHotDistribution = inputItem.IsDocCreatedByHotDistribution; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HotDistributionSaleDocumentDto Map(HotDistributionSaleDocument inputItem)
        {
            var dto = new HotDistributionSaleDocumentDto()
            {
                  
  
		HotDistributionSaleDocumentId = inputItem.HotDistributionSaleDocumentId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		IsDocCreatedByHotDistribution = inputItem.IsDocCreatedByHotDistribution, 
            };
            return dto;
        }

        public static List<HotDistributionSaleDocumentDto> Map(ICollection<HotDistributionSaleDocument> entities)
        {
            var dtos = new List<HotDistributionSaleDocumentDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HotDistributionSaleDocumentDto()
                {
                      
  
		HotDistributionSaleDocumentId = inputItem.HotDistributionSaleDocumentId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		InvoiceRef = inputItem.InvoiceRef,  
  
		ReturnedInvoiceRef = inputItem.ReturnedInvoiceRef,  
  
		IsDocCreatedByHotDistribution = inputItem.IsDocCreatedByHotDistribution, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static HotDistributionUnexecutedAct Map(AddHotDistributionUnexecutedActCommand inputItem)
        {
            var entity = new HotDistributionUnexecutedAct() {
                  
  
		HotDistributionUnexecutedActId = inputItem.HotDistributionUnexecutedActId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Guid = inputItem.Guid,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static HotDistributionUnexecutedAct Map(HotDistributionUnexecutedAct entity ,EditHotDistributionUnexecutedActCommand inputItem)
        {
              
  
		entity.HotDistributionUnexecutedActId = inputItem.HotDistributionUnexecutedActId;  
  
		entity.HotDistributionRef = inputItem.HotDistributionRef;  
  
		entity.AreaAndPathRef = inputItem.AreaAndPathRef;  
  
		entity.PartyAddressRef = inputItem.PartyAddressRef;  
  
		entity.UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static HotDistributionUnexecutedActDto Map(HotDistributionUnexecutedAct inputItem)
        {
            var dto = new HotDistributionUnexecutedActDto()
            {
                  
  
		HotDistributionUnexecutedActId = inputItem.HotDistributionUnexecutedActId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Guid = inputItem.Guid,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<HotDistributionUnexecutedActDto> Map(ICollection<HotDistributionUnexecutedAct> entities)
        {
            var dtos = new List<HotDistributionUnexecutedActDto>();
            foreach (var inputItem in entities)
            {
                var dto = new HotDistributionUnexecutedActDto()
                {
                      
  
		HotDistributionUnexecutedActId = inputItem.HotDistributionUnexecutedActId,  
  
		HotDistributionRef = inputItem.HotDistributionRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Guid = inputItem.Guid,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Order Map(AddOrderCommand inputItem)
        {
            var entity = new Order() {
                  
  
		OrderID = inputItem.OrderID,  
  
		State = inputItem.State,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		BrokerPartyRef = inputItem.BrokerPartyRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerPartyAddressRef = inputItem.CustomerPartyAddressRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
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
  
		Agreements = inputItem.Agreements,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
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

        public static Order Map(Order entity ,EditOrderCommand inputItem)
        {
              
  
		entity.OrderID = inputItem.OrderID;  
  
		entity.State = inputItem.State;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.BrokerPartyRef = inputItem.BrokerPartyRef;  
  
		entity.CustomerPartyRef = inputItem.CustomerPartyRef;  
  
		entity.CustomerPartyAddressRef = inputItem.CustomerPartyAddressRef;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.DeliveryDate = inputItem.DeliveryDate;  
  
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
  
		entity.Agreements = inputItem.Agreements;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OrderDto Map(Order inputItem)
        {
            var dto = new OrderDto()
            {
                  
  
		OrderID = inputItem.OrderID,  
  
		State = inputItem.State,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		BrokerPartyRef = inputItem.BrokerPartyRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerPartyAddressRef = inputItem.CustomerPartyAddressRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
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
  
		Agreements = inputItem.Agreements,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<OrderDto> Map(ICollection<Order> entities)
        {
            var dtos = new List<OrderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OrderDto()
                {
                      
  
		OrderID = inputItem.OrderID,  
  
		State = inputItem.State,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		BrokerPartyRef = inputItem.BrokerPartyRef,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerPartyAddressRef = inputItem.CustomerPartyAddressRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		DeliveryDate = inputItem.DeliveryDate,  
  
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
  
		Agreements = inputItem.Agreements,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
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
        
        public static OrderingFailure Map(AddOrderingFailureCommand inputItem)
        {
            var entity = new OrderingFailure() {
                  
  
		OrderingFailureId = inputItem.OrderingFailureId,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
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

        public static OrderingFailure Map(OrderingFailure entity ,EditOrderingFailureCommand inputItem)
        {
              
  
		entity.OrderingFailureId = inputItem.OrderingFailureId;  
  
		entity.Date = inputItem.Date;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OrderingFailureDto Map(OrderingFailure inputItem)
        {
            var dto = new OrderingFailureDto()
            {
                  
  
		OrderingFailureId = inputItem.OrderingFailureId,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<OrderingFailureDto> Map(ICollection<OrderingFailure> entities)
        {
            var dtos = new List<OrderingFailureDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OrderingFailureDto()
                {
                      
  
		OrderingFailureId = inputItem.OrderingFailureId,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
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
        
        public static OrderingFailureItem Map(AddOrderingFailureItemCommand inputItem)
        {
            var entity = new OrderingFailureItem() {
                  
  
		OrderingFailureItemId = inputItem.OrderingFailureItemId,  
  
		OrderingFailureRef = inputItem.OrderingFailureRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Guid = inputItem.Guid,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OrderingFailureItem Map(OrderingFailureItem entity ,EditOrderingFailureItemCommand inputItem)
        {
              
  
		entity.OrderingFailureItemId = inputItem.OrderingFailureItemId;  
  
		entity.OrderingFailureRef = inputItem.OrderingFailureRef;  
  
		entity.AreaAndPathRef = inputItem.AreaAndPathRef;  
  
		entity.PartyAddressRef = inputItem.PartyAddressRef;  
  
		entity.UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OrderingFailureItemDto Map(OrderingFailureItem inputItem)
        {
            var dto = new OrderingFailureItemDto()
            {
                  
  
		OrderingFailureItemId = inputItem.OrderingFailureItemId,  
  
		OrderingFailureRef = inputItem.OrderingFailureRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Guid = inputItem.Guid,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<OrderingFailureItemDto> Map(ICollection<OrderingFailureItem> entities)
        {
            var dtos = new List<OrderingFailureItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OrderingFailureItemDto()
                {
                      
  
		OrderingFailureItemId = inputItem.OrderingFailureItemId,  
  
		OrderingFailureRef = inputItem.OrderingFailureRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		UnexecutedActReasonRef = inputItem.UnexecutedActReasonRef,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		Guid = inputItem.Guid,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OrderingSchedule Map(AddOrderingScheduleCommand inputItem)
        {
            var entity = new OrderingSchedule() {
                  
  
		OrderingScheduleId = inputItem.OrderingScheduleId,  
  
		OrderingScheduleRecurrenceRef = inputItem.OrderingScheduleRecurrenceRef,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		IsLockedByDevice = inputItem.IsLockedByDevice,  
  
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

        public static OrderingSchedule Map(OrderingSchedule entity ,EditOrderingScheduleCommand inputItem)
        {
              
  
		entity.OrderingScheduleId = inputItem.OrderingScheduleId;  
  
		entity.OrderingScheduleRecurrenceRef = inputItem.OrderingScheduleRecurrenceRef;  
  
		entity.Date = inputItem.Date;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.AreaAndPathRef = inputItem.AreaAndPathRef;  
  
		entity.IsLockedByDevice = inputItem.IsLockedByDevice;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OrderingScheduleDto Map(OrderingSchedule inputItem)
        {
            var dto = new OrderingScheduleDto()
            {
                  
  
		OrderingScheduleId = inputItem.OrderingScheduleId,  
  
		OrderingScheduleRecurrenceRef = inputItem.OrderingScheduleRecurrenceRef,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		IsLockedByDevice = inputItem.IsLockedByDevice,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<OrderingScheduleDto> Map(ICollection<OrderingSchedule> entities)
        {
            var dtos = new List<OrderingScheduleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OrderingScheduleDto()
                {
                      
  
		OrderingScheduleId = inputItem.OrderingScheduleId,  
  
		OrderingScheduleRecurrenceRef = inputItem.OrderingScheduleRecurrenceRef,  
  
		Date = inputItem.Date,  
  
		PartyRef = inputItem.PartyRef,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		IsLockedByDevice = inputItem.IsLockedByDevice,  
  
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
        
        public static OrderingScheduleRecurrence Map(AddOrderingScheduleRecurrenceCommand inputItem)
        {
            var entity = new OrderingScheduleRecurrence() {
                  
  
		OrderingScheduleRecurrenceId = inputItem.OrderingScheduleRecurrenceId,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Type = inputItem.Type,  
  
		DayInterval = inputItem.DayInterval,  
  
		WeekInterval = inputItem.WeekInterval,  
  
		Weekdays = inputItem.Weekdays,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OrderingScheduleRecurrence Map(OrderingScheduleRecurrence entity ,EditOrderingScheduleRecurrenceCommand inputItem)
        {
              
  
		entity.OrderingScheduleRecurrenceId = inputItem.OrderingScheduleRecurrenceId;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.Type = inputItem.Type;  
  
		entity.DayInterval = inputItem.DayInterval;  
  
		entity.WeekInterval = inputItem.WeekInterval;  
  
		entity.Weekdays = inputItem.Weekdays;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OrderingScheduleRecurrenceDto Map(OrderingScheduleRecurrence inputItem)
        {
            var dto = new OrderingScheduleRecurrenceDto()
            {
                  
  
		OrderingScheduleRecurrenceId = inputItem.OrderingScheduleRecurrenceId,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Type = inputItem.Type,  
  
		DayInterval = inputItem.DayInterval,  
  
		WeekInterval = inputItem.WeekInterval,  
  
		Weekdays = inputItem.Weekdays,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<OrderingScheduleRecurrenceDto> Map(ICollection<OrderingScheduleRecurrence> entities)
        {
            var dtos = new List<OrderingScheduleRecurrenceDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OrderingScheduleRecurrenceDto()
                {
                      
  
		OrderingScheduleRecurrenceId = inputItem.OrderingScheduleRecurrenceId,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Type = inputItem.Type,  
  
		DayInterval = inputItem.DayInterval,  
  
		WeekInterval = inputItem.WeekInterval,  
  
		Weekdays = inputItem.Weekdays,  
  
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
        
        public static OrderingScheduleRelatedActivities Map(AddOrderingScheduleRelatedActivitiesCommand inputItem)
        {
            var entity = new OrderingScheduleRelatedActivities() {
                  
  
		OrderingScheduleRelatedActivitiesId = inputItem.OrderingScheduleRelatedActivitiesId,  
  
		ScheduleId = inputItem.ScheduleId,  
  
		OrderRef = inputItem.OrderRef,  
  
		OrderingFailureItemRef = inputItem.OrderingFailureItemRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OrderingScheduleRelatedActivities Map(OrderingScheduleRelatedActivities entity ,EditOrderingScheduleRelatedActivitiesCommand inputItem)
        {
              
  
		entity.OrderingScheduleRelatedActivitiesId = inputItem.OrderingScheduleRelatedActivitiesId;  
  
		entity.ScheduleId = inputItem.ScheduleId;  
  
		entity.OrderRef = inputItem.OrderRef;  
  
		entity.OrderingFailureItemRef = inputItem.OrderingFailureItemRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OrderingScheduleRelatedActivitiesDto Map(OrderingScheduleRelatedActivities inputItem)
        {
            var dto = new OrderingScheduleRelatedActivitiesDto()
            {
                  
  
		OrderingScheduleRelatedActivitiesId = inputItem.OrderingScheduleRelatedActivitiesId,  
  
		ScheduleId = inputItem.ScheduleId,  
  
		OrderRef = inputItem.OrderRef,  
  
		OrderingFailureItemRef = inputItem.OrderingFailureItemRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<OrderingScheduleRelatedActivitiesDto> Map(ICollection<OrderingScheduleRelatedActivities> entities)
        {
            var dtos = new List<OrderingScheduleRelatedActivitiesDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OrderingScheduleRelatedActivitiesDto()
                {
                      
  
		OrderingScheduleRelatedActivitiesId = inputItem.OrderingScheduleRelatedActivitiesId,  
  
		ScheduleId = inputItem.ScheduleId,  
  
		OrderRef = inputItem.OrderRef,  
  
		OrderingFailureItemRef = inputItem.OrderingFailureItemRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static OrderItem Map(AddOrderItemCommand inputItem)
        {
            var entity = new OrderItem() {
                  
  
		OrderItemID = inputItem.OrderItemID,  
  
		OrderRef = inputItem.OrderRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		OrderedQuantity = inputItem.OrderedQuantity,  
  
		OrderedSecondaryQuantity = inputItem.OrderedSecondaryQuantity,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		InvoicedQuantity = inputItem.InvoicedQuantity,  
  
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
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountOrderItemRef = inputItem.DiscountOrderItemRef,  
  
		Rate = inputItem.Rate,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		OrderedProductPackQuantity = inputItem.OrderedProductPackQuantity,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OrderItem Map(OrderItem entity ,EditOrderItemCommand inputItem)
        {
              
  
		entity.OrderItemID = inputItem.OrderItemID;  
  
		entity.OrderRef = inputItem.OrderRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef;  
  
		entity.StockRef = inputItem.StockRef;  
  
		entity.OrderedQuantity = inputItem.OrderedQuantity;  
  
		entity.OrderedSecondaryQuantity = inputItem.OrderedSecondaryQuantity;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.InvoicedQuantity = inputItem.InvoicedQuantity;  
  
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
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.DiscountOrderItemRef = inputItem.DiscountOrderItemRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.ProductPackRef = inputItem.ProductPackRef;  
  
		entity.OrderedProductPackQuantity = inputItem.OrderedProductPackQuantity;  
  
		entity.ProductPackQuantity = inputItem.ProductPackQuantity;  
  
		entity.AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate;  
  
		entity.AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount;  
  
		entity.AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OrderItemDto Map(OrderItem inputItem)
        {
            var dto = new OrderItemDto()
            {
                  
  
		OrderItemID = inputItem.OrderItemID,  
  
		OrderRef = inputItem.OrderRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		OrderedQuantity = inputItem.OrderedQuantity,  
  
		OrderedSecondaryQuantity = inputItem.OrderedSecondaryQuantity,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		InvoicedQuantity = inputItem.InvoicedQuantity,  
  
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
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountOrderItemRef = inputItem.DiscountOrderItemRef,  
  
		Rate = inputItem.Rate,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		OrderedProductPackQuantity = inputItem.OrderedProductPackQuantity,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<OrderItemDto> Map(ICollection<OrderItem> entities)
        {
            var dtos = new List<OrderItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OrderItemDto()
                {
                      
  
		OrderItemID = inputItem.OrderItemID,  
  
		OrderRef = inputItem.OrderRef,  
  
		RowID = inputItem.RowID,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef,  
  
		StockRef = inputItem.StockRef,  
  
		OrderedQuantity = inputItem.OrderedQuantity,  
  
		OrderedSecondaryQuantity = inputItem.OrderedSecondaryQuantity,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		InvoicedQuantity = inputItem.InvoicedQuantity,  
  
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
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountOrderItemRef = inputItem.DiscountOrderItemRef,  
  
		Rate = inputItem.Rate,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		OrderedProductPackQuantity = inputItem.OrderedProductPackQuantity,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
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
        
        public static OrderItemAdditionFactor Map(AddOrderItemAdditionFactorCommand inputItem)
        {
            var entity = new OrderItemAdditionFactor() {
                  
  
		OrderItemAdditionFactorID = inputItem.OrderItemAdditionFactorID,  
  
		OrderItemRef = inputItem.OrderItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static OrderItemAdditionFactor Map(OrderItemAdditionFactor entity ,EditOrderItemAdditionFactorCommand inputItem)
        {
              
  
		entity.OrderItemAdditionFactorID = inputItem.OrderItemAdditionFactorID;  
  
		entity.OrderItemRef = inputItem.OrderItemRef;  
  
		entity.AdditionFactorRef = inputItem.AdditionFactorRef;  
  
		entity.Value = inputItem.Value;  
  
		entity.ValueInBaseCurrency = inputItem.ValueInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static OrderItemAdditionFactorDto Map(OrderItemAdditionFactor inputItem)
        {
            var dto = new OrderItemAdditionFactorDto()
            {
                  
  
		OrderItemAdditionFactorID = inputItem.OrderItemAdditionFactorID,  
  
		OrderItemRef = inputItem.OrderItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
            };
            return dto;
        }

        public static List<OrderItemAdditionFactorDto> Map(ICollection<OrderItemAdditionFactor> entities)
        {
            var dtos = new List<OrderItemAdditionFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new OrderItemAdditionFactorDto()
                {
                      
  
		OrderItemAdditionFactorID = inputItem.OrderItemAdditionFactorID,  
  
		OrderItemRef = inputItem.OrderItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static PathPartyAddress Map(AddPathPartyAddressCommand inputItem)
        {
            var entity = new PathPartyAddress() {
                  
  
		PathPartyAddressId = inputItem.PathPartyAddressId,  
  
		RowOrder = inputItem.RowOrder,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static PathPartyAddress Map(PathPartyAddress entity ,EditPathPartyAddressCommand inputItem)
        {
              
  
		entity.PathPartyAddressId = inputItem.PathPartyAddressId;  
  
		entity.RowOrder = inputItem.RowOrder;  
  
		entity.AreaAndPathRef = inputItem.AreaAndPathRef;  
  
		entity.PartyAddressRef = inputItem.PartyAddressRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static PathPartyAddressDto Map(PathPartyAddress inputItem)
        {
            var dto = new PathPartyAddressDto()
            {
                  
  
		PathPartyAddressId = inputItem.PathPartyAddressId,  
  
		RowOrder = inputItem.RowOrder,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<PathPartyAddressDto> Map(ICollection<PathPartyAddress> entities)
        {
            var dtos = new List<PathPartyAddressDto>();
            foreach (var inputItem in entities)
            {
                var dto = new PathPartyAddressDto()
                {
                      
  
		PathPartyAddressId = inputItem.PathPartyAddressId,  
  
		RowOrder = inputItem.RowOrder,  
  
		AreaAndPathRef = inputItem.AreaAndPathRef,  
  
		PartyAddressRef = inputItem.PartyAddressRef,  
  
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
        
        public static ProductSaleLine Map(AddProductSaleLineCommand inputItem)
        {
            var entity = new ProductSaleLine() {
                  
  
		ProductSaleLineId = inputItem.ProductSaleLineId,  
  
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

        public static ProductSaleLine Map(ProductSaleLine entity ,EditProductSaleLineCommand inputItem)
        {
              
  
		entity.ProductSaleLineId = inputItem.ProductSaleLineId;  
  
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

        
        public static ProductSaleLineDto Map(ProductSaleLine inputItem)
        {
            var dto = new ProductSaleLineDto()
            {
                  
  
		ProductSaleLineId = inputItem.ProductSaleLineId,  
  
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

        public static List<ProductSaleLineDto> Map(ICollection<ProductSaleLine> entities)
        {
            var dtos = new List<ProductSaleLineDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductSaleLineDto()
                {
                      
  
		ProductSaleLineId = inputItem.ProductSaleLineId,  
  
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
        
        public static ProductSaleLineItem Map(AddProductSaleLineItemCommand inputItem)
        {
            var entity = new ProductSaleLineItem() {
                  
  
		ProductSaleLineItemId = inputItem.ProductSaleLineItemId,  
  
		ProductSaleLineRef = inputItem.ProductSaleLineRef,  
  
		ItemRef = inputItem.ItemRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ProductSaleLineItem Map(ProductSaleLineItem entity ,EditProductSaleLineItemCommand inputItem)
        {
              
  
		entity.ProductSaleLineItemId = inputItem.ProductSaleLineItemId;  
  
		entity.ProductSaleLineRef = inputItem.ProductSaleLineRef;  
  
		entity.ItemRef = inputItem.ItemRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProductSaleLineItemDto Map(ProductSaleLineItem inputItem)
        {
            var dto = new ProductSaleLineItemDto()
            {
                  
  
		ProductSaleLineItemId = inputItem.ProductSaleLineItemId,  
  
		ProductSaleLineRef = inputItem.ProductSaleLineRef,  
  
		ItemRef = inputItem.ItemRef, 
            };
            return dto;
        }

        public static List<ProductSaleLineItemDto> Map(ICollection<ProductSaleLineItem> entities)
        {
            var dtos = new List<ProductSaleLineItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductSaleLineItemDto()
                {
                      
  
		ProductSaleLineItemId = inputItem.ProductSaleLineItemId,  
  
		ProductSaleLineRef = inputItem.ProductSaleLineRef,  
  
		ItemRef = inputItem.ItemRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ProductSaleLineParty Map(AddProductSaleLinePartyCommand inputItem)
        {
            var entity = new ProductSaleLineParty() {
                  
  
		ProductSaleLinePartyId = inputItem.ProductSaleLinePartyId,  
  
		ProductSaleLineRef = inputItem.ProductSaleLineRef,  
  
		PartyRef = inputItem.PartyRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ProductSaleLineParty Map(ProductSaleLineParty entity ,EditProductSaleLinePartyCommand inputItem)
        {
              
  
		entity.ProductSaleLinePartyId = inputItem.ProductSaleLinePartyId;  
  
		entity.ProductSaleLineRef = inputItem.ProductSaleLineRef;  
  
		entity.PartyRef = inputItem.PartyRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProductSaleLinePartyDto Map(ProductSaleLineParty inputItem)
        {
            var dto = new ProductSaleLinePartyDto()
            {
                  
  
		ProductSaleLinePartyId = inputItem.ProductSaleLinePartyId,  
  
		ProductSaleLineRef = inputItem.ProductSaleLineRef,  
  
		PartyRef = inputItem.PartyRef, 
            };
            return dto;
        }

        public static List<ProductSaleLinePartyDto> Map(ICollection<ProductSaleLineParty> entities)
        {
            var dtos = new List<ProductSaleLinePartyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductSaleLinePartyDto()
                {
                      
  
		ProductSaleLinePartyId = inputItem.ProductSaleLinePartyId,  
  
		ProductSaleLineRef = inputItem.ProductSaleLineRef,  
  
		PartyRef = inputItem.PartyRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReturnOrder Map(AddReturnOrderCommand inputItem)
        {
            var entity = new ReturnOrder() {
                  
  
		ReturnOrderID = inputItem.ReturnOrderID,  
  
		State = inputItem.State,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerPartyAddressRef = inputItem.CustomerPartyAddressRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
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
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
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

        public static ReturnOrder Map(ReturnOrder entity ,EditReturnOrderCommand inputItem)
        {
              
  
		entity.ReturnOrderID = inputItem.ReturnOrderID;  
  
		entity.State = inputItem.State;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.CurrencyRef = inputItem.CurrencyRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.CustomerPartyRef = inputItem.CustomerPartyRef;  
  
		entity.CustomerPartyAddressRef = inputItem.CustomerPartyAddressRef;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Description = inputItem.Description;  
  
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
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReturnOrderDto Map(ReturnOrder inputItem)
        {
            var dto = new ReturnOrderDto()
            {
                  
  
		ReturnOrderID = inputItem.ReturnOrderID,  
  
		State = inputItem.State,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerPartyAddressRef = inputItem.CustomerPartyAddressRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
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
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Guid = inputItem.Guid,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<ReturnOrderDto> Map(ICollection<ReturnOrder> entities)
        {
            var dtos = new List<ReturnOrderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnOrderDto()
                {
                      
  
		ReturnOrderID = inputItem.ReturnOrderID,  
  
		State = inputItem.State,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		CurrencyRef = inputItem.CurrencyRef,  
  
		Rate = inputItem.Rate,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		CustomerPartyAddressRef = inputItem.CustomerPartyAddressRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Description = inputItem.Description,  
  
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
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
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
        
        public static ReturnOrderItem Map(AddReturnOrderItemCommand inputItem)
        {
            var entity = new ReturnOrderItem() {
                  
  
		ReturnOrderItemID = inputItem.ReturnOrderItemID,  
  
		ReturnOrderRef = inputItem.ReturnOrderRef,  
  
		RowID = inputItem.RowID,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
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
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountReturnOrderItemRef = inputItem.DiscountReturnOrderItemRef,  
  
		Rate = inputItem.Rate,  
  
		ReurnReasonRef = inputItem.ReurnReasonRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
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

        public static ReturnOrderItem Map(ReturnOrderItem entity ,EditReturnOrderItemCommand inputItem)
        {
              
  
		entity.ReturnOrderItemID = inputItem.ReturnOrderItemID;  
  
		entity.ReturnOrderRef = inputItem.ReturnOrderRef;  
  
		entity.RowID = inputItem.RowID;  
  
		entity.InvoiceItemRef = inputItem.InvoiceItemRef;  
  
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
  
		entity.Addition = inputItem.Addition;  
  
		entity.AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency;  
  
		entity.Tax = inputItem.Tax;  
  
		entity.TaxInBaseCurrency = inputItem.TaxInBaseCurrency;  
  
		entity.Duty = inputItem.Duty;  
  
		entity.DutyInBaseCurrency = inputItem.DutyInBaseCurrency;  
  
		entity.NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency;  
  
		entity.Description = inputItem.Description;  
  
		entity.Description_En = inputItem.Description_En;  
  
		entity.DiscountReturnOrderItemRef = inputItem.DiscountReturnOrderItemRef;  
  
		entity.Rate = inputItem.Rate;  
  
		entity.ReurnReasonRef = inputItem.ReurnReasonRef;  
  
		entity.ProductPackRef = inputItem.ProductPackRef;  
  
		entity.ProductPackQuantity = inputItem.ProductPackQuantity;  
  
		entity.AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate;  
  
		entity.AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount;  
  
		entity.AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount;  
  
		entity.ReturnReasonRef = inputItem.ReturnReasonRef;  
  
		entity.AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective;  
  
		entity.AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective;  
  
		entity.AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective;  
  
		entity.AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective;  
  
		entity.NetPrice = inputItem.NetPrice; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReturnOrderItemDto Map(ReturnOrderItem inputItem)
        {
            var dto = new ReturnOrderItemDto()
            {
                  
  
		ReturnOrderItemID = inputItem.ReturnOrderItemID,  
  
		ReturnOrderRef = inputItem.ReturnOrderRef,  
  
		RowID = inputItem.RowID,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
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
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountReturnOrderItemRef = inputItem.DiscountReturnOrderItemRef,  
  
		Rate = inputItem.Rate,  
  
		ReurnReasonRef = inputItem.ReurnReasonRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
		ReturnReasonRef = inputItem.ReturnReasonRef,  
  
		AdditionFactor_VatEffective = inputItem.AdditionFactor_VatEffective,  
  
		AdditionFactorInBaseCurrency_VatEffective = inputItem.AdditionFactorInBaseCurrency_VatEffective,  
  
		AdditionFactor_VatIneffective = inputItem.AdditionFactor_VatIneffective,  
  
		AdditionFactorInBaseCurrency_VatIneffective = inputItem.AdditionFactorInBaseCurrency_VatIneffective,  
  
		NetPrice = inputItem.NetPrice, 
            };
            return dto;
        }

        public static List<ReturnOrderItemDto> Map(ICollection<ReturnOrderItem> entities)
        {
            var dtos = new List<ReturnOrderItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnOrderItemDto()
                {
                      
  
		ReturnOrderItemID = inputItem.ReturnOrderItemID,  
  
		ReturnOrderRef = inputItem.ReturnOrderRef,  
  
		RowID = inputItem.RowID,  
  
		InvoiceItemRef = inputItem.InvoiceItemRef,  
  
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
  
		Addition = inputItem.Addition,  
  
		AdditionInBaseCurrency = inputItem.AdditionInBaseCurrency,  
  
		Tax = inputItem.Tax,  
  
		TaxInBaseCurrency = inputItem.TaxInBaseCurrency,  
  
		Duty = inputItem.Duty,  
  
		DutyInBaseCurrency = inputItem.DutyInBaseCurrency,  
  
		NetPriceInBaseCurrency = inputItem.NetPriceInBaseCurrency,  
  
		Description = inputItem.Description,  
  
		Description_En = inputItem.Description_En,  
  
		DiscountReturnOrderItemRef = inputItem.DiscountReturnOrderItemRef,  
  
		Rate = inputItem.Rate,  
  
		ReurnReasonRef = inputItem.ReurnReasonRef,  
  
		ProductPackRef = inputItem.ProductPackRef,  
  
		ProductPackQuantity = inputItem.ProductPackQuantity,  
  
		AggregateAmountDiscountRate = inputItem.AggregateAmountDiscountRate,  
  
		AggregateAmountPriceDiscount = inputItem.AggregateAmountPriceDiscount,  
  
		AggregateAmountPercentDiscount = inputItem.AggregateAmountPercentDiscount,  
  
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
        
        public static ReturnOrderItemAdditionFactor Map(AddReturnOrderItemAdditionFactorCommand inputItem)
        {
            var entity = new ReturnOrderItemAdditionFactor() {
                  
  
		ReturnOrderItemAdditionFactorID = inputItem.ReturnOrderItemAdditionFactorID,  
  
		ReturnOrderItemRef = inputItem.ReturnOrderItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ReturnOrderItemAdditionFactor Map(ReturnOrderItemAdditionFactor entity ,EditReturnOrderItemAdditionFactorCommand inputItem)
        {
              
  
		entity.ReturnOrderItemAdditionFactorID = inputItem.ReturnOrderItemAdditionFactorID;  
  
		entity.ReturnOrderItemRef = inputItem.ReturnOrderItemRef;  
  
		entity.AdditionFactorRef = inputItem.AdditionFactorRef;  
  
		entity.Value = inputItem.Value;  
  
		entity.ValueInBaseCurrency = inputItem.ValueInBaseCurrency; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ReturnOrderItemAdditionFactorDto Map(ReturnOrderItemAdditionFactor inputItem)
        {
            var dto = new ReturnOrderItemAdditionFactorDto()
            {
                  
  
		ReturnOrderItemAdditionFactorID = inputItem.ReturnOrderItemAdditionFactorID,  
  
		ReturnOrderItemRef = inputItem.ReturnOrderItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
            };
            return dto;
        }

        public static List<ReturnOrderItemAdditionFactorDto> Map(ICollection<ReturnOrderItemAdditionFactor> entities)
        {
            var dtos = new List<ReturnOrderItemAdditionFactorDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnOrderItemAdditionFactorDto()
                {
                      
  
		ReturnOrderItemAdditionFactorID = inputItem.ReturnOrderItemAdditionFactorID,  
  
		ReturnOrderItemRef = inputItem.ReturnOrderItemRef,  
  
		AdditionFactorRef = inputItem.AdditionFactorRef,  
  
		Value = inputItem.Value,  
  
		ValueInBaseCurrency = inputItem.ValueInBaseCurrency, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ReturnReason Map(AddReturnReasonCommand inputItem)
        {
            var entity = new ReturnReason() {
                  
  
		ReturnReasonID = inputItem.ReturnReasonID,  
  
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

        public static ReturnReason Map(ReturnReason entity ,EditReturnReasonCommand inputItem)
        {
              
  
		entity.ReturnReasonID = inputItem.ReturnReasonID;  
  
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

        
        public static ReturnReasonDto Map(ReturnReason inputItem)
        {
            var dto = new ReturnReasonDto()
            {
                  
  
		ReturnReasonID = inputItem.ReturnReasonID,  
  
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

        public static List<ReturnReasonDto> Map(ICollection<ReturnReason> entities)
        {
            var dtos = new List<ReturnReasonDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ReturnReasonDto()
                {
                      
  
		ReturnReasonID = inputItem.ReturnReasonID,  
  
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
        
        public static SalesLimit Map(AddSalesLimitCommand inputItem)
        {
            var entity = new SalesLimit() {
                  
  
		SalesLimitId = inputItem.SalesLimitId,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ControlType = inputItem.ControlType,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
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

        public static SalesLimit Map(SalesLimit entity ,EditSalesLimitCommand inputItem)
        {
              
  
		entity.SalesLimitId = inputItem.SalesLimitId;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.ControlType = inputItem.ControlType;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SalesLimitDto Map(SalesLimit inputItem)
        {
            var dto = new SalesLimitDto()
            {
                  
  
		SalesLimitId = inputItem.SalesLimitId,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ControlType = inputItem.ControlType,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		IsActive = inputItem.IsActive,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<SalesLimitDto> Map(ICollection<SalesLimit> entities)
        {
            var dtos = new List<SalesLimitDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SalesLimitDto()
                {
                      
  
		SalesLimitId = inputItem.SalesLimitId,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		ControlType = inputItem.ControlType,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
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
        
        public static SalesLimitItem Map(AddSalesLimitItemCommand inputItem)
        {
            var entity = new SalesLimitItem() {
                  
  
		SalesLimitItemId = inputItem.SalesLimitItemId,  
  
		SalesLimitRef = inputItem.SalesLimitRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SalesLimitItem Map(SalesLimitItem entity ,EditSalesLimitItemCommand inputItem)
        {
              
  
		entity.SalesLimitItemId = inputItem.SalesLimitItemId;  
  
		entity.SalesLimitRef = inputItem.SalesLimitRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.TracingRef = inputItem.TracingRef; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SalesLimitItemDto Map(SalesLimitItem inputItem)
        {
            var dto = new SalesLimitItemDto()
            {
                  
  
		SalesLimitItemId = inputItem.SalesLimitItemId,  
  
		SalesLimitRef = inputItem.SalesLimitRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
            };
            return dto;
        }

        public static List<SalesLimitItemDto> Map(ICollection<SalesLimitItem> entities)
        {
            var dtos = new List<SalesLimitItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SalesLimitItemDto()
                {
                      
  
		SalesLimitItemId = inputItem.SalesLimitItemId,  
  
		SalesLimitRef = inputItem.SalesLimitRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		TracingRef = inputItem.TracingRef, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SalesLimitItemParty Map(AddSalesLimitItemPartyCommand inputItem)
        {
            var entity = new SalesLimitItemParty() {
                  
  
		SalesLimitItemPartyId = inputItem.SalesLimitItemPartyId,  
  
		SalesLimitItemRef = inputItem.SalesLimitItemRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SalesLimitItemParty Map(SalesLimitItemParty entity ,EditSalesLimitItemPartyCommand inputItem)
        {
              
  
		entity.SalesLimitItemPartyId = inputItem.SalesLimitItemPartyId;  
  
		entity.SalesLimitItemRef = inputItem.SalesLimitItemRef;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SalesLimitItemPartyDto Map(SalesLimitItemParty inputItem)
        {
            var dto = new SalesLimitItemPartyDto()
            {
                  
  
		SalesLimitItemPartyId = inputItem.SalesLimitItemPartyId,  
  
		SalesLimitItemRef = inputItem.SalesLimitItemRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
            };
            return dto;
        }

        public static List<SalesLimitItemPartyDto> Map(ICollection<SalesLimitItemParty> entities)
        {
            var dtos = new List<SalesLimitItemPartyDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SalesLimitItemPartyDto()
                {
                      
  
		SalesLimitItemPartyId = inputItem.SalesLimitItemPartyId,  
  
		SalesLimitItemRef = inputItem.SalesLimitItemRef,  
  
		PartyRef = inputItem.PartyRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static SaleTypeConstraint Map(AddSaleTypeConstraintCommand inputItem)
        {
            var entity = new SaleTypeConstraint() {
                  
  
		SaleTypeConstraintID = inputItem.SaleTypeConstraintID,  
  
		PartyRef = inputItem.PartyRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SaleTypeConstraint Map(SaleTypeConstraint entity ,EditSaleTypeConstraintCommand inputItem)
        {
              
  
		entity.SaleTypeConstraintID = inputItem.SaleTypeConstraintID;  
  
		entity.PartyRef = inputItem.PartyRef;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SaleTypeConstraintDto Map(SaleTypeConstraint inputItem)
        {
            var dto = new SaleTypeConstraintDto()
            {
                  
  
		SaleTypeConstraintID = inputItem.SaleTypeConstraintID,  
  
		PartyRef = inputItem.PartyRef,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<SaleTypeConstraintDto> Map(ICollection<SaleTypeConstraint> entities)
        {
            var dtos = new List<SaleTypeConstraintDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SaleTypeConstraintDto()
                {
                      
  
		SaleTypeConstraintID = inputItem.SaleTypeConstraintID,  
  
		PartyRef = inputItem.PartyRef,  
  
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
        
        public static SaleTypeConstraintItem Map(AddSaleTypeConstraintItemCommand inputItem)
        {
            var entity = new SaleTypeConstraintItem() {
                  
  
		SaleTypeConstraintItemID = inputItem.SaleTypeConstraintItemID,  
  
		SaleTypeConstraintRef = inputItem.SaleTypeConstraintRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SaleTypeConstraintItem Map(SaleTypeConstraintItem entity ,EditSaleTypeConstraintItemCommand inputItem)
        {
              
  
		entity.SaleTypeConstraintItemID = inputItem.SaleTypeConstraintItemID;  
  
		entity.SaleTypeConstraintRef = inputItem.SaleTypeConstraintRef;  
  
		entity.SaleTypeRef = inputItem.SaleTypeRef;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SaleTypeConstraintItemDto Map(SaleTypeConstraintItem inputItem)
        {
            var dto = new SaleTypeConstraintItemDto()
            {
                  
  
		SaleTypeConstraintItemID = inputItem.SaleTypeConstraintItemID,  
  
		SaleTypeConstraintRef = inputItem.SaleTypeConstraintRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<SaleTypeConstraintItemDto> Map(ICollection<SaleTypeConstraintItem> entities)
        {
            var dtos = new List<SaleTypeConstraintItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SaleTypeConstraintItemDto()
                {
                      
  
		SaleTypeConstraintItemID = inputItem.SaleTypeConstraintItemID,  
  
		SaleTypeConstraintRef = inputItem.SaleTypeConstraintRef,  
  
		SaleTypeRef = inputItem.SaleTypeRef,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UnexecutedActReason Map(AddUnexecutedActReasonCommand inputItem)
        {
            var entity = new UnexecutedActReason() {
                  
  
		UnexecutedActReasonId = inputItem.UnexecutedActReasonId,  
  
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

        public static UnexecutedActReason Map(UnexecutedActReason entity ,EditUnexecutedActReasonCommand inputItem)
        {
              
  
		entity.UnexecutedActReasonId = inputItem.UnexecutedActReasonId;  
  
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

        
        public static UnexecutedActReasonDto Map(UnexecutedActReason inputItem)
        {
            var dto = new UnexecutedActReasonDto()
            {
                  
  
		UnexecutedActReasonId = inputItem.UnexecutedActReasonId,  
  
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

        public static List<UnexecutedActReasonDto> Map(ICollection<UnexecutedActReason> entities)
        {
            var dtos = new List<UnexecutedActReasonDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UnexecutedActReasonDto()
                {
                      
  
		UnexecutedActReasonId = inputItem.UnexecutedActReasonId,  
  
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
    }
}

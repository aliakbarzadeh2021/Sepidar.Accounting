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
                
        
        public static FormulaBomItem Map(AddFormulaBomItemCommand inputItem)
        {
            var entity = new FormulaBomItem() {
                  
  
		FormulaBomItemID = inputItem.FormulaBomItemID,  
  
		ProductFormulaRef = inputItem.ProductFormulaRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Description = inputItem.Description, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static FormulaBomItem Map(FormulaBomItem entity ,EditFormulaBomItemCommand inputItem)
        {
              
  
		entity.FormulaBomItemID = inputItem.FormulaBomItemID;  
  
		entity.ProductFormulaRef = inputItem.ProductFormulaRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.SecondaryQuantity = inputItem.SecondaryQuantity;  
  
		entity.Description = inputItem.Description; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static FormulaBomItemDto Map(FormulaBomItem inputItem)
        {
            var dto = new FormulaBomItemDto()
            {
                  
  
		FormulaBomItemID = inputItem.FormulaBomItemID,  
  
		ProductFormulaRef = inputItem.ProductFormulaRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Description = inputItem.Description, 
            };
            return dto;
        }

        public static List<FormulaBomItemDto> Map(ICollection<FormulaBomItem> entities)
        {
            var dtos = new List<FormulaBomItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new FormulaBomItemDto()
                {
                      
  
		FormulaBomItemID = inputItem.FormulaBomItemID,  
  
		ProductFormulaRef = inputItem.ProductFormulaRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		Quantity = inputItem.Quantity,  
  
		SecondaryQuantity = inputItem.SecondaryQuantity,  
  
		Description = inputItem.Description, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static FormulaBomItemAlternative Map(AddFormulaBomItemAlternativeCommand inputItem)
        {
            var entity = new FormulaBomItemAlternative() {
                  
  
		FormulaBomItemAlternativeID = inputItem.FormulaBomItemAlternativeID,  
  
		FormulaBomItemRef = inputItem.FormulaBomItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		AlternativeRatio = inputItem.AlternativeRatio, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static FormulaBomItemAlternative Map(FormulaBomItemAlternative entity ,EditFormulaBomItemAlternativeCommand inputItem)
        {
              
  
		entity.FormulaBomItemAlternativeID = inputItem.FormulaBomItemAlternativeID;  
  
		entity.FormulaBomItemRef = inputItem.FormulaBomItemRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.AlternativeRatio = inputItem.AlternativeRatio; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static FormulaBomItemAlternativeDto Map(FormulaBomItemAlternative inputItem)
        {
            var dto = new FormulaBomItemAlternativeDto()
            {
                  
  
		FormulaBomItemAlternativeID = inputItem.FormulaBomItemAlternativeID,  
  
		FormulaBomItemRef = inputItem.FormulaBomItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		AlternativeRatio = inputItem.AlternativeRatio, 
            };
            return dto;
        }

        public static List<FormulaBomItemAlternativeDto> Map(ICollection<FormulaBomItemAlternative> entities)
        {
            var dtos = new List<FormulaBomItemAlternativeDto>();
            foreach (var inputItem in entities)
            {
                var dto = new FormulaBomItemAlternativeDto()
                {
                      
  
		FormulaBomItemAlternativeID = inputItem.FormulaBomItemAlternativeID,  
  
		FormulaBomItemRef = inputItem.FormulaBomItemRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		AlternativeRatio = inputItem.AlternativeRatio, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ProductFormula Map(AddProductFormulaCommand inputItem)
        {
            var entity = new ProductFormula() {
                  
  
		ProductFormulaID = inputItem.ProductFormulaID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		ItemRef = inputItem.ItemRef,  
  
		ItemUnitRef = inputItem.ItemUnitRef,  
  
		Quantity = inputItem.Quantity,  
  
		IsActive = inputItem.IsActive,  
  
		EstimatedLabour = inputItem.EstimatedLabour,  
  
		EstimatedOverhead = inputItem.EstimatedOverhead,  
  
		BaseProductFormula = inputItem.BaseProductFormula,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ProductFormula Map(ProductFormula entity ,EditProductFormulaCommand inputItem)
        {
              
  
		entity.ProductFormulaID = inputItem.ProductFormulaID;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.ItemUnitRef = inputItem.ItemUnitRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.EstimatedLabour = inputItem.EstimatedLabour;  
  
		entity.EstimatedOverhead = inputItem.EstimatedOverhead;  
  
		entity.BaseProductFormula = inputItem.BaseProductFormula;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProductFormulaDto Map(ProductFormula inputItem)
        {
            var dto = new ProductFormulaDto()
            {
                  
  
		ProductFormulaID = inputItem.ProductFormulaID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		ItemRef = inputItem.ItemRef,  
  
		ItemUnitRef = inputItem.ItemUnitRef,  
  
		Quantity = inputItem.Quantity,  
  
		IsActive = inputItem.IsActive,  
  
		EstimatedLabour = inputItem.EstimatedLabour,  
  
		EstimatedOverhead = inputItem.EstimatedOverhead,  
  
		BaseProductFormula = inputItem.BaseProductFormula,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ProductFormulaDto> Map(ICollection<ProductFormula> entities)
        {
            var dtos = new List<ProductFormulaDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductFormulaDto()
                {
                      
  
		ProductFormulaID = inputItem.ProductFormulaID,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		ItemRef = inputItem.ItemRef,  
  
		ItemUnitRef = inputItem.ItemUnitRef,  
  
		Quantity = inputItem.Quantity,  
  
		IsActive = inputItem.IsActive,  
  
		EstimatedLabour = inputItem.EstimatedLabour,  
  
		EstimatedOverhead = inputItem.EstimatedOverhead,  
  
		BaseProductFormula = inputItem.BaseProductFormula,  
  
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
        
        public static ProductOrder Map(AddProductOrderCommand inputItem)
        {
            var entity = new ProductOrder() {
                  
  
		ProductOrderID = inputItem.ProductOrderID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		BaseProductOrderRef = inputItem.BaseProductOrderRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		ProductRef = inputItem.ProductRef,  
  
		ProductFormulaRef = inputItem.ProductFormulaRef,  
  
		Quantity = inputItem.Quantity,  
  
		WastageQuantity = inputItem.WastageQuantity,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		State = inputItem.State,  
  
		RemainingBOMCost = inputItem.RemainingBOMCost,  
  
		BOMCost = inputItem.BOMCost,  
  
		EstimatedLabourCost = inputItem.EstimatedLabourCost,  
  
		EstimatedOverheadCost = inputItem.EstimatedOverheadCost,  
  
		Cost = inputItem.Cost,  
  
		BOMPercent = inputItem.BOMPercent,  
  
		EstimatedLabourPercent = inputItem.EstimatedLabourPercent,  
  
		EstimatedOverheadPercent = inputItem.EstimatedOverheadPercent,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CanTransferNextPeriod = inputItem.CanTransferNextPeriod,  
  
		IsInitial = inputItem.IsInitial,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ProductOrder Map(ProductOrder entity ,EditProductOrderCommand inputItem)
        {
              
  
		entity.ProductOrderID = inputItem.ProductOrderID;  
  
		entity.Number = inputItem.Number;  
  
		entity.Date = inputItem.Date;  
  
		entity.BaseProductOrderRef = inputItem.BaseProductOrderRef;  
  
		entity.CostCenterRef = inputItem.CostCenterRef;  
  
		entity.ProductRef = inputItem.ProductRef;  
  
		entity.ProductFormulaRef = inputItem.ProductFormulaRef;  
  
		entity.Quantity = inputItem.Quantity;  
  
		entity.WastageQuantity = inputItem.WastageQuantity;  
  
		entity.CustomerPartyRef = inputItem.CustomerPartyRef;  
  
		entity.State = inputItem.State;  
  
		entity.RemainingBOMCost = inputItem.RemainingBOMCost;  
  
		entity.BOMCost = inputItem.BOMCost;  
  
		entity.EstimatedLabourCost = inputItem.EstimatedLabourCost;  
  
		entity.EstimatedOverheadCost = inputItem.EstimatedOverheadCost;  
  
		entity.Cost = inputItem.Cost;  
  
		entity.BOMPercent = inputItem.BOMPercent;  
  
		entity.EstimatedLabourPercent = inputItem.EstimatedLabourPercent;  
  
		entity.EstimatedOverheadPercent = inputItem.EstimatedOverheadPercent;  
  
		entity.FiscalYearRef = inputItem.FiscalYearRef;  
  
		entity.CanTransferNextPeriod = inputItem.CanTransferNextPeriod;  
  
		entity.IsInitial = inputItem.IsInitial;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProductOrderDto Map(ProductOrder inputItem)
        {
            var dto = new ProductOrderDto()
            {
                  
  
		ProductOrderID = inputItem.ProductOrderID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		BaseProductOrderRef = inputItem.BaseProductOrderRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		ProductRef = inputItem.ProductRef,  
  
		ProductFormulaRef = inputItem.ProductFormulaRef,  
  
		Quantity = inputItem.Quantity,  
  
		WastageQuantity = inputItem.WastageQuantity,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		State = inputItem.State,  
  
		RemainingBOMCost = inputItem.RemainingBOMCost,  
  
		BOMCost = inputItem.BOMCost,  
  
		EstimatedLabourCost = inputItem.EstimatedLabourCost,  
  
		EstimatedOverheadCost = inputItem.EstimatedOverheadCost,  
  
		Cost = inputItem.Cost,  
  
		BOMPercent = inputItem.BOMPercent,  
  
		EstimatedLabourPercent = inputItem.EstimatedLabourPercent,  
  
		EstimatedOverheadPercent = inputItem.EstimatedOverheadPercent,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CanTransferNextPeriod = inputItem.CanTransferNextPeriod,  
  
		IsInitial = inputItem.IsInitial,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ProductOrderDto> Map(ICollection<ProductOrder> entities)
        {
            var dtos = new List<ProductOrderDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductOrderDto()
                {
                      
  
		ProductOrderID = inputItem.ProductOrderID,  
  
		Number = inputItem.Number,  
  
		Date = inputItem.Date,  
  
		BaseProductOrderRef = inputItem.BaseProductOrderRef,  
  
		CostCenterRef = inputItem.CostCenterRef,  
  
		ProductRef = inputItem.ProductRef,  
  
		ProductFormulaRef = inputItem.ProductFormulaRef,  
  
		Quantity = inputItem.Quantity,  
  
		WastageQuantity = inputItem.WastageQuantity,  
  
		CustomerPartyRef = inputItem.CustomerPartyRef,  
  
		State = inputItem.State,  
  
		RemainingBOMCost = inputItem.RemainingBOMCost,  
  
		BOMCost = inputItem.BOMCost,  
  
		EstimatedLabourCost = inputItem.EstimatedLabourCost,  
  
		EstimatedOverheadCost = inputItem.EstimatedOverheadCost,  
  
		Cost = inputItem.Cost,  
  
		BOMPercent = inputItem.BOMPercent,  
  
		EstimatedLabourPercent = inputItem.EstimatedLabourPercent,  
  
		EstimatedOverheadPercent = inputItem.EstimatedOverheadPercent,  
  
		FiscalYearRef = inputItem.FiscalYearRef,  
  
		CanTransferNextPeriod = inputItem.CanTransferNextPeriod,  
  
		IsInitial = inputItem.IsInitial,  
  
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
        
        public static ProductOrderBOMItem Map(AddProductOrderBOMItemCommand inputItem)
        {
            var entity = new ProductOrderBOMItem() {
                  
  
		ProductOrderBOMItemID = inputItem.ProductOrderBOMItemID,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		FormulaBOMItemRef = inputItem.FormulaBOMItemRef,  
  
		StandardConsumptionQuantity = inputItem.StandardConsumptionQuantity,  
  
		RemainingConsumptionQuantity = inputItem.RemainingConsumptionQuantity,  
  
		Description = inputItem.Description,  
  
		TransferedQuantity = inputItem.TransferedQuantity, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ProductOrderBOMItem Map(ProductOrderBOMItem entity ,EditProductOrderBOMItemCommand inputItem)
        {
              
  
		entity.ProductOrderBOMItemID = inputItem.ProductOrderBOMItemID;  
  
		entity.ProductOrderRef = inputItem.ProductOrderRef;  
  
		entity.ItemRef = inputItem.ItemRef;  
  
		entity.FormulaBOMItemRef = inputItem.FormulaBOMItemRef;  
  
		entity.StandardConsumptionQuantity = inputItem.StandardConsumptionQuantity;  
  
		entity.RemainingConsumptionQuantity = inputItem.RemainingConsumptionQuantity;  
  
		entity.Description = inputItem.Description;  
  
		entity.TransferedQuantity = inputItem.TransferedQuantity; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ProductOrderBOMItemDto Map(ProductOrderBOMItem inputItem)
        {
            var dto = new ProductOrderBOMItemDto()
            {
                  
  
		ProductOrderBOMItemID = inputItem.ProductOrderBOMItemID,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		FormulaBOMItemRef = inputItem.FormulaBOMItemRef,  
  
		StandardConsumptionQuantity = inputItem.StandardConsumptionQuantity,  
  
		RemainingConsumptionQuantity = inputItem.RemainingConsumptionQuantity,  
  
		Description = inputItem.Description,  
  
		TransferedQuantity = inputItem.TransferedQuantity, 
            };
            return dto;
        }

        public static List<ProductOrderBOMItemDto> Map(ICollection<ProductOrderBOMItem> entities)
        {
            var dtos = new List<ProductOrderBOMItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ProductOrderBOMItemDto()
                {
                      
  
		ProductOrderBOMItemID = inputItem.ProductOrderBOMItemID,  
  
		ProductOrderRef = inputItem.ProductOrderRef,  
  
		ItemRef = inputItem.ItemRef,  
  
		FormulaBOMItemRef = inputItem.FormulaBOMItemRef,  
  
		StandardConsumptionQuantity = inputItem.StandardConsumptionQuantity,  
  
		RemainingConsumptionQuantity = inputItem.RemainingConsumptionQuantity,  
  
		Description = inputItem.Description,  
  
		TransferedQuantity = inputItem.TransferedQuantity, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}

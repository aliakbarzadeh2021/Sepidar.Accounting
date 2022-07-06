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
                
        
        public static Scheduling Map(AddSchedulingCommand inputItem)
        {
            var entity = new Scheduling() {
                  
  
		SchedulingId = inputItem.SchedulingId,  
  
		Title = inputItem.Title,  
  
		IsActive = inputItem.IsActive,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Scheduling Map(Scheduling entity ,EditSchedulingCommand inputItem)
        {
              
  
		entity.SchedulingId = inputItem.SchedulingId;  
  
		entity.Title = inputItem.Title;  
  
		entity.IsActive = inputItem.IsActive;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SchedulingDto Map(Scheduling inputItem)
        {
            var dto = new SchedulingDto()
            {
                  
  
		SchedulingId = inputItem.SchedulingId,  
  
		Title = inputItem.Title,  
  
		IsActive = inputItem.IsActive,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<SchedulingDto> Map(ICollection<Scheduling> entities)
        {
            var dtos = new List<SchedulingDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SchedulingDto()
                {
                      
  
		SchedulingId = inputItem.SchedulingId,  
  
		Title = inputItem.Title,  
  
		IsActive = inputItem.IsActive,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
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
        
        public static SchedulingItem Map(AddSchedulingItemCommand inputItem)
        {
            var entity = new SchedulingItem() {
                  
  
		SchedulingItemId = inputItem.SchedulingItemId,  
  
		SchedulingRef = inputItem.SchedulingRef,  
  
		DateTime = inputItem.DateTime, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static SchedulingItem Map(SchedulingItem entity ,EditSchedulingItemCommand inputItem)
        {
              
  
		entity.SchedulingItemId = inputItem.SchedulingItemId;  
  
		entity.SchedulingRef = inputItem.SchedulingRef;  
  
		entity.DateTime = inputItem.DateTime; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static SchedulingItemDto Map(SchedulingItem inputItem)
        {
            var dto = new SchedulingItemDto()
            {
                  
  
		SchedulingItemId = inputItem.SchedulingItemId,  
  
		SchedulingRef = inputItem.SchedulingRef,  
  
		DateTime = inputItem.DateTime, 
            };
            return dto;
        }

        public static List<SchedulingItemDto> Map(ICollection<SchedulingItem> entities)
        {
            var dtos = new List<SchedulingItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new SchedulingItemDto()
                {
                      
  
		SchedulingItemId = inputItem.SchedulingItemId,  
  
		SchedulingRef = inputItem.SchedulingRef,  
  
		DateTime = inputItem.DateTime, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}

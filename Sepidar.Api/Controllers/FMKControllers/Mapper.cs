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
                
        
        public static ApiLog Map(AddApiLogCommand inputItem)
        {
            var entity = new ApiLog() {
                  
  
		ApiLogID = inputItem.ApiLogID,  
  
		RequestTime = inputItem.RequestTime,  
  
		RequestUrl = inputItem.RequestUrl,  
  
		RequestUserHostAddress = inputItem.RequestUserHostAddress,  
  
		RequestHeaders = inputItem.RequestHeaders,  
  
		RequestMethod = inputItem.RequestMethod,  
  
		RequestBody = inputItem.RequestBody,  
  
		Guid = inputItem.Guid,  
  
		UserRef = inputItem.UserRef,  
  
		UserName = inputItem.UserName,  
  
		UserName_En = inputItem.UserName_En,  
  
		UserUserName = inputItem.UserUserName,  
  
		DeviceRef = inputItem.DeviceRef,  
  
		DeviceTitle = inputItem.DeviceTitle,  
  
		DeviceTitle_En = inputItem.DeviceTitle_En,  
  
		DeviceCode = inputItem.DeviceCode,  
  
		OriginalResource = inputItem.OriginalResource,  
  
		ResponseTime = inputItem.ResponseTime,  
  
		ResponseRawText = inputItem.ResponseRawText,  
  
		ResponseStatusCode = inputItem.ResponseStatusCode, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ApiLog Map(ApiLog entity ,EditApiLogCommand inputItem)
        {
              
  
		entity.ApiLogID = inputItem.ApiLogID;  
  
		entity.RequestTime = inputItem.RequestTime;  
  
		entity.RequestUrl = inputItem.RequestUrl;  
  
		entity.RequestUserHostAddress = inputItem.RequestUserHostAddress;  
  
		entity.RequestHeaders = inputItem.RequestHeaders;  
  
		entity.RequestMethod = inputItem.RequestMethod;  
  
		entity.RequestBody = inputItem.RequestBody;  
  
		entity.Guid = inputItem.Guid;  
  
		entity.UserRef = inputItem.UserRef;  
  
		entity.UserName = inputItem.UserName;  
  
		entity.UserName_En = inputItem.UserName_En;  
  
		entity.UserUserName = inputItem.UserUserName;  
  
		entity.DeviceRef = inputItem.DeviceRef;  
  
		entity.DeviceTitle = inputItem.DeviceTitle;  
  
		entity.DeviceTitle_En = inputItem.DeviceTitle_En;  
  
		entity.DeviceCode = inputItem.DeviceCode;  
  
		entity.OriginalResource = inputItem.OriginalResource;  
  
		entity.ResponseTime = inputItem.ResponseTime;  
  
		entity.ResponseRawText = inputItem.ResponseRawText;  
  
		entity.ResponseStatusCode = inputItem.ResponseStatusCode; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ApiLogDto Map(ApiLog inputItem)
        {
            var dto = new ApiLogDto()
            {
                  
  
		ApiLogID = inputItem.ApiLogID,  
  
		RequestTime = inputItem.RequestTime,  
  
		RequestUrl = inputItem.RequestUrl,  
  
		RequestUserHostAddress = inputItem.RequestUserHostAddress,  
  
		RequestHeaders = inputItem.RequestHeaders,  
  
		RequestMethod = inputItem.RequestMethod,  
  
		RequestBody = inputItem.RequestBody,  
  
		Guid = inputItem.Guid,  
  
		UserRef = inputItem.UserRef,  
  
		UserName = inputItem.UserName,  
  
		UserName_En = inputItem.UserName_En,  
  
		UserUserName = inputItem.UserUserName,  
  
		DeviceRef = inputItem.DeviceRef,  
  
		DeviceTitle = inputItem.DeviceTitle,  
  
		DeviceTitle_En = inputItem.DeviceTitle_En,  
  
		DeviceCode = inputItem.DeviceCode,  
  
		OriginalResource = inputItem.OriginalResource,  
  
		ResponseTime = inputItem.ResponseTime,  
  
		ResponseRawText = inputItem.ResponseRawText,  
  
		ResponseStatusCode = inputItem.ResponseStatusCode, 
            };
            return dto;
        }

        public static List<ApiLogDto> Map(ICollection<ApiLog> entities)
        {
            var dtos = new List<ApiLogDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ApiLogDto()
                {
                      
  
		ApiLogID = inputItem.ApiLogID,  
  
		RequestTime = inputItem.RequestTime,  
  
		RequestUrl = inputItem.RequestUrl,  
  
		RequestUserHostAddress = inputItem.RequestUserHostAddress,  
  
		RequestHeaders = inputItem.RequestHeaders,  
  
		RequestMethod = inputItem.RequestMethod,  
  
		RequestBody = inputItem.RequestBody,  
  
		Guid = inputItem.Guid,  
  
		UserRef = inputItem.UserRef,  
  
		UserName = inputItem.UserName,  
  
		UserName_En = inputItem.UserName_En,  
  
		UserUserName = inputItem.UserUserName,  
  
		DeviceRef = inputItem.DeviceRef,  
  
		DeviceTitle = inputItem.DeviceTitle,  
  
		DeviceTitle_En = inputItem.DeviceTitle_En,  
  
		DeviceCode = inputItem.DeviceCode,  
  
		OriginalResource = inputItem.OriginalResource,  
  
		ResponseTime = inputItem.ResponseTime,  
  
		ResponseRawText = inputItem.ResponseRawText,  
  
		ResponseStatusCode = inputItem.ResponseStatusCode, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CheckDataParity Map(AddCheckDataParityCommand inputItem)
        {
            var entity = new CheckDataParity() {
                  
  
		Column1 = inputItem.Column1,  
  
		Column2 = inputItem.Column2,  
  
		Column3 = inputItem.Column3,  
  
		Column4 = inputItem.Column4,  
  
		Column5 = inputItem.Column5, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CheckDataParity Map(CheckDataParity entity ,EditCheckDataParityCommand inputItem)
        {
              
  
		entity.Column1 = inputItem.Column1;  
  
		entity.Column2 = inputItem.Column2;  
  
		entity.Column3 = inputItem.Column3;  
  
		entity.Column4 = inputItem.Column4;  
  
		entity.Column5 = inputItem.Column5; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CheckDataParityDto Map(CheckDataParity inputItem)
        {
            var dto = new CheckDataParityDto()
            {
                  
  
		Column1 = inputItem.Column1,  
  
		Column2 = inputItem.Column2,  
  
		Column3 = inputItem.Column3,  
  
		Column4 = inputItem.Column4,  
  
		Column5 = inputItem.Column5, 
            };
            return dto;
        }

        public static List<CheckDataParityDto> Map(ICollection<CheckDataParity> entities)
        {
            var dtos = new List<CheckDataParityDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CheckDataParityDto()
                {
                      
  
		Column1 = inputItem.Column1,  
  
		Column2 = inputItem.Column2,  
  
		Column3 = inputItem.Column3,  
  
		Column4 = inputItem.Column4,  
  
		Column5 = inputItem.Column5, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static CheckDataParityItem Map(AddCheckDataParityItemCommand inputItem)
        {
            var entity = new CheckDataParityItem() {
                  
  
		Column1 = inputItem.Column1,  
  
		Column2 = inputItem.Column2,  
  
		Column3 = inputItem.Column3,  
  
		Column4 = inputItem.Column4,  
  
		Column5 = inputItem.Column5, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static CheckDataParityItem Map(CheckDataParityItem entity ,EditCheckDataParityItemCommand inputItem)
        {
              
  
		entity.Column1 = inputItem.Column1;  
  
		entity.Column2 = inputItem.Column2;  
  
		entity.Column3 = inputItem.Column3;  
  
		entity.Column4 = inputItem.Column4;  
  
		entity.Column5 = inputItem.Column5; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static CheckDataParityItemDto Map(CheckDataParityItem inputItem)
        {
            var dto = new CheckDataParityItemDto()
            {
                  
  
		Column1 = inputItem.Column1,  
  
		Column2 = inputItem.Column2,  
  
		Column3 = inputItem.Column3,  
  
		Column4 = inputItem.Column4,  
  
		Column5 = inputItem.Column5, 
            };
            return dto;
        }

        public static List<CheckDataParityItemDto> Map(ICollection<CheckDataParityItem> entities)
        {
            var dtos = new List<CheckDataParityItemDto>();
            foreach (var inputItem in entities)
            {
                var dto = new CheckDataParityItemDto()
                {
                      
  
		Column1 = inputItem.Column1,  
  
		Column2 = inputItem.Column2,  
  
		Column3 = inputItem.Column3,  
  
		Column4 = inputItem.Column4,  
  
		Column5 = inputItem.Column5, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Configuration Map(AddConfigurationCommand inputItem)
        {
            var entity = new Configuration() {
                  
  
		ConfigurationID = inputItem.ConfigurationID,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Configuration Map(Configuration entity ,EditConfigurationCommand inputItem)
        {
              
  
		entity.ConfigurationID = inputItem.ConfigurationID;  
  
		entity.Key = inputItem.Key;  
  
		entity.Value = inputItem.Value;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ConfigurationDto Map(Configuration inputItem)
        {
            var dto = new ConfigurationDto()
            {
                  
  
		ConfigurationID = inputItem.ConfigurationID,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ConfigurationDto> Map(ICollection<Configuration> entities)
        {
            var dtos = new List<ConfigurationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ConfigurationDto()
                {
                      
  
		ConfigurationID = inputItem.ConfigurationID,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ExtraColumnDescription Map(AddExtraColumnDescriptionCommand inputItem)
        {
            var entity = new ExtraColumnDescription() {
                  
  
		ExtraColumnDescriptionID = inputItem.ExtraColumnDescriptionID,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		UrlColumn1Description = inputItem.UrlColumn1Description,  
  
		UrlColumn2Description = inputItem.UrlColumn2Description,  
  
		UrlColumn3Description = inputItem.UrlColumn3Description,  
  
		UrlColumn4Description = inputItem.UrlColumn4Description,  
  
		UrlColumn5Description = inputItem.UrlColumn5Description,  
  
		StringColumn1Description = inputItem.StringColumn1Description,  
  
		StringColumn2Description = inputItem.StringColumn2Description,  
  
		StringColumn3Description = inputItem.StringColumn3Description,  
  
		StringColumn4Description = inputItem.StringColumn4Description,  
  
		StringColumn5Description = inputItem.StringColumn5Description,  
  
		StringColumn6Description = inputItem.StringColumn6Description,  
  
		StringColumn7Description = inputItem.StringColumn7Description,  
  
		StringColumn8Description = inputItem.StringColumn8Description,  
  
		StringColumn9Description = inputItem.StringColumn9Description,  
  
		StringColumn10Description = inputItem.StringColumn10Description,  
  
		StringColumn11Description = inputItem.StringColumn11Description,  
  
		StringColumn12Description = inputItem.StringColumn12Description,  
  
		StringColumn13Description = inputItem.StringColumn13Description,  
  
		StringColumn14Description = inputItem.StringColumn14Description,  
  
		StringColumn15Description = inputItem.StringColumn15Description,  
  
		DateColumn1Description = inputItem.DateColumn1Description,  
  
		DateColumn2Description = inputItem.DateColumn2Description,  
  
		DateColumn3Description = inputItem.DateColumn3Description,  
  
		DateColumn4Description = inputItem.DateColumn4Description,  
  
		DateColumn5Description = inputItem.DateColumn5Description,  
  
		IntegerColumn1Description = inputItem.IntegerColumn1Description,  
  
		IntegerColumn2Description = inputItem.IntegerColumn2Description,  
  
		IntegerColumn3Description = inputItem.IntegerColumn3Description,  
  
		IntegerColumn4Description = inputItem.IntegerColumn4Description,  
  
		IntegerColumn5Description = inputItem.IntegerColumn5Description,  
  
		DecimalColumn1Description = inputItem.DecimalColumn1Description,  
  
		DecimalColumn2Description = inputItem.DecimalColumn2Description,  
  
		DecimalColumn3Description = inputItem.DecimalColumn3Description,  
  
		DecimalColumn4Description = inputItem.DecimalColumn4Description,  
  
		DecimalColumn5Description = inputItem.DecimalColumn5Description,  
  
		DecimalColumn6Description = inputItem.DecimalColumn6Description,  
  
		DecimalColumn7Description = inputItem.DecimalColumn7Description,  
  
		DecimalColumn8Description = inputItem.DecimalColumn8Description,  
  
		DecimalColumn9Description = inputItem.DecimalColumn9Description,  
  
		DecimalColumn10Description = inputItem.DecimalColumn10Description,  
  
		UrlColumn1Order = inputItem.UrlColumn1Order,  
  
		UrlColumn2Order = inputItem.UrlColumn2Order,  
  
		UrlColumn3Order = inputItem.UrlColumn3Order,  
  
		UrlColumn4Order = inputItem.UrlColumn4Order,  
  
		UrlColumn5Order = inputItem.UrlColumn5Order,  
  
		StringColumn1Order = inputItem.StringColumn1Order,  
  
		StringColumn2Order = inputItem.StringColumn2Order,  
  
		StringColumn3Order = inputItem.StringColumn3Order,  
  
		StringColumn4Order = inputItem.StringColumn4Order,  
  
		StringColumn5Order = inputItem.StringColumn5Order,  
  
		StringColumn6Order = inputItem.StringColumn6Order,  
  
		StringColumn7Order = inputItem.StringColumn7Order,  
  
		StringColumn8Order = inputItem.StringColumn8Order,  
  
		StringColumn9Order = inputItem.StringColumn9Order,  
  
		StringColumn10Order = inputItem.StringColumn10Order,  
  
		StringColumn11Order = inputItem.StringColumn11Order,  
  
		StringColumn12Order = inputItem.StringColumn12Order,  
  
		StringColumn13Order = inputItem.StringColumn13Order,  
  
		StringColumn14Order = inputItem.StringColumn14Order,  
  
		StringColumn15Order = inputItem.StringColumn15Order,  
  
		DateColumn1Order = inputItem.DateColumn1Order,  
  
		DateColumn2Order = inputItem.DateColumn2Order,  
  
		DateColumn3Order = inputItem.DateColumn3Order,  
  
		DateColumn4Order = inputItem.DateColumn4Order,  
  
		DateColumn5Order = inputItem.DateColumn5Order,  
  
		IntegerColumn1Order = inputItem.IntegerColumn1Order,  
  
		IntegerColumn2Order = inputItem.IntegerColumn2Order,  
  
		IntegerColumn3Order = inputItem.IntegerColumn3Order,  
  
		IntegerColumn4Order = inputItem.IntegerColumn4Order,  
  
		IntegerColumn5Order = inputItem.IntegerColumn5Order,  
  
		DecimalColumn1Order = inputItem.DecimalColumn1Order,  
  
		DecimalColumn2Order = inputItem.DecimalColumn2Order,  
  
		DecimalColumn3Order = inputItem.DecimalColumn3Order,  
  
		DecimalColumn4Order = inputItem.DecimalColumn4Order,  
  
		DecimalColumn5Order = inputItem.DecimalColumn5Order,  
  
		DecimalColumn6Order = inputItem.DecimalColumn6Order,  
  
		DecimalColumn7Order = inputItem.DecimalColumn7Order,  
  
		DecimalColumn8Order = inputItem.DecimalColumn8Order,  
  
		DecimalColumn9Order = inputItem.DecimalColumn9Order,  
  
		DecimalColumn10Order = inputItem.DecimalColumn10Order,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ExtraColumnDescription Map(ExtraColumnDescription entity ,EditExtraColumnDescriptionCommand inputItem)
        {
              
  
		entity.ExtraColumnDescriptionID = inputItem.ExtraColumnDescriptionID;  
  
		entity.EntityTypeName = inputItem.EntityTypeName;  
  
		entity.UrlColumn1Description = inputItem.UrlColumn1Description;  
  
		entity.UrlColumn2Description = inputItem.UrlColumn2Description;  
  
		entity.UrlColumn3Description = inputItem.UrlColumn3Description;  
  
		entity.UrlColumn4Description = inputItem.UrlColumn4Description;  
  
		entity.UrlColumn5Description = inputItem.UrlColumn5Description;  
  
		entity.StringColumn1Description = inputItem.StringColumn1Description;  
  
		entity.StringColumn2Description = inputItem.StringColumn2Description;  
  
		entity.StringColumn3Description = inputItem.StringColumn3Description;  
  
		entity.StringColumn4Description = inputItem.StringColumn4Description;  
  
		entity.StringColumn5Description = inputItem.StringColumn5Description;  
  
		entity.StringColumn6Description = inputItem.StringColumn6Description;  
  
		entity.StringColumn7Description = inputItem.StringColumn7Description;  
  
		entity.StringColumn8Description = inputItem.StringColumn8Description;  
  
		entity.StringColumn9Description = inputItem.StringColumn9Description;  
  
		entity.StringColumn10Description = inputItem.StringColumn10Description;  
  
		entity.StringColumn11Description = inputItem.StringColumn11Description;  
  
		entity.StringColumn12Description = inputItem.StringColumn12Description;  
  
		entity.StringColumn13Description = inputItem.StringColumn13Description;  
  
		entity.StringColumn14Description = inputItem.StringColumn14Description;  
  
		entity.StringColumn15Description = inputItem.StringColumn15Description;  
  
		entity.DateColumn1Description = inputItem.DateColumn1Description;  
  
		entity.DateColumn2Description = inputItem.DateColumn2Description;  
  
		entity.DateColumn3Description = inputItem.DateColumn3Description;  
  
		entity.DateColumn4Description = inputItem.DateColumn4Description;  
  
		entity.DateColumn5Description = inputItem.DateColumn5Description;  
  
		entity.IntegerColumn1Description = inputItem.IntegerColumn1Description;  
  
		entity.IntegerColumn2Description = inputItem.IntegerColumn2Description;  
  
		entity.IntegerColumn3Description = inputItem.IntegerColumn3Description;  
  
		entity.IntegerColumn4Description = inputItem.IntegerColumn4Description;  
  
		entity.IntegerColumn5Description = inputItem.IntegerColumn5Description;  
  
		entity.DecimalColumn1Description = inputItem.DecimalColumn1Description;  
  
		entity.DecimalColumn2Description = inputItem.DecimalColumn2Description;  
  
		entity.DecimalColumn3Description = inputItem.DecimalColumn3Description;  
  
		entity.DecimalColumn4Description = inputItem.DecimalColumn4Description;  
  
		entity.DecimalColumn5Description = inputItem.DecimalColumn5Description;  
  
		entity.DecimalColumn6Description = inputItem.DecimalColumn6Description;  
  
		entity.DecimalColumn7Description = inputItem.DecimalColumn7Description;  
  
		entity.DecimalColumn8Description = inputItem.DecimalColumn8Description;  
  
		entity.DecimalColumn9Description = inputItem.DecimalColumn9Description;  
  
		entity.DecimalColumn10Description = inputItem.DecimalColumn10Description;  
  
		entity.UrlColumn1Order = inputItem.UrlColumn1Order;  
  
		entity.UrlColumn2Order = inputItem.UrlColumn2Order;  
  
		entity.UrlColumn3Order = inputItem.UrlColumn3Order;  
  
		entity.UrlColumn4Order = inputItem.UrlColumn4Order;  
  
		entity.UrlColumn5Order = inputItem.UrlColumn5Order;  
  
		entity.StringColumn1Order = inputItem.StringColumn1Order;  
  
		entity.StringColumn2Order = inputItem.StringColumn2Order;  
  
		entity.StringColumn3Order = inputItem.StringColumn3Order;  
  
		entity.StringColumn4Order = inputItem.StringColumn4Order;  
  
		entity.StringColumn5Order = inputItem.StringColumn5Order;  
  
		entity.StringColumn6Order = inputItem.StringColumn6Order;  
  
		entity.StringColumn7Order = inputItem.StringColumn7Order;  
  
		entity.StringColumn8Order = inputItem.StringColumn8Order;  
  
		entity.StringColumn9Order = inputItem.StringColumn9Order;  
  
		entity.StringColumn10Order = inputItem.StringColumn10Order;  
  
		entity.StringColumn11Order = inputItem.StringColumn11Order;  
  
		entity.StringColumn12Order = inputItem.StringColumn12Order;  
  
		entity.StringColumn13Order = inputItem.StringColumn13Order;  
  
		entity.StringColumn14Order = inputItem.StringColumn14Order;  
  
		entity.StringColumn15Order = inputItem.StringColumn15Order;  
  
		entity.DateColumn1Order = inputItem.DateColumn1Order;  
  
		entity.DateColumn2Order = inputItem.DateColumn2Order;  
  
		entity.DateColumn3Order = inputItem.DateColumn3Order;  
  
		entity.DateColumn4Order = inputItem.DateColumn4Order;  
  
		entity.DateColumn5Order = inputItem.DateColumn5Order;  
  
		entity.IntegerColumn1Order = inputItem.IntegerColumn1Order;  
  
		entity.IntegerColumn2Order = inputItem.IntegerColumn2Order;  
  
		entity.IntegerColumn3Order = inputItem.IntegerColumn3Order;  
  
		entity.IntegerColumn4Order = inputItem.IntegerColumn4Order;  
  
		entity.IntegerColumn5Order = inputItem.IntegerColumn5Order;  
  
		entity.DecimalColumn1Order = inputItem.DecimalColumn1Order;  
  
		entity.DecimalColumn2Order = inputItem.DecimalColumn2Order;  
  
		entity.DecimalColumn3Order = inputItem.DecimalColumn3Order;  
  
		entity.DecimalColumn4Order = inputItem.DecimalColumn4Order;  
  
		entity.DecimalColumn5Order = inputItem.DecimalColumn5Order;  
  
		entity.DecimalColumn6Order = inputItem.DecimalColumn6Order;  
  
		entity.DecimalColumn7Order = inputItem.DecimalColumn7Order;  
  
		entity.DecimalColumn8Order = inputItem.DecimalColumn8Order;  
  
		entity.DecimalColumn9Order = inputItem.DecimalColumn9Order;  
  
		entity.DecimalColumn10Order = inputItem.DecimalColumn10Order;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ExtraColumnDescriptionDto Map(ExtraColumnDescription inputItem)
        {
            var dto = new ExtraColumnDescriptionDto()
            {
                  
  
		ExtraColumnDescriptionID = inputItem.ExtraColumnDescriptionID,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		UrlColumn1Description = inputItem.UrlColumn1Description,  
  
		UrlColumn2Description = inputItem.UrlColumn2Description,  
  
		UrlColumn3Description = inputItem.UrlColumn3Description,  
  
		UrlColumn4Description = inputItem.UrlColumn4Description,  
  
		UrlColumn5Description = inputItem.UrlColumn5Description,  
  
		StringColumn1Description = inputItem.StringColumn1Description,  
  
		StringColumn2Description = inputItem.StringColumn2Description,  
  
		StringColumn3Description = inputItem.StringColumn3Description,  
  
		StringColumn4Description = inputItem.StringColumn4Description,  
  
		StringColumn5Description = inputItem.StringColumn5Description,  
  
		StringColumn6Description = inputItem.StringColumn6Description,  
  
		StringColumn7Description = inputItem.StringColumn7Description,  
  
		StringColumn8Description = inputItem.StringColumn8Description,  
  
		StringColumn9Description = inputItem.StringColumn9Description,  
  
		StringColumn10Description = inputItem.StringColumn10Description,  
  
		StringColumn11Description = inputItem.StringColumn11Description,  
  
		StringColumn12Description = inputItem.StringColumn12Description,  
  
		StringColumn13Description = inputItem.StringColumn13Description,  
  
		StringColumn14Description = inputItem.StringColumn14Description,  
  
		StringColumn15Description = inputItem.StringColumn15Description,  
  
		DateColumn1Description = inputItem.DateColumn1Description,  
  
		DateColumn2Description = inputItem.DateColumn2Description,  
  
		DateColumn3Description = inputItem.DateColumn3Description,  
  
		DateColumn4Description = inputItem.DateColumn4Description,  
  
		DateColumn5Description = inputItem.DateColumn5Description,  
  
		IntegerColumn1Description = inputItem.IntegerColumn1Description,  
  
		IntegerColumn2Description = inputItem.IntegerColumn2Description,  
  
		IntegerColumn3Description = inputItem.IntegerColumn3Description,  
  
		IntegerColumn4Description = inputItem.IntegerColumn4Description,  
  
		IntegerColumn5Description = inputItem.IntegerColumn5Description,  
  
		DecimalColumn1Description = inputItem.DecimalColumn1Description,  
  
		DecimalColumn2Description = inputItem.DecimalColumn2Description,  
  
		DecimalColumn3Description = inputItem.DecimalColumn3Description,  
  
		DecimalColumn4Description = inputItem.DecimalColumn4Description,  
  
		DecimalColumn5Description = inputItem.DecimalColumn5Description,  
  
		DecimalColumn6Description = inputItem.DecimalColumn6Description,  
  
		DecimalColumn7Description = inputItem.DecimalColumn7Description,  
  
		DecimalColumn8Description = inputItem.DecimalColumn8Description,  
  
		DecimalColumn9Description = inputItem.DecimalColumn9Description,  
  
		DecimalColumn10Description = inputItem.DecimalColumn10Description,  
  
		UrlColumn1Order = inputItem.UrlColumn1Order,  
  
		UrlColumn2Order = inputItem.UrlColumn2Order,  
  
		UrlColumn3Order = inputItem.UrlColumn3Order,  
  
		UrlColumn4Order = inputItem.UrlColumn4Order,  
  
		UrlColumn5Order = inputItem.UrlColumn5Order,  
  
		StringColumn1Order = inputItem.StringColumn1Order,  
  
		StringColumn2Order = inputItem.StringColumn2Order,  
  
		StringColumn3Order = inputItem.StringColumn3Order,  
  
		StringColumn4Order = inputItem.StringColumn4Order,  
  
		StringColumn5Order = inputItem.StringColumn5Order,  
  
		StringColumn6Order = inputItem.StringColumn6Order,  
  
		StringColumn7Order = inputItem.StringColumn7Order,  
  
		StringColumn8Order = inputItem.StringColumn8Order,  
  
		StringColumn9Order = inputItem.StringColumn9Order,  
  
		StringColumn10Order = inputItem.StringColumn10Order,  
  
		StringColumn11Order = inputItem.StringColumn11Order,  
  
		StringColumn12Order = inputItem.StringColumn12Order,  
  
		StringColumn13Order = inputItem.StringColumn13Order,  
  
		StringColumn14Order = inputItem.StringColumn14Order,  
  
		StringColumn15Order = inputItem.StringColumn15Order,  
  
		DateColumn1Order = inputItem.DateColumn1Order,  
  
		DateColumn2Order = inputItem.DateColumn2Order,  
  
		DateColumn3Order = inputItem.DateColumn3Order,  
  
		DateColumn4Order = inputItem.DateColumn4Order,  
  
		DateColumn5Order = inputItem.DateColumn5Order,  
  
		IntegerColumn1Order = inputItem.IntegerColumn1Order,  
  
		IntegerColumn2Order = inputItem.IntegerColumn2Order,  
  
		IntegerColumn3Order = inputItem.IntegerColumn3Order,  
  
		IntegerColumn4Order = inputItem.IntegerColumn4Order,  
  
		IntegerColumn5Order = inputItem.IntegerColumn5Order,  
  
		DecimalColumn1Order = inputItem.DecimalColumn1Order,  
  
		DecimalColumn2Order = inputItem.DecimalColumn2Order,  
  
		DecimalColumn3Order = inputItem.DecimalColumn3Order,  
  
		DecimalColumn4Order = inputItem.DecimalColumn4Order,  
  
		DecimalColumn5Order = inputItem.DecimalColumn5Order,  
  
		DecimalColumn6Order = inputItem.DecimalColumn6Order,  
  
		DecimalColumn7Order = inputItem.DecimalColumn7Order,  
  
		DecimalColumn8Order = inputItem.DecimalColumn8Order,  
  
		DecimalColumn9Order = inputItem.DecimalColumn9Order,  
  
		DecimalColumn10Order = inputItem.DecimalColumn10Order,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ExtraColumnDescriptionDto> Map(ICollection<ExtraColumnDescription> entities)
        {
            var dtos = new List<ExtraColumnDescriptionDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ExtraColumnDescriptionDto()
                {
                      
  
		ExtraColumnDescriptionID = inputItem.ExtraColumnDescriptionID,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		UrlColumn1Description = inputItem.UrlColumn1Description,  
  
		UrlColumn2Description = inputItem.UrlColumn2Description,  
  
		UrlColumn3Description = inputItem.UrlColumn3Description,  
  
		UrlColumn4Description = inputItem.UrlColumn4Description,  
  
		UrlColumn5Description = inputItem.UrlColumn5Description,  
  
		StringColumn1Description = inputItem.StringColumn1Description,  
  
		StringColumn2Description = inputItem.StringColumn2Description,  
  
		StringColumn3Description = inputItem.StringColumn3Description,  
  
		StringColumn4Description = inputItem.StringColumn4Description,  
  
		StringColumn5Description = inputItem.StringColumn5Description,  
  
		StringColumn6Description = inputItem.StringColumn6Description,  
  
		StringColumn7Description = inputItem.StringColumn7Description,  
  
		StringColumn8Description = inputItem.StringColumn8Description,  
  
		StringColumn9Description = inputItem.StringColumn9Description,  
  
		StringColumn10Description = inputItem.StringColumn10Description,  
  
		StringColumn11Description = inputItem.StringColumn11Description,  
  
		StringColumn12Description = inputItem.StringColumn12Description,  
  
		StringColumn13Description = inputItem.StringColumn13Description,  
  
		StringColumn14Description = inputItem.StringColumn14Description,  
  
		StringColumn15Description = inputItem.StringColumn15Description,  
  
		DateColumn1Description = inputItem.DateColumn1Description,  
  
		DateColumn2Description = inputItem.DateColumn2Description,  
  
		DateColumn3Description = inputItem.DateColumn3Description,  
  
		DateColumn4Description = inputItem.DateColumn4Description,  
  
		DateColumn5Description = inputItem.DateColumn5Description,  
  
		IntegerColumn1Description = inputItem.IntegerColumn1Description,  
  
		IntegerColumn2Description = inputItem.IntegerColumn2Description,  
  
		IntegerColumn3Description = inputItem.IntegerColumn3Description,  
  
		IntegerColumn4Description = inputItem.IntegerColumn4Description,  
  
		IntegerColumn5Description = inputItem.IntegerColumn5Description,  
  
		DecimalColumn1Description = inputItem.DecimalColumn1Description,  
  
		DecimalColumn2Description = inputItem.DecimalColumn2Description,  
  
		DecimalColumn3Description = inputItem.DecimalColumn3Description,  
  
		DecimalColumn4Description = inputItem.DecimalColumn4Description,  
  
		DecimalColumn5Description = inputItem.DecimalColumn5Description,  
  
		DecimalColumn6Description = inputItem.DecimalColumn6Description,  
  
		DecimalColumn7Description = inputItem.DecimalColumn7Description,  
  
		DecimalColumn8Description = inputItem.DecimalColumn8Description,  
  
		DecimalColumn9Description = inputItem.DecimalColumn9Description,  
  
		DecimalColumn10Description = inputItem.DecimalColumn10Description,  
  
		UrlColumn1Order = inputItem.UrlColumn1Order,  
  
		UrlColumn2Order = inputItem.UrlColumn2Order,  
  
		UrlColumn3Order = inputItem.UrlColumn3Order,  
  
		UrlColumn4Order = inputItem.UrlColumn4Order,  
  
		UrlColumn5Order = inputItem.UrlColumn5Order,  
  
		StringColumn1Order = inputItem.StringColumn1Order,  
  
		StringColumn2Order = inputItem.StringColumn2Order,  
  
		StringColumn3Order = inputItem.StringColumn3Order,  
  
		StringColumn4Order = inputItem.StringColumn4Order,  
  
		StringColumn5Order = inputItem.StringColumn5Order,  
  
		StringColumn6Order = inputItem.StringColumn6Order,  
  
		StringColumn7Order = inputItem.StringColumn7Order,  
  
		StringColumn8Order = inputItem.StringColumn8Order,  
  
		StringColumn9Order = inputItem.StringColumn9Order,  
  
		StringColumn10Order = inputItem.StringColumn10Order,  
  
		StringColumn11Order = inputItem.StringColumn11Order,  
  
		StringColumn12Order = inputItem.StringColumn12Order,  
  
		StringColumn13Order = inputItem.StringColumn13Order,  
  
		StringColumn14Order = inputItem.StringColumn14Order,  
  
		StringColumn15Order = inputItem.StringColumn15Order,  
  
		DateColumn1Order = inputItem.DateColumn1Order,  
  
		DateColumn2Order = inputItem.DateColumn2Order,  
  
		DateColumn3Order = inputItem.DateColumn3Order,  
  
		DateColumn4Order = inputItem.DateColumn4Order,  
  
		DateColumn5Order = inputItem.DateColumn5Order,  
  
		IntegerColumn1Order = inputItem.IntegerColumn1Order,  
  
		IntegerColumn2Order = inputItem.IntegerColumn2Order,  
  
		IntegerColumn3Order = inputItem.IntegerColumn3Order,  
  
		IntegerColumn4Order = inputItem.IntegerColumn4Order,  
  
		IntegerColumn5Order = inputItem.IntegerColumn5Order,  
  
		DecimalColumn1Order = inputItem.DecimalColumn1Order,  
  
		DecimalColumn2Order = inputItem.DecimalColumn2Order,  
  
		DecimalColumn3Order = inputItem.DecimalColumn3Order,  
  
		DecimalColumn4Order = inputItem.DecimalColumn4Order,  
  
		DecimalColumn5Order = inputItem.DecimalColumn5Order,  
  
		DecimalColumn6Order = inputItem.DecimalColumn6Order,  
  
		DecimalColumn7Order = inputItem.DecimalColumn7Order,  
  
		DecimalColumn8Order = inputItem.DecimalColumn8Order,  
  
		DecimalColumn9Order = inputItem.DecimalColumn9Order,  
  
		DecimalColumn10Order = inputItem.DecimalColumn10Order,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ExtraData Map(AddExtraDataCommand inputItem)
        {
            var entity = new ExtraData() {
                  
  
		ExtraDataID = inputItem.ExtraDataID,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		EntityRef = inputItem.EntityRef,  
  
		UrlColumn1 = inputItem.UrlColumn1,  
  
		UrlColumn2 = inputItem.UrlColumn2,  
  
		UrlColumn3 = inputItem.UrlColumn3,  
  
		UrlColumn4 = inputItem.UrlColumn4,  
  
		UrlColumn5 = inputItem.UrlColumn5,  
  
		StringColumn1 = inputItem.StringColumn1,  
  
		StringColumn2 = inputItem.StringColumn2,  
  
		StringColumn3 = inputItem.StringColumn3,  
  
		StringColumn4 = inputItem.StringColumn4,  
  
		StringColumn5 = inputItem.StringColumn5,  
  
		StringColumn6 = inputItem.StringColumn6,  
  
		StringColumn7 = inputItem.StringColumn7,  
  
		StringColumn8 = inputItem.StringColumn8,  
  
		StringColumn9 = inputItem.StringColumn9,  
  
		StringColumn10 = inputItem.StringColumn10,  
  
		StringColumn11 = inputItem.StringColumn11,  
  
		StringColumn12 = inputItem.StringColumn12,  
  
		StringColumn13 = inputItem.StringColumn13,  
  
		StringColumn14 = inputItem.StringColumn14,  
  
		StringColumn15 = inputItem.StringColumn15,  
  
		Note = inputItem.Note,  
  
		DateColumn1 = inputItem.DateColumn1,  
  
		DateColumn2 = inputItem.DateColumn2,  
  
		DateColumn3 = inputItem.DateColumn3,  
  
		DateColumn4 = inputItem.DateColumn4,  
  
		DateColumn5 = inputItem.DateColumn5,  
  
		IntegerColumn1 = inputItem.IntegerColumn1,  
  
		IntegerColumn2 = inputItem.IntegerColumn2,  
  
		IntegerColumn3 = inputItem.IntegerColumn3,  
  
		IntegerColumn4 = inputItem.IntegerColumn4,  
  
		IntegerColumn5 = inputItem.IntegerColumn5,  
  
		DecimalColumn1 = inputItem.DecimalColumn1,  
  
		DecimalColumn2 = inputItem.DecimalColumn2,  
  
		DecimalColumn3 = inputItem.DecimalColumn3,  
  
		DecimalColumn4 = inputItem.DecimalColumn4,  
  
		DecimalColumn5 = inputItem.DecimalColumn5,  
  
		DecimalColumn6 = inputItem.DecimalColumn6,  
  
		DecimalColumn7 = inputItem.DecimalColumn7,  
  
		DecimalColumn8 = inputItem.DecimalColumn8,  
  
		DecimalColumn9 = inputItem.DecimalColumn9,  
  
		DecimalColumn10 = inputItem.DecimalColumn10,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ExtraData Map(ExtraData entity ,EditExtraDataCommand inputItem)
        {
              
  
		entity.ExtraDataID = inputItem.ExtraDataID;  
  
		entity.EntityTypeName = inputItem.EntityTypeName;  
  
		entity.EntityRef = inputItem.EntityRef;  
  
		entity.UrlColumn1 = inputItem.UrlColumn1;  
  
		entity.UrlColumn2 = inputItem.UrlColumn2;  
  
		entity.UrlColumn3 = inputItem.UrlColumn3;  
  
		entity.UrlColumn4 = inputItem.UrlColumn4;  
  
		entity.UrlColumn5 = inputItem.UrlColumn5;  
  
		entity.StringColumn1 = inputItem.StringColumn1;  
  
		entity.StringColumn2 = inputItem.StringColumn2;  
  
		entity.StringColumn3 = inputItem.StringColumn3;  
  
		entity.StringColumn4 = inputItem.StringColumn4;  
  
		entity.StringColumn5 = inputItem.StringColumn5;  
  
		entity.StringColumn6 = inputItem.StringColumn6;  
  
		entity.StringColumn7 = inputItem.StringColumn7;  
  
		entity.StringColumn8 = inputItem.StringColumn8;  
  
		entity.StringColumn9 = inputItem.StringColumn9;  
  
		entity.StringColumn10 = inputItem.StringColumn10;  
  
		entity.StringColumn11 = inputItem.StringColumn11;  
  
		entity.StringColumn12 = inputItem.StringColumn12;  
  
		entity.StringColumn13 = inputItem.StringColumn13;  
  
		entity.StringColumn14 = inputItem.StringColumn14;  
  
		entity.StringColumn15 = inputItem.StringColumn15;  
  
		entity.Note = inputItem.Note;  
  
		entity.DateColumn1 = inputItem.DateColumn1;  
  
		entity.DateColumn2 = inputItem.DateColumn2;  
  
		entity.DateColumn3 = inputItem.DateColumn3;  
  
		entity.DateColumn4 = inputItem.DateColumn4;  
  
		entity.DateColumn5 = inputItem.DateColumn5;  
  
		entity.IntegerColumn1 = inputItem.IntegerColumn1;  
  
		entity.IntegerColumn2 = inputItem.IntegerColumn2;  
  
		entity.IntegerColumn3 = inputItem.IntegerColumn3;  
  
		entity.IntegerColumn4 = inputItem.IntegerColumn4;  
  
		entity.IntegerColumn5 = inputItem.IntegerColumn5;  
  
		entity.DecimalColumn1 = inputItem.DecimalColumn1;  
  
		entity.DecimalColumn2 = inputItem.DecimalColumn2;  
  
		entity.DecimalColumn3 = inputItem.DecimalColumn3;  
  
		entity.DecimalColumn4 = inputItem.DecimalColumn4;  
  
		entity.DecimalColumn5 = inputItem.DecimalColumn5;  
  
		entity.DecimalColumn6 = inputItem.DecimalColumn6;  
  
		entity.DecimalColumn7 = inputItem.DecimalColumn7;  
  
		entity.DecimalColumn8 = inputItem.DecimalColumn8;  
  
		entity.DecimalColumn9 = inputItem.DecimalColumn9;  
  
		entity.DecimalColumn10 = inputItem.DecimalColumn10;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ExtraDataDto Map(ExtraData inputItem)
        {
            var dto = new ExtraDataDto()
            {
                  
  
		ExtraDataID = inputItem.ExtraDataID,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		EntityRef = inputItem.EntityRef,  
  
		UrlColumn1 = inputItem.UrlColumn1,  
  
		UrlColumn2 = inputItem.UrlColumn2,  
  
		UrlColumn3 = inputItem.UrlColumn3,  
  
		UrlColumn4 = inputItem.UrlColumn4,  
  
		UrlColumn5 = inputItem.UrlColumn5,  
  
		StringColumn1 = inputItem.StringColumn1,  
  
		StringColumn2 = inputItem.StringColumn2,  
  
		StringColumn3 = inputItem.StringColumn3,  
  
		StringColumn4 = inputItem.StringColumn4,  
  
		StringColumn5 = inputItem.StringColumn5,  
  
		StringColumn6 = inputItem.StringColumn6,  
  
		StringColumn7 = inputItem.StringColumn7,  
  
		StringColumn8 = inputItem.StringColumn8,  
  
		StringColumn9 = inputItem.StringColumn9,  
  
		StringColumn10 = inputItem.StringColumn10,  
  
		StringColumn11 = inputItem.StringColumn11,  
  
		StringColumn12 = inputItem.StringColumn12,  
  
		StringColumn13 = inputItem.StringColumn13,  
  
		StringColumn14 = inputItem.StringColumn14,  
  
		StringColumn15 = inputItem.StringColumn15,  
  
		Note = inputItem.Note,  
  
		DateColumn1 = inputItem.DateColumn1,  
  
		DateColumn2 = inputItem.DateColumn2,  
  
		DateColumn3 = inputItem.DateColumn3,  
  
		DateColumn4 = inputItem.DateColumn4,  
  
		DateColumn5 = inputItem.DateColumn5,  
  
		IntegerColumn1 = inputItem.IntegerColumn1,  
  
		IntegerColumn2 = inputItem.IntegerColumn2,  
  
		IntegerColumn3 = inputItem.IntegerColumn3,  
  
		IntegerColumn4 = inputItem.IntegerColumn4,  
  
		IntegerColumn5 = inputItem.IntegerColumn5,  
  
		DecimalColumn1 = inputItem.DecimalColumn1,  
  
		DecimalColumn2 = inputItem.DecimalColumn2,  
  
		DecimalColumn3 = inputItem.DecimalColumn3,  
  
		DecimalColumn4 = inputItem.DecimalColumn4,  
  
		DecimalColumn5 = inputItem.DecimalColumn5,  
  
		DecimalColumn6 = inputItem.DecimalColumn6,  
  
		DecimalColumn7 = inputItem.DecimalColumn7,  
  
		DecimalColumn8 = inputItem.DecimalColumn8,  
  
		DecimalColumn9 = inputItem.DecimalColumn9,  
  
		DecimalColumn10 = inputItem.DecimalColumn10,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<ExtraDataDto> Map(ICollection<ExtraData> entities)
        {
            var dtos = new List<ExtraDataDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ExtraDataDto()
                {
                      
  
		ExtraDataID = inputItem.ExtraDataID,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		EntityRef = inputItem.EntityRef,  
  
		UrlColumn1 = inputItem.UrlColumn1,  
  
		UrlColumn2 = inputItem.UrlColumn2,  
  
		UrlColumn3 = inputItem.UrlColumn3,  
  
		UrlColumn4 = inputItem.UrlColumn4,  
  
		UrlColumn5 = inputItem.UrlColumn5,  
  
		StringColumn1 = inputItem.StringColumn1,  
  
		StringColumn2 = inputItem.StringColumn2,  
  
		StringColumn3 = inputItem.StringColumn3,  
  
		StringColumn4 = inputItem.StringColumn4,  
  
		StringColumn5 = inputItem.StringColumn5,  
  
		StringColumn6 = inputItem.StringColumn6,  
  
		StringColumn7 = inputItem.StringColumn7,  
  
		StringColumn8 = inputItem.StringColumn8,  
  
		StringColumn9 = inputItem.StringColumn9,  
  
		StringColumn10 = inputItem.StringColumn10,  
  
		StringColumn11 = inputItem.StringColumn11,  
  
		StringColumn12 = inputItem.StringColumn12,  
  
		StringColumn13 = inputItem.StringColumn13,  
  
		StringColumn14 = inputItem.StringColumn14,  
  
		StringColumn15 = inputItem.StringColumn15,  
  
		Note = inputItem.Note,  
  
		DateColumn1 = inputItem.DateColumn1,  
  
		DateColumn2 = inputItem.DateColumn2,  
  
		DateColumn3 = inputItem.DateColumn3,  
  
		DateColumn4 = inputItem.DateColumn4,  
  
		DateColumn5 = inputItem.DateColumn5,  
  
		IntegerColumn1 = inputItem.IntegerColumn1,  
  
		IntegerColumn2 = inputItem.IntegerColumn2,  
  
		IntegerColumn3 = inputItem.IntegerColumn3,  
  
		IntegerColumn4 = inputItem.IntegerColumn4,  
  
		IntegerColumn5 = inputItem.IntegerColumn5,  
  
		DecimalColumn1 = inputItem.DecimalColumn1,  
  
		DecimalColumn2 = inputItem.DecimalColumn2,  
  
		DecimalColumn3 = inputItem.DecimalColumn3,  
  
		DecimalColumn4 = inputItem.DecimalColumn4,  
  
		DecimalColumn5 = inputItem.DecimalColumn5,  
  
		DecimalColumn6 = inputItem.DecimalColumn6,  
  
		DecimalColumn7 = inputItem.DecimalColumn7,  
  
		DecimalColumn8 = inputItem.DecimalColumn8,  
  
		DecimalColumn9 = inputItem.DecimalColumn9,  
  
		DecimalColumn10 = inputItem.DecimalColumn10,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static FAQ Map(AddFAQCommand inputItem)
        {
            var entity = new FAQ() {
                  
  
		FAQID = inputItem.FAQID,  
  
		ClubFAQRef = inputItem.ClubFAQRef,  
  
		ClubVersion = inputItem.ClubVersion,  
  
		Question = inputItem.Question,  
  
		Answer = inputItem.Answer,  
  
		Location = inputItem.Location,  
  
		Key = inputItem.Key,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static FAQ Map(FAQ entity ,EditFAQCommand inputItem)
        {
              
  
		entity.FAQID = inputItem.FAQID;  
  
		entity.ClubFAQRef = inputItem.ClubFAQRef;  
  
		entity.ClubVersion = inputItem.ClubVersion;  
  
		entity.Question = inputItem.Question;  
  
		entity.Answer = inputItem.Answer;  
  
		entity.Location = inputItem.Location;  
  
		entity.Key = inputItem.Key;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static FAQDto Map(FAQ inputItem)
        {
            var dto = new FAQDto()
            {
                  
  
		FAQID = inputItem.FAQID,  
  
		ClubFAQRef = inputItem.ClubFAQRef,  
  
		ClubVersion = inputItem.ClubVersion,  
  
		Question = inputItem.Question,  
  
		Answer = inputItem.Answer,  
  
		Location = inputItem.Location,  
  
		Key = inputItem.Key,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<FAQDto> Map(ICollection<FAQ> entities)
        {
            var dtos = new List<FAQDto>();
            foreach (var inputItem in entities)
            {
                var dto = new FAQDto()
                {
                      
  
		FAQID = inputItem.FAQID,  
  
		ClubFAQRef = inputItem.ClubFAQRef,  
  
		ClubVersion = inputItem.ClubVersion,  
  
		Question = inputItem.Question,  
  
		Answer = inputItem.Answer,  
  
		Location = inputItem.Location,  
  
		Key = inputItem.Key,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static FiscalYear Map(AddFiscalYearCommand inputItem)
        {
            var entity = new FiscalYear() {
                  
  
		FiscalYearId = inputItem.FiscalYearId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Status = inputItem.Status,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static FiscalYear Map(FiscalYear entity ,EditFiscalYearCommand inputItem)
        {
              
  
		entity.FiscalYearId = inputItem.FiscalYearId;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.StartDate = inputItem.StartDate;  
  
		entity.EndDate = inputItem.EndDate;  
  
		entity.Status = inputItem.Status;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static FiscalYearDto Map(FiscalYear inputItem)
        {
            var dto = new FiscalYearDto()
            {
                  
  
		FiscalYearId = inputItem.FiscalYearId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Status = inputItem.Status,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<FiscalYearDto> Map(ICollection<FiscalYear> entities)
        {
            var dtos = new List<FiscalYearDto>();
            foreach (var inputItem in entities)
            {
                var dto = new FiscalYearDto()
                {
                      
  
		FiscalYearId = inputItem.FiscalYearId,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		StartDate = inputItem.StartDate,  
  
		EndDate = inputItem.EndDate,  
  
		Status = inputItem.Status,  
  
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
        
        public static IDGeneration Map(AddIDGenerationCommand inputItem)
        {
            var entity = new IDGeneration() {
                  
  
		TableName = inputItem.TableName,  
  
		LastId = inputItem.LastId, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static IDGeneration Map(IDGeneration entity ,EditIDGenerationCommand inputItem)
        {
              
  
		entity.TableName = inputItem.TableName;  
  
		entity.LastId = inputItem.LastId; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static IDGenerationDto Map(IDGeneration inputItem)
        {
            var dto = new IDGenerationDto()
            {
                  
  
		TableName = inputItem.TableName,  
  
		LastId = inputItem.LastId, 
            };
            return dto;
        }

        public static List<IDGenerationDto> Map(ICollection<IDGeneration> entities)
        {
            var dtos = new List<IDGenerationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new IDGenerationDto()
                {
                      
  
		TableName = inputItem.TableName,  
  
		LastId = inputItem.LastId, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static ImportExportTemplate Map(AddImportExportTemplateCommand inputItem)
        {
            var entity = new ImportExportTemplate() {
                  
  
		ImportExportTemplateID = inputItem.ImportExportTemplateID,  
  
		PersianTitle = inputItem.PersianTitle,  
  
		EnglishTitle = inputItem.EnglishTitle,  
  
		Template = inputItem.Template,  
  
		GUID = inputItem.GUID,  
  
		Type = inputItem.Type,  
  
		IsImport = inputItem.IsImport, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static ImportExportTemplate Map(ImportExportTemplate entity ,EditImportExportTemplateCommand inputItem)
        {
              
  
		entity.ImportExportTemplateID = inputItem.ImportExportTemplateID;  
  
		entity.PersianTitle = inputItem.PersianTitle;  
  
		entity.EnglishTitle = inputItem.EnglishTitle;  
  
		entity.Template = inputItem.Template;  
  
		entity.GUID = inputItem.GUID;  
  
		entity.Type = inputItem.Type;  
  
		entity.IsImport = inputItem.IsImport; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static ImportExportTemplateDto Map(ImportExportTemplate inputItem)
        {
            var dto = new ImportExportTemplateDto()
            {
                  
  
		ImportExportTemplateID = inputItem.ImportExportTemplateID,  
  
		PersianTitle = inputItem.PersianTitle,  
  
		EnglishTitle = inputItem.EnglishTitle,  
  
		Template = inputItem.Template,  
  
		GUID = inputItem.GUID,  
  
		Type = inputItem.Type,  
  
		IsImport = inputItem.IsImport, 
            };
            return dto;
        }

        public static List<ImportExportTemplateDto> Map(ICollection<ImportExportTemplate> entities)
        {
            var dtos = new List<ImportExportTemplateDto>();
            foreach (var inputItem in entities)
            {
                var dto = new ImportExportTemplateDto()
                {
                      
  
		ImportExportTemplateID = inputItem.ImportExportTemplateID,  
  
		PersianTitle = inputItem.PersianTitle,  
  
		EnglishTitle = inputItem.EnglishTitle,  
  
		Template = inputItem.Template,  
  
		GUID = inputItem.GUID,  
  
		Type = inputItem.Type,  
  
		IsImport = inputItem.IsImport, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Keyword Map(AddKeywordCommand inputItem)
        {
            var entity = new Keyword() {
                  
  
		KeywordID = inputItem.KeywordID,  
  
		ActionKey = inputItem.ActionKey, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Keyword Map(Keyword entity ,EditKeywordCommand inputItem)
        {
              
  
		entity.KeywordID = inputItem.KeywordID;  
  
		entity.ActionKey = inputItem.ActionKey; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static KeywordDto Map(Keyword inputItem)
        {
            var dto = new KeywordDto()
            {
                  
  
		KeywordID = inputItem.KeywordID,  
  
		ActionKey = inputItem.ActionKey, 
            };
            return dto;
        }

        public static List<KeywordDto> Map(ICollection<Keyword> entities)
        {
            var dtos = new List<KeywordDto>();
            foreach (var inputItem in entities)
            {
                var dto = new KeywordDto()
                {
                      
  
		KeywordID = inputItem.KeywordID,  
  
		ActionKey = inputItem.ActionKey, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static KeywordLocale Map(AddKeywordLocaleCommand inputItem)
        {
            var entity = new KeywordLocale() {
                  
  
		KeywordRef = inputItem.KeywordRef,  
  
		LocaleName = inputItem.LocaleName,  
  
		Value = inputItem.Value, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static KeywordLocale Map(KeywordLocale entity ,EditKeywordLocaleCommand inputItem)
        {
              
  
		entity.KeywordRef = inputItem.KeywordRef;  
  
		entity.LocaleName = inputItem.LocaleName;  
  
		entity.Value = inputItem.Value; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static KeywordLocaleDto Map(KeywordLocale inputItem)
        {
            var dto = new KeywordLocaleDto()
            {
                  
  
		KeywordRef = inputItem.KeywordRef,  
  
		LocaleName = inputItem.LocaleName,  
  
		Value = inputItem.Value, 
            };
            return dto;
        }

        public static List<KeywordLocaleDto> Map(ICollection<KeywordLocale> entities)
        {
            var dtos = new List<KeywordLocaleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new KeywordLocaleDto()
                {
                      
  
		KeywordRef = inputItem.KeywordRef,  
  
		LocaleName = inputItem.LocaleName,  
  
		Value = inputItem.Value, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Lookup Map(AddLookupCommand inputItem)
        {
            var entity = new Lookup() {
                  
  
		LookupID = inputItem.LookupID,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DisplayOrder = inputItem.DisplayOrder,  
  
		Extra = inputItem.Extra,  
  
		System = inputItem.System, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Lookup Map(Lookup entity ,EditLookupCommand inputItem)
        {
              
  
		entity.LookupID = inputItem.LookupID;  
  
		entity.Type = inputItem.Type;  
  
		entity.Code = inputItem.Code;  
  
		entity.Title = inputItem.Title;  
  
		entity.Title_En = inputItem.Title_En;  
  
		entity.DisplayOrder = inputItem.DisplayOrder;  
  
		entity.Extra = inputItem.Extra;  
  
		entity.System = inputItem.System; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static LookupDto Map(Lookup inputItem)
        {
            var dto = new LookupDto()
            {
                  
  
		LookupID = inputItem.LookupID,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DisplayOrder = inputItem.DisplayOrder,  
  
		Extra = inputItem.Extra,  
  
		System = inputItem.System, 
            };
            return dto;
        }

        public static List<LookupDto> Map(ICollection<Lookup> entities)
        {
            var dtos = new List<LookupDto>();
            foreach (var inputItem in entities)
            {
                var dto = new LookupDto()
                {
                      
  
		LookupID = inputItem.LookupID,  
  
		Type = inputItem.Type,  
  
		Code = inputItem.Code,  
  
		Title = inputItem.Title,  
  
		Title_En = inputItem.Title_En,  
  
		DisplayOrder = inputItem.DisplayOrder,  
  
		Extra = inputItem.Extra,  
  
		System = inputItem.System, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static LookupLocale Map(AddLookupLocaleCommand inputItem)
        {
            var entity = new LookupLocale() {
                  
  
		LookupRef = inputItem.LookupRef,  
  
		LocaleName = inputItem.LocaleName,  
  
		Title = inputItem.Title, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static LookupLocale Map(LookupLocale entity ,EditLookupLocaleCommand inputItem)
        {
              
  
		entity.LookupRef = inputItem.LookupRef;  
  
		entity.LocaleName = inputItem.LocaleName;  
  
		entity.Title = inputItem.Title; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static LookupLocaleDto Map(LookupLocale inputItem)
        {
            var dto = new LookupLocaleDto()
            {
                  
  
		LookupRef = inputItem.LookupRef,  
  
		LocaleName = inputItem.LocaleName,  
  
		Title = inputItem.Title, 
            };
            return dto;
        }

        public static List<LookupLocaleDto> Map(ICollection<LookupLocale> entities)
        {
            var dtos = new List<LookupLocaleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new LookupLocaleDto()
                {
                      
  
		LookupRef = inputItem.LookupRef,  
  
		LocaleName = inputItem.LocaleName,  
  
		Title = inputItem.Title, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Note Map(AddNoteCommand inputItem)
        {
            var entity = new Note() {
                  
  
		NoteID = inputItem.NoteID,  
  
		EntityType = inputItem.EntityType,  
  
		EntityRef = inputItem.EntityRef,  
  
		Note1 = inputItem.Note1,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Note Map(Note entity ,EditNoteCommand inputItem)
        {
              
  
		entity.NoteID = inputItem.NoteID;  
  
		entity.EntityType = inputItem.EntityType;  
  
		entity.EntityRef = inputItem.EntityRef;  
  
		entity.Note1 = inputItem.Note1;  
  
		entity.Version = inputItem.Version;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static NoteDto Map(Note inputItem)
        {
            var dto = new NoteDto()
            {
                  
  
		NoteID = inputItem.NoteID,  
  
		EntityType = inputItem.EntityType,  
  
		EntityRef = inputItem.EntityRef,  
  
		Note1 = inputItem.Note1,  
  
		Version = inputItem.Version,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate, 
            };
            return dto;
        }

        public static List<NoteDto> Map(ICollection<Note> entities)
        {
            var dtos = new List<NoteDto>();
            foreach (var inputItem in entities)
            {
                var dto = new NoteDto()
                {
                      
  
		NoteID = inputItem.NoteID,  
  
		EntityType = inputItem.EntityType,  
  
		EntityRef = inputItem.EntityRef,  
  
		Note1 = inputItem.Note1,  
  
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
        
        public static NumberedEntity Map(AddNumberedEntityCommand inputItem)
        {
            var entity = new NumberedEntity() {
                  
  
		NumberedEntityID = inputItem.NumberedEntityID,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		Method = inputItem.Method,  
  
		StartValue = inputItem.StartValue,  
  
		FinishValue = inputItem.FinishValue,  
  
		ApplyProperty1 = inputItem.ApplyProperty1,  
  
		ApplyProperty2 = inputItem.ApplyProperty2,  
  
		ApplyProperty3 = inputItem.ApplyProperty3,  
  
		ApplyPorperty4 = inputItem.ApplyPorperty4,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static NumberedEntity Map(NumberedEntity entity ,EditNumberedEntityCommand inputItem)
        {
              
  
		entity.NumberedEntityID = inputItem.NumberedEntityID;  
  
		entity.EntityFullName = inputItem.EntityFullName;  
  
		entity.Method = inputItem.Method;  
  
		entity.StartValue = inputItem.StartValue;  
  
		entity.FinishValue = inputItem.FinishValue;  
  
		entity.ApplyProperty1 = inputItem.ApplyProperty1;  
  
		entity.ApplyProperty2 = inputItem.ApplyProperty2;  
  
		entity.ApplyProperty3 = inputItem.ApplyProperty3;  
  
		entity.ApplyPorperty4 = inputItem.ApplyPorperty4;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static NumberedEntityDto Map(NumberedEntity inputItem)
        {
            var dto = new NumberedEntityDto()
            {
                  
  
		NumberedEntityID = inputItem.NumberedEntityID,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		Method = inputItem.Method,  
  
		StartValue = inputItem.StartValue,  
  
		FinishValue = inputItem.FinishValue,  
  
		ApplyProperty1 = inputItem.ApplyProperty1,  
  
		ApplyProperty2 = inputItem.ApplyProperty2,  
  
		ApplyProperty3 = inputItem.ApplyProperty3,  
  
		ApplyPorperty4 = inputItem.ApplyPorperty4,  
  
		Creator = inputItem.Creator,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModifier = inputItem.LastModifier,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<NumberedEntityDto> Map(ICollection<NumberedEntity> entities)
        {
            var dtos = new List<NumberedEntityDto>();
            foreach (var inputItem in entities)
            {
                var dto = new NumberedEntityDto()
                {
                      
  
		NumberedEntityID = inputItem.NumberedEntityID,  
  
		EntityFullName = inputItem.EntityFullName,  
  
		Method = inputItem.Method,  
  
		StartValue = inputItem.StartValue,  
  
		FinishValue = inputItem.FinishValue,  
  
		ApplyProperty1 = inputItem.ApplyProperty1,  
  
		ApplyProperty2 = inputItem.ApplyProperty2,  
  
		ApplyProperty3 = inputItem.ApplyProperty3,  
  
		ApplyPorperty4 = inputItem.ApplyPorperty4,  
  
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
        
        public static StandardDescription Map(AddStandardDescriptionCommand inputItem)
        {
            var entity = new StandardDescription() {
                  
  
		StandardDescriptionId = inputItem.StandardDescriptionId,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static StandardDescription Map(StandardDescription entity ,EditStandardDescriptionCommand inputItem)
        {
              
  
		entity.StandardDescriptionId = inputItem.StandardDescriptionId;  
  
		entity.EntityTypeName = inputItem.EntityTypeName;  
  
		entity.Key = inputItem.Key;  
  
		entity.Value = inputItem.Value;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static StandardDescriptionDto Map(StandardDescription inputItem)
        {
            var dto = new StandardDescriptionDto()
            {
                  
  
		StandardDescriptionId = inputItem.StandardDescriptionId,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<StandardDescriptionDto> Map(ICollection<StandardDescription> entities)
        {
            var dtos = new List<StandardDescriptionDto>();
            foreach (var inputItem in entities)
            {
                var dto = new StandardDescriptionDto()
                {
                      
  
		StandardDescriptionId = inputItem.StandardDescriptionId,  
  
		EntityTypeName = inputItem.EntityTypeName,  
  
		Key = inputItem.Key,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static User Map(AddUserCommand inputItem)
        {
            var entity = new User() {
                  
  
		UserID = inputItem.UserID,  
  
		Name = inputItem.Name,  
  
		Name_En = inputItem.Name_En,  
  
		UserName = inputItem.UserName,  
  
		Password = inputItem.Password,  
  
		Status = inputItem.Status,  
  
		IsDeleted = inputItem.IsDeleted,  
  
		CanChangeAdminConfiguration = inputItem.CanChangeAdminConfiguration,  
  
		Creator = inputItem.Creator,  
  
		LastModifier = inputItem.LastModifier,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static User Map(User entity ,EditUserCommand inputItem)
        {
              
  
		entity.UserID = inputItem.UserID;  
  
		entity.Name = inputItem.Name;  
  
		entity.Name_En = inputItem.Name_En;  
  
		entity.UserName = inputItem.UserName;  
  
		entity.Password = inputItem.Password;  
  
		entity.Status = inputItem.Status;  
  
		entity.IsDeleted = inputItem.IsDeleted;  
  
		entity.CanChangeAdminConfiguration = inputItem.CanChangeAdminConfiguration;  
  
		entity.Creator = inputItem.Creator;  
  
		entity.LastModifier = inputItem.LastModifier;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserDto Map(User inputItem)
        {
            var dto = new UserDto()
            {
                  
  
		UserID = inputItem.UserID,  
  
		Name = inputItem.Name,  
  
		Name_En = inputItem.Name_En,  
  
		UserName = inputItem.UserName,  
  
		Password = inputItem.Password,  
  
		Status = inputItem.Status,  
  
		IsDeleted = inputItem.IsDeleted,  
  
		CanChangeAdminConfiguration = inputItem.CanChangeAdminConfiguration,  
  
		Creator = inputItem.Creator,  
  
		LastModifier = inputItem.LastModifier,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<UserDto> Map(ICollection<User> entities)
        {
            var dtos = new List<UserDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserDto()
                {
                      
  
		UserID = inputItem.UserID,  
  
		Name = inputItem.Name,  
  
		Name_En = inputItem.Name_En,  
  
		UserName = inputItem.UserName,  
  
		Password = inputItem.Password,  
  
		Status = inputItem.Status,  
  
		IsDeleted = inputItem.IsDeleted,  
  
		CanChangeAdminConfiguration = inputItem.CanChangeAdminConfiguration,  
  
		Creator = inputItem.Creator,  
  
		LastModifier = inputItem.LastModifier,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserAccess Map(AddUserAccessCommand inputItem)
        {
            var entity = new UserAccess() {
                  
  
		UserAccessID = inputItem.UserAccessID,  
  
		UserRef = inputItem.UserRef,  
  
		LogicalResource = inputItem.LogicalResource,  
  
		HasAccess = inputItem.HasAccess, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserAccess Map(UserAccess entity ,EditUserAccessCommand inputItem)
        {
              
  
		entity.UserAccessID = inputItem.UserAccessID;  
  
		entity.UserRef = inputItem.UserRef;  
  
		entity.LogicalResource = inputItem.LogicalResource;  
  
		entity.HasAccess = inputItem.HasAccess; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserAccessDto Map(UserAccess inputItem)
        {
            var dto = new UserAccessDto()
            {
                  
  
		UserAccessID = inputItem.UserAccessID,  
  
		UserRef = inputItem.UserRef,  
  
		LogicalResource = inputItem.LogicalResource,  
  
		HasAccess = inputItem.HasAccess, 
            };
            return dto;
        }

        public static List<UserAccessDto> Map(ICollection<UserAccess> entities)
        {
            var dtos = new List<UserAccessDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserAccessDto()
                {
                      
  
		UserAccessID = inputItem.UserAccessID,  
  
		UserRef = inputItem.UserRef,  
  
		LogicalResource = inputItem.LogicalResource,  
  
		HasAccess = inputItem.HasAccess, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserConfiguration Map(AddUserConfigurationCommand inputItem)
        {
            var entity = new UserConfiguration() {
                  
  
		UserConfigurationID = inputItem.UserConfigurationID,  
  
		Key = inputItem.Key,  
  
		UserRef = inputItem.UserRef,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserConfiguration Map(UserConfiguration entity ,EditUserConfigurationCommand inputItem)
        {
              
  
		entity.UserConfigurationID = inputItem.UserConfigurationID;  
  
		entity.Key = inputItem.Key;  
  
		entity.UserRef = inputItem.UserRef;  
  
		entity.Value = inputItem.Value;  
  
		entity.Version = inputItem.Version; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserConfigurationDto Map(UserConfiguration inputItem)
        {
            var dto = new UserConfigurationDto()
            {
                  
  
		UserConfigurationID = inputItem.UserConfigurationID,  
  
		Key = inputItem.Key,  
  
		UserRef = inputItem.UserRef,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
            };
            return dto;
        }

        public static List<UserConfigurationDto> Map(ICollection<UserConfiguration> entities)
        {
            var dtos = new List<UserConfigurationDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserConfigurationDto()
                {
                      
  
		UserConfigurationID = inputItem.UserConfigurationID,  
  
		Key = inputItem.Key,  
  
		UserRef = inputItem.UserRef,  
  
		Value = inputItem.Value,  
  
		Version = inputItem.Version, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserPhone Map(AddUserPhoneCommand inputItem)
        {
            var entity = new UserPhone() {
                  
  
		UserPhoneId = inputItem.UserPhoneId,  
  
		UserRef = inputItem.UserRef,  
  
		Type = inputItem.Type,  
  
		Phone = inputItem.Phone,  
  
		IsMain = inputItem.IsMain, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserPhone Map(UserPhone entity ,EditUserPhoneCommand inputItem)
        {
              
  
		entity.UserPhoneId = inputItem.UserPhoneId;  
  
		entity.UserRef = inputItem.UserRef;  
  
		entity.Type = inputItem.Type;  
  
		entity.Phone = inputItem.Phone;  
  
		entity.IsMain = inputItem.IsMain; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserPhoneDto Map(UserPhone inputItem)
        {
            var dto = new UserPhoneDto()
            {
                  
  
		UserPhoneId = inputItem.UserPhoneId,  
  
		UserRef = inputItem.UserRef,  
  
		Type = inputItem.Type,  
  
		Phone = inputItem.Phone,  
  
		IsMain = inputItem.IsMain, 
            };
            return dto;
        }

        public static List<UserPhoneDto> Map(ICollection<UserPhone> entities)
        {
            var dtos = new List<UserPhoneDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserPhoneDto()
                {
                      
  
		UserPhoneId = inputItem.UserPhoneId,  
  
		UserRef = inputItem.UserRef,  
  
		Type = inputItem.Type,  
  
		Phone = inputItem.Phone,  
  
		IsMain = inputItem.IsMain, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserReports Map(AddUserReportsCommand inputItem)
        {
            var entity = new UserReports() {
                  
  
		UserReportsID = inputItem.UserReportsID,  
  
		Name = inputItem.Name,  
  
		PersianTitle = inputItem.PersianTitle,  
  
		EnglishTitle = inputItem.EnglishTitle,  
  
		ReportData = inputItem.ReportData,  
  
		XMLData = inputItem.XMLData,  
  
		ParentName = inputItem.ParentName,  
  
		ReportMetaDataType = inputItem.ReportMetaDataType, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserReports Map(UserReports entity ,EditUserReportsCommand inputItem)
        {
              
  
		entity.UserReportsID = inputItem.UserReportsID;  
  
		entity.Name = inputItem.Name;  
  
		entity.PersianTitle = inputItem.PersianTitle;  
  
		entity.EnglishTitle = inputItem.EnglishTitle;  
  
		entity.ReportData = inputItem.ReportData;  
  
		entity.XMLData = inputItem.XMLData;  
  
		entity.ParentName = inputItem.ParentName;  
  
		entity.ReportMetaDataType = inputItem.ReportMetaDataType; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserReportsDto Map(UserReports inputItem)
        {
            var dto = new UserReportsDto()
            {
                  
  
		UserReportsID = inputItem.UserReportsID,  
  
		Name = inputItem.Name,  
  
		PersianTitle = inputItem.PersianTitle,  
  
		EnglishTitle = inputItem.EnglishTitle,  
  
		ReportData = inputItem.ReportData,  
  
		XMLData = inputItem.XMLData,  
  
		ParentName = inputItem.ParentName,  
  
		ReportMetaDataType = inputItem.ReportMetaDataType, 
            };
            return dto;
        }

        public static List<UserReportsDto> Map(ICollection<UserReports> entities)
        {
            var dtos = new List<UserReportsDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserReportsDto()
                {
                      
  
		UserReportsID = inputItem.UserReportsID,  
  
		Name = inputItem.Name,  
  
		PersianTitle = inputItem.PersianTitle,  
  
		EnglishTitle = inputItem.EnglishTitle,  
  
		ReportData = inputItem.ReportData,  
  
		XMLData = inputItem.XMLData,  
  
		ParentName = inputItem.ParentName,  
  
		ReportMetaDataType = inputItem.ReportMetaDataType, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static UserReportsInvisible Map(AddUserReportsInvisibleCommand inputItem)
        {
            var entity = new UserReportsInvisible() {
                  
  
		UserReportsInvisibleID = inputItem.UserReportsInvisibleID,  
  
		Name = inputItem.Name, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static UserReportsInvisible Map(UserReportsInvisible entity ,EditUserReportsInvisibleCommand inputItem)
        {
              
  
		entity.UserReportsInvisibleID = inputItem.UserReportsInvisibleID;  
  
		entity.Name = inputItem.Name; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static UserReportsInvisibleDto Map(UserReportsInvisible inputItem)
        {
            var dto = new UserReportsInvisibleDto()
            {
                  
  
		UserReportsInvisibleID = inputItem.UserReportsInvisibleID,  
  
		Name = inputItem.Name, 
            };
            return dto;
        }

        public static List<UserReportsInvisibleDto> Map(ICollection<UserReportsInvisible> entities)
        {
            var dtos = new List<UserReportsInvisibleDto>();
            foreach (var inputItem in entities)
            {
                var dto = new UserReportsInvisibleDto()
                {
                      
  
		UserReportsInvisibleID = inputItem.UserReportsInvisibleID,  
  
		Name = inputItem.Name, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        }        
        
        public static Version1 Map(AddVersion1Command inputItem)
        {
            var entity = new Version1() {
                  
  
		VersionID = inputItem.VersionID,  
  
		Major = inputItem.Major,  
  
		Minor = inputItem.Minor,  
  
		Build = inputItem.Build,  
  
		Revision = inputItem.Revision,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version2 = inputItem.Version2, 
                //CreationDate = DateTime.Now
            };
            return entity;
        }

        public static Version1 Map(Version1 entity ,EditVersion1Command inputItem)
        {
              
  
		entity.VersionID = inputItem.VersionID;  
  
		entity.Major = inputItem.Major;  
  
		entity.Minor = inputItem.Minor;  
  
		entity.Build = inputItem.Build;  
  
		entity.Revision = inputItem.Revision;  
  
		entity.CreationDate = inputItem.CreationDate;  
  
		entity.LastModificationDate = inputItem.LastModificationDate;  
  
		entity.Version2 = inputItem.Version2; 
            entity.ModifiedDate = DateTime.Now;
            return entity;
        }

        
        public static Version1Dto Map(Version1 inputItem)
        {
            var dto = new Version1Dto()
            {
                  
  
		VersionID = inputItem.VersionID,  
  
		Major = inputItem.Major,  
  
		Minor = inputItem.Minor,  
  
		Build = inputItem.Build,  
  
		Revision = inputItem.Revision,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version2 = inputItem.Version2, 
            };
            return dto;
        }

        public static List<Version1Dto> Map(ICollection<Version1> entities)
        {
            var dtos = new List<Version1Dto>();
            foreach (var inputItem in entities)
            {
                var dto = new Version1Dto()
                {
                      
  
		VersionID = inputItem.VersionID,  
  
		Major = inputItem.Major,  
  
		Minor = inputItem.Minor,  
  
		Build = inputItem.Build,  
  
		Revision = inputItem.Revision,  
  
		CreationDate = inputItem.CreationDate,  
  
		LastModificationDate = inputItem.LastModificationDate,  
  
		Version2 = inputItem.Version2, 
                };
                dtos.Add(dto);
            }           
            return dtos;
        } 
    }
}

using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Truck : BaseEntity
    {
          
 
		public Int32 TruckID { get; set; }  
 
		public Nullable<Int32> BrokerPartyRef { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public String VehicleNumber { get; set; }  
 
		public String DrivingLicenseNumber { get; set; }  
 
		public Nullable<Decimal> MinimumWeight { get; set; }  
 
		public Nullable<Decimal> MaximumWeight { get; set; }  
 
		public Nullable<Decimal> MinimumVolumeCapacity { get; set; }  
 
		public Nullable<Decimal> MaximumVolumeCapacity { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Nullable<Int32> BrokerPartyCode { get; set; }  
 
		public Boolean IsActive { get; set; } 
    }
}



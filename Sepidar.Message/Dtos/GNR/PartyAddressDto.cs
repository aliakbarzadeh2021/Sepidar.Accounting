using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class PartyAddressDto
    {
          
 
		public Int32 PartyAddressId { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 IsMain { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public String Address { get; set; }  
 
		public Nullable<Int32> LocationRef { get; set; }  
 
		public String ZipCode { get; set; }  
 
		public String Adress_En { get; set; }  
 
		public String Title { get; set; }  
 
		public Nullable<Decimal> Latitude { get; set; }  
 
		public Nullable<Decimal> Longitude { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public String Guid { get; set; } 
    }
}



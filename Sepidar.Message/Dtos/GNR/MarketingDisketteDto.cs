using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class MarketingDisketteDto
    {
          
 
		public Int32 MarketingDisketteID { get; set; }  
 
		public Int32 year { get; set; }  
 
		public Int32 Season { get; set; }  
 
		public Int32 Type { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Month { get; set; }  
 
		public Int32 PeriodType { get; set; }  
 
		public Boolean FillItemNameByCategory { get; set; } 
    }
}



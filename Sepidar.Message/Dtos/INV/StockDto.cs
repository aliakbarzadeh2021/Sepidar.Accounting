using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class StockDto
    {
          
 
		public Int32 StockID { get; set; }  
 
		public Int32 Code { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public String StockClerk { get; set; }  
 
		public String Phone { get; set; }  
 
		public String Address { get; set; }  
 
		public String Address_En { get; set; }  
 
		public Nullable<Int32> AccountSLRef { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



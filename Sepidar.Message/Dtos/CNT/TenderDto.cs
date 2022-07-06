using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class TenderDto
    {
          
 
		public Int32 TenderID { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public Int32 DocumentNumber { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 TenderPartyRef { get; set; }  
 
		public DateTime StartDate { get; set; }  
 
		public DateTime EndDate { get; set; }  
 
		public Int32 DLRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public Int32 FiscalYearRef { get; set; } 
    }
}



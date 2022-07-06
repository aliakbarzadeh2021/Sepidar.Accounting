using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ContractPriceListDto
    {
          
 
		public Int32 ContractPriceListID { get; set; }  
 
		public String ContractPriceListChapterTitle { get; set; }  
 
		public String ContractPriceListClassTitle { get; set; }  
 
		public String ContractPriceListFieldTitle { get; set; }  
 
		public String OperationalYear { get; set; }  
 
		public String OperationCode { get; set; }  
 
		public String OperationDescription { get; set; }  
 
		public String OperationUnit { get; set; }  
 
		public Nullable<Decimal> OperationFee { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



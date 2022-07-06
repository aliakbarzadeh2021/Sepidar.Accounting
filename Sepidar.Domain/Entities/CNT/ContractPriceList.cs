using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ContractPriceList : BaseEntity
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



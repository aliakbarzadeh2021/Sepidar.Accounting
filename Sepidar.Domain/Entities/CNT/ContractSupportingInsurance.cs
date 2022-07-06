using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class ContractSupportingInsurance : BaseEntity
    {
          
 
		public Int32 ContractSupportingInsuranceID { get; set; }  
 
		public Int32 ContractRef { get; set; }  
 
		public Int32 RowNumber { get; set; }  
 
		public Int32 BranchCode { get; set; }  
 
		public String BranchTitle { get; set; }  
 
		public String BranchTitle_En { get; set; }  
 
		public String WorkshopCode { get; set; }  
 
		public String Description { get; set; }  
 
		public String Description_En { get; set; } 
    }
}



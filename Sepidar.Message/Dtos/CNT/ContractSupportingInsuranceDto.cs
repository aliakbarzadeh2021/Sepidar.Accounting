using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class ContractSupportingInsuranceDto
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



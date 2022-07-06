using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class AcquisitionReceiptItem : BaseEntity
    {
          
 
		public Int32 AcquisitionReceiptItemID { get; set; }  
 
		public Int32 AcquisitionReceiptRef { get; set; }  
 
		public String PlaqueNumber { get; set; }  
 
		public String OldPlaqueNumber { get; set; }  
 
		public String Title { get; set; }  
 
		public String Title_En { get; set; }  
 
		public Int32 AssetGroupRef { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Nullable<Int32> CostCenterDlRef { get; set; }  
 
		public Nullable<Int32> EmplacementRef { get; set; }  
 
		public Nullable<Int32> ReceiverPartyRef { get; set; }  
 
		public String Description { get; set; }  
 
		public String Details { get; set; }  
 
		public DateTime UtilizationDate { get; set; }  
 
		public Decimal AccumulatedDepreciation { get; set; }  
 
		public Decimal TotalCost { get; set; }  
 
		public Decimal TotalCostInBasecurrency { get; set; }  
 
		public Decimal DepreciationRate { get; set; }  
 
		public Int32 DepreciationMethodType { get; set; }  
 
		public Decimal UsefulLife { get; set; }  
 
		public Decimal MaxDepreciableBookValue { get; set; }  
 
		public Decimal SalvageValue { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; } 
    }
}



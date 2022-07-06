using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class TransferItem : BaseEntity
    {
          
 
		public Int32 TransferItemID { get; set; }  
 
		public Int32 AssetRef { get; set; }  
 
		public Int32 TransferRef { get; set; }  
 
		public Int32 AssetTransactionRef { get; set; }  
 
		public Nullable<Int32> PreCostCenterDlRef { get; set; }  
 
		public Nullable<Int32> PreEmplacementRef { get; set; }  
 
		public Nullable<Int32> PreReceiverPartyRef { get; set; }  
 
		public Int32 CostCenterDlRef { get; set; }  
 
		public Nullable<Int32> EmplacementRef { get; set; }  
 
		public Nullable<Int32> ReceiverPartyRef { get; set; } 
    }
}



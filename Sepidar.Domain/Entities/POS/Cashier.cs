using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class Cashier : BaseEntity
    {
          
 
		public Int32 CashierID { get; set; }  
 
		public String Title { get; set; }  
 
		public Int32 PartyRef { get; set; }  
 
		public Int32 UserRef { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public Boolean CanChangeDiscount { get; set; }  
 
		public Boolean CanReceiveCash { get; set; }  
 
		public Boolean CanReceiveCheque { get; set; }  
 
		public Boolean CanReceivePos { get; set; }  
 
		public Boolean CanReceiveOther { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 
    }
}



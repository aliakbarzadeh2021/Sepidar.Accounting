using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class QuickBarItem : BaseEntity
    {
          
 
		public Int32 QuickBarItemID { get; set; }  
 
		public Int32 QuickBarRef { get; set; }  
 
		public Int32 ItemIndex { get; set; }  
 
		public Int32 ItemRef { get; set; }  
 
		public Int32 Shortcut { get; set; } 
    }
}



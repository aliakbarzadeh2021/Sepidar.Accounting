using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class GLVoucherItem : BaseEntity
    {
          
 
		public Int32 GLVoucherItemId { get; set; }  
 
		public Int32 GLVoucherRef { get; set; }  
 
		public Int32 VoucherRef { get; set; }  
 
		public Int32 Version { get; set; } 
    }
}



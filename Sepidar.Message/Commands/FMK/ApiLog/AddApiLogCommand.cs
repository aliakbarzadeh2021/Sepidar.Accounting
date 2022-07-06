using Sepidar.Message.Base;
using Sepidar.Message.Extentions;
using Sepidar.Message.Validators;
using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Commands
{
    /// <summary>
    ///  
    /// </summary>
    public class AddApiLogCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 ApiLogID { get; set; }  
 
		public DateTime RequestTime { get; set; }  
 
		public String RequestUrl { get; set; }  
 
		public String RequestUserHostAddress { get; set; }  
 
		public String RequestHeaders { get; set; }  
 
		public String RequestMethod { get; set; }  
 
		public String RequestBody { get; set; }  
 
		public String Guid { get; set; }  
 
		public Nullable<Int32> UserRef { get; set; }  
 
		public String UserName { get; set; }  
 
		public String UserName_En { get; set; }  
 
		public String UserUserName { get; set; }  
 
		public Nullable<Int32> DeviceRef { get; set; }  
 
		public String DeviceTitle { get; set; }  
 
		public String DeviceTitle_En { get; set; }  
 
		public Nullable<Int32> DeviceCode { get; set; }  
 
		public String OriginalResource { get; set; }  
 
		public Nullable<DateTime> ResponseTime { get; set; }  
 
		public String ResponseRawText { get; set; }  
 
		public Nullable<Int32> ResponseStatusCode { get; set; } 

        public void Validate()
        {
            new AddApiLogCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

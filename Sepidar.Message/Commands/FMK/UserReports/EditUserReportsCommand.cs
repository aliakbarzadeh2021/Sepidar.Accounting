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
    public class EditUserReportsCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 UserReportsID { get; set; }  
 
		public String Name { get; set; }  
 
		public String PersianTitle { get; set; }  
 
		public String EnglishTitle { get; set; }  
 
		public Byte[] ReportData { get; set; }  
 
		public Byte[] XMLData { get; set; }  
 
		public String ParentName { get; set; }  
 
		public Nullable<Int32> ReportMetaDataType { get; set; } 

        public void Validate()
        {
            new EditUserReportsCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

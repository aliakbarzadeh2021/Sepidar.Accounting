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
    public class AddAutomaticBackupConfigCommand : ICommandBase
    {
        public Guid Id {get;set;}
          
 
		public Int32 AutomaticBackupConfigID { get; set; }  
 
		public Boolean IsActive { get; set; }  
 
		public String BackupPath { get; set; }  
 
		public String Filename { get; set; }  
 
		public Nullable<Int32> BackupPeriod { get; set; }  
 
		public Nullable<Int32> BackupFrequency { get; set; }  
 
		public Nullable<DateTime> BackupStartDateTime { get; set; }  
 
		public Nullable<DateTime> LastBackupDate { get; set; }  
 
		public Boolean IsPasswordProtected { get; set; }  
 
		public String Password { get; set; }  
 
		public Boolean DeleteOldFiles { get; set; }  
 
		public Int32 NumberOfFiles { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; } 

        public void Validate()
        {
            new AddAutomaticBackupConfigCommandValidator().Validate(this).RaiseExceptionIfRequired();
        }
    }
}

using Sepidar.Domain.Entities.Base;
using Sepidar.Infrastructure.Enum;

using System;
using System.Collections.Generic;

namespace Sepidar.Domain.Entities
{
    public class AutomaticBackupConfig : BaseEntity
    {
          
 
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
    }
}



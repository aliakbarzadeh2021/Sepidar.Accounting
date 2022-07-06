using Sepidar.Infrastructure.Enum;
using System;

namespace Sepidar.Message.Dtos
{
    public class BackupDto
    {
          
 
		public Int32 BackupID { get; set; }  
 
		public String Label { get; set; }  
 
		public DateTime Date { get; set; }  
 
		public String Path { get; set; }  
 
		public Nullable<DateTime> RestoreDate { get; set; }  
 
		public Int32 Version { get; set; }  
 
		public Int32 Creator { get; set; }  
 
		public DateTime CreationDate { get; set; }  
 
		public Int32 LastModifier { get; set; }  
 
		public DateTime LastModificationDate { get; set; }  
 
		public String Filename { get; set; }  
 
		public String ServerName { get; set; }  
 
		public Boolean IsOk { get; set; }  
 
		public Nullable<Boolean> IsAutomatic { get; set; }  
 
		public Boolean IsPasswordProtected { get; set; }  
 
		public String Password { get; set; } 
    }
}



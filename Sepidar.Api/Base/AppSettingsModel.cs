namespace Sepidar.api.Base
{
    public class AppSettingsModel
    {
        public bool HostRunAsConsole { get; set; }
        public string HostAddress { get; set; }
        public JwtIssuerOptions JwtIssuerOptions { get; set; }
    }
}

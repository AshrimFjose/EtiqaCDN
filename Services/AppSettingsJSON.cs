using Microsoft.Extensions.Configuration;
using System.IO;

namespace EtiqaCDN.Services
{
    public class AppSettingsJSON
    {
        public AppSettingsJSON() { }

        public string GetValue(string parent, string children)
        {
            var appSettingValue = "";

            var config = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json").Build();

            appSettingValue = config.GetSection(parent).GetSection(children).Value.ToString();

            return appSettingValue;
        }
    }
}

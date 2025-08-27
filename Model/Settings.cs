using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace TODOList.Model
{
    internal class Settings
    {
        public string conStr { get; set; }
        public string GetSettingsRelease()
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").AddEnvironmentVariables().Build();
            var settings = config.GetSection("SettingsRelease").Get<Settings>();
            string chaine = settings.conStr;
            return (chaine);
        }
        public string GetSettingsDebug()
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("AppSettings.json").AddEnvironmentVariables().Build();
            var settings = config.GetSection("SettingsDebug").Get<Settings>();
            string chaine = settings.conStr;
            return (chaine);
        }
    }
}

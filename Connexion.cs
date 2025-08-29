using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using TODOList.Model;

namespace TODOList
{
    public class Connexion
    {
        private SqlConnection connexion;

        public SqlConnection GetConnection()
        {
            Settings settings = new Settings();
            if (Environment.GetEnvironmentVariable("env") == "release")
            {
                connexion = new SqlConnection(settings.GetSettingsRelease());
            }
            else
            {
                connexion = new SqlConnection(settings.GetSettingsDebug());
            }
            return connexion;
        }
    }
}

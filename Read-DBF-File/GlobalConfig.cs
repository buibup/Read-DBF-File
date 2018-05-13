using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace Read_DBF_File
{
    public static class GlobalConfig
    {
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static string AppConfig(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}
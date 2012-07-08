using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using ObliqueStrategies.Properties;

namespace ObliqueStrategies.Classes
{
    public static class ConfigurationHelper
    {
        public static bool? TryToCreateDefault()
        {
            bool? result = null;
            try
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                if (configuration.HasFile==false)
                    throw new Exception();
                result = false;
            }
            catch
            {
                try
                {
                    var fiApp = new FileInfo(Application.ExecutablePath);
                    File.WriteAllText(Path.Combine(fiApp.Directory.FullName,
                            string.Concat(fiApp.Name, ".config")),
                        Resources.Config);
                    result = true;
                }
                catch { }
            }
            return result;
        }

        private static string ReadValue(string key)
        {
            string value = null;
            try
            {
                value=ConfigurationManager.AppSettings[key];
            }
            catch
            {}
            return value;
        }

        private static bool WriteValue(string key, string value)
        {
            var result = false;
            try
            {
                var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                configuration.AppSettings.Settings[key].Value = value;
                configuration.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                result = true;
            }
            catch{}
            return result;
        }

        public static bool ReadValue<T>(string key, out T value)
        {
            var result = false;
            value=default(T);

            var strValue = ReadValue(key);
            if (strValue!=null)
            {
                try
                {
                    value = (T) Convert.ChangeType(strValue, typeof (T));
                    result = true;
                }
                catch{}
            }
            return result;
        }

        public static bool WriteValue<T>(string key, T value)
        {
            var result = false;

            if (WriteValue(key, value.ToString()))
                result = true;

            return result;
        }
    }
}

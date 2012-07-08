using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ObliqueStrategies.Classes
{
    public static class StartupHelper
    {
        private const string STARTUP_APPLICATION_NAME = "Oblique Strategies";

        public static bool SetStartup(Boolean RunOnStartup)
        {
            var result = false;
            RegistryKey key = null;

            try
            {
                key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (RunOnStartup)
                    key.SetValue(STARTUP_APPLICATION_NAME, Application.ExecutablePath);
                else
                    key.DeleteValue(STARTUP_APPLICATION_NAME, false);
                result = true;
            }
            catch{}
            finally
            {
                if (key!=null)
                    key.Close();
            }

            return result;
        }

        public static bool GetStartup()
        {
            var result = false;
            RegistryKey key=null;

            try
            {
                key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", false);
                var appName = key.GetValue(STARTUP_APPLICATION_NAME);
                result = (appName != null && appName.ToString()==Application.ExecutablePath);
            }
            catch { }
            finally
            {
                if (key!=null)
                    key.Close();
            }

            return result;
        }
    }
}

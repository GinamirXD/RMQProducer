using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producer
{
    public class LocalizationManager
    {
        public static void SetCulture(string cultureCode)
        {
            var culture = new CultureInfo(cultureCode);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
        }

        public static string GetSavedLanguage()
        {
            string appDataConfigPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "RMQProducer",
            "Producer.exe.config"
            );

            var configMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = appDataConfigPath
            };

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(
                configMap,
                ConfigurationUserLevel.None
            );
            return config.AppSettings.Settings["Language"].Value ?? "en";
        }

        public static void SaveLanguage(string langCode)
        {
            /*string appDataConfigPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "RMQProducer",
            "Producer.exe.config"
            );

            if (!File.Exists(appDataConfigPath))
            {
                MessageBox.Show("Конфигурационный файл не был найден", $"{Strings.error}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var configMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = appDataConfigPath
            };

            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(
                configMap,
                ConfigurationUserLevel.None
            );*/
            
            AppConfigManager.Config.AppSettings.Settings["Language"].Value = langCode;
            AppConfigManager.Config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}

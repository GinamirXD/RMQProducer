using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Producer
{
    public partial class FormUser : Form
    {
        public string UserName { get; private set; }
        public string Password { get; private set; }

        public FormUser()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            UserName = textBoxUser.Text;
            Password = textBoxPassword.Text;

            string appDataConfigPath = Path.Combine(
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
            );

            config.AppSettings.Settings["UserName"].Value = UserName;
            config.AppSettings.Settings["Password"].Value = Password;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

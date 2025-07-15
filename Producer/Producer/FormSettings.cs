using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
namespace Producer
{
    public partial class FormSettings : Form
    {
        

        public string ConnectionType { get; private set; }
        public string VHost { get; private set; }
        public string HostName { get; private set; }
        public string Port { get; private set; }
        public string URI { get; private set; }
        public string Exchange {  get; private set; }
        public string ExchangeType { get; private set; }

        public FormSettings()
        {
            InitializeComponent();
        }

        private void radioVirtualHost_CheckedChanged(object sender, EventArgs e)
        {
            if (radioVirtualHost.Checked)
            {
                labelConnection1.Visible = true;
                textBoxConnection1.Visible = true;
                labelHost.Visible = true;
                textBoxHost.Visible = true;
                textBoxPort.Visible = true;
                labelPort.Visible = true;
                labelConnectionURI.Visible = false;
                textBoxConnectionURI.Visible = false;
            }
            else if (radioUri.Checked)
            {
                labelConnection1.Visible = false;
                textBoxConnection1.Visible = false;
                labelHost.Visible = false;
                textBoxHost.Visible = false;
                textBoxPort.Visible = false;
                labelPort.Visible = false;
                labelConnectionURI.Visible = true;
                textBoxConnectionURI.Visible = true;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            ConnectionType = radioVirtualHost.Checked ? "VirtualHost" : "URI";
            VHost = textBoxConnection1.Text;
            HostName = textBoxHost.Text;
            Port = textBoxPort.Text;
            URI = textBoxConnectionURI.Text;
            Exchange = textBoxExchange.Text;
            ExchangeType = comboBoxExchangeType.SelectedItem.ToString();

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

            AppConfigManager.Config.AppSettings.Settings["ConnectionType"].Value = ConnectionType;
            AppConfigManager.Config.AppSettings.Settings["VHost"].Value = VHost;
            AppConfigManager.Config.AppSettings.Settings["HostName"].Value = HostName;
            AppConfigManager.Config.AppSettings.Settings["Port"].Value = Port;
            AppConfigManager.Config.AppSettings.Settings["URI"].Value = URI;
            AppConfigManager.Config.AppSettings.Settings["Exchange"].Value = Exchange;
            AppConfigManager.Config.AppSettings.Settings["ExchangeType"].Value = ExchangeType;
            AppConfigManager.Config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
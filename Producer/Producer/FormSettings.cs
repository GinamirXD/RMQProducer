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

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["ConnectionType"].Value = ConnectionType;
            config.AppSettings.Settings["VHost"].Value = VHost;
            config.AppSettings.Settings["HostName"].Value = HostName;
            config.AppSettings.Settings["Port"].Value = Port;
            config.AppSettings.Settings["URI"].Value = URI;
            config.AppSettings.Settings["Exchange"].Value = Exchange;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
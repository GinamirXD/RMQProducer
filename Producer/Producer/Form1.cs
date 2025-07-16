using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace Producer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonSubmit_Click(object sender, EventArgs e)
        {
            string key = textBoxKey.Text.Trim();
            string json = textBoxJson.Text.Trim();

            DialogResult result = MessageBox.Show(
                $"{Strings.submitMessage}",
                $"{Strings.submitMessageBox}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrWhiteSpace(key))
                {
                    MessageBox.Show($"{Strings.IsNullOrWhiteSpaceKey}", $"{Strings.error}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(json))
                {
                    MessageBox.Show($"{Strings.IsNullOrWhiteSpaceJson}", $"{Strings.error}", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidJson(json))
                {
                    MessageBox.Show($"{Strings.IsValidJson}", $"{Strings.error}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    SendMessageToRabbitMQ(key, json);
                    MessageBox.Show($"{Strings.succsesfulSend}", $"{Strings.success}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{Strings.sendError} {ex.Message}", $"{Strings.error}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void SendMessageToRabbitMQ(string key, string json)
        {
            string connectionType = AppConfigManager.Config.AppSettings.Settings["ConnectionType"].Value;
            string vhost = AppConfigManager.Config.AppSettings.Settings["VHost"].Value;
            string userName = AppConfigManager.Config.AppSettings.Settings["UserName"].Value;
            string password = AppConfigManager.Config.AppSettings.Settings["Password"].Value;
            string host = AppConfigManager.Config.AppSettings.Settings["HostName"].Value;
            string uri = AppConfigManager.Config.AppSettings.Settings["URI"].Value;
            string port = AppConfigManager.Config.AppSettings.Settings["Port"].Value ;

            var factory = new ConnectionFactory();

            if (connectionType == "VirtualHost")
            {
                factory.HostName = host;
                factory.UserName = userName;
                factory.Password = password;
                factory.VirtualHost = vhost;
                factory.Port = Convert.ToInt32(port);
            }
            else
            {
                factory.Uri = new Uri(uri);
            }

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var body = Encoding.UTF8.GetBytes(json);

                    channel.ExchangeDeclare(exchange: AppConfigManager.Config.AppSettings.Settings["Exchange"].Value, type: AppConfigManager.Config.AppSettings.Settings["ExchangeType"].Value, durable: true);

                    channel.BasicPublish(exchange: AppConfigManager.Config.AppSettings.Settings["Exchange"].Value,
                        routingKey: key,
                        basicProperties: null,
                        body: body);

                    Console.WriteLine("Done");
                }
            }
        }
        
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            FormSettings settingsForm = new FormSettings();
            settingsForm.ShowDialog();
        }
        private void ButtonUser_Click(object sender, EventArgs e)
        {
            FormUser userForm = new FormUser();
            userForm.ShowDialog();
        }
        private void ButtonLanguage_Click(object sender, EventArgs e)
        {
            FormLanguage languageForm = new FormLanguage();
            languageForm.ShowDialog();
        }
        private bool IsValidJson(string json)
        {
            try
            {
                var token = JToken.Parse(json);
                return true;
            }
            catch (JsonReaderException)
            {
                return false;
            }
        }
    }
}

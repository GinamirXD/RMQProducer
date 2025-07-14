using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
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

            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["UserName"].Value = UserName;
            config.AppSettings.Settings["Password"].Value = Password;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

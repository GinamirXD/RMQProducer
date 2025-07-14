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
using System.Globalization;
using System.Threading;

namespace Producer
{
    public partial class FormLanguage : Form
    {
        public string Language { get; set; }
        public FormLanguage()
        {
            InitializeComponent();
        }        
        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCulture = comboBoxLanguage.SelectedItem.ToString() == "Русский" ? "ru" : "en";
            LocalizationManager.SaveLanguage(selectedCulture);
            LocalizationManager.SetCulture(selectedCulture);

            this.Close();

            if (Application.OpenForms["Form1"] is Form1 form1)
            {
                form1.Controls.Clear();
                form1.InitializeComponent();
            }           
        }
    }
}

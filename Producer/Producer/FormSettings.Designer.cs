namespace Producer
{
    partial class FormSettings
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radioVirtualHost = new System.Windows.Forms.RadioButton();
            this.radioUri = new System.Windows.Forms.RadioButton();
            this.labelConnection1 = new System.Windows.Forms.Label();
            this.textBoxConnection1 = new System.Windows.Forms.TextBox();
            this.labelConnectionURI = new System.Windows.Forms.Label();
            this.textBoxConnectionURI = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelHost = new System.Windows.Forms.Label();
            this.textBoxHost = new System.Windows.Forms.TextBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelExchange = new System.Windows.Forms.Label();
            this.textBoxExchange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // radioVirtualHost
            // 
            this.radioVirtualHost.AutoSize = true;
            this.radioVirtualHost.Checked = true;
            this.radioVirtualHost.Location = new System.Drawing.Point(30, 20);
            this.radioVirtualHost.Name = "radioVirtualHost";
            this.radioVirtualHost.Size = new System.Drawing.Size(230, 20);
            this.radioVirtualHost.TabIndex = 0;
            this.radioVirtualHost.TabStop = true;
            this.radioVirtualHost.Text = Strings.radioVirtualHost;
            this.radioVirtualHost.CheckedChanged += new System.EventHandler(this.radioVirtualHost_CheckedChanged);
            // 
            // radioUri
            // 
            this.radioUri.AutoSize = true;
            this.radioUri.Location = new System.Drawing.Point(228, 20);
            this.radioUri.Name = "radioUri";
            this.radioUri.Size = new System.Drawing.Size(188, 20);
            this.radioUri.TabIndex = 1;
            this.radioUri.Text = Strings.radioUri;
            // 
            // labelConnection1
            // 
            this.labelConnection1.AutoSize = true;
            this.labelConnection1.Location = new System.Drawing.Point(30, 60);
            this.labelConnection1.Name = "labelConnection1";
            this.labelConnection1.Size = new System.Drawing.Size(75, 16);
            this.labelConnection1.TabIndex = 2;
            this.labelConnection1.Text = "VirtualHost:";
            // 
            // textBoxConnection1
            // 
            this.textBoxConnection1.Location = new System.Drawing.Point(30, 80);
            this.textBoxConnection1.Name = "textBoxConnection1";
            this.textBoxConnection1.Size = new System.Drawing.Size(346, 22);
            this.textBoxConnection1.TabIndex = 3;
            // 
            // labelConnectionURI
            // 
            this.labelConnectionURI.AutoSize = true;
            this.labelConnectionURI.Location = new System.Drawing.Point(30, 60);
            this.labelConnectionURI.Name = "labelConnectionURI";
            this.labelConnectionURI.Size = new System.Drawing.Size(33, 16);
            this.labelConnectionURI.TabIndex = 2;
            this.labelConnectionURI.Text = "URI:";
            this.labelConnectionURI.Visible = false;
            // 
            // textBoxConnectionURI
            // 
            this.textBoxConnectionURI.Location = new System.Drawing.Point(30, 80);
            this.textBoxConnectionURI.Name = "textBoxConnectionURI";
            this.textBoxConnectionURI.Size = new System.Drawing.Size(346, 22);
            this.textBoxConnectionURI.TabIndex = 3;
            this.textBoxConnectionURI.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(288, 269);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(91, 30);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = Strings.buttonSave;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.Location = new System.Drawing.Point(30, 160);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(78, 16);
            this.labelHost.TabIndex = 1;
            this.labelHost.Text = "Host Name:";
            // 
            // textBoxHost
            // 
            this.textBoxHost.Location = new System.Drawing.Point(33, 179);
            this.textBoxHost.Name = "textBoxHost";
            this.textBoxHost.Size = new System.Drawing.Size(346, 22);
            this.textBoxHost.TabIndex = 0;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(30, 213);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(34, 16);
            this.labelPort.TabIndex = 5;
            this.labelPort.Text = "Port:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(33, 232);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(346, 22);
            this.textBoxPort.TabIndex = 6;
            // 
            // labelExchange
            // 
            this.labelExchange.AutoSize = true;
            this.labelExchange.Location = new System.Drawing.Point(30, 109);
            this.labelExchange.Name = "labelExchange";
            this.labelExchange.Size = new System.Drawing.Size(70, 16);
            this.labelExchange.TabIndex = 7;
            this.labelExchange.Text = "Exchange:";
            // 
            // textBoxExchange
            // 
            this.textBoxExchange.Location = new System.Drawing.Point(30, 129);
            this.textBoxExchange.Name = "textBoxExchange";
            this.textBoxExchange.Size = new System.Drawing.Size(346, 22);
            this.textBoxExchange.TabIndex = 8;
            // 
            // FormSettings
            // 
            this.ClientSize = new System.Drawing.Size(407, 311);
            this.Controls.Add(this.textBoxExchange);
            this.Controls.Add(this.labelExchange);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxHost);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.radioVirtualHost);
            this.Controls.Add(this.radioUri);
            this.Controls.Add(this.labelConnection1);
            this.Controls.Add(this.textBoxConnection1);
            this.Controls.Add(this.labelConnectionURI);
            this.Controls.Add(this.textBoxConnectionURI);
            this.Controls.Add(this.buttonSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = Strings.connectionSettings;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.RadioButton radioVirtualHost;
        private System.Windows.Forms.RadioButton radioUri;
        private System.Windows.Forms.Label labelConnection1;
        private System.Windows.Forms.TextBox textBoxConnection1;
        private System.Windows.Forms.Label labelConnectionURI;
        private System.Windows.Forms.TextBox textBoxConnectionURI;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.TextBox textBoxHost;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelExchange;
        private System.Windows.Forms.TextBox textBoxExchange;
    }
}
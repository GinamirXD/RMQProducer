using System.Windows.Forms;

namespace Producer
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        public void InitializeComponent()
        {
            this.labelKey = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.labelJson = new System.Windows.Forms.Label();
            this.textBoxJson = new System.Windows.Forms.TextBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.buttonLanguage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(16, 18);
            this.labelKey.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(81, 16);
            this.labelKey.TabIndex = 0;
            this.labelKey.Text = Strings.routingKey;
            // 
            // textBoxKey
            // 
            this.textBoxKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxKey.Location = new System.Drawing.Point(177, 15);
            this.textBoxKey.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxKey.MaxLength = 15;
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(297, 22);
            this.textBoxKey.TabIndex = 1;
            // 
            // labelJson
            // 
            this.labelJson.AutoSize = true;
            this.labelJson.Location = new System.Drawing.Point(15, 50);
            this.labelJson.Name = "labelJson";
            this.labelJson.Size = new System.Drawing.Size(104, 16);
            this.labelJson.TabIndex = 2;
            this.labelJson.Text = Strings.labelJson;
            // 
            // textBoxJson
            // 
            this.textBoxJson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJson.Location = new System.Drawing.Point(19, 69);
            this.textBoxJson.Multiline = true;
            this.textBoxJson.Name = "textBoxJson";
            this.textBoxJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxJson.Size = new System.Drawing.Size(575, 236);
            this.textBoxJson.TabIndex = 3;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.Location = new System.Drawing.Point(468, 315);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(125, 34);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = global::Producer.Strings.buttonSubmit;
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSettings.Location = new System.Drawing.Point(335, 316);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(126, 34);
            this.buttonSettings.TabIndex = 5;
            this.buttonSettings.Text = global::Producer.Strings.buttonSettings;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUser.Location = new System.Drawing.Point(203, 315);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(126, 34);
            this.buttonUser.TabIndex = 5;
            this.buttonUser.Text = global::Producer.Strings.buttonUser;
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.ButtonUser_Click);
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.Location = new System.Drawing.Point(71, 316);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Size = new System.Drawing.Size(126, 34);
            this.buttonLanguage.TabIndex = 6;
            this.buttonLanguage.Text = global::Producer.Strings.buttonLanguage;
            this.buttonLanguage.UseVisualStyleBackColor = true;
            this.buttonLanguage.Click += new System.EventHandler(this.ButtonLanguage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 362);
            this.Controls.Add(this.buttonLanguage);
            this.Controls.Add(this.buttonUser);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.textBoxJson);
            this.Controls.Add(this.labelJson);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.labelKey);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "RabbitMQ JSON Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label labelJson;
        private System.Windows.Forms.TextBox textBoxJson;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonUser;
        private Button buttonLanguage;
    }
}


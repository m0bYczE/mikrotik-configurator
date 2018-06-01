namespace mikrotik_configurator
{
    partial class configurationMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.wifiSettingsBtn = new System.Windows.Forms.Button();
            this.modulesBtn = new System.Windows.Forms.Button();
            this.portForwardingBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wifiSettingsBtn
            // 
            this.wifiSettingsBtn.Location = new System.Drawing.Point(96, 12);
            this.wifiSettingsBtn.Name = "wifiSettingsBtn";
            this.wifiSettingsBtn.Size = new System.Drawing.Size(115, 73);
            this.wifiSettingsBtn.TabIndex = 0;
            this.wifiSettingsBtn.Text = "Packman200 WiFi settings";
            this.wifiSettingsBtn.UseVisualStyleBackColor = true;
            this.wifiSettingsBtn.Click += new System.EventHandler(this.wifiSettingsBtn_Click);
            // 
            // modulesBtn
            // 
            this.modulesBtn.Location = new System.Drawing.Point(96, 91);
            this.modulesBtn.Name = "modulesBtn";
            this.modulesBtn.Size = new System.Drawing.Size(115, 73);
            this.modulesBtn.TabIndex = 1;
            this.modulesBtn.Text = "Packman200 modules";
            this.modulesBtn.UseVisualStyleBackColor = true;
            this.modulesBtn.Click += new System.EventHandler(this.modulesBtn_Click);
            // 
            // portForwardingBtn
            // 
            this.portForwardingBtn.Location = new System.Drawing.Point(96, 170);
            this.portForwardingBtn.Name = "portForwardingBtn";
            this.portForwardingBtn.Size = new System.Drawing.Size(115, 73);
            this.portForwardingBtn.TabIndex = 2;
            this.portForwardingBtn.Text = "Port forwarding";
            this.portForwardingBtn.UseVisualStyleBackColor = true;
            this.portForwardingBtn.Click += new System.EventHandler(this.portForwardingBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(96, 266);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(115, 25);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // configurationMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 308);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.portForwardingBtn);
            this.Controls.Add(this.modulesBtn);
            this.Controls.Add(this.wifiSettingsBtn);
            this.MaximizeBox = false;
            this.Name = "configurationMenu";
            this.Text = "MikroTik Configurator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wifiSettingsBtn;
        private System.Windows.Forms.Button modulesBtn;
        private System.Windows.Forms.Button portForwardingBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}


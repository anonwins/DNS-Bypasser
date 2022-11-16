namespace DNS_Bypasser
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboboxNetworkAdapter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.radioProvider1 = new System.Windows.Forms.RadioButton();
            this.panelAddresses = new System.Windows.Forms.Panel();
            this.textBoxIPv6b = new System.Windows.Forms.TextBox();
            this.textBoxIPv6a = new System.Windows.Forms.TextBox();
            this.textBoxIPv4b = new System.Windows.Forms.TextBox();
            this.textBoxIPv4a = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioProvider2 = new System.Windows.Forms.RadioButton();
            this.buttonApply = new System.Windows.Forms.Button();
            this.radioProvider3 = new System.Windows.Forms.RadioButton();
            this.radioProvider4 = new System.Windows.Forms.RadioButton();
            this.radioProviderCustom = new System.Windows.Forms.RadioButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panelAddresses.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboboxNetworkAdapter
            // 
            this.comboboxNetworkAdapter.BackColor = System.Drawing.Color.Black;
            this.comboboxNetworkAdapter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboboxNetworkAdapter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxNetworkAdapter.ForeColor = System.Drawing.Color.White;
            this.comboboxNetworkAdapter.FormattingEnabled = true;
            this.comboboxNetworkAdapter.Location = new System.Drawing.Point(145, 29);
            this.comboboxNetworkAdapter.Name = "comboboxNetworkAdapter";
            this.comboboxNetworkAdapter.Size = new System.Drawing.Size(425, 25);
            this.comboboxNetworkAdapter.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Network Adapter:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNS Provider:";
            // 
            // radioProvider1
            // 
            this.radioProvider1.AutoSize = true;
            this.radioProvider1.Checked = true;
            this.radioProvider1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioProvider1.Location = new System.Drawing.Point(114, 9);
            this.radioProvider1.Name = "radioProvider1";
            this.radioProvider1.Size = new System.Drawing.Size(83, 21);
            this.radioProvider1.TabIndex = 5;
            this.radioProvider1.TabStop = true;
            this.radioProvider1.Text = "dns.watch";
            this.radioProvider1.UseVisualStyleBackColor = true;
            this.radioProvider1.CheckedChanged += new System.EventHandler(this.radioProvider1_CheckedChanged);
            // 
            // panelAddresses
            // 
            this.panelAddresses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelAddresses.Controls.Add(this.textBoxIPv6b);
            this.panelAddresses.Controls.Add(this.textBoxIPv6a);
            this.panelAddresses.Controls.Add(this.textBoxIPv4b);
            this.panelAddresses.Controls.Add(this.textBoxIPv4a);
            this.panelAddresses.ForeColor = System.Drawing.Color.White;
            this.panelAddresses.Location = new System.Drawing.Point(31, 111);
            this.panelAddresses.Name = "panelAddresses";
            this.panelAddresses.Size = new System.Drawing.Size(552, 85);
            this.panelAddresses.TabIndex = 6;
            // 
            // textBoxIPv6b
            // 
            this.textBoxIPv6b.BackColor = System.Drawing.Color.Black;
            this.textBoxIPv6b.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIPv6b.ForeColor = System.Drawing.Color.White;
            this.textBoxIPv6b.Location = new System.Drawing.Point(287, 45);
            this.textBoxIPv6b.Name = "textBoxIPv6b";
            this.textBoxIPv6b.Size = new System.Drawing.Size(245, 23);
            this.textBoxIPv6b.TabIndex = 9;
            // 
            // textBoxIPv6a
            // 
            this.textBoxIPv6a.BackColor = System.Drawing.Color.Black;
            this.textBoxIPv6a.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIPv6a.ForeColor = System.Drawing.Color.White;
            this.textBoxIPv6a.Location = new System.Drawing.Point(21, 45);
            this.textBoxIPv6a.Name = "textBoxIPv6a";
            this.textBoxIPv6a.Size = new System.Drawing.Size(245, 23);
            this.textBoxIPv6a.TabIndex = 8;
            // 
            // textBoxIPv4b
            // 
            this.textBoxIPv4b.BackColor = System.Drawing.Color.Black;
            this.textBoxIPv4b.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIPv4b.ForeColor = System.Drawing.Color.White;
            this.textBoxIPv4b.Location = new System.Drawing.Point(287, 16);
            this.textBoxIPv4b.Name = "textBoxIPv4b";
            this.textBoxIPv4b.Size = new System.Drawing.Size(245, 23);
            this.textBoxIPv4b.TabIndex = 1;
            // 
            // textBoxIPv4a
            // 
            this.textBoxIPv4a.BackColor = System.Drawing.Color.Black;
            this.textBoxIPv4a.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIPv4a.ForeColor = System.Drawing.Color.White;
            this.textBoxIPv4a.Location = new System.Drawing.Point(21, 16);
            this.textBoxIPv4a.Name = "textBoxIPv4a";
            this.textBoxIPv4a.Size = new System.Drawing.Size(245, 23);
            this.textBoxIPv4a.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.radioProviderCustom);
            this.panel2.Controls.Add(this.radioProvider4);
            this.panel2.Controls.Add(this.radioProvider3);
            this.panel2.Controls.Add(this.radioProvider2);
            this.panel2.Controls.Add(this.radioProvider1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(31, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 32);
            this.panel2.TabIndex = 8;
            // 
            // radioProvider2
            // 
            this.radioProvider2.AutoSize = true;
            this.radioProvider2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioProvider2.Location = new System.Drawing.Point(203, 9);
            this.radioProvider2.Name = "radioProvider2";
            this.radioProvider2.Size = new System.Drawing.Size(69, 21);
            this.radioProvider2.TabIndex = 7;
            this.radioProvider2.Text = "Google";
            this.radioProvider2.UseVisualStyleBackColor = true;
            this.radioProvider2.CheckedChanged += new System.EventHandler(this.radioProvider2_CheckedChanged);
            // 
            // buttonApply
            // 
            this.buttonApply.BackColor = System.Drawing.Color.Fuchsia;
            this.buttonApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonApply.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonApply.ForeColor = System.Drawing.Color.White;
            this.buttonApply.Location = new System.Drawing.Point(168, 223);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(275, 28);
            this.buttonApply.TabIndex = 9;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = false;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // radioProvider3
            // 
            this.radioProvider3.AutoSize = true;
            this.radioProvider3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioProvider3.Location = new System.Drawing.Point(277, 9);
            this.radioProvider3.Name = "radioProvider3";
            this.radioProvider3.Size = new System.Drawing.Size(83, 21);
            this.radioProvider3.TabIndex = 11;
            this.radioProvider3.Text = "Control-D";
            this.radioProvider3.UseVisualStyleBackColor = true;
            this.radioProvider3.CheckedChanged += new System.EventHandler(this.radioProvider3_CheckedChanged);
            // 
            // radioProvider4
            // 
            this.radioProvider4.AutoSize = true;
            this.radioProvider4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioProvider4.Location = new System.Drawing.Point(366, 9);
            this.radioProvider4.Name = "radioProvider4";
            this.radioProvider4.Size = new System.Drawing.Size(86, 21);
            this.radioProvider4.TabIndex = 12;
            this.radioProvider4.Text = "Cloudflare";
            this.radioProvider4.UseVisualStyleBackColor = true;
            this.radioProvider4.CheckedChanged += new System.EventHandler(this.radioProvider4_CheckedChanged);
            // 
            // radioProviderCustom
            // 
            this.radioProviderCustom.AutoSize = true;
            this.radioProviderCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioProviderCustom.Location = new System.Drawing.Point(458, 9);
            this.radioProviderCustom.Name = "radioProviderCustom";
            this.radioProviderCustom.Size = new System.Drawing.Size(73, 21);
            this.radioProviderCustom.TabIndex = 13;
            this.radioProviderCustom.Text = "Custom:";
            this.radioProviderCustom.UseVisualStyleBackColor = true;
            this.radioProviderCustom.CheckedChanged += new System.EventHandler(this.radioProviderCustom_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(28, 234);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(46, 17);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Github";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(614, 277);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelAddresses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboboxNetworkAdapter);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNS Bypasser";
            this.panelAddresses.ResumeLayout(false);
            this.panelAddresses.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboboxNetworkAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioProvider1;
        private System.Windows.Forms.Panel panelAddresses;
        private System.Windows.Forms.TextBox textBoxIPv6b;
        private System.Windows.Forms.TextBox textBoxIPv6a;
        private System.Windows.Forms.TextBox textBoxIPv4b;
        private System.Windows.Forms.TextBox textBoxIPv4a;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioProvider2;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.RadioButton radioProvider3;
        private System.Windows.Forms.RadioButton radioProvider4;
        private System.Windows.Forms.RadioButton radioProviderCustom;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}


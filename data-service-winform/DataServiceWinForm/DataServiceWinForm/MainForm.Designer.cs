namespace DataServiceWinForm
{
    partial class MainForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.tbxMessages = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxAccountName = new System.Windows.Forms.TextBox();
            this.tbxSubscription = new System.Windows.Forms.TextBox();
            this.tbxRootURL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbxFilter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetItems = new System.Windows.Forms.Button();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(14, 253);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tbxMessages
            // 
            this.tbxMessages.BackColor = System.Drawing.SystemColors.Control;
            this.tbxMessages.Enabled = false;
            this.tbxMessages.Location = new System.Drawing.Point(15, 168);
            this.tbxMessages.Multiline = true;
            this.tbxMessages.Name = "tbxMessages";
            this.tbxMessages.Size = new System.Drawing.Size(292, 52);
            this.tbxMessages.TabIndex = 22;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(105, 90);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(141, 20);
            this.tbxPassword.TabIndex = 21;
            // 
            // tbxAccountName
            // 
            this.tbxAccountName.Location = new System.Drawing.Point(105, 64);
            this.tbxAccountName.Name = "tbxAccountName";
            this.tbxAccountName.Size = new System.Drawing.Size(141, 20);
            this.tbxAccountName.TabIndex = 20;
            // 
            // tbxSubscription
            // 
            this.tbxSubscription.Location = new System.Drawing.Point(105, 38);
            this.tbxSubscription.Name = "tbxSubscription";
            this.tbxSubscription.Size = new System.Drawing.Size(141, 20);
            this.tbxSubscription.TabIndex = 19;
            // 
            // tbxRootURL
            // 
            this.tbxRootURL.Location = new System.Drawing.Point(105, 11);
            this.tbxRootURL.Name = "tbxRootURL";
            this.tbxRootURL.Size = new System.Drawing.Size(202, 20);
            this.tbxRootURL.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "account name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "subscription";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "MagoCloud URL";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 125);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 23);
            this.btnConnect.TabIndex = 13;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbxFilter
            // 
            this.tbxFilter.Location = new System.Drawing.Point(397, 6);
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.Size = new System.Drawing.Size(143, 20);
            this.tbxFilter.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Filter";
            // 
            // btnGetItems
            // 
            this.btnGetItems.Location = new System.Drawing.Point(546, 3);
            this.btnGetItems.Name = "btnGetItems";
            this.btnGetItems.Size = new System.Drawing.Size(75, 23);
            this.btnGetItems.TabIndex = 26;
            this.btnGetItems.Text = "Get Items";
            this.btnGetItems.UseVisualStyleBackColor = true;
            this.btnGetItems.Click += new System.EventHandler(this.btnGetItems_Click);
            // 
            // tbxData
            // 
            this.tbxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxData.BackColor = System.Drawing.SystemColors.Control;
            this.tbxData.Location = new System.Drawing.Point(364, 32);
            this.tbxData.Multiline = true;
            this.tbxData.Name = "tbxData";
            this.tbxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxData.Size = new System.Drawing.Size(424, 406);
            this.tbxData.TabIndex = 27;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.btnGetItems);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.tbxMessages);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxAccountName);
            this.Controls.Add(this.tbxSubscription);
            this.Controls.Add(this.tbxRootURL);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnect);
            this.Name = "MainForm";
            this.Text = "DataService Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TextBox tbxMessages;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxAccountName;
        private System.Windows.Forms.TextBox tbxSubscription;
        private System.Windows.Forms.TextBox tbxRootURL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbxFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetItems;
        private System.Windows.Forms.TextBox tbxData;
    }
}


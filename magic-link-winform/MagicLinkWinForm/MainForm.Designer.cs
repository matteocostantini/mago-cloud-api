namespace MagicLinkWinForm
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
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxRootURL = new System.Windows.Forms.TextBox();
            this.tbxSubscription = new System.Windows.Forms.TextBox();
            this.tbxAccountName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxMessages = new System.Windows.Forms.TextBox();
            this.btnGetContacts = new System.Windows.Forms.Button();
            this.tbxData = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(16, 137);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(96, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MagoCloud URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "subscription";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "account name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "password";
            // 
            // tbxRootURL
            // 
            this.tbxRootURL.Location = new System.Drawing.Point(106, 23);
            this.tbxRootURL.Name = "tbxRootURL";
            this.tbxRootURL.Size = new System.Drawing.Size(202, 20);
            this.tbxRootURL.TabIndex = 5;
            // 
            // tbxSubscription
            // 
            this.tbxSubscription.Location = new System.Drawing.Point(106, 50);
            this.tbxSubscription.Name = "tbxSubscription";
            this.tbxSubscription.Size = new System.Drawing.Size(141, 20);
            this.tbxSubscription.TabIndex = 6;
            // 
            // tbxAccountName
            // 
            this.tbxAccountName.Location = new System.Drawing.Point(106, 76);
            this.tbxAccountName.Name = "tbxAccountName";
            this.tbxAccountName.Size = new System.Drawing.Size(141, 20);
            this.tbxAccountName.TabIndex = 7;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(106, 102);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(141, 20);
            this.tbxPassword.TabIndex = 8;
            // 
            // tbxMessages
            // 
            this.tbxMessages.BackColor = System.Drawing.SystemColors.Control;
            this.tbxMessages.Enabled = false;
            this.tbxMessages.Location = new System.Drawing.Point(16, 180);
            this.tbxMessages.Multiline = true;
            this.tbxMessages.Name = "tbxMessages";
            this.tbxMessages.Size = new System.Drawing.Size(292, 52);
            this.tbxMessages.TabIndex = 9;
            // 
            // btnGetContacts
            // 
            this.btnGetContacts.Location = new System.Drawing.Point(334, 21);
            this.btnGetContacts.Name = "btnGetContacts";
            this.btnGetContacts.Size = new System.Drawing.Size(109, 23);
            this.btnGetContacts.TabIndex = 10;
            this.btnGetContacts.Text = "Get Contacts";
            this.btnGetContacts.UseVisualStyleBackColor = true;
            this.btnGetContacts.Click += new System.EventHandler(this.btnGetContacts_Click);
            // 
            // tbxData
            // 
            this.tbxData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxData.BackColor = System.Drawing.SystemColors.Control;
            this.tbxData.Location = new System.Drawing.Point(334, 53);
            this.tbxData.Multiline = true;
            this.tbxData.Name = "tbxData";
            this.tbxData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxData.Size = new System.Drawing.Size(454, 244);
            this.tbxData.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.tbxData);
            this.Controls.Add(this.btnGetContacts);
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
            this.Text = "MagicLink Sample";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxRootURL;
        private System.Windows.Forms.TextBox tbxSubscription;
        private System.Windows.Forms.TextBox tbxAccountName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxMessages;
        private System.Windows.Forms.Button btnGetContacts;
        private System.Windows.Forms.TextBox tbxData;
    }
}


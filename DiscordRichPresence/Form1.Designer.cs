namespace RPCTUTORIAL
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

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSetClientId = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLargeImageText = new System.Windows.Forms.TextBox();
            this.txtLargeImageKey = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtButton2Url = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtButton2Label = new System.Windows.Forms.TextBox();
            this.txtButton1Url = new System.Windows.Forms.TextBox();
            this.txtButton1Label = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkShowButtons = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.pictureBoxAvatar);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(10, 10);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(63, 13);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pictureBoxAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(25, 30);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxAvatar.TabIndex = 1;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(10, 130);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.Text = "Status";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.btnSetClientId);
            this.panel2.Controls.Add(this.txtClientId);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnInitialize);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Location = new System.Drawing.Point(168, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 150);
            this.panel2.TabIndex = 1;
            // 
            // btnSetClientId
            // 
            this.btnSetClientId.Location = new System.Drawing.Point(10, 60);
            this.btnSetClientId.Name = "btnSetClientId";
            this.btnSetClientId.Size = new System.Drawing.Size(180, 23);
            this.btnSetClientId.TabIndex = 4;
            this.btnSetClientId.Text = "Set Client ID";
            this.btnSetClientId.UseVisualStyleBackColor = true;
            this.btnSetClientId.Click += new System.EventHandler(this.btnSetClientId_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(10, 30);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(180, 20);
            this.txtClientId.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Client ID";
            // 
            // btnInitialize
            // 
            this.btnInitialize.Location = new System.Drawing.Point(10, 90);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(180, 23);
            this.btnInitialize.TabIndex = 0;
            this.btnInitialize.Text = "Initialize RPC";
            this.btnInitialize.UseVisualStyleBackColor = true;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(10, 120);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Presence";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLargeImageText);
            this.groupBox1.Controls.Add(this.txtLargeImageKey);
            this.groupBox1.Controls.Add(this.txtState);
            this.groupBox1.Controls.Add(this.txtDetails);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 150);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Presence Details";
            // 
            // txtLargeImageText
            // 
            this.txtLargeImageText.Location = new System.Drawing.Point(150, 110);
            this.txtLargeImageText.Name = "txtLargeImageText";
            this.txtLargeImageText.Size = new System.Drawing.Size(200, 20);
            this.txtLargeImageText.TabIndex = 7;
            // 
            // txtLargeImageKey
            // 
            this.txtLargeImageKey.Location = new System.Drawing.Point(150, 80);
            this.txtLargeImageKey.Name = "txtLargeImageKey";
            this.txtLargeImageKey.Size = new System.Drawing.Size(200, 20);
            this.txtLargeImageKey.TabIndex = 6;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(150, 50);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(200, 20);
            this.txtState.TabIndex = 5;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(150, 20);
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(200, 20);
            this.txtDetails.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Large Image Text";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Large Image Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "State";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtButton2Url);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtButton2Label);
            this.groupBox2.Controls.Add(this.txtButton1Url);
            this.groupBox2.Controls.Add(this.txtButton1Label);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chkShowButtons);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buttons";
            // 
            // txtButton2Url
            // 
            this.txtButton2Url.Enabled = false;
            this.txtButton2Url.Location = new System.Drawing.Point(150, 110);
            this.txtButton2Url.Name = "txtButton2Url";
            this.txtButton2Url.Size = new System.Drawing.Size(200, 20);
            this.txtButton2Url.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Button 2 URL";
            // 
            // txtButton2Label
            // 
            this.txtButton2Label.Enabled = false;
            this.txtButton2Label.Location = new System.Drawing.Point(150, 80);
            this.txtButton2Label.Name = "txtButton2Label";
            this.txtButton2Label.Size = new System.Drawing.Size(200, 20);
            this.txtButton2Label.TabIndex = 5;
            // 
            // txtButton1Url
            // 
            this.txtButton1Url.Enabled = false;
            this.txtButton1Url.Location = new System.Drawing.Point(150, 50);
            this.txtButton1Url.Name = "txtButton1Url";
            this.txtButton1Url.Size = new System.Drawing.Size(200, 20);
            this.txtButton1Url.TabIndex = 4;
            // 
            // txtButton1Label
            // 
            this.txtButton1Label.Enabled = false;
            this.txtButton1Label.Location = new System.Drawing.Point(150, 20);
            this.txtButton1Label.Name = "txtButton1Label";
            this.txtButton1Label.Size = new System.Drawing.Size(200, 20);
            this.txtButton1Label.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Button 1 URL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Button 1 Label";
            // 
            // chkShowButtons
            // 
            this.chkShowButtons.AutoSize = true;
            this.chkShowButtons.Location = new System.Drawing.Point(10, 130);
            this.chkShowButtons.Name = "chkShowButtons";
            this.chkShowButtons.Size = new System.Drawing.Size(92, 17);
            this.chkShowButtons.TabIndex = 0;
            this.chkShowButtons.Text = "Show Buttons";
            this.chkShowButtons.UseVisualStyleBackColor = true;
            this.chkShowButtons.CheckedChanged += new System.EventHandler(this.chkShowButtons_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 486);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discord RPC Control Panel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLargeImageText;
        private System.Windows.Forms.TextBox txtLargeImageKey;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtButton2Url;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtButton2Label;
        private System.Windows.Forms.TextBox txtButton1Url;
        private System.Windows.Forms.TextBox txtButton1Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkShowButtons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.Button btnSetClientId;
    }
}
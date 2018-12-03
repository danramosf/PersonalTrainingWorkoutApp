namespace WorkOutApp
{
    partial class PersonalTrainerEditProfile
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
            this.lblProfile = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPersonalTrainerProfilePic = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picProfileImg = new System.Windows.Forms.PictureBox();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.lblProfileAddress = new System.Windows.Forms.Label();
            this.lblProfileEmail = new System.Windows.Forms.Label();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.txtProfileAddress = new System.Windows.Forms.TextBox();
            this.txtProfileEmail = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImg)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProfile
            // 
            this.lblProfile.AutoSize = true;
            this.lblProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfile.Location = new System.Drawing.Point(189, 24);
            this.lblProfile.Name = "lblProfile";
            this.lblProfile.Size = new System.Drawing.Size(119, 13);
            this.lblProfile.TabIndex = 0;
            this.lblProfile.Text = "Edit Profile - <user>";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblMainMenu);
            this.panel2.Controls.Add(this.pbPersonalTrainerProfilePic);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblProfile);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 61);
            this.panel2.TabIndex = 6;
            // 
            // pbPersonalTrainerProfilePic
            // 
            this.pbPersonalTrainerProfilePic.Location = new System.Drawing.Point(414, 5);
            this.pbPersonalTrainerProfilePic.Name = "pbPersonalTrainerProfilePic";
            this.pbPersonalTrainerProfilePic.Size = new System.Drawing.Size(41, 34);
            this.pbPersonalTrainerProfilePic.TabIndex = 1;
            this.pbPersonalTrainerProfilePic.TabStop = false;
            this.pbPersonalTrainerProfilePic.Click += new System.EventHandler(this.pbPersonalTrainerProfilePic_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(401, 42);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(68, 13);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "Edit Account";
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMainMenu.Location = new System.Drawing.Point(23, 24);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(80, 13);
            this.lblMainMenu.TabIndex = 3;
            this.lblMainMenu.Text = "< Main Menu";
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveProfile);
            this.panel1.Controls.Add(this.txtProfileEmail);
            this.panel1.Controls.Add(this.txtProfileAddress);
            this.panel1.Controls.Add(this.txtProfileName);
            this.panel1.Controls.Add(this.lblProfileEmail);
            this.panel1.Controls.Add(this.lblProfileAddress);
            this.panel1.Controls.Add(this.lblProfileName);
            this.panel1.Controls.Add(this.picProfileImg);
            this.panel1.Location = new System.Drawing.Point(2, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 323);
            this.panel1.TabIndex = 7;
            // 
            // picProfileImg
            // 
            this.picProfileImg.Location = new System.Drawing.Point(26, 24);
            this.picProfileImg.Name = "picProfileImg";
            this.picProfileImg.Size = new System.Drawing.Size(200, 200);
            this.picProfileImg.TabIndex = 4;
            this.picProfileImg.TabStop = false;
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.Location = new System.Drawing.Point(255, 48);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(35, 13);
            this.lblProfileName.TabIndex = 5;
            this.lblProfileName.Text = "Name";
            // 
            // lblProfileAddress
            // 
            this.lblProfileAddress.AutoSize = true;
            this.lblProfileAddress.Location = new System.Drawing.Point(255, 111);
            this.lblProfileAddress.Name = "lblProfileAddress";
            this.lblProfileAddress.Size = new System.Drawing.Size(45, 13);
            this.lblProfileAddress.TabIndex = 6;
            this.lblProfileAddress.Text = "Address";
            // 
            // lblProfileEmail
            // 
            this.lblProfileEmail.AutoSize = true;
            this.lblProfileEmail.Location = new System.Drawing.Point(255, 179);
            this.lblProfileEmail.Name = "lblProfileEmail";
            this.lblProfileEmail.Size = new System.Drawing.Size(32, 13);
            this.lblProfileEmail.TabIndex = 7;
            this.lblProfileEmail.Text = "Email";
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(318, 45);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(180, 20);
            this.txtProfileName.TabIndex = 8;
            // 
            // txtProfileAddress
            // 
            this.txtProfileAddress.Location = new System.Drawing.Point(318, 108);
            this.txtProfileAddress.Name = "txtProfileAddress";
            this.txtProfileAddress.Size = new System.Drawing.Size(180, 20);
            this.txtProfileAddress.TabIndex = 9;
            // 
            // txtProfileEmail
            // 
            this.txtProfileEmail.Location = new System.Drawing.Point(318, 176);
            this.txtProfileEmail.Name = "txtProfileEmail";
            this.txtProfileEmail.Size = new System.Drawing.Size(180, 20);
            this.txtProfileEmail.TabIndex = 10;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Location = new System.Drawing.Point(318, 275);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(180, 23);
            this.btnSaveProfile.TabIndex = 11;
            this.btnSaveProfile.Text = "Save";
            this.btnSaveProfile.UseVisualStyleBackColor = true;
            // 
            // PersonalTrainerEditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PersonalTrainerEditProfile";
            this.Text = "Personal Trainer - Edit Profile";
            this.Load += new System.EventHandler(this.PersonalTrainerEditProfile_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProfile;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbPersonalTrainerProfilePic;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picProfileImg;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.TextBox txtProfileEmail;
        private System.Windows.Forms.TextBox txtProfileAddress;
        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Label lblProfileEmail;
        private System.Windows.Forms.Label lblProfileAddress;
        private System.Windows.Forms.Label lblProfileName;
    }
}
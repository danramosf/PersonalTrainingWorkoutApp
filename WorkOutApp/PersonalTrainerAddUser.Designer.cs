namespace WorkOutApp
{
    partial class PersonalTrainerAddUser
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
            this.components = new System.ComponentModel.Container();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbPersonalTrainerProfilePic = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblObjective = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.cmbObjective = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblMainMenu.Location = new System.Drawing.Point(15, 24);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(80, 13);
            this.lblMainMenu.TabIndex = 7;
            this.lblMainMenu.Text = "< Main Menu";
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblMainMenu);
            this.panel2.Controls.Add(this.pbPersonalTrainerProfilePic);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(554, 61);
            this.panel2.TabIndex = 9;
            // 
            // pbPersonalTrainerProfilePic
            // 
            this.pbPersonalTrainerProfilePic.Location = new System.Drawing.Point(488, 5);
            this.pbPersonalTrainerProfilePic.Name = "pbPersonalTrainerProfilePic";
            this.pbPersonalTrainerProfilePic.Size = new System.Drawing.Size(41, 34);
            this.pbPersonalTrainerProfilePic.TabIndex = 1;
            this.pbPersonalTrainerProfilePic.TabStop = false;
            this.pbPersonalTrainerProfilePic.Click += new System.EventHandler(this.pbPersonalTrainerProfilePic_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(475, 42);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(68, 13);
            this.lblAccount.TabIndex = 2;
            this.lblAccount.Text = "Edit Account";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(169, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "<user> - Add User";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.cmbObjective);
            this.panel1.Controls.Add(this.txtTelephone);
            this.panel1.Controls.Add(this.txtUserEmail);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblObjective);
            this.panel1.Controls.Add(this.lblTelephone);
            this.panel1.Controls.Add(this.lblUserEmail);
            this.panel1.Controls.Add(this.lblLastName);
            this.panel1.Controls.Add(this.lblFirstName);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Location = new System.Drawing.Point(13, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 370);
            this.panel1.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(24, 20);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(24, 75);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(57, 13);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(22, 124);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(58, 13);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(24, 174);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(32, 13);
            this.lblUserEmail.TabIndex = 3;
            this.lblUserEmail.Text = "Email";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(24, 226);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Telephone";
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Location = new System.Drawing.Point(27, 270);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(52, 13);
            this.lblObjective.TabIndex = 5;
            this.lblObjective.Text = "Objective";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(121, 17);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(297, 20);
            this.txtUsername.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(121, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(297, 20);
            this.txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(121, 121);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(297, 20);
            this.txtLastName.TabIndex = 8;
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(121, 174);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(297, 20);
            this.txtUserEmail.TabIndex = 9;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(121, 223);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(297, 20);
            this.txtTelephone.TabIndex = 10;
            // 
            // cmbObjective
            // 
            this.cmbObjective.FormattingEnabled = true;
            this.cmbObjective.Items.AddRange(new object[] {
            "1:  Bulking",
            "2:  Weight Loss",
            "3:  Strength"});
            this.cmbObjective.Location = new System.Drawing.Point(121, 270);
            this.cmbObjective.Name = "cmbObjective";
            this.cmbObjective.Size = new System.Drawing.Size(297, 21);
            this.cmbObjective.TabIndex = 11;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(224, 322);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PersonalTrainerAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PersonalTrainerAddUser";
            this.Text = "Personal Trainer - Add User";
            this.Load += new System.EventHandler(this.PersonalTrainerAddUser_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbPersonalTrainerProfilePic;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.ComboBox cmbObjective;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtUserEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
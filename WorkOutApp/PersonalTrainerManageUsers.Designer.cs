namespace WorkOutApp
{
    partial class PersonalTrainerManageUsers
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.pbPersonalTrainerProfilePic = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblMainMenu);
            this.panel2.Controls.Add(this.pbPersonalTrainerProfilePic);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 61);
            this.panel2.TabIndex = 8;
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
            // pbPersonalTrainerProfilePic
            // 
            this.pbPersonalTrainerProfilePic.Location = new System.Drawing.Point(596, 5);
            this.pbPersonalTrainerProfilePic.Name = "pbPersonalTrainerProfilePic";
            this.pbPersonalTrainerProfilePic.Size = new System.Drawing.Size(41, 34);
            this.pbPersonalTrainerProfilePic.TabIndex = 1;
            this.pbPersonalTrainerProfilePic.TabStop = false;
            this.pbPersonalTrainerProfilePic.Click += new System.EventHandler(this.pbPersonalTrainerProfilePic_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(583, 42);
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
            this.lblTitle.Size = new System.Drawing.Size(160, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "<user> - Manage Exercises";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 282);
            this.dataGridView1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteUser);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(13, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(666, 370);
            this.panel1.TabIndex = 10;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(432, 321);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(96, 23);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(551, 321);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteUser.TabIndex = 11;
            this.btnDeleteUser.Text = "Delete Selected";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            // 
            // PersonalTrainerManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PersonalTrainerManageUsers";
            this.Text = "PersonalTrainerManageUsers";
            this.Load += new System.EventHandler(this.PersonalTrainerManageUsers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.PictureBox pbPersonalTrainerProfilePic;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
    }
}
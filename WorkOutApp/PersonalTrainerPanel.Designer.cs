namespace WorkOutApp
{
    partial class PersonalTrainerPanel
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pbPersonalTrainerProfilePic = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.picMngUsers = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMngUsers = new System.Windows.Forms.Label();
            this.picMngExercises = new System.Windows.Forms.PictureBox();
            this.lblMngExercises = new System.Windows.Forms.Label();
            this.lblMngDefault = new System.Windows.Forms.Label();
            this.picMngDefault = new System.Windows.Forms.PictureBox();
            this.lblLogout = new System.Windows.Forms.Label();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMngUsers)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMngExercises)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMngDefault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(22, 24);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(90, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, <user>";
            // 
            // pbPersonalTrainerProfilePic
            // 
            this.pbPersonalTrainerProfilePic.Location = new System.Drawing.Point(414, 5);
            this.pbPersonalTrainerProfilePic.Name = "pbPersonalTrainerProfilePic";
            this.pbPersonalTrainerProfilePic.Size = new System.Drawing.Size(41, 34);
            this.pbPersonalTrainerProfilePic.TabIndex = 1;
            this.pbPersonalTrainerProfilePic.TabStop = false;
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
            // picMngUsers
            // 
            this.picMngUsers.Location = new System.Drawing.Point(32, 13);
            this.picMngUsers.Name = "picMngUsers";
            this.picMngUsers.Size = new System.Drawing.Size(159, 128);
            this.picMngUsers.TabIndex = 3;
            this.picMngUsers.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblLogout);
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.lblMngDefault);
            this.panel1.Controls.Add(this.picMngDefault);
            this.panel1.Controls.Add(this.lblMngExercises);
            this.panel1.Controls.Add(this.picMngExercises);
            this.panel1.Controls.Add(this.lblMngUsers);
            this.panel1.Controls.Add(this.picMngUsers);
            this.panel1.Location = new System.Drawing.Point(20, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 342);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMngUsers
            // 
            this.lblMngUsers.AutoSize = true;
            this.lblMngUsers.Location = new System.Drawing.Point(38, 153);
            this.lblMngUsers.Name = "lblMngUsers";
            this.lblMngUsers.Size = new System.Drawing.Size(76, 13);
            this.lblMngUsers.TabIndex = 4;
            this.lblMngUsers.Text = "Manage Users";
            // 
            // picMngExercises
            // 
            this.picMngExercises.Location = new System.Drawing.Point(261, 13);
            this.picMngExercises.Name = "picMngExercises";
            this.picMngExercises.Size = new System.Drawing.Size(159, 128);
            this.picMngExercises.TabIndex = 5;
            this.picMngExercises.TabStop = false;
            // 
            // lblMngExercises
            // 
            this.lblMngExercises.AutoSize = true;
            this.lblMngExercises.Location = new System.Drawing.Point(268, 153);
            this.lblMngExercises.Name = "lblMngExercises";
            this.lblMngExercises.Size = new System.Drawing.Size(94, 13);
            this.lblMngExercises.TabIndex = 6;
            this.lblMngExercises.Text = "Manage Exercises";
            // 
            // lblMngDefault
            // 
            this.lblMngDefault.AutoSize = true;
            this.lblMngDefault.Location = new System.Drawing.Point(38, 318);
            this.lblMngDefault.Name = "lblMngDefault";
            this.lblMngDefault.Size = new System.Drawing.Size(132, 13);
            this.lblMngDefault.TabIndex = 8;
            this.lblMngDefault.Text = "Manage Default Workouts";
            this.lblMngDefault.Click += new System.EventHandler(this.label1_Click);
            // 
            // picMngDefault
            // 
            this.picMngDefault.Location = new System.Drawing.Point(32, 178);
            this.picMngDefault.Name = "picMngDefault";
            this.picMngDefault.Size = new System.Drawing.Size(159, 128);
            this.picMngDefault.TabIndex = 7;
            this.picMngDefault.TabStop = false;
            // 
            // lblLogout
            // 
            this.lblLogout.AutoSize = true;
            this.lblLogout.Location = new System.Drawing.Point(267, 318);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(40, 13);
            this.lblLogout.TabIndex = 10;
            this.lblLogout.Text = "Logout";
            // 
            // picLogout
            // 
            this.picLogout.Location = new System.Drawing.Point(261, 178);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(159, 128);
            this.picLogout.TabIndex = 9;
            this.picLogout.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pbPersonalTrainerProfilePic);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblWelcome);
            this.panel2.Location = new System.Drawing.Point(-1, -2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 61);
            this.panel2.TabIndex = 5;
            // 
            // PersonalTrainerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonalTrainerPanel";
            this.Text = "Personal Trainer Panel";
            this.Load += new System.EventHandler(this.PersonalTrainerPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMngUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMngExercises)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMngDefault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pbPersonalTrainerProfilePic;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.PictureBox picMngUsers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblLogout;
        private System.Windows.Forms.PictureBox picLogout;
        private System.Windows.Forms.Label lblMngDefault;
        private System.Windows.Forms.PictureBox picMngDefault;
        private System.Windows.Forms.Label lblMngExercises;
        private System.Windows.Forms.PictureBox picMngExercises;
        private System.Windows.Forms.Label lblMngUsers;
        private System.Windows.Forms.Panel panel2;
    }
}
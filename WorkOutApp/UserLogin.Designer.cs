namespace WorkOutApp
{
    partial class UserLogin
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
            this.lblPersonalTrainerAccount = new System.Windows.Forms.Label();
            this.cmbPersonalTrainerAccount = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPersonalTrainerAccount
            // 
            this.lblPersonalTrainerAccount.AutoSize = true;
            this.lblPersonalTrainerAccount.Location = new System.Drawing.Point(140, 183);
            this.lblPersonalTrainerAccount.Name = "lblPersonalTrainerAccount";
            this.lblPersonalTrainerAccount.Size = new System.Drawing.Size(189, 13);
            this.lblPersonalTrainerAccount.TabIndex = 0;
            this.lblPersonalTrainerAccount.Text = "Select your Personal Trainer Account: ";
            // 
            // cmbPersonalTrainerAccount
            // 
            this.cmbPersonalTrainerAccount.FormattingEnabled = true;
            this.cmbPersonalTrainerAccount.Location = new System.Drawing.Point(382, 183);
            this.cmbPersonalTrainerAccount.Name = "cmbPersonalTrainerAccount";
            this.cmbPersonalTrainerAccount.Size = new System.Drawing.Size(219, 21);
            this.cmbPersonalTrainerAccount.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(382, 232);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(219, 23);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PersonalTrainerLoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbPersonalTrainerAccount);
            this.Controls.Add(this.lblPersonalTrainerAccount);
            this.Name = "PersonalTrainerLoginPanel";
            this.Text = "Personal Trainer Panel - Login";
            this.Load += new System.EventHandler(this.PersonalTrainerLoginPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPersonalTrainerAccount;
        private System.Windows.Forms.ComboBox cmbPersonalTrainerAccount;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
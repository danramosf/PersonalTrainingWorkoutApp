namespace WorkOutApp
{
    partial class PersonalTrainerManageExercises
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeleteExercise = new System.Windows.Forms.Button();
            this.btnAddExercise = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblMainMenu);
            this.panel2.Controls.Add(this.pbPersonalTrainerProfilePic);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 61);
            this.panel2.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDeleteExercise);
            this.panel1.Controls.Add(this.btnAddExercise);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(-3, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 333);
            this.panel1.TabIndex = 7;
            // 
            // btnDeleteExercise
            // 
            this.btnDeleteExercise.Enabled = false;
            this.btnDeleteExercise.Location = new System.Drawing.Point(532, 286);
            this.btnDeleteExercise.Name = "btnDeleteExercise";
            this.btnDeleteExercise.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteExercise.TabIndex = 2;
            this.btnDeleteExercise.Text = "Delete Selected";
            this.btnDeleteExercise.UseVisualStyleBackColor = true;
            this.btnDeleteExercise.Click += new System.EventHandler(this.btnDeleteExercise_Click);
            // 
            // btnAddExercise
            // 
            this.btnAddExercise.Location = new System.Drawing.Point(399, 286);
            this.btnAddExercise.Name = "btnAddExercise";
            this.btnAddExercise.Size = new System.Drawing.Size(105, 23);
            this.btnAddExercise.TabIndex = 1;
            this.btnAddExercise.Text = "Add Exercise";
            this.btnAddExercise.UseVisualStyleBackColor = true;
            this.btnAddExercise.Click += new System.EventHandler(this.btnAddExercise_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(631, 241);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // PersonalTrainerManageExercises
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PersonalTrainerManageExercises";
            this.Text = "Personal Trainer Panel - Manage Exercises";
            this.Load += new System.EventHandler(this.PersonalTrainerManageExercises_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbPersonalTrainerProfilePic;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteExercise;
        private System.Windows.Forms.Button btnAddExercise;
    }
}
namespace WorkOutApp
{
    partial class PersonalTrainerAddExercise
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
            this.pbPersonalTrainerProfilePic = new System.Windows.Forms.PictureBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExerciseName = new System.Windows.Forms.Label();
            this.lblMuscle = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtExerciseName = new System.Windows.Forms.TextBox();
            this.txtMuscle = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.richTextDescription = new System.Windows.Forms.RichTextBox();
            this.btnSaveExercise = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.lblMainMenu.Click += new System.EventHandler(this.lblMainMenu_Click_1);
            // 
            // pbPersonalTrainerProfilePic
            // 
            this.pbPersonalTrainerProfilePic.Location = new System.Drawing.Point(596, 5);
            this.pbPersonalTrainerProfilePic.Name = "pbPersonalTrainerProfilePic";
            this.pbPersonalTrainerProfilePic.Size = new System.Drawing.Size(41, 34);
            this.pbPersonalTrainerProfilePic.TabIndex = 1;
            this.pbPersonalTrainerProfilePic.TabStop = false;
            this.pbPersonalTrainerProfilePic.Click += new System.EventHandler(this.pbPersonalTrainerProfilePic_Click_1);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lblMainMenu);
            this.panel2.Controls.Add(this.pbPersonalTrainerProfilePic);
            this.panel2.Controls.Add(this.lblAccount);
            this.panel2.Controls.Add(this.lblTitle);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(677, 61);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSaveExercise);
            this.panel1.Controls.Add(this.richTextDescription);
            this.panel1.Controls.Add(this.txtIcon);
            this.panel1.Controls.Add(this.txtMuscle);
            this.panel1.Controls.Add(this.txtExerciseName);
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblIcon);
            this.panel1.Controls.Add(this.lblMuscle);
            this.panel1.Controls.Add(this.lblExerciseName);
            this.panel1.Location = new System.Drawing.Point(13, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 320);
            this.panel1.TabIndex = 8;
            // 
            // lblExerciseName
            // 
            this.lblExerciseName.AutoSize = true;
            this.lblExerciseName.Location = new System.Drawing.Point(31, 36);
            this.lblExerciseName.Name = "lblExerciseName";
            this.lblExerciseName.Size = new System.Drawing.Size(78, 13);
            this.lblExerciseName.TabIndex = 0;
            this.lblExerciseName.Text = "Exercise Name";
            // 
            // lblMuscle
            // 
            this.lblMuscle.AutoSize = true;
            this.lblMuscle.Location = new System.Drawing.Point(31, 87);
            this.lblMuscle.Name = "lblMuscle";
            this.lblMuscle.Size = new System.Drawing.Size(95, 13);
            this.lblMuscle.TabIndex = 1;
            this.lblMuscle.Text = "Muscle (Body part)";
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(31, 138);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(59, 13);
            this.lblIcon.TabIndex = 2;
            this.lblIcon.Text = "Icon Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(31, 185);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description";
            // 
            // txtExerciseName
            // 
            this.txtExerciseName.Location = new System.Drawing.Point(197, 33);
            this.txtExerciseName.Name = "txtExerciseName";
            this.txtExerciseName.Size = new System.Drawing.Size(325, 20);
            this.txtExerciseName.TabIndex = 4;
            // 
            // txtMuscle
            // 
            this.txtMuscle.Location = new System.Drawing.Point(197, 84);
            this.txtMuscle.Name = "txtMuscle";
            this.txtMuscle.Size = new System.Drawing.Size(325, 20);
            this.txtMuscle.TabIndex = 5;
            // 
            // txtIcon
            // 
            this.txtIcon.Location = new System.Drawing.Point(197, 135);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.Size = new System.Drawing.Size(325, 20);
            this.txtIcon.TabIndex = 6;
            // 
            // richTextDescription
            // 
            this.richTextDescription.Location = new System.Drawing.Point(197, 185);
            this.richTextDescription.Name = "richTextDescription";
            this.richTextDescription.Size = new System.Drawing.Size(325, 82);
            this.richTextDescription.TabIndex = 7;
            this.richTextDescription.Text = "";
            // 
            // btnSaveExercise
            // 
            this.btnSaveExercise.Location = new System.Drawing.Point(363, 285);
            this.btnSaveExercise.Name = "btnSaveExercise";
            this.btnSaveExercise.Size = new System.Drawing.Size(159, 23);
            this.btnSaveExercise.TabIndex = 8;
            this.btnSaveExercise.Text = "Save";
            this.btnSaveExercise.UseVisualStyleBackColor = true;
            this.btnSaveExercise.Click += new System.EventHandler(this.btnSaveExercise_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PersonalTrainerAddExercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "PersonalTrainerAddExercise";
            this.Text = "Personal Trainer - Add Exercise";
            this.Load += new System.EventHandler(this.PersonalTrainerAddExercise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonalTrainerProfilePic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.PictureBox pbPersonalTrainerProfilePic;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveExercise;
        private System.Windows.Forms.RichTextBox richTextDescription;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.TextBox txtMuscle;
        private System.Windows.Forms.TextBox txtExerciseName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label lblMuscle;
        private System.Windows.Forms.Label lblExerciseName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
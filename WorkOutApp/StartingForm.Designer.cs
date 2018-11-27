namespace WorkOutApp
{
    partial class StartingForm
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
            this.btnPersonalTrainer = new System.Windows.Forms.Button();
            this.btnUserPanel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPersonalTrainer
            // 
            this.btnPersonalTrainer.Location = new System.Drawing.Point(189, 174);
            this.btnPersonalTrainer.Name = "btnPersonalTrainer";
            this.btnPersonalTrainer.Size = new System.Drawing.Size(131, 23);
            this.btnPersonalTrainer.TabIndex = 0;
            this.btnPersonalTrainer.Text = "I am a Personal Trainer";
            this.btnPersonalTrainer.UseVisualStyleBackColor = true;
            // 
            // btnUserPanel
            // 
            this.btnUserPanel.Location = new System.Drawing.Point(401, 174);
            this.btnUserPanel.Name = "btnUserPanel";
            this.btnUserPanel.Size = new System.Drawing.Size(166, 23);
            this.btnUserPanel.TabIndex = 1;
            this.btnUserPanel.Text = "I want to see my Workouts";
            this.btnUserPanel.UseVisualStyleBackColor = true;
            this.btnUserPanel.Click += new System.EventHandler(this.btnUserPanel_Click);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserPanel);
            this.Controls.Add(this.btnPersonalTrainer);
            this.Name = "StartingForm";
            this.Text = "StartingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonalTrainer;
        private System.Windows.Forms.Button btnUserPanel;
    }
}
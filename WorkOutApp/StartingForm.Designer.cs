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
            this.btnPersonalTrainer.Location = new System.Drawing.Point(284, 268);
            this.btnPersonalTrainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPersonalTrainer.Name = "btnPersonalTrainer";
            this.btnPersonalTrainer.Size = new System.Drawing.Size(196, 35);
            this.btnPersonalTrainer.TabIndex = 0;
            this.btnPersonalTrainer.Text = "I am a Personal Trainer";
            this.btnPersonalTrainer.UseVisualStyleBackColor = true;
            this.btnPersonalTrainer.Click += new System.EventHandler(this.btnPersonalTrainer_Click);
            // 
            // btnUserPanel
            // 
            this.btnUserPanel.Location = new System.Drawing.Point(602, 268);
            this.btnUserPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUserPanel.Name = "btnUserPanel";
            this.btnUserPanel.Size = new System.Drawing.Size(249, 35);
            this.btnUserPanel.TabIndex = 1;
            this.btnUserPanel.Text = "I want to see my Workouts";
            this.btnUserPanel.UseVisualStyleBackColor = true;
            this.btnUserPanel.Click += new System.EventHandler(this.btnUserPanel_Click);
            // 
            // StartingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WorkOutApp.Properties.Resources.front_page;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btnUserPanel);
            this.Controls.Add(this.btnPersonalTrainer);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StartingForm";
            this.Text = "StartingForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPersonalTrainer;
        private System.Windows.Forms.Button btnUserPanel;
    }
}
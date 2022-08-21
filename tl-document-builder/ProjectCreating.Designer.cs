
namespace tl_document_builder
{
    partial class ProjectCreating
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
            this.ProjName = new System.Windows.Forms.TextBox();
            this.ProjNameLabel = new System.Windows.Forms.Label();
            this.agreeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProjName
            // 
            this.ProjName.Location = new System.Drawing.Point(36, 48);
            this.ProjName.Name = "ProjName";
            this.ProjName.Size = new System.Drawing.Size(403, 22);
            this.ProjName.TabIndex = 0;
            // 
            // ProjNameLabel
            // 
            this.ProjNameLabel.AutoSize = true;
            this.ProjNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjNameLabel.Location = new System.Drawing.Point(32, 20);
            this.ProjNameLabel.Name = "ProjNameLabel";
            this.ProjNameLabel.Size = new System.Drawing.Size(215, 20);
            this.ProjNameLabel.TabIndex = 1;
            this.ProjNameLabel.Text = "Name of your project here...";
            // 
            // agreeButton
            // 
            this.agreeButton.Location = new System.Drawing.Point(446, 48);
            this.agreeButton.Name = "agreeButton";
            this.agreeButton.Size = new System.Drawing.Size(24, 22);
            this.agreeButton.TabIndex = 2;
            this.agreeButton.Text = "✓";
            this.agreeButton.UseVisualStyleBackColor = true;
            this.agreeButton.Click += new System.EventHandler(this.agreeButton_Click);
            // 
            // ProjectCreating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 82);
            this.Controls.Add(this.agreeButton);
            this.Controls.Add(this.ProjNameLabel);
            this.Controls.Add(this.ProjName);
            this.MaximumSize = new System.Drawing.Size(500, 150);
            this.MinimumSize = new System.Drawing.Size(500, 150);
            this.Name = "ProjectCreating";
            this.Text = "Create a project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ProjName;
        private System.Windows.Forms.Label ProjNameLabel;
        private System.Windows.Forms.Button agreeButton;
    }
}
namespace BookClub
{
    partial class WritersForm
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
            this.DeleteWriterButton = new System.Windows.Forms.Button();
            this.writersBiographyTextBox = new System.Windows.Forms.TextBox();
            this.UpdateWritersBiographyButton = new System.Windows.Forms.Button();
            this.allWritersComboBox = new System.Windows.Forms.ComboBox();
            this.BackToMainFormWriterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteWriterButton
            // 
            this.DeleteWriterButton.Location = new System.Drawing.Point(44, 81);
            this.DeleteWriterButton.Name = "DeleteWriterButton";
            this.DeleteWriterButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteWriterButton.TabIndex = 1;
            this.DeleteWriterButton.Text = "Delete";
            this.DeleteWriterButton.UseVisualStyleBackColor = true;
            this.DeleteWriterButton.Click += new System.EventHandler(this.DeleteWriterButton_Click);
            // 
            // writersBiographyTextBox
            // 
            this.writersBiographyTextBox.Location = new System.Drawing.Point(218, 34);
            this.writersBiographyTextBox.Multiline = true;
            this.writersBiographyTextBox.Name = "writersBiographyTextBox";
            this.writersBiographyTextBox.Size = new System.Drawing.Size(156, 121);
            this.writersBiographyTextBox.TabIndex = 2;
            // 
            // UpdateWritersBiographyButton
            // 
            this.UpdateWritersBiographyButton.Location = new System.Drawing.Point(218, 172);
            this.UpdateWritersBiographyButton.Name = "UpdateWritersBiographyButton";
            this.UpdateWritersBiographyButton.Size = new System.Drawing.Size(94, 29);
            this.UpdateWritersBiographyButton.TabIndex = 3;
            this.UpdateWritersBiographyButton.Text = "Update";
            this.UpdateWritersBiographyButton.UseVisualStyleBackColor = true;
            this.UpdateWritersBiographyButton.Click += new System.EventHandler(this.UpdateWritersBiographyButton_Click);
            // 
            // allWritersComboBox
            // 
            this.allWritersComboBox.FormattingEnabled = true;
            this.allWritersComboBox.Location = new System.Drawing.Point(44, 34);
            this.allWritersComboBox.Name = "allWritersComboBox";
            this.allWritersComboBox.Size = new System.Drawing.Size(151, 28);
            this.allWritersComboBox.TabIndex = 4;
            this.allWritersComboBox.SelectedIndexChanged += new System.EventHandler(this.allWritersComboBox_SelectedIndexChanged);
            // 
            // BackToMainFormWriterButton
            // 
            this.BackToMainFormWriterButton.Location = new System.Drawing.Point(12, 282);
            this.BackToMainFormWriterButton.Name = "BackToMainFormWriterButton";
            this.BackToMainFormWriterButton.Size = new System.Drawing.Size(94, 29);
            this.BackToMainFormWriterButton.TabIndex = 5;
            this.BackToMainFormWriterButton.Text = "Back";
            this.BackToMainFormWriterButton.UseVisualStyleBackColor = true;
            this.BackToMainFormWriterButton.Click += new System.EventHandler(this.BackToMainFormWriterButton_Click);
            // 
            // WritersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 323);
            this.Controls.Add(this.BackToMainFormWriterButton);
            this.Controls.Add(this.allWritersComboBox);
            this.Controls.Add(this.UpdateWritersBiographyButton);
            this.Controls.Add(this.writersBiographyTextBox);
            this.Controls.Add(this.DeleteWriterButton);
            this.Name = "WritersForm";
            this.Text = "WritersForm";
            this.Load += new System.EventHandler(this.WritersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteWriterButton;
        private System.Windows.Forms.TextBox writersBiographyTextBox;
        private System.Windows.Forms.Button UpdateWritersBiographyButton;
        private System.Windows.Forms.ComboBox allWritersComboBox;
        private System.Windows.Forms.Button BackToMainFormWriterButton;
    }
}
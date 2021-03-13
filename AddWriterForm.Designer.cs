namespace BookClub
{
    partial class AddWriterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.writerNameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.biographyTextBox = new System.Windows.Forms.TextBox();
            this.additionalInformationTextBOx = new System.Windows.Forms.TextBox();
            this.AddWriterButton = new System.Windows.Forms.Button();
            this.backToAddBookForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-193, -10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Biography";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 460);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Additional information";
            // 
            // writerNameTextBox
            // 
            this.writerNameTextBox.Location = new System.Drawing.Point(291, 27);
            this.writerNameTextBox.Name = "writerNameTextBox";
            this.writerNameTextBox.Size = new System.Drawing.Size(143, 27);
            this.writerNameTextBox.TabIndex = 0;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(291, 107);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(143, 27);
            this.lastnameTextBox.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(291, 182);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // biographyTextBox
            // 
            this.biographyTextBox.Location = new System.Drawing.Point(282, 241);
            this.biographyTextBox.Multiline = true;
            this.biographyTextBox.Name = "biographyTextBox";
            this.biographyTextBox.Size = new System.Drawing.Size(246, 194);
            this.biographyTextBox.TabIndex = 10;
            // 
            // additionalInformationTextBOx
            // 
            this.additionalInformationTextBOx.Location = new System.Drawing.Point(282, 460);
            this.additionalInformationTextBOx.Name = "additionalInformationTextBOx";
            this.additionalInformationTextBOx.Size = new System.Drawing.Size(185, 27);
            this.additionalInformationTextBOx.TabIndex = 13;
            // 
            // AddWriterButton
            // 
            this.AddWriterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddWriterButton.Location = new System.Drawing.Point(315, 514);
            this.AddWriterButton.Name = "AddWriterButton";
            this.AddWriterButton.Size = new System.Drawing.Size(119, 51);
            this.AddWriterButton.TabIndex = 14;
            this.AddWriterButton.Text = "Add";
            this.AddWriterButton.UseVisualStyleBackColor = true;
            this.AddWriterButton.Click += new System.EventHandler(this.AddWriterButton_Click);
            // 
            // backToAddBookForm
            // 
            this.backToAddBookForm.Location = new System.Drawing.Point(12, 536);
            this.backToAddBookForm.Name = "backToAddBookForm";
            this.backToAddBookForm.Size = new System.Drawing.Size(94, 29);
            this.backToAddBookForm.TabIndex = 15;
            this.backToAddBookForm.Text = "Back";
            this.backToAddBookForm.UseVisualStyleBackColor = true;
            this.backToAddBookForm.Click += new System.EventHandler(this.backToAddBookForm_Click);
            // 
            // AddWriterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 592);
            this.Controls.Add(this.backToAddBookForm);
            this.Controls.Add(this.AddWriterButton);
            this.Controls.Add(this.additionalInformationTextBOx);
            this.Controls.Add(this.biographyTextBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.writerNameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddWriterForm";
            this.Text = "AddWriterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox writerNameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox biographyTextBox;
        private System.Windows.Forms.TextBox additionalInformationTextBOx;
        private System.Windows.Forms.Button AddWriterButton;
        private System.Windows.Forms.Button backToAddBookForm;
    }
}
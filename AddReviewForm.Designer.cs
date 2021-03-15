
namespace BookClub
{
    partial class bookComboBox
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
            this.reviewComboBox = new System.Windows.Forms.ComboBox();
            this.reviewTextBox = new System.Windows.Forms.RichTextBox();
            this.addReviewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reviewComboBox
            // 
            this.reviewComboBox.FormattingEnabled = true;
            this.reviewComboBox.Location = new System.Drawing.Point(307, 65);
            this.reviewComboBox.Name = "reviewComboBox";
            this.reviewComboBox.Size = new System.Drawing.Size(176, 28);
            this.reviewComboBox.TabIndex = 0;
            // 
            // reviewTextBox
            // 
            this.reviewTextBox.Location = new System.Drawing.Point(244, 139);
            this.reviewTextBox.Name = "reviewTextBox";
            this.reviewTextBox.Size = new System.Drawing.Size(310, 152);
            this.reviewTextBox.TabIndex = 1;
            this.reviewTextBox.Text = "";
            // 
            // addReviewBtn
            // 
            this.addReviewBtn.Location = new System.Drawing.Point(307, 335);
            this.addReviewBtn.Name = "addReviewBtn";
            this.addReviewBtn.Size = new System.Drawing.Size(176, 29);
            this.addReviewBtn.TabIndex = 2;
            this.addReviewBtn.Text = "Add Review";
            this.addReviewBtn.UseVisualStyleBackColor = true;
            this.addReviewBtn.Click += new System.EventHandler(this.addReviewBtn_Click);
            // 
            // bookComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addReviewBtn);
            this.Controls.Add(this.reviewTextBox);
            this.Controls.Add(this.reviewComboBox);
            this.Name = "bookComboBox";
            this.Text = "AddReviewForm";
            this.Load += new System.EventHandler(this.AddReviewForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox reviewComboBox;
        private System.Windows.Forms.RichTextBox reviewTextBox;
        private System.Windows.Forms.Button addReviewBtn;
    }
}
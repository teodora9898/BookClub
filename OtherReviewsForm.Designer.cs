
namespace BookClub
{
    partial class OtherReviewsForm
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
            this.findReviewBtn = new System.Windows.Forms.Button();
            this.findOtherReviewComboBox = new System.Windows.Forms.ComboBox();
            this.Reviews = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // findReviewBtn
            // 
            this.findReviewBtn.Location = new System.Drawing.Point(34, 33);
            this.findReviewBtn.Name = "findReviewBtn";
            this.findReviewBtn.Size = new System.Drawing.Size(111, 49);
            this.findReviewBtn.TabIndex = 0;
            this.findReviewBtn.Text = "Find review";
            this.findReviewBtn.UseVisualStyleBackColor = true;
            this.findReviewBtn.Click += new System.EventHandler(this.findReviewBtn_Click);
            // 
            // findOtherReviewComboBox
            // 
            this.findOtherReviewComboBox.FormattingEnabled = true;
            this.findOtherReviewComboBox.Location = new System.Drawing.Point(219, 33);
            this.findOtherReviewComboBox.Name = "findOtherReviewComboBox";
            this.findOtherReviewComboBox.Size = new System.Drawing.Size(177, 28);
            this.findOtherReviewComboBox.TabIndex = 1;
            // 
            // Reviews
            // 
            this.Reviews.FormattingEnabled = true;
            this.Reviews.ItemHeight = 20;
            this.Reviews.Location = new System.Drawing.Point(219, 89);
            this.Reviews.Name = "Reviews";
            this.Reviews.Size = new System.Drawing.Size(523, 304);
            this.Reviews.TabIndex = 2;
            // 
            // OtherReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Reviews);
            this.Controls.Add(this.findOtherReviewComboBox);
            this.Controls.Add(this.findReviewBtn);
            this.Name = "OtherReviewsForm";
            this.Text = "OtherReviewsForm";
            this.Load += new System.EventHandler(this.OtherReviewsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button findReviewBtn;
        private System.Windows.Forms.ComboBox findOtherReviewComboBox;
        private System.Windows.Forms.ListBox Reviews;
    }
}
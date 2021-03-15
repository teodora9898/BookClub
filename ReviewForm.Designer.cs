
namespace BookClub
{
    partial class ReviewForm
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
            this.myReviewsButton = new System.Windows.Forms.Button();
            this.addReviewButton = new System.Windows.Forms.Button();
            this.Reviews = new System.Windows.Forms.ListBox();
            this.Books = new System.Windows.Forms.ListBox();
            this.findReviewsBtn = new System.Windows.Forms.Button();
            this.deleteReviewBtn = new System.Windows.Forms.Button();
            this.updateTextBox = new System.Windows.Forms.RichTextBox();
            this.updateReviewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // myReviewsButton
            // 
            this.myReviewsButton.Location = new System.Drawing.Point(66, 41);
            this.myReviewsButton.Name = "myReviewsButton";
            this.myReviewsButton.Size = new System.Drawing.Size(145, 65);
            this.myReviewsButton.TabIndex = 0;
            this.myReviewsButton.Text = "My reviews";
            this.myReviewsButton.UseVisualStyleBackColor = true;
            this.myReviewsButton.Click += new System.EventHandler(this.myReviewsButton_Click);
            // 
            // addReviewButton
            // 
            this.addReviewButton.Location = new System.Drawing.Point(66, 124);
            this.addReviewButton.Name = "addReviewButton";
            this.addReviewButton.Size = new System.Drawing.Size(145, 65);
            this.addReviewButton.TabIndex = 1;
            this.addReviewButton.Text = "Add review";
            this.addReviewButton.UseVisualStyleBackColor = true;
            this.addReviewButton.Click += new System.EventHandler(this.addReviewButton_Click);
            // 
            // Reviews
            // 
            this.Reviews.FormattingEnabled = true;
            this.Reviews.ItemHeight = 20;
            this.Reviews.Location = new System.Drawing.Point(273, 41);
            this.Reviews.Name = "Reviews";
            this.Reviews.Size = new System.Drawing.Size(249, 184);
            this.Reviews.TabIndex = 2;
            // 
            // Books
            // 
            this.Books.FormattingEnabled = true;
            this.Books.ItemHeight = 20;
            this.Books.Location = new System.Drawing.Point(545, 41);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(182, 184);
            this.Books.TabIndex = 3;
            // 
            // findReviewsBtn
            // 
            this.findReviewsBtn.Location = new System.Drawing.Point(66, 205);
            this.findReviewsBtn.Name = "findReviewsBtn";
            this.findReviewsBtn.Size = new System.Drawing.Size(145, 65);
            this.findReviewsBtn.TabIndex = 4;
            this.findReviewsBtn.Text = "Find other reviews";
            this.findReviewsBtn.UseVisualStyleBackColor = true;
            this.findReviewsBtn.Click += new System.EventHandler(this.findReviewsBtn_Click);
            // 
            // deleteReviewBtn
            // 
            this.deleteReviewBtn.Location = new System.Drawing.Point(66, 287);
            this.deleteReviewBtn.Name = "deleteReviewBtn";
            this.deleteReviewBtn.Size = new System.Drawing.Size(145, 58);
            this.deleteReviewBtn.TabIndex = 5;
            this.deleteReviewBtn.Text = "Delete review";
            this.deleteReviewBtn.UseVisualStyleBackColor = true;
            this.deleteReviewBtn.Click += new System.EventHandler(this.deleteReviewBtn_Click);
            // 
            // updateTextBox
            // 
            this.updateTextBox.Location = new System.Drawing.Point(545, 245);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(182, 144);
            this.updateTextBox.TabIndex = 6;
            this.updateTextBox.Text = "";
            // 
            // updateReviewBtn
            // 
            this.updateReviewBtn.Location = new System.Drawing.Point(575, 395);
            this.updateReviewBtn.Name = "updateReviewBtn";
            this.updateReviewBtn.Size = new System.Drawing.Size(126, 43);
            this.updateReviewBtn.TabIndex = 7;
            this.updateReviewBtn.Text = "Update review";
            this.updateReviewBtn.UseVisualStyleBackColor = true;
            this.updateReviewBtn.Click += new System.EventHandler(this.updateReviewBtn_Click);
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateReviewBtn);
            this.Controls.Add(this.updateTextBox);
            this.Controls.Add(this.deleteReviewBtn);
            this.Controls.Add(this.findReviewsBtn);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.Reviews);
            this.Controls.Add(this.addReviewButton);
            this.Controls.Add(this.myReviewsButton);
            this.Name = "ReviewForm";
            this.Text = "ReviewForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myReviewsButton;
        private System.Windows.Forms.Button addReviewButton;
        private System.Windows.Forms.ListBox Reviews;
        private System.Windows.Forms.ListBox Books;
        private System.Windows.Forms.Button findReviewsBtn;
        private System.Windows.Forms.Button deleteReviewBtn;
        private System.Windows.Forms.RichTextBox updateTextBox;
        private System.Windows.Forms.Button updateReviewBtn;
    }
}
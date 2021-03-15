
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.whoLikedListBox = new System.Windows.Forms.ListBox();
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
            this.Reviews.SelectedIndexChanged += new System.EventHandler(this.Reviews_SelectedIndexChanged);
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
            this.updateTextBox.Location = new System.Drawing.Point(545, 255);
            this.updateTextBox.Name = "updateTextBox";
            this.updateTextBox.Size = new System.Drawing.Size(182, 134);
            this.updateTextBox.TabIndex = 6;
            this.updateTextBox.Text = "";
            // 
            // updateReviewBtn
            // 
            this.updateReviewBtn.Location = new System.Drawing.Point(571, 395);
            this.updateReviewBtn.Name = "updateReviewBtn";
            this.updateReviewBtn.Size = new System.Drawing.Size(126, 43);
            this.updateReviewBtn.TabIndex = 7;
            this.updateReviewBtn.Text = "Update review";
            this.updateReviewBtn.UseVisualStyleBackColor = true;
            this.updateReviewBtn.Click += new System.EventHandler(this.updateReviewBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Reviews:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Books:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Insert review update:";
            // 
            // num
            // 
            this.num.FormattingEnabled = true;
            this.num.ItemHeight = 20;
            this.num.Location = new System.Drawing.Point(302, 250);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(49, 24);
            this.num.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Likes by";
            // 
            // whoLikedListBox
            // 
            this.whoLikedListBox.FormattingEnabled = true;
            this.whoLikedListBox.ItemHeight = 20;
            this.whoLikedListBox.Location = new System.Drawing.Point(301, 285);
            this.whoLikedListBox.Name = "whoLikedListBox";
            this.whoLikedListBox.Size = new System.Drawing.Size(117, 104);
            this.whoLikedListBox.TabIndex = 13;
            // 
            // ReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 450);
            this.Controls.Add(this.whoLikedListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
            this.Load += new System.EventHandler(this.ReviewForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox whoLikedListBox;
    }
}
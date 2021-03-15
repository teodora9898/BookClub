
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
            this.Comments = new System.Windows.Forms.ListBox();
            this.addReviewCommentBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.commentTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.likeBtn = new System.Windows.Forms.Button();
            this.dislikeBtn = new System.Windows.Forms.Button();
            this.Likes = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // findReviewBtn
            // 
            this.findReviewBtn.Location = new System.Drawing.Point(255, 53);
            this.findReviewBtn.Name = "findReviewBtn";
            this.findReviewBtn.Size = new System.Drawing.Size(111, 60);
            this.findReviewBtn.TabIndex = 0;
            this.findReviewBtn.Text = "Find review";
            this.findReviewBtn.UseVisualStyleBackColor = true;
            this.findReviewBtn.Click += new System.EventHandler(this.findReviewBtn_Click);
            // 
            // findOtherReviewComboBox
            // 
            this.findOtherReviewComboBox.FormattingEnabled = true;
            this.findOtherReviewComboBox.Location = new System.Drawing.Point(29, 85);
            this.findOtherReviewComboBox.Name = "findOtherReviewComboBox";
            this.findOtherReviewComboBox.Size = new System.Drawing.Size(165, 28);
            this.findOtherReviewComboBox.TabIndex = 1;
            // 
            // Reviews
            // 
            this.Reviews.FormattingEnabled = true;
            this.Reviews.ItemHeight = 20;
            this.Reviews.Location = new System.Drawing.Point(426, 36);
            this.Reviews.Name = "Reviews";
            this.Reviews.Size = new System.Drawing.Size(535, 164);
            this.Reviews.TabIndex = 2;
            this.Reviews.SelectedIndexChanged += new System.EventHandler(this.Reviews_SelectedIndexChanged);
            // 
            // Comments
            // 
            this.Comments.FormattingEnabled = true;
            this.Comments.ItemHeight = 20;
            this.Comments.Location = new System.Drawing.Point(426, 226);
            this.Comments.Name = "Comments";
            this.Comments.Size = new System.Drawing.Size(390, 164);
            this.Comments.TabIndex = 3;
            // 
            // addReviewCommentBtn
            // 
            this.addReviewCommentBtn.Location = new System.Drawing.Point(426, 442);
            this.addReviewCommentBtn.Name = "addReviewCommentBtn";
            this.addReviewCommentBtn.Size = new System.Drawing.Size(93, 61);
            this.addReviewCommentBtn.TabIndex = 4;
            this.addReviewCommentBtn.Text = "Add a comment";
            this.addReviewCommentBtn.UseVisualStyleBackColor = true;
            this.addReviewCommentBtn.Click += new System.EventHandler(this.addReviewCommentBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose a book:";
            // 
            // commentTextBox
            // 
            this.commentTextBox.Location = new System.Drawing.Point(525, 411);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(436, 120);
            this.commentTextBox.TabIndex = 6;
            this.commentTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(426, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Reviews for a chosen book:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(426, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Comments for a chosen review:";
            // 
            // likeBtn
            // 
            this.likeBtn.Location = new System.Drawing.Point(29, 164);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(165, 29);
            this.likeBtn.TabIndex = 9;
            this.likeBtn.Text = "Like review";
            this.likeBtn.UseVisualStyleBackColor = true;
            this.likeBtn.Click += new System.EventHandler(this.likeBtn_Click);
            // 
            // dislikeBtn
            // 
            this.dislikeBtn.Location = new System.Drawing.Point(29, 502);
            this.dislikeBtn.Name = "dislikeBtn";
            this.dislikeBtn.Size = new System.Drawing.Size(165, 29);
            this.dislikeBtn.TabIndex = 10;
            this.dislikeBtn.Text = "Dislike review";
            this.dislikeBtn.UseVisualStyleBackColor = true;
            this.dislikeBtn.Click += new System.EventHandler(this.dislikeBtn_Click);
            // 
            // Likes
            // 
            this.Likes.FormattingEnabled = true;
            this.Likes.ItemHeight = 20;
            this.Likes.Location = new System.Drawing.Point(29, 225);
            this.Likes.Name = "Likes";
            this.Likes.Size = new System.Drawing.Size(209, 264);
            this.Likes.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Reviews you liked:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.FormattingEnabled = true;
            this.usernameTextBox.ItemHeight = 20;
            this.usernameTextBox.Location = new System.Drawing.Point(823, 226);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(138, 164);
            this.usernameTextBox.TabIndex = 13;
            // 
            // OtherReviewsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 559);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Likes);
            this.Controls.Add(this.dislikeBtn);
            this.Controls.Add(this.likeBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.commentTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addReviewCommentBtn);
            this.Controls.Add(this.Comments);
            this.Controls.Add(this.Reviews);
            this.Controls.Add(this.findOtherReviewComboBox);
            this.Controls.Add(this.findReviewBtn);
            this.Name = "OtherReviewsForm";
            this.Text = "OtherReviewsForm";
            this.Load += new System.EventHandler(this.OtherReviewsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button findReviewBtn;
        private System.Windows.Forms.ComboBox findOtherReviewComboBox;
        private System.Windows.Forms.ListBox Reviews;
        private System.Windows.Forms.ListBox Comments;
        private System.Windows.Forms.Button addReviewCommentBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox commentTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button likeBtn;
        private System.Windows.Forms.Button dislikeBtn;
        private System.Windows.Forms.ListBox Likes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox usernameTextBox;
    }
}
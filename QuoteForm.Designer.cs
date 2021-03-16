
namespace BookClub
{
    partial class QuoteForm
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
            this.myQuoteButton = new System.Windows.Forms.Button();
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.Quotes = new System.Windows.Forms.ListBox();
            this.Books = new System.Windows.Forms.ListBox();
            this.deleteQuoteBtn = new System.Windows.Forms.Button();
            this.myBookmarksBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchByNameBtn = new System.Windows.Forms.Button();
            this.searchByWriterBtn = new System.Windows.Forms.Button();
            this.bookmarkBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // myQuoteButton
            // 
            this.myQuoteButton.Location = new System.Drawing.Point(56, 32);
            this.myQuoteButton.Name = "myQuoteButton";
            this.myQuoteButton.Size = new System.Drawing.Size(147, 64);
            this.myQuoteButton.TabIndex = 0;
            this.myQuoteButton.Text = "My qoutes";
            this.myQuoteButton.UseVisualStyleBackColor = true;
            this.myQuoteButton.Click += new System.EventHandler(this.myQuoteButton_Click);
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Location = new System.Drawing.Point(56, 102);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(147, 64);
            this.addQuoteButton.TabIndex = 2;
            this.addQuoteButton.Text = "Add quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            this.addQuoteButton.Click += new System.EventHandler(this.addQuoteButton_Click);
            // 
            // Quotes
            // 
            this.Quotes.FormattingEnabled = true;
            this.Quotes.ItemHeight = 20;
            this.Quotes.Location = new System.Drawing.Point(290, 32);
            this.Quotes.Name = "Quotes";
            this.Quotes.Size = new System.Drawing.Size(150, 144);
            this.Quotes.TabIndex = 3;
            // 
            // Books
            // 
            this.Books.FormattingEnabled = true;
            this.Books.ItemHeight = 20;
            this.Books.Location = new System.Drawing.Point(506, 32);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(150, 144);
            this.Books.TabIndex = 4;
            // 
            // deleteQuoteBtn
            // 
            this.deleteQuoteBtn.Location = new System.Drawing.Point(56, 184);
            this.deleteQuoteBtn.Name = "deleteQuoteBtn";
            this.deleteQuoteBtn.Size = new System.Drawing.Size(147, 64);
            this.deleteQuoteBtn.TabIndex = 5;
            this.deleteQuoteBtn.Text = "Delete quote";
            this.deleteQuoteBtn.UseVisualStyleBackColor = true;
            this.deleteQuoteBtn.Click += new System.EventHandler(this.deleteQuoteBtn_Click);
            // 
            // myBookmarksBtn
            // 
            this.myBookmarksBtn.Location = new System.Drawing.Point(56, 344);
            this.myBookmarksBtn.Name = "myBookmarksBtn";
            this.myBookmarksBtn.Size = new System.Drawing.Size(147, 64);
            this.myBookmarksBtn.TabIndex = 6;
            this.myBookmarksBtn.Text = "My bookmarks";
            this.myBookmarksBtn.UseVisualStyleBackColor = true;
            this.myBookmarksBtn.Click += new System.EventHandler(this.myBookmarksBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Enter full or part of the quote/writer:";
            // 
            // searchByNameBtn
            // 
            this.searchByNameBtn.Location = new System.Drawing.Point(521, 286);
            this.searchByNameBtn.Name = "searchByNameBtn";
            this.searchByNameBtn.Size = new System.Drawing.Size(135, 58);
            this.searchByNameBtn.TabIndex = 8;
            this.searchByNameBtn.Text = "Search quotes by its part or content";
            this.searchByNameBtn.UseVisualStyleBackColor = true;
            // 
            // searchByWriterBtn
            // 
            this.searchByWriterBtn.Location = new System.Drawing.Point(521, 350);
            this.searchByWriterBtn.Name = "searchByWriterBtn";
            this.searchByWriterBtn.Size = new System.Drawing.Size(135, 58);
            this.searchByWriterBtn.TabIndex = 9;
            this.searchByWriterBtn.Text = "Search quotes by its writer";
            this.searchByWriterBtn.UseVisualStyleBackColor = true;
            // 
            // bookmarkBtn
            // 
            this.bookmarkBtn.Location = new System.Drawing.Point(56, 267);
            this.bookmarkBtn.Name = "bookmarkBtn";
            this.bookmarkBtn.Size = new System.Drawing.Size(147, 64);
            this.bookmarkBtn.TabIndex = 11;
            this.bookmarkBtn.Text = "Bookmark";
            this.bookmarkBtn.UseVisualStyleBackColor = true;
            this.bookmarkBtn.Click += new System.EventHandler(this.bookmarkBtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(290, 286);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(225, 122);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // QuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bookmarkBtn);
            this.Controls.Add(this.searchByWriterBtn);
            this.Controls.Add(this.searchByNameBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myBookmarksBtn);
            this.Controls.Add(this.deleteQuoteBtn);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.Quotes);
            this.Controls.Add(this.addQuoteButton);
            this.Controls.Add(this.myQuoteButton);
            this.Name = "QuoteForm";
            this.Text = "QuoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myQuoteButton;
        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.ListBox Quotes;
        private System.Windows.Forms.ListBox Books;
        private System.Windows.Forms.Button deleteQuoteBtn;
        private System.Windows.Forms.Button myBookmarksBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchByNameBtn;
        private System.Windows.Forms.Button searchByWriterBtn;
        private System.Windows.Forms.Button bookmarkBtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
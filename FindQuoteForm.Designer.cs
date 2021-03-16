
namespace BookClub
{
    partial class FindQuoteForm
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
            this.searchByNameBtn = new System.Windows.Forms.Button();
            this.searchByWriterBtn = new System.Windows.Forms.Button();
            this.bookmarkBtn = new System.Windows.Forms.Button();
            this.myBookmarksBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Quotes = new System.Windows.Forms.ListBox();
            this.Books = new System.Windows.Forms.ListBox();
            this.quoteTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // searchByNameBtn
            // 
            this.searchByNameBtn.Location = new System.Drawing.Point(306, 312);
            this.searchByNameBtn.Name = "searchByNameBtn";
            this.searchByNameBtn.Size = new System.Drawing.Size(131, 71);
            this.searchByNameBtn.TabIndex = 14;
            this.searchByNameBtn.Text = "Search quotes by its part or content";
            this.searchByNameBtn.UseVisualStyleBackColor = true;
            this.searchByNameBtn.Click += new System.EventHandler(this.searchByNameBtn_Click);
            // 
            // searchByWriterBtn
            // 
            this.searchByWriterBtn.Location = new System.Drawing.Point(443, 312);
            this.searchByWriterBtn.Name = "searchByWriterBtn";
            this.searchByWriterBtn.Size = new System.Drawing.Size(113, 71);
            this.searchByWriterBtn.TabIndex = 15;
            this.searchByWriterBtn.Text = "Search quotes by its writer";
            this.searchByWriterBtn.UseVisualStyleBackColor = true;
            this.searchByWriterBtn.Click += new System.EventHandler(this.searchByWriterBtn_Click);
            // 
            // bookmarkBtn
            // 
            this.bookmarkBtn.Location = new System.Drawing.Point(45, 131);
            this.bookmarkBtn.Name = "bookmarkBtn";
            this.bookmarkBtn.Size = new System.Drawing.Size(147, 64);
            this.bookmarkBtn.TabIndex = 16;
            this.bookmarkBtn.Text = "Bookmark";
            this.bookmarkBtn.UseVisualStyleBackColor = true;
            this.bookmarkBtn.Click += new System.EventHandler(this.bookmarkBtn_Click);
            // 
            // myBookmarksBtn
            // 
            this.myBookmarksBtn.Location = new System.Drawing.Point(45, 46);
            this.myBookmarksBtn.Name = "myBookmarksBtn";
            this.myBookmarksBtn.Size = new System.Drawing.Size(147, 64);
            this.myBookmarksBtn.TabIndex = 17;
            this.myBookmarksBtn.Text = "My bookmarks";
            this.myBookmarksBtn.UseVisualStyleBackColor = true;
            this.myBookmarksBtn.Click += new System.EventHandler(this.myBookmarksBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Enter full or part of the quote/writer:";
            // 
            // Quotes
            // 
            this.Quotes.FormattingEnabled = true;
            this.Quotes.ItemHeight = 20;
            this.Quotes.Location = new System.Drawing.Point(306, 46);
            this.Quotes.Name = "Quotes";
            this.Quotes.Size = new System.Drawing.Size(150, 144);
            this.Quotes.TabIndex = 19;
            // 
            // Books
            // 
            this.Books.FormattingEnabled = true;
            this.Books.ItemHeight = 20;
            this.Books.Location = new System.Drawing.Point(493, 46);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(150, 144);
            this.Books.TabIndex = 20;
            // 
            // quoteTextBox
            // 
            this.quoteTextBox.Location = new System.Drawing.Point(306, 258);
            this.quoteTextBox.Name = "quoteTextBox";
            this.quoteTextBox.Size = new System.Drawing.Size(250, 27);
            this.quoteTextBox.TabIndex = 21;
            // 
            // FindQuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quoteTextBox);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.Quotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.myBookmarksBtn);
            this.Controls.Add(this.bookmarkBtn);
            this.Controls.Add(this.searchByWriterBtn);
            this.Controls.Add(this.searchByNameBtn);
            this.Name = "FindQuoteForm";
            this.Text = "NewQuoteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchByNameBtn;
        private System.Windows.Forms.Button searchByWriterBtn;
        private System.Windows.Forms.Button bookmarkBtn;
        private System.Windows.Forms.Button myBookmarksBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Quotes;
        private System.Windows.Forms.ListBox Books;
        private System.Windows.Forms.TextBox quoteTextBox;
    }
}
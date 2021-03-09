
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
            this.quoteBookmarksButton = new System.Windows.Forms.Button();
            this.addQuoteButton = new System.Windows.Forms.Button();
            this.Quotes = new System.Windows.Forms.ListBox();
            this.Books = new System.Windows.Forms.ListBox();
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
            // quoteBookmarksButton
            // 
            this.quoteBookmarksButton.Location = new System.Drawing.Point(56, 147);
            this.quoteBookmarksButton.Name = "quoteBookmarksButton";
            this.quoteBookmarksButton.Size = new System.Drawing.Size(147, 58);
            this.quoteBookmarksButton.TabIndex = 1;
            this.quoteBookmarksButton.Text = "Quote bookmarks";
            this.quoteBookmarksButton.UseVisualStyleBackColor = true;
            // 
            // addQuoteButton
            // 
            this.addQuoteButton.Location = new System.Drawing.Point(56, 272);
            this.addQuoteButton.Name = "addQuoteButton";
            this.addQuoteButton.Size = new System.Drawing.Size(147, 67);
            this.addQuoteButton.TabIndex = 2;
            this.addQuoteButton.Text = "Add quote";
            this.addQuoteButton.UseVisualStyleBackColor = true;
            // 
            // Quotes
            // 
            this.Quotes.FormattingEnabled = true;
            this.Quotes.ItemHeight = 20;
            this.Quotes.Location = new System.Drawing.Point(269, 61);
            this.Quotes.Name = "Quotes";
            this.Quotes.Size = new System.Drawing.Size(150, 144);
            this.Quotes.TabIndex = 3;
            // 
            // Books
            // 
            this.Books.FormattingEnabled = true;
            this.Books.ItemHeight = 20;
            this.Books.Location = new System.Drawing.Point(511, 61);
            this.Books.Name = "Books";
            this.Books.Size = new System.Drawing.Size(150, 144);
            this.Books.TabIndex = 4;
            // 
            // QuoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Books);
            this.Controls.Add(this.Quotes);
            this.Controls.Add(this.addQuoteButton);
            this.Controls.Add(this.quoteBookmarksButton);
            this.Controls.Add(this.myQuoteButton);
            this.Name = "QuoteForm";
            this.Text = "QuoteForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button myQuoteButton;
        private System.Windows.Forms.Button quoteBookmarksButton;
        private System.Windows.Forms.Button addQuoteButton;
        private System.Windows.Forms.ListBox Quotes;
        private System.Windows.Forms.ListBox Books;
    }
}